using PetShopPink.Aplicacao.Servicos;
using PetShopPink.Dominio.Entidades;
using PetShopPink.WinForms.Imagens;
using System.ComponentModel;

namespace PetShopPink.WinForms.Formularios;

[DesignerCategory("Form")]
public partial class FrmConsultaAnimais : Form
{
    private readonly AnimalService _service;

    public FrmConsultaAnimais()
    {
        _service = null!;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
    }

    public FrmConsultaAnimais(AnimalService service)
    {
        _service = service;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
        Atualizar();
    }

    private void Pesquisar(object? sender, EventArgs e) => Atualizar();

    // Atualiza a grade com todos os animais ou com o filtro informado.
    private void Atualizar()
    {
        if (_service is null) return;
        gridAnimais.DataSource = null;
        string termo = txtFiltro.Text.Trim();
        IEnumerable<Animal> animais = _service.Listar();

        if (!string.IsNullOrWhiteSpace(termo))
        {
            animais = cmbCampo.SelectedItem?.ToString() switch
            {
                "Código/ID" when int.TryParse(termo, out int codigo) => animais.Where(a => a.Codigo == codigo),
                "Idade" when int.TryParse(termo, out int idade) => animais.Where(a => a.Idade == idade),
                "Espécie" => animais.Where(a => a.Especie.Contains(termo, StringComparison.OrdinalIgnoreCase)),
                "Raça" => animais.Where(a => a.Raca.Contains(termo, StringComparison.OrdinalIgnoreCase)),
                "Responsável" => animais.Where(a => a.NomeResponsavel.Contains(termo, StringComparison.OrdinalIgnoreCase)),
                _ => animais.Where(a => a.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase))
            };
        }

        gridAnimais.DataSource = animais.ToList();
    }

    // Abre a edição usando o animal atualmente selecionado na grade.
    private void Editar(object? sender, EventArgs e)
    {
        if (gridAnimais.CurrentRow?.DataBoundItem is not Animal animal) return;
        using var tela = new FrmEdicaoAnimal(_service, animal);
        tela.ShowDialog(this);
        Atualizar();
    }

    // Fecha a consulta e retorna ao menu principal.
    private void Voltar(object? sender, EventArgs e) => Close();

    // Remove o animal selecionado após confirmação do usuário.
    private void Excluir(object? sender, EventArgs e)
    {
        if (gridAnimais.CurrentRow?.DataBoundItem is not Animal animal)
        {
            MessageBox.Show("Selecione um animal para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show($"Deseja excluir o animal '{animal.Nome}'?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _service.Remover(animal.Codigo);
            Atualizar();
            MessageBox.Show("Animal excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Não foi possível excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
