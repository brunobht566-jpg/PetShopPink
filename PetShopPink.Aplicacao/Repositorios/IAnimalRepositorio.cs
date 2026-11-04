using PetShopPink.Dominio.Entidades;

namespace PetShopPink.Aplicacao.Repositorios;

public interface IAnimalRepositorio
{
    IReadOnlyList<Animal> Listar();
    void Salvar(IReadOnlyList<Animal> animais);
}
