using PetShopPink.Aplicacao.Servicos;
using PetShopPink.WinForms.Imagens;
using System.ComponentModel;

namespace PetShopPink.WinForms.Formularios;

// Tela inicial responsável por autenticar o usuário antes de abrir o sistema.
[DesignerCategory("Form")]
public partial class FrmLogin : Form
{
    private readonly AnimalService _service;

    // Construtor usado pelo Designer do Visual Studio.
    public FrmLogin()
    {
        _service = null!;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "login-pets.png");
    }

    // Construtor usado pela aplicação em execução.
    public FrmLogin(AnimalService service)
    {
        _service = service;
        InitializeComponent();
        ImagensDasTelas.Aplicar(this, "login-pets.png");
    }

    // Valida as credenciais e abre o menu principal.
    private void Entrar(object? sender, EventArgs e)
    {
        if (txtUsuario.Text.Trim() == "admin" && txtSenha.Text == "1234")
        {
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        MessageBox.Show("Usuário ou senha inválidos.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtSenha.Clear();
        txtSenha.Focus();
    }

    // Fecha a aplicação sem autenticar.
    private void Sair(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }
}
