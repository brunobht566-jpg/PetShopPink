using PetShopPink.Aplicacao.Servicos;
using PetShopPink.Dominio.Entidades;
using PetShopPink.WinForms.Imagens;
using System.ComponentModel;

namespace PetShopPink.WinForms.Formularios;

[DesignerCategory("Form")]
public partial class FrmEdicaoAnimal : Form
{
    private readonly AnimalService _service;
    private readonly Animal _original;

    public FrmEdicaoAnimal()
    {
        _service = null!;
        _original = new Animal();
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
    }

    public FrmEdicaoAnimal(AnimalService service, Animal animal)
    {
        _service = service;
        _original = animal;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
        txtNome.Text = animal.Nome; txtEspecie.Text = animal.Especie; txtRaca.Text = animal.Raca; numIdade.Value = animal.Idade; txtResponsavel.Text = animal.NomeResponsavel; lblCodigoValor.Text = animal.Codigo.ToString();
    }

    private void Salvar(object? sender, EventArgs e)
    {
        try
        {
            _service.Atualizar(new Animal { Codigo = _original.Codigo, Nome = txtNome.Text.Trim(), Especie = txtEspecie.Text.Trim(), Raca = txtRaca.Text.Trim(), Idade = (int)numIdade.Value, NomeResponsavel = txtResponsavel.Text.Trim() });
            MessageBox.Show("Animal atualizado com sucesso.", "Sucesso"); Close();
        }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException) { MessageBox.Show(ex.Message, "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    private void Voltar(object? sender, EventArgs e) => Close();
}
