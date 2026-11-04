using System.Text.Json;
using PetShopPink.Dominio.Entidades;

namespace PetShopPink.Aplicacao.Repositorios;

/// <summary>
/// Persiste os animais em um arquivo JSON local.
/// </summary>
public class AnimalJsonRepositorio : IAnimalRepositorio
{
    private readonly string _caminhoArquivo;
    private readonly JsonSerializerOptions _opcoes = new() { WriteIndented = true };

    // O construtor recebe o caminho do arquivo. Isso deixa a classe reutilizável
    // e facilita os testes, pois o local do armazenamento pode ser substituído.
    public AnimalJsonRepositorio(string caminhoArquivo)
    {
        _caminhoArquivo = caminhoArquivo;
    }

    public IReadOnlyList<Animal> Listar()
    {
        if (!File.Exists(_caminhoArquivo))
        {
            return Array.Empty<Animal>();
        }

        string json = File.ReadAllText(_caminhoArquivo);
        return JsonSerializer.Deserialize<List<Animal>>(json, _opcoes) ?? new List<Animal>();
    }

    public void Salvar(IReadOnlyList<Animal> animais)
    {
        string? diretorio = Path.GetDirectoryName(_caminhoArquivo);
        if (!string.IsNullOrWhiteSpace(diretorio))
        {
            Directory.CreateDirectory(diretorio);
        }

        string json = JsonSerializer.Serialize(animais, _opcoes);
        File.WriteAllText(_caminhoArquivo, json);
    }
}
