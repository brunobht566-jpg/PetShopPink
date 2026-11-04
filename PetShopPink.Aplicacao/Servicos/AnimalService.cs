using PetShopPink.Aplicacao.Repositorios;
using PetShopPink.Dominio.Entidades;

namespace PetShopPink.Aplicacao.Servicos;

/// <summary>
/// Contém as regras de negócio do cadastro de animais.
/// </summary>
public class AnimalService
{
    private readonly IAnimalRepositorio _repositorio;

    // Este construtor recebe uma dependência pronta. Essa composição é um
    // exemplo de uma classe usando outra classe sem herança entre elas.
    public AnimalService(IAnimalRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public IReadOnlyList<Animal> Listar() => _repositorio.Listar();

    public void Adicionar(Animal animal)
    {
        Validar(animal);
        List<Animal> animais = _repositorio.Listar().ToList();

        if (animais.Any(a => a.Codigo == animal.Codigo))
        {
            throw new InvalidOperationException("Já existe um animal cadastrado com este código.");
        }

        animais.Add(animal);
        _repositorio.Salvar(animais);
    }

    public void Atualizar(Animal animal)
    {
        Validar(animal);
        List<Animal> animais = _repositorio.Listar().ToList();
        int indice = animais.FindIndex(a => a.Codigo == animal.Codigo);

        if (indice < 0)
        {
            throw new InvalidOperationException("Animal não encontrado.");
        }

        animais[indice] = animal;
        _repositorio.Salvar(animais);
    }

    public void Remover(int codigo)
    {
        List<Animal> animais = _repositorio.Listar().ToList();
        Animal? animal = animais.FirstOrDefault(a => a.Codigo == codigo);

        if (animal is null)
        {
            throw new InvalidOperationException("Animal não encontrado.");
        }

        animais.Remove(animal);
        _repositorio.Salvar(animais);
    }

    public IReadOnlyList<Animal> Pesquisar(string termo)
    {
        if (string.IsNullOrWhiteSpace(termo))
        {
            return Listar();
        }

        termo = termo.Trim();
        return Listar()
            .Where(a => a.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)
                || a.Especie.Contains(termo, StringComparison.OrdinalIgnoreCase)
                || a.NomeResponsavel.Contains(termo, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    private static void Validar(Animal animal)
    {
        if (animal.Codigo <= 0) throw new ArgumentException("Informe um código inteiro maior que zero.");
        if (string.IsNullOrWhiteSpace(animal.Nome)) throw new ArgumentException("Informe o nome do animal.");
        if (string.IsNullOrWhiteSpace(animal.Especie)) throw new ArgumentException("Informe a espécie do animal.");
        if (string.IsNullOrWhiteSpace(animal.Raca)) throw new ArgumentException("Informe a raça do animal.");
        if (animal.Idade < 0) throw new ArgumentException("A idade não pode ser negativa.");
        if (string.IsNullOrWhiteSpace(animal.NomeResponsavel)) throw new ArgumentException("Informe o nome do responsável.");
    }
}
