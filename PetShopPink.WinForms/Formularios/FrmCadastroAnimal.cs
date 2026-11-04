// Serviço responsável pelas operações de cadastro.
using PetShopPink.Aplicacao.Servicos;
// Entidade que representa o animal no domínio da aplicação.
using PetShopPink.Dominio.Entidades;
// Classe que carrega a imagem de fundo do formulário.
using PetShopPink.WinForms.Imagens;
using System.ComponentModel;

namespace PetShopPink.WinForms.Formularios;

[DesignerCategory("Form")]
// Esta é uma classe filha de Form.
// Form é a classe-pai do Windows Forms e fornece o comportamento básico
// de uma janela, como título, tamanho, controles, eventos e fechamento.
// A palavra partial permite dividir esta mesma classe em dois arquivos:
// este arquivo contém as regras da tela e o arquivo .Designer.cs contém
// a criação e a configuração visual dos controles.
public partial class FrmCadastroAnimal : Form
{
    // Serviço compartilhado com as demais telas para salvar os dados.
    protected readonly AnimalService Service;

    // Construtor sem parâmetros utilizado pelo Designer do Windows Forms.
    // O Designer precisa deste construtor para conseguir instanciar a tela
    // e exibir uma prévia sem possuir um AnimalService real.
    public FrmCadastroAnimal()
    {
        // O Designer não precisa executar operações no serviço.
        Service = null!;
        InitializeComponent();
        // Aplica o fundo somente depois de criar os controles visuais.
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
    }

    // Construtor utilizado pela aplicação durante a execução.
    // O programa fornece o serviço pronto para que a tela consiga salvar
    // os dados no repositório.
    public FrmCadastroAnimal(AnimalService service)
    {
        Service = service;
        InitializeComponent();
        // Define a imagem de fundo da tela de cadastro.
        ImagensDasTelas.Aplicar(this, "fundo-telas.png");
    }

    // Lê os campos, cria um Animal e solicita o cadastro ao serviço.
    private void Salvar(object? sender, EventArgs e)
    {
        try
        {
            // Monta a entidade com os dados informados pelo usuário.
            var animal = new Animal
            {
                Codigo = (int)numCodigo.Value,
                Nome = txtNome.Text.Trim(),
                Especie = txtEspecie.Text.Trim(),
                Raca = txtRaca.Text.Trim(),
                Idade = (int)numIdade.Value,
                NomeResponsavel = txtResponsavel.Text.Trim()
            };

            // O serviço valida os dados e grava o animal no repositório.
            Service.Adicionar(animal);
            MessageBox.Show("Animal cadastrado com sucesso.", "Sucesso");
            // Limpa os campos para permitir um novo cadastro.
            Limpar();
        }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
        {
            // Exibe erros de validação sem encerrar a tela.
            MessageBox.Show(ex.Message, "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Restaura os campos para os valores iniciais.
    private void Limpar()
    {
        numCodigo.Value = 1;
        txtNome.Clear();
        txtEspecie.Clear();
        txtRaca.Clear();
        numIdade.Value = 0;
        txtResponsavel.Clear();
        txtNome.Focus();
    }

    // Fecha a tela e retorna para o menu ou para a tela anterior.
    private void Voltar(object? sender, EventArgs e) => Close();

    // Evento reservado para inicializações adicionais da tela.
    private void FrmCadastroAnimal_Load(object sender, EventArgs e)
    {
        // A configuração visual já é feita pelo InitializeComponent.
    }
}
