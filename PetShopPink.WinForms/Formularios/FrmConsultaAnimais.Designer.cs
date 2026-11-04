namespace PetShopPink.WinForms.Formularios;

partial class FrmConsultaAnimais
{
    private TextBox txtFiltro = null!;
    private ComboBox cmbCampo = null!;
    private Button btnPesquisar = null!;
    private Button btnEditar = null!;
    private Button btnExcluir = null!;
    private Button btnVoltar = null!;
    private DataGridView gridAnimais = null!;

    private void InitializeComponent()
    {
        txtFiltro = new TextBox();
        cmbCampo = new ComboBox();
        btnPesquisar = new Button();
        btnEditar = new Button();
        btnExcluir = new Button();
        btnVoltar = new Button();
        gridAnimais = new DataGridView();
        topo = new FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)gridAnimais).BeginInit();
        topo.SuspendLayout();
        SuspendLayout();
        // 
        // txtFiltro
        // 
        txtFiltro.Location = new Point(233, 11);
        txtFiltro.Name = "txtFiltro";
        txtFiltro.Size = new Size(300, 36);
        txtFiltro.TabIndex = 2;
        // 
        // cmbCampo
        // 
        cmbCampo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCampo.Items.AddRange(new object[] { "Nome", "Código/ID", "Espécie", "Raça", "Idade", "Responsável" });
        cmbCampo.Location = new Point(117, 11);
        cmbCampo.Name = "cmbCampo";
        cmbCampo.Size = new Size(140, 36);
        cmbCampo.TabIndex = 1;
        // 
        // btnPesquisar
        // 
        btnPesquisar.Location = new Point(459, 11);
        btnPesquisar.Name = "btnPesquisar";
        btnPesquisar.Size = new Size(120, 36);
        btnPesquisar.TabIndex = 3;
        btnPesquisar.Text = "Pesquisar";
        btnPesquisar.Click += Pesquisar;
        // 
        // btnEditar
        // 
        btnEditar.Location = new Point(555, 11);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(160, 36);
        btnEditar.TabIndex = 4;
        btnEditar.Text = "Editar selecionado";
        btnEditar.Click += Editar;
        // 
        // btnExcluir
        // 
        btnExcluir.Location = new Point(691, 11);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(160, 36);
        btnExcluir.TabIndex = 5;
        btnExcluir.Text = "Excluir selecionado";
        btnExcluir.Click += Excluir;
        // 
        // btnVoltar
        // 
        btnVoltar.Location = new Point(822, 11);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(100, 36);
        btnVoltar.TabIndex = 6;
        btnVoltar.Text = "Voltar";
        btnVoltar.Click += Voltar;
        // 
        // gridAnimais
        // 
        gridAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridAnimais.ColumnHeadersHeight = 29;
        gridAnimais.Dock = DockStyle.Fill;
        gridAnimais.Location = new Point(0, 63);
        gridAnimais.Name = "gridAnimais";
        gridAnimais.ReadOnly = true;
        gridAnimais.RowHeadersWidth = 51;
        gridAnimais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridAnimais.Size = new Size(1000, 437);
        gridAnimais.TabIndex = 0;
        // 
        // topo
        // 
        topo.BackColor = Color.Transparent;
        topo.Controls.Add(cmbCampo);
        topo.Controls.Add(txtFiltro);
        topo.Controls.Add(btnPesquisar);
        topo.Controls.Add(btnEditar);
        topo.Controls.Add(btnExcluir);
        topo.Controls.Add(btnVoltar);
        topo.Dock = DockStyle.Top;
        topo.Location = new Point(0, 0);
        topo.Name = "topo";
        topo.Padding = new Padding(8);
        topo.Size = new Size(1280, 72);
        topo.TabIndex = 1;
        // 
        // FrmConsultaAnimais
        // 
        ClientSize = new Size(1280, 720);
        Controls.Add(gridAnimais);
        Controls.Add(topo);
        MinimumSize = new Size(750, 400);
        Name = "FrmConsultaAnimais";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Consulta de animais";
        ((System.ComponentModel.ISupportInitialize)gridAnimais).EndInit();
        topo.ResumeLayout(false);
        topo.PerformLayout();
        ResumeLayout(false);
    }

    private FlowLayoutPanel topo;
}
