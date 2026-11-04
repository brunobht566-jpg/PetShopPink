using PetShopPink.Aplicacao.Repositorios;
using PetShopPink.Aplicacao.Servicos;
using PetShopPink.WinForms.Formularios;

namespace PetShopPink.WinForms;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        // Inicializa configurações padrão do Windows Forms, como fonte e estilos visuais.
        ApplicationConfiguration.Initialize();

        // O arquivo JSON é armazenado na pasta Dados da aplicação.
        string caminho = Path.Combine(AppContext.BaseDirectory, "Dados", "animais.json");

        // Monta as dependências da aplicação: repositório, serviço e tela de login.
        var repositorio = new AnimalJsonRepositorio(caminho);
        var service = new AnimalService(repositorio);

        // O login valida o acesso antes de iniciar o menu principal.
        using var login = new FrmLogin(service);
        if (login.ShowDialog() == DialogResult.OK)
        {
            Application.Run(new FrmMenuPrincipal(service));
        }
    }
}
