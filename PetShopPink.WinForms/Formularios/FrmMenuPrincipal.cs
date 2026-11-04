using PetShopPink.Aplicacao.Servicos;
using PetShopPink.WinForms.Imagens;
using System.ComponentModel;

namespace PetShopPink.WinForms.Formularios;

// Menu central do sistema. Cada tela possui uma responsabilidade específica.
[DesignerCategory("Form")]
public partial class FrmMenuPrincipal : Form
{
    private readonly AnimalService _service;

    // Construtor usado pelo Designer.
    public FrmMenuPrincipal()
    {
        _service = null!;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
    }

    // Recebe o serviço compartilhado pelas telas de cadastro e consulta.
    public FrmMenuPrincipal(AnimalService service)
    {
        _service = service;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
    }

    // Abre a tela para inserir um novo animal.
    private void AbrirCadastro(object? sender, EventArgs e) => new FrmCadastroAnimal(_service).ShowDialog(this);

    // A consulta também permite editar e excluir o animal selecionado.
    private void AbrirConsulta(object? sender, EventArgs e) => new FrmConsultaAnimais(_service).ShowDialog(this);

    // Encerra o menu e retorna ao login/aplicação.
    private void Sair(object? sender, EventArgs e) => Close();

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }
}
