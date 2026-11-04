namespace PetShopPink.WinForms.Formularios;

partial class FrmMenuPrincipal
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private Button btnCadastro = null!;
    private Button btnConsulta = null!;
    private Button btnSair = null!;

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        btnCadastro = new Button();
        btnConsulta = new Button();
        btnSair = new Button();
        painel = new FlowLayoutPanel();
        painel.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Top;
        lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1280, 90);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "Pet Shop Pink";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnCadastro
        // 
        btnCadastro.Location = new Point(0, 5);
        btnCadastro.Margin = new Padding(0, 5, 0, 5);
        btnCadastro.Name = "btnCadastro";
        btnCadastro.Size = new Size(300, 48);
        btnCadastro.TabIndex = 0;
        btnCadastro.Text = "Cadastrar animal";
        btnCadastro.Click += AbrirCadastro;
        // 
        // btnConsulta
        // 
        btnConsulta.Location = new Point(0, 57);
        btnConsulta.Margin = new Padding(0, 5, 0, 5);
        btnConsulta.Name = "btnConsulta";
        btnConsulta.Size = new Size(300, 48);
        btnConsulta.TabIndex = 1;
        btnConsulta.Text = "Consultar / editar animais";
        btnConsulta.Click += AbrirConsulta;
        // 
        // btnSair
        // 
        btnSair.Location = new Point(0, 109);
        btnSair.Margin = new Padding(0, 5, 0, 5);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(300, 48);
        btnSair.TabIndex = 2;
        btnSair.Text = "Sair";
        btnSair.Click += Sair;
        // 
        // painel
        // 
        painel.Dock = DockStyle.Fill;
        painel.BackColor = Color.Transparent;
        painel.FlowDirection = FlowDirection.TopDown;
        painel.WrapContents = false;
        painel.Padding = new Padding(490, 105, 490, 10);
        lblTitulo.BackColor = Color.Transparent;
        painel.Controls.Add(btnCadastro);
        painel.Controls.Add(btnConsulta);
        painel.Controls.Add(btnSair);
        painel.Location = new Point(0, 0);
        painel.Name = "painel";
        painel.Size = new Size(200, 100);
        painel.TabIndex = 0;
        // 
        // FrmMenuPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 720);
        Controls.Add(painel);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        MinimizeBox = true;
        MinimumSize = new Size(1280, 720);
        Name = "FrmMenuPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pet Shop Pink - Menu principal";
        painel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private FlowLayoutPanel painel;
}
