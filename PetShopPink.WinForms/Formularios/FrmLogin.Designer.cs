namespace PetShopPink.WinForms.Formularios;

partial class FrmLogin
{
    private System.ComponentModel.IContainer? components = null;
    private TableLayoutPanel tabela = null!;
    private Label lblTitulo = null!;
    private Label lblUsuario = null!;
    private Label lblSenha = null!;
    private TextBox txtUsuario = null!;
    private TextBox txtSenha = null!;
    private Button btnEntrar = null!;
    private Button btnSair = null!;
    private FlowLayoutPanel painelBotoes = null!;

    private void InitializeComponent()
    {
        tabela = new TableLayoutPanel();
        lblTitulo = new Label();
        txtUsuario = new TextBox();
        txtSenha = new TextBox();
        painelBotoes = new FlowLayoutPanel();
        btnEntrar = new Button();
        btnSair = new Button();
        lblUsuario = new Label();
        lblSenha = new Label();
        tabela.SuspendLayout();
        painelBotoes.SuspendLayout();
        SuspendLayout();
        // 
        // tabela
        // 
        tabela.Anchor = AnchorStyles.None;
        tabela.BackColor = Color.FromArgb(215, 35, 25, 50);
        tabela.ColumnCount = 2;
        tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tabela.Controls.Add(lblTitulo, 0, 0);
        tabela.Controls.Add(txtUsuario, 0, 1);
        tabela.Controls.Add(txtSenha, 0, 2);
        tabela.Controls.Add(painelBotoes, 0, 4);
        tabela.Location = new Point(290, 130);
        tabela.Margin = new Padding(3, 4, 3, 4);
        tabela.Name = "tabela";
        tabela.Padding = new Padding(36, 30, 36, 30);
        tabela.RowCount = 5;
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tabela.Size = new Size(700, 460);
        tabela.TabIndex = 0;
        // 
        // lblTitulo
        // 
        tabela.SetColumnSpan(lblTitulo, 2);
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(39, 30);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(622, 80);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Pet Shop Pink";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtUsuario
        // 
        tabela.SetColumnSpan(txtUsuario, 2);
        txtUsuario.Dock = DockStyle.Fill;
        txtUsuario.Font = new Font("Segoe UI", 13F);
        txtUsuario.Location = new Point(39, 114);
        txtUsuario.Margin = new Padding(3, 4, 3, 4);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.PlaceholderText = "Usuário";
        txtUsuario.Size = new Size(622, 36);
        txtUsuario.TabIndex = 2;
        // 
        // txtSenha
        // 
        tabela.SetColumnSpan(txtSenha, 2);
        txtSenha.Dock = DockStyle.Fill;
        txtSenha.Font = new Font("Segoe UI", 13F);
        txtSenha.Location = new Point(39, 178);
        txtSenha.Margin = new Padding(3, 4, 3, 4);
        txtSenha.Name = "txtSenha";
        txtSenha.PlaceholderText = "Senha";
        txtSenha.Size = new Size(622, 36);
        txtSenha.TabIndex = 4;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // painelBotoes
        // 
        painelBotoes.Anchor = AnchorStyles.None;
        painelBotoes.AutoSize = true;
        tabela.SetColumnSpan(painelBotoes, 2);
        painelBotoes.Controls.Add(btnEntrar);
        painelBotoes.Controls.Add(btnSair);
        painelBotoes.Location = new Point(164, 370);
        painelBotoes.Margin = new Padding(3, 4, 3, 4);
        painelBotoes.Name = "painelBotoes";
        painelBotoes.Size = new Size(372, 56);
        painelBotoes.TabIndex = 5;
        painelBotoes.WrapContents = false;
        // 
        // btnEntrar
        // 
        btnEntrar.Anchor = AnchorStyles.None;
        btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnEntrar.Location = new Point(3, 4);
        btnEntrar.Margin = new Padding(3, 4, 3, 4);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(180, 48);
        btnEntrar.TabIndex = 6;
        btnEntrar.Text = "Entrar";
        btnEntrar.Click += Entrar;
        // 
        // btnSair
        // 
        btnSair.Anchor = AnchorStyles.None;
        btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnSair.Location = new Point(189, 4);
        btnSair.Margin = new Padding(3, 4, 3, 4);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(180, 48);
        btnSair.TabIndex = 5;
        btnSair.Text = "Sair";
        btnSair.Click += Sair;
        // 
        // lblUsuario
        // 
        lblUsuario.Anchor = AnchorStyles.Left;
        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 11F);
        lblUsuario.ForeColor = Color.White;
        lblUsuario.Location = new Point(35, 111);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(62, 20);
        lblUsuario.TabIndex = 1;
        lblUsuario.Text = "Usuário:";
        // 
        // lblSenha
        // 
        lblSenha.Anchor = AnchorStyles.Left;
        lblSenha.AutoSize = true;
        lblSenha.Font = new Font("Segoe UI", 11F);
        lblSenha.ForeColor = Color.White;
        lblSenha.Location = new Point(35, 169);
        lblSenha.Name = "lblSenha";
        lblSenha.Size = new Size(52, 20);
        lblSenha.TabIndex = 3;
        lblSenha.Text = "Senha:";
        // 
        // FrmLogin
        // 
        AcceptButton = btnEntrar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnSair;
        ClientSize = new Size(1280, 720);
        Controls.Add(tabela);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimumSize = new Size(1280, 720);
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pet Shop Pink - Login";
        tabela.ResumeLayout(false);
        tabela.PerformLayout();
        painelBotoes.ResumeLayout(false);
        ResumeLayout(false);
    }
}
