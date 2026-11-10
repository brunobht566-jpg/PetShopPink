using PetShopPink.Aplicacao.Repositorios;
using PetShopPink.Aplicacao.Servicos;
using PetShopPink.Dominio.Entidades;

var builder = WebApplication.CreateBuilder(args);

var dataFile = Environment.GetEnvironmentVariable("PetShopPink_DATA_PATH");
if (string.IsNullOrWhiteSpace(dataFile))
{
    dataFile = Path.Combine(builder.Environment.ContentRootPath, "App_Data", "animais.json");
}

builder.Services.AddSingleton<IAnimalRepositorio>(_ => new AnimalJsonRepositorio(dataFile));
builder.Services.AddSingleton<AnimalService>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/health", () => Results.Ok(new { status = "ok" }));

app.MapGet("/api/animais", (string? termo, string? campo, AnimalService service) =>
{
    IEnumerable<Animal> animais = service.Listar();
    if (!string.IsNullOrWhiteSpace(termo))
    {
        termo = termo.Trim();
        animais = campo?.ToLowerInvariant() switch
        {
            "codigo" when int.TryParse(termo, out var codigo) => animais.Where(a => a.Codigo == codigo),
            "idade" when int.TryParse(termo, out var idade) => animais.Where(a => a.Idade == idade),
            "especie" => animais.Where(a => a.Especie.Contains(termo, StringComparison.OrdinalIgnoreCase)),
            "raca" => animais.Where(a => a.Raca.Contains(termo, StringComparison.OrdinalIgnoreCase)),
            "responsavel" => animais.Where(a => a.NomeResponsavel.Contains(termo, StringComparison.OrdinalIgnoreCase)),
            _ => animais.Where(a => a.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase))
        };
    }

    return Results.Ok(animais.OrderBy(a => a.Codigo));
});

app.MapPost("/api/animais", (Animal animal, AnimalService service) =>
{
    try
    {
        service.Adicionar(animal);
        return Results.Created($"/api/animais/{animal.Codigo}", animal);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { erro = ex.Message });
    }
    catch (InvalidOperationException ex)
    {
        return Results.Conflict(new { erro = ex.Message });
    }
});

app.MapPut("/api/animais/{codigo:int}", (int codigo, Animal animal, AnimalService service) =>
{
    animal.Codigo = codigo;
    try
    {
        service.Atualizar(animal);
        return Results.Ok(animal);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { erro = ex.Message });
    }
    catch (InvalidOperationException ex)
    {
        return Results.NotFound(new { erro = ex.Message });
    }
});

app.MapDelete("/api/animais/{codigo:int}", (int codigo, AnimalService service) =>
{
    try
    {
        service.Remover(codigo);
        return Results.NoContent();
    }
    catch (InvalidOperationException ex)
    {
        return Results.NotFound(new { erro = ex.Message });
    }
});

app.Run();
