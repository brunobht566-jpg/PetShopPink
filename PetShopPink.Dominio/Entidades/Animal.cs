namespace PetShopPink.Dominio.Entidades;

/// <summary>
/// Classe de domínio que representa um animal cadastrado no pet shop.
/// </summary>
public class Animal
{
    public int Codigo { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Especie { get; set; } = string.Empty;
    public string Raca { get; set; } = string.Empty;
    public int Idade { get; set; }
    public string NomeResponsavel { get; set; } = string.Empty;

    // Este é um construtor implícito: quando nenhum construtor é declarado,
    // o C# fornece um construtor público sem parâmetros automaticamente.
    // Ele é útil para o desserializador JSON criar o objeto e preencher as propriedades.
}
