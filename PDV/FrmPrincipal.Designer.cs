namespace PDV
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripButton();
            this.menuCaixa = new System.Windows.Forms.ToolStripButton();
            this.menuVendas = new System.Windows.Forms.ToolStripButton();
            this.menuOrcamentos = new System.Windows.Forms.ToolStripButton();
            this.menuFinanceiro = new System.Windows.Forms.ToolStripButton();
            this.menuEstoque = new System.Windows.Forms.ToolStripButton();
            this.menuUtilitarios = new System.Windows.Forms.ToolStripButton();
            this.menuBloquear = new System.Windows.Forms.ToolStripButton();
            this.menuConfiguracao = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuAjuda = new System.Windows.Forms.ToolStripButton();
            this.menuSair = new System.Windows.Forms.ToolStripButton();
            this.statusStripMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.barraCadastros = new System.Windows.Forms.ToolStrip();
            this.Clientes = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncluirSaldoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTranferirSaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripButton();
            this.menuUsuarios = new System.Windows.Forms.ToolStripButton();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.menuFormaPagamento = new System.Windows.Forms.ToolStripButton();
            this.GrupoProdutos = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuGruposDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubgrupoProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTributacao = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuGrupoImpostoCadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTributacaoPorEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmpresa = new System.Windows.Forms.ToolStripButton();
            this.barraCaixa = new System.Windows.Forms.ToolStrip();
            this.menuPDV = new System.Windows.Forms.ToolStripButton();
            this.menuAbrirCaixa = new System.Windows.Forms.ToolStripButton();
            this.menuSangria = new System.Windows.Forms.ToolStripButton();
            this.menuSuprimento = new System.Windows.Forms.ToolStripButton();
            this.menuFecharCaixa = new System.Windows.Forms.ToolStripButton();
            this.barraVendas = new System.Windows.Forms.ToolStrip();
            this.menuNumeroDocumento = new System.Windows.Forms.ToolStripButton();
            this.menuDataEmissao = new System.Windows.Forms.ToolStripButton();
            this.menuDtaVendasFinalizada = new System.Windows.Forms.ToolStripButton();
            this.menuCPF = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.statusStripMenu.SuspendLayout();
            this.barraCadastros.SuspendLayout();
            this.barraCaixa.SuspendLayout();
            this.barraVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuCaixa,
            this.menuVendas,
            this.menuOrcamentos,
            this.menuFinanceiro,
            this.menuEstoque,
            this.menuUtilitarios,
            this.menuBloquear,
            this.menuConfiguracao,
            this.menuAjuda,
            this.menuSair});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1089, 25);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCadastros.ForeColor = System.Drawing.Color.White;
            this.menuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastros.Image")));
            this.menuCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(81, 22);
            this.menuCadastros.Text = "   Cadastros   ";
            // 
            // menuCaixa
            // 
            this.menuCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCaixa.ForeColor = System.Drawing.Color.White;
            this.menuCaixa.Image = ((System.Drawing.Image)(resources.GetObject("menuCaixa.Image")));
            this.menuCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCaixa.Name = "menuCaixa";
            this.menuCaixa.Size = new System.Drawing.Size(58, 22);
            this.menuCaixa.Text = "   Caixa   ";
            // 
            // menuVendas
            // 
            this.menuVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVendas.ForeColor = System.Drawing.Color.White;
            this.menuVendas.Image = ((System.Drawing.Image)(resources.GetObject("menuVendas.Image")));
            this.menuVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(66, 22);
            this.menuVendas.Text = "   Vendas   ";
            // 
            // menuOrcamentos
            // 
            this.menuOrcamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOrcamentos.ForeColor = System.Drawing.Color.White;
            this.menuOrcamentos.Image = ((System.Drawing.Image)(resources.GetObject("menuOrcamentos.Image")));
            this.menuOrcamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOrcamentos.Name = "menuOrcamentos";
            this.menuOrcamentos.Size = new System.Drawing.Size(94, 22);
            this.menuOrcamentos.Text = "   Orçamentos   ";
            // 
            // menuFinanceiro
            // 
            this.menuFinanceiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFinanceiro.ForeColor = System.Drawing.Color.White;
            this.menuFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("menuFinanceiro.Image")));
            this.menuFinanceiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFinanceiro.Name = "menuFinanceiro";
            this.menuFinanceiro.Size = new System.Drawing.Size(84, 22);
            this.menuFinanceiro.Text = "   Financeiro   ";
            // 
            // menuEstoque
            // 
            this.menuEstoque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuEstoque.ForeColor = System.Drawing.Color.White;
            this.menuEstoque.Image = ((System.Drawing.Image)(resources.GetObject("menuEstoque.Image")));
            this.menuEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Size = new System.Drawing.Size(77, 22);
            this.menuEstoque.Text = "   Estoque     ";
            // 
            // menuUtilitarios
            // 
            this.menuUtilitarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuUtilitarios.ForeColor = System.Drawing.Color.White;
            this.menuUtilitarios.Image = ((System.Drawing.Image)(resources.GetObject("menuUtilitarios.Image")));
            this.menuUtilitarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUtilitarios.Name = "menuUtilitarios";
            this.menuUtilitarios.Size = new System.Drawing.Size(79, 22);
            this.menuUtilitarios.Text = "   Utilitários   ";
            // 
            // menuBloquear
            // 
            this.menuBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuBloquear.ForeColor = System.Drawing.Color.White;
            this.menuBloquear.Image = ((System.Drawing.Image)(resources.GetObject("menuBloquear.Image")));
            this.menuBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuBloquear.Name = "menuBloquear";
            this.menuBloquear.Size = new System.Drawing.Size(76, 22);
            this.menuBloquear.Text = "   Bloquear   ";
            // 
            // menuConfiguracao
            // 
            this.menuConfiguracao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuConfiguracao.ForeColor = System.Drawing.Color.White;
            this.menuConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("menuConfiguracao.Image")));
            this.menuConfiguracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuConfiguracao.Name = "menuConfiguracao";
            this.menuConfiguracao.Size = new System.Drawing.Size(110, 22);
            this.menuConfiguracao.Text = "   Configuração   ";
            // 
            // menuAjuda
            // 
            this.menuAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuAjuda.ForeColor = System.Drawing.Color.White;
            this.menuAjuda.Image = ((System.Drawing.Image)(resources.GetObject("menuAjuda.Image")));
            this.menuAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(69, 22);
            this.menuAjuda.Text = "   Ajuda      ";
            // 
            // menuSair
            // 
            this.menuSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSair.ForeColor = System.Drawing.Color.White;
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(48, 22);
            this.menuSair.Text = "   Sair   ";
            // 
            // statusStripMenu
            // 
            this.statusStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.statusStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1});
            this.statusStripMenu.Location = new System.Drawing.Point(0, 432);
            this.statusStripMenu.Name = "statusStripMenu";
            this.statusStripMenu.Size = new System.Drawing.Size(1089, 22);
            this.statusStripMenu.TabIndex = 3;
            this.statusStripMenu.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel2.Text = "NomePC   ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel3.Text = "UsuarioLogado   ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "DataHora   ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(440, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Excluir acesso automático";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // barraCadastros
            // 
            this.barraCadastros.AutoSize = false;
            this.barraCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.barraCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barraCadastros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraCadastros.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes,
            this.menuProdutos,
            this.menuUsuarios,
            this.menuFuncionarios,
            this.menuFormaPagamento,
            this.GrupoProdutos,
            this.menuTributacao,
            this.menuEmpresa});
            this.barraCadastros.Location = new System.Drawing.Point(0, 25);
            this.barraCadastros.Name = "barraCadastros";
            this.barraCadastros.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barraCadastros.Size = new System.Drawing.Size(1089, 65);
            this.barraCadastros.Stretch = true;
            this.barraCadastros.TabIndex = 22;
            this.barraCadastros.Visible = false;
            // 
            // Clientes
            // 
            this.Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuIncluirSaldoCliente,
            this.menuTranferirSaldo});
            this.Clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.Clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(80, 62);
            this.Clientes.Text = "   Clientes   ";
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Clientes.ToolTipText = "Cadastro de Clientes";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(219, 22);
            this.menuClientes.Text = "1. Cadastro de clientes";
            // 
            // menuIncluirSaldoCliente
            // 
            this.menuIncluirSaldoCliente.Name = "menuIncluirSaldoCliente";
            this.menuIncluirSaldoCliente.Size = new System.Drawing.Size(219, 22);
            this.menuIncluirSaldoCliente.Text = "2. Incluir saldo para cliente";
            // 
            // menuTranferirSaldo
            // 
            this.menuTranferirSaldo.Name = "menuTranferirSaldo";
            this.menuTranferirSaldo.Size = new System.Drawing.Size(219, 22);
            this.menuTranferirSaldo.Text = "3. Transferir saldo de cliente";
            // 
            // menuProdutos
            // 
            this.menuProdutos.ForeColor = System.Drawing.SystemColors.Control;
            this.menuProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(77, 62);
            this.menuProdutos.Text = "   Produtos   ";
            this.menuProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProdutos.ToolTipText = "Cadastro de Clientes";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.menuUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(74, 62);
            this.menuUsuarios.Text = "   Usuários   ";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.ToolTipText = "Cadastro de Usuários";
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.ForeColor = System.Drawing.SystemColors.Control;
            this.menuFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(97, 62);
            this.menuFuncionarios.Text = "   Funcionários   ";
            this.menuFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuFuncionarios.ToolTipText = "Cadastro de subgrupoProdutos";
            // 
            // menuFormaPagamento
            // 
            this.menuFormaPagamento.ForeColor = System.Drawing.SystemColors.Control;
            this.menuFormaPagamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFormaPagamento.Name = "menuFormaPagamento";
            this.menuFormaPagamento.Size = new System.Drawing.Size(148, 62);
            this.menuFormaPagamento.Text = "   Formas de Pagamento   ";
            this.menuFormaPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuFormaPagamento.ToolTipText = "Cadastro de subgrupoProdutos";
            // 
            // GrupoProdutos
            // 
            this.GrupoProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGruposDeProdutos,
            this.menuSubgrupoProdutos});
            this.GrupoProdutos.ForeColor = System.Drawing.SystemColors.Control;
            this.GrupoProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GrupoProdutos.Name = "GrupoProdutos";
            this.GrupoProdutos.Size = new System.Drawing.Size(143, 62);
            this.GrupoProdutos.Text = "   Grupos de Produtos   ";
            this.GrupoProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GrupoProdutos.ToolTipText = "Cadastro de Categoria";
            // 
            // menuGruposDeProdutos
            // 
            this.menuGruposDeProdutos.Name = "menuGruposDeProdutos";
            this.menuGruposDeProdutos.Size = new System.Drawing.Size(205, 22);
            this.menuGruposDeProdutos.Text = "1. Grupos de Produtos";
            // 
            // menuSubgrupoProdutos
            // 
            this.menuSubgrupoProdutos.Name = "menuSubgrupoProdutos";
            this.menuSubgrupoProdutos.Size = new System.Drawing.Size(205, 22);
            this.menuSubgrupoProdutos.Text = "2. Subgrupo de Produtos";
            // 
            // menuTributacao
            // 
            this.menuTributacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrupoImpostoCadastrados,
            this.menuTributacaoPorEstado});
            this.menuTributacao.ForeColor = System.Drawing.SystemColors.Control;
            this.menuTributacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuTributacao.Name = "menuTributacao";
            this.menuTributacao.Size = new System.Drawing.Size(93, 62);
            this.menuTributacao.Text = "   Tributação   ";
            this.menuTributacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuTributacao.ToolTipText = "Cadastro de subgrupoProdutos";
            // 
            // menuGrupoImpostoCadastrados
            // 
            this.menuGrupoImpostoCadastrados.Name = "menuGrupoImpostoCadastrados";
            this.menuGrupoImpostoCadastrados.Size = new System.Drawing.Size(253, 22);
            this.menuGrupoImpostoCadastrados.Text = "1. Grupo de Impostos cadastrados";
            // 
            // menuTributacaoPorEstado
            // 
            this.menuTributacaoPorEstado.Name = "menuTributacaoPorEstado";
            this.menuTributacaoPorEstado.Size = new System.Drawing.Size(253, 22);
            this.menuTributacaoPorEstado.Text = "2. Tributação por Estado";
            // 
            // menuEmpresa
            // 
            this.menuEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.menuEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEmpresa.Name = "menuEmpresa";
            this.menuEmpresa.Size = new System.Drawing.Size(56, 62);
            this.menuEmpresa.Text = "Empresa";
            this.menuEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuEmpresa.ToolTipText = "Cadastro de subgrupoProdutos";
            // 
            // barraCaixa
            // 
            this.barraCaixa.AutoSize = false;
            this.barraCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.barraCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barraCaixa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraCaixa.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraCaixa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPDV,
            this.menuAbrirCaixa,
            this.menuSangria,
            this.menuSuprimento,
            this.menuFecharCaixa});
            this.barraCaixa.Location = new System.Drawing.Point(0, 25);
            this.barraCaixa.Name = "barraCaixa";
            this.barraCaixa.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barraCaixa.Size = new System.Drawing.Size(1089, 65);
            this.barraCaixa.Stretch = true;
            this.barraCaixa.TabIndex = 23;
            this.barraCaixa.Visible = false;
            // 
            // menuPDV
            // 
            this.menuPDV.ForeColor = System.Drawing.SystemColors.Control;
            this.menuPDV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPDV.Name = "menuPDV";
            this.menuPDV.Size = new System.Drawing.Size(51, 62);
            this.menuPDV.Text = "   PDV   ";
            this.menuPDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPDV.ToolTipText = "Cadastro de Clientes";
            // 
            // menuAbrirCaixa
            // 
            this.menuAbrirCaixa.ForeColor = System.Drawing.SystemColors.Control;
            this.menuAbrirCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAbrirCaixa.Name = "menuAbrirCaixa";
            this.menuAbrirCaixa.Size = new System.Drawing.Size(87, 62);
            this.menuAbrirCaixa.Text = "   Abrir Caixa   ";
            this.menuAbrirCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAbrirCaixa.ToolTipText = "Cadastro de Clientes";
            // 
            // menuSangria
            // 
            this.menuSangria.ForeColor = System.Drawing.SystemColors.Control;
            this.menuSangria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSangria.Name = "menuSangria";
            this.menuSangria.Size = new System.Drawing.Size(68, 62);
            this.menuSangria.Text = "   Sangria   ";
            this.menuSangria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSangria.ToolTipText = "Cadastro de Clientes";
            // 
            // menuSuprimento
            // 
            this.menuSuprimento.ForeColor = System.Drawing.SystemColors.Control;
            this.menuSuprimento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSuprimento.Name = "menuSuprimento";
            this.menuSuprimento.Size = new System.Drawing.Size(91, 62);
            this.menuSuprimento.Text = "   Suprimento   ";
            this.menuSuprimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSuprimento.ToolTipText = "Cadastro de Clientes";
            // 
            // menuFecharCaixa
            // 
            this.menuFecharCaixa.ForeColor = System.Drawing.SystemColors.Control;
            this.menuFecharCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFecharCaixa.Name = "menuFecharCaixa";
            this.menuFecharCaixa.Size = new System.Drawing.Size(96, 62);
            this.menuFecharCaixa.Text = "   Fechar Caixa   ";
            this.menuFecharCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuFecharCaixa.ToolTipText = "Cadastro de Clientes";
            // 
            // barraVendas
            // 
            this.barraVendas.AutoSize = false;
            this.barraVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.barraVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barraVendas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraVendas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNumeroDocumento,
            this.menuDataEmissao,
            this.menuDtaVendasFinalizada,
            this.menuCPF});
            this.barraVendas.Location = new System.Drawing.Point(0, 25);
            this.barraVendas.Name = "barraVendas";
            this.barraVendas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barraVendas.Size = new System.Drawing.Size(1089, 65);
            this.barraVendas.Stretch = true;
            this.barraVendas.TabIndex = 24;
            this.barraVendas.Visible = false;
            // 
            // menuNumeroDocumento
            // 
            this.menuNumeroDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuNumeroDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.menuNumeroDocumento.Image = ((System.Drawing.Image)(resources.GetObject("menuNumeroDocumento.Image")));
            this.menuNumeroDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNumeroDocumento.Name = "menuNumeroDocumento";
            this.menuNumeroDocumento.Size = new System.Drawing.Size(121, 62);
            this.menuNumeroDocumento.Text = "Número Documento";
            this.menuNumeroDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuNumeroDocumento.ToolTipText = "Cadastro de Vendas";
            // 
            // menuDataEmissao
            // 
            this.menuDataEmissao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuDataEmissao.ForeColor = System.Drawing.SystemColors.Control;
            this.menuDataEmissao.Image = ((System.Drawing.Image)(resources.GetObject("menuDataEmissao.Image")));
            this.menuDataEmissao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDataEmissao.Name = "menuDataEmissao";
            this.menuDataEmissao.Size = new System.Drawing.Size(81, 62);
            this.menuDataEmissao.Text = "Data Emissão";
            this.menuDataEmissao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuDataEmissao.ToolTipText = "Cadastro de Vendas";
            // 
            // menuDtaVendasFinalizada
            // 
            this.menuDtaVendasFinalizada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuDtaVendasFinalizada.ForeColor = System.Drawing.SystemColors.Control;
            this.menuDtaVendasFinalizada.Image = ((System.Drawing.Image)(resources.GetObject("menuDtaVendasFinalizada.Image")));
            this.menuDtaVendasFinalizada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDtaVendasFinalizada.Name = "menuDtaVendasFinalizada";
            this.menuDtaVendasFinalizada.Size = new System.Drawing.Size(130, 62);
            this.menuDtaVendasFinalizada.Text = "Data Vendas Finalizada";
            this.menuDtaVendasFinalizada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuDtaVendasFinalizada.ToolTipText = "Cadastro de Vendas";
            // 
            // menuCPF
            // 
            this.menuCPF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.menuCPF.Image = ((System.Drawing.Image)(resources.GetObject("menuCPF.Image")));
            this.menuCPF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCPF.Name = "menuCPF";
            this.menuCPF.Size = new System.Drawing.Size(32, 62);
            this.menuCPF.Text = "CPF";
            this.menuCPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCPF.ToolTipText = "Cadastro de Vendas";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1089, 454);
            this.Controls.Add(this.barraVendas);
            this.Controls.Add(this.barraCaixa);
            this.Controls.Add(this.barraCadastros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStripMenu);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.statusStripMenu.ResumeLayout(false);
            this.statusStripMenu.PerformLayout();
            this.barraCadastros.ResumeLayout(false);
            this.barraCadastros.PerformLayout();
            this.barraCaixa.ResumeLayout(false);
            this.barraCaixa.PerformLayout();
            this.barraVendas.ResumeLayout(false);
            this.barraVendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton menuCadastros;
        private System.Windows.Forms.ToolStripButton menuCaixa;
        private System.Windows.Forms.ToolStripButton menuVendas;
        private System.Windows.Forms.ToolStripButton menuOrcamentos;
        private System.Windows.Forms.ToolStripButton menuFinanceiro;
        private System.Windows.Forms.ToolStripButton menuEstoque;
        private System.Windows.Forms.ToolStripButton menuUtilitarios;
        private System.Windows.Forms.ToolStripButton menuBloquear;
        private System.Windows.Forms.ToolStripDropDownButton menuConfiguracao;
        private System.Windows.Forms.ToolStripButton menuAjuda;
        private System.Windows.Forms.ToolStripButton menuSair;
        private System.Windows.Forms.StatusStrip statusStripMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip barraCadastros;
        private System.Windows.Forms.ToolStripDropDownButton Clientes;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuIncluirSaldoCliente;
        private System.Windows.Forms.ToolStripMenuItem menuTranferirSaldo;
        private System.Windows.Forms.ToolStripButton menuProdutos;
        private System.Windows.Forms.ToolStripButton menuUsuarios;
        private System.Windows.Forms.ToolStripButton menuFuncionarios;
        private System.Windows.Forms.ToolStripButton menuFormaPagamento;
        private System.Windows.Forms.ToolStripDropDownButton GrupoProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuGruposDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuSubgrupoProdutos;
        private System.Windows.Forms.ToolStripDropDownButton menuTributacao;
        private System.Windows.Forms.ToolStripMenuItem menuGrupoImpostoCadastrados;
        private System.Windows.Forms.ToolStripMenuItem menuTributacaoPorEstado;
        private System.Windows.Forms.ToolStripButton menuEmpresa;
        private System.Windows.Forms.ToolStrip barraCaixa;
        private System.Windows.Forms.ToolStripButton menuPDV;
        private System.Windows.Forms.ToolStripButton menuAbrirCaixa;
        private System.Windows.Forms.ToolStripButton menuSangria;
        private System.Windows.Forms.ToolStripButton menuSuprimento;
        private System.Windows.Forms.ToolStripButton menuFecharCaixa;
        private System.Windows.Forms.ToolStrip barraVendas;
        private System.Windows.Forms.ToolStripButton menuNumeroDocumento;
        private System.Windows.Forms.ToolStripButton menuDataEmissao;
        private System.Windows.Forms.ToolStripButton menuDtaVendasFinalizada;
        private System.Windows.Forms.ToolStripButton menuCPF;
    }
}