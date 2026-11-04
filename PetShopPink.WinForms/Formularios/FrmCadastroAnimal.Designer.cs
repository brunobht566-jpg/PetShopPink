namespace PetShopPink.WinForms.Formularios;

// Parte visual da classe filha FrmCadastroAnimal.
// Este arquivo também pertence à classe FrmCadastroAnimal por causa da
// palavra partial usada no arquivo principal. A classe base Form continua
// fornecendo o comportamento de janela para as duas partes da classe.
partial class FrmCadastroAnimal
{
    // Controles visíveis da tela de cadastro.
    private TableLayoutPanel tabela = null!;
    private Label lblCodigo = null!;
    private Label lblNome = null!;
    private Label lblEspecie = null!;
    private Label lblRaca = null!;
    private Label lblIdade = null!;
    private Label lblResponsavel = null!;
    private NumericUpDown numCodigo = null!;
    private TextBox txtNome = null!;
    private TextBox txtEspecie = null!;
    private TextBox txtRaca = null!;
    private NumericUpDown numIdade = null!;
    private TextBox txtResponsavel = null!;
    private FlowLayoutPanel painelBotoes = null!;
    private Button btnSalvar = null!;
    private Button btnVoltar = null!;

    // Método chamado pelos construtores da classe principal.
    // Ele cria os controles e define suas propriedades visuais.
    private void InitializeComponent()
    {
        tabela = new TableLayoutPanel();
        lblCodigo = new Label();
        numCodigo = new NumericUpDown();
        lblNome = new Label();
        txtNome = new TextBox();
        lblEspecie = new Label();
        txtEspecie = new TextBox();
        lblRaca = new Label();
        txtRaca = new TextBox();
        lblIdade = new Label();
        numIdade = new NumericUpDown();
        lblResponsavel = new Label();
        txtResponsavel = new TextBox();
        painelBotoes = new FlowLayoutPanel();
        btnVoltar = new Button();
        btnSalvar = new Button();
        tabela.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numIdade).BeginInit();
        painelBotoes.SuspendLayout();
        SuspendLayout();
        // 
        // tabela
        // 
        tabela.BackColor = Color.FromArgb(220, 255, 255, 255);
        tabela.ColumnCount = 2;
        tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
        tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tabela.Controls.Add(lblCodigo, 0, 0);
        tabela.Controls.Add(numCodigo, 1, 0);
        tabela.Controls.Add(lblNome, 0, 1);
        tabela.Controls.Add(txtNome, 1, 1);
        tabela.Controls.Add(lblEspecie, 0, 2);
        tabela.Controls.Add(txtEspecie, 1, 2);
        tabela.Controls.Add(lblRaca, 0, 3);
        tabela.Controls.Add(txtRaca, 1, 3);
        tabela.Controls.Add(lblIdade, 0, 4);
        tabela.Controls.Add(numIdade, 1, 4);
        tabela.Controls.Add(lblResponsavel, 0, 5);
        tabela.Controls.Add(txtResponsavel, 1, 5);
        tabela.Controls.Add(painelBotoes, 0, 6);
        tabela.Anchor = AnchorStyles.None;
        tabela.Dock = DockStyle.None;
        tabela.Location = new Point(190, 100);
        tabela.Name = "tabela";
        tabela.Padding = new Padding(20);
        tabela.RowCount = 7;
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tabela.Size = new Size(900, 520);
        tabela.TabIndex = 0;
        // 
        // lblCodigo
        // 
        lblCodigo.Anchor = AnchorStyles.Left;
        lblCodigo.AutoSize = true;
        lblCodigo.Location = new Point(23, 30);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(58, 20);
        lblCodigo.TabIndex = 0;
        lblCodigo.Text = "Código";
        // 
        // numCodigo
        // 
        numCodigo.Dock = DockStyle.Fill;
        numCodigo.Location = new Point(163, 23);
        numCodigo.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
        numCodigo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numCodigo.Name = "numCodigo";
        numCodigo.Size = new Size(334, 27);
        numCodigo.TabIndex = 1;
        numCodigo.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblNome
        // 
        lblNome.Anchor = AnchorStyles.Left;
        lblNome.AutoSize = true;
        lblNome.Location = new Point(23, 70);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(50, 20);
        lblNome.TabIndex = 2;
        lblNome.Text = "Nome";
        // 
        // txtNome
        // 
        txtNome.Dock = DockStyle.Fill;
        txtNome.Location = new Point(163, 63);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(334, 27);
        txtNome.TabIndex = 3;
        // 
        // lblEspecie
        // 
        lblEspecie.Anchor = AnchorStyles.Left;
        lblEspecie.AutoSize = true;
        lblEspecie.Location = new Point(23, 110);
        lblEspecie.Name = "lblEspecie";
        lblEspecie.Size = new Size(59, 20);
        lblEspecie.TabIndex = 4;
        lblEspecie.Text = "Espécie";
        // 
        // txtEspecie
        // 
        txtEspecie.Dock = DockStyle.Fill;
        txtEspecie.Location = new Point(163, 103);
        txtEspecie.Name = "txtEspecie";
        txtEspecie.Size = new Size(334, 27);
        txtEspecie.TabIndex = 5;
        // 
        // lblRaca
        // 
        lblRaca.Anchor = AnchorStyles.Left;
        lblRaca.AutoSize = true;
        lblRaca.Location = new Point(23, 150);
        lblRaca.Name = "lblRaca";
        lblRaca.Size = new Size(41, 20);
        lblRaca.TabIndex = 6;
        lblRaca.Text = "Raça";
        // 
        // txtRaca
        // 
        txtRaca.Dock = DockStyle.Fill;
        txtRaca.Location = new Point(163, 143);
        txtRaca.Name = "txtRaca";
        txtRaca.Size = new Size(334, 27);
        txtRaca.TabIndex = 7;
        // 
        // lblIdade
        // 
        lblIdade.Anchor = AnchorStyles.Left;
        lblIdade.AutoSize = true;
        lblIdade.Location = new Point(23, 190);
        lblIdade.Name = "lblIdade";
        lblIdade.Size = new Size(47, 20);
        lblIdade.TabIndex = 8;
        lblIdade.Text = "Idade";
        // 
        // numIdade
        // 
        numIdade.Dock = DockStyle.Fill;
        numIdade.Location = new Point(163, 183);
        numIdade.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
        numIdade.Name = "numIdade";
        numIdade.Size = new Size(334, 27);
        numIdade.TabIndex = 9;
        // 
        // lblResponsavel
        // 
        lblResponsavel.Anchor = AnchorStyles.Left;
        lblResponsavel.AutoSize = true;
        lblResponsavel.Location = new Point(23, 230);
        lblResponsavel.Name = "lblResponsavel";
        lblResponsavel.Size = new Size(91, 20);
        lblResponsavel.TabIndex = 10;
        lblResponsavel.Text = "Responsável";
        // 
        // txtResponsavel
        // 
        txtResponsavel.Dock = DockStyle.Fill;
        txtResponsavel.Location = new Point(163, 223);
        txtResponsavel.Name = "txtResponsavel";
        txtResponsavel.Size = new Size(334, 27);
        txtResponsavel.TabIndex = 11;
        // 
        // painelBotoes
        // 
        tabela.SetColumnSpan(painelBotoes, 2);
        painelBotoes.Controls.Add(btnVoltar);
        painelBotoes.Controls.Add(btnSalvar);
        painelBotoes.Dock = DockStyle.Fill;
        painelBotoes.FlowDirection = FlowDirection.RightToLeft;
        painelBotoes.Location = new Point(23, 263);
        painelBotoes.Name = "painelBotoes";
        painelBotoes.Size = new Size(474, 104);
        painelBotoes.TabIndex = 12;
        // 
        // btnVoltar
        // 
        btnVoltar.Location = new Point(381, 3);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(110, 40);
        btnVoltar.TabIndex = 0;
        btnVoltar.Text = "Voltar";
        btnVoltar.Click += Voltar;
        // 
        // btnSalvar
        // 
        btnSalvar.Location = new Point(245, 3);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(160, 40);
        btnSalvar.TabIndex = 1;
        btnSalvar.Text = "Salvar cadastro";
        btnSalvar.Click += Salvar;
        // 
        // FrmCadastroAnimal
        // 
        ClientSize = new Size(1280, 720);
        Controls.Add(tabela);
        MinimumSize = new Size(520, 390);
        Name = "FrmCadastroAnimal";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastro de animal";
        Load += FrmCadastroAnimal_Load;
        tabela.ResumeLayout(false);
        tabela.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
        ((System.ComponentModel.ISupportInitialize)numIdade).EndInit();
        painelBotoes.ResumeLayout(false);
        ResumeLayout(false);
    }

}
