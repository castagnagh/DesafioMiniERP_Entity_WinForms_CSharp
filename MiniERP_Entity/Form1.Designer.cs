﻿namespace MiniERP_Entity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabVendas = new TabPage();
            splitContainer1 = new SplitContainer();
            button6 = new Button();
            button5 = new Button();
            labelPrecoTotal = new Label();
            label18 = new Label();
            listViewCarrinhoCompraLoja = new ListView();
            nr = new ColumnHeader();
            nomeItem = new ColumnHeader();
            precoItemCar = new ColumnHeader();
            qtdItem = new ColumnHeader();
            precoTotalItem = new ColumnHeader();
            label16 = new Label();
            textBoxInformeQtd = new TextBox();
            labelInformeQtd = new Label();
            buttonAddQtdItemLoja = new Button();
            buttonRemoverNomePesquisaAreaitens = new Button();
            textBoxIdClienteHiddenLoja = new TextBox();
            buttonSelecionarItemLoja = new Button();
            listViewItensLoja = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            precoItem = new ColumnHeader();
            qtdEstoque = new ColumnHeader();
            fornecedorItem = new ColumnHeader();
            buttonPesquisaClienteLoja = new Button();
            textBoxPesquisaClienteLoja = new TextBox();
            label17 = new Label();
            tabAdmin = new TabPage();
            tabControl2 = new TabControl();
            tabClientes = new TabPage();
            listViewClientes = new ListView();
            nomeCompleto = new ColumnHeader();
            cpf = new ColumnHeader();
            label4 = new Label();
            textBoxBuscaCliente = new TextBox();
            panel1 = new Panel();
            textBoxCpfCliente = new MaskedTextBox();
            buttonCadastrarCliente = new Button();
            textBoxNomeCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabFornecedores = new TabPage();
            textBoxBuscaCnpjFornecedor = new MaskedTextBox();
            listViewFornecedores = new ListView();
            razaoSocial = new ColumnHeader();
            cnpj = new ColumnHeader();
            label8 = new Label();
            panel2 = new Panel();
            buttonCadastrarFornecedor = new Button();
            maskedTextBoxCnpjFornecedor = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBoxRazaoSocialFornecedor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tabProdutos = new TabPage();
            listViewProdutos = new ListView();
            descricao = new ColumnHeader();
            preco = new ColumnHeader();
            estoque = new ColumnHeader();
            fornecedor = new ColumnHeader();
            textBoxBuscarProduto = new TextBox();
            label15 = new Label();
            panel3 = new Panel();
            buttonPesquisarForneceProduto = new Button();
            label14 = new Label();
            textBoxNomeForneceProduto = new TextBox();
            label13 = new Label();
            textBoxIdForneceProduto = new TextBox();
            textBoxEstoqueProduto = new TextBox();
            textBoxPrecoProduto = new TextBox();
            textBoxDescricaoProduto = new TextBox();
            label12 = new Label();
            buttonCadastrarProduto = new Button();
            maskedTextBox3 = new MaskedTextBox();
            button3 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabNotas = new TabPage();
            textBoxIdHiddenNota = new TextBox();
            button9 = new Button();
            button8 = new Button();
            label22 = new Label();
            listViewNotasCliente = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            panel4 = new Panel();
            maskedTextBox2 = new MaskedTextBox();
            button7 = new Button();
            button10 = new Button();
            textBoxIdHiddenClienteNotas = new TextBox();
            label20 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label19 = new Label();
            textBoxNomeClienteNotas = new TextBox();
            label21 = new Label();
            listViewNotas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabControl2.SuspendLayout();
            tabClientes.SuspendLayout();
            panel1.SuspendLayout();
            tabFornecedores.SuspendLayout();
            panel2.SuspendLayout();
            tabProdutos.SuspendLayout();
            panel3.SuspendLayout();
            tabNotas.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabVendas);
            tabControl1.Controls.Add(tabAdmin);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 606);
            tabControl1.TabIndex = 0;
            // 
            // tabVendas
            // 
            tabVendas.Controls.Add(splitContainer1);
            tabVendas.Location = new Point(4, 24);
            tabVendas.Name = "tabVendas";
            tabVendas.Padding = new Padding(3);
            tabVendas.Size = new Size(1040, 578);
            tabVendas.TabIndex = 0;
            tabVendas.Text = "Loja";
            tabVendas.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(labelPrecoTotal);
            splitContainer1.Panel1.Controls.Add(label18);
            splitContainer1.Panel1.Controls.Add(listViewCarrinhoCompraLoja);
            splitContainer1.Panel1.Controls.Add(label16);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxInformeQtd);
            splitContainer1.Panel2.Controls.Add(labelInformeQtd);
            splitContainer1.Panel2.Controls.Add(buttonAddQtdItemLoja);
            splitContainer1.Panel2.Controls.Add(buttonRemoverNomePesquisaAreaitens);
            splitContainer1.Panel2.Controls.Add(textBoxIdClienteHiddenLoja);
            splitContainer1.Panel2.Controls.Add(buttonSelecionarItemLoja);
            splitContainer1.Panel2.Controls.Add(listViewItensLoja);
            splitContainer1.Panel2.Controls.Add(buttonPesquisaClienteLoja);
            splitContainer1.Panel2.Controls.Add(textBoxPesquisaClienteLoja);
            splitContainer1.Panel2.Controls.Add(label17);
            splitContainer1.Size = new Size(1034, 572);
            splitContainer1.SplitterDistance = 383;
            splitContainer1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(248, 524);
            button6.Name = "button6";
            button6.Size = new Size(114, 23);
            button6.TabIndex = 6;
            button6.Text = "Finalizar Compra";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonFinalizarCompra_Click;
            // 
            // button5
            // 
            button5.Location = new Point(17, 474);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 5;
            button5.Text = "Cancelar Compra";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonCancelarCompra_Click;
            // 
            // labelPrecoTotal
            // 
            labelPrecoTotal.AutoSize = true;
            labelPrecoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecoTotal.Location = new Point(74, 528);
            labelPrecoTotal.Name = "labelPrecoTotal";
            labelPrecoTotal.Size = new Size(0, 21);
            labelPrecoTotal.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 532);
            label18.Name = "label18";
            label18.Size = new Size(48, 15);
            label18.TabIndex = 2;
            label18.Text = "Total R$";
            // 
            // listViewCarrinhoCompraLoja
            // 
            listViewCarrinhoCompraLoja.Columns.AddRange(new ColumnHeader[] { nr, nomeItem, precoItemCar, qtdItem, precoTotalItem });
            listViewCarrinhoCompraLoja.Location = new Point(17, 45);
            listViewCarrinhoCompraLoja.Name = "listViewCarrinhoCompraLoja";
            listViewCarrinhoCompraLoja.Size = new Size(345, 423);
            listViewCarrinhoCompraLoja.TabIndex = 1;
            listViewCarrinhoCompraLoja.UseCompatibleStateImageBehavior = false;
            listViewCarrinhoCompraLoja.View = View.Details;
            // 
            // nr
            // 
            nr.Text = "Nr";
            nr.Width = 30;
            // 
            // nomeItem
            // 
            nomeItem.Text = "Nome";
            nomeItem.Width = 130;
            // 
            // precoItemCar
            // 
            precoItemCar.Text = "Preço Un.";
            precoItemCar.Width = 65;
            // 
            // qtdItem
            // 
            qtdItem.Text = "Qtd";
            qtdItem.Width = 45;
            // 
            // precoTotalItem
            // 
            precoTotalItem.Text = "Preç Total";
            precoTotalItem.Width = 65;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 17);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 0;
            label16.Text = "Carrinho";
            // 
            // textBoxInformeQtd
            // 
            textBoxInformeQtd.Enabled = false;
            textBoxInformeQtd.Location = new Point(153, 495);
            textBoxInformeQtd.Name = "textBoxInformeQtd";
            textBoxInformeQtd.Size = new Size(100, 23);
            textBoxInformeQtd.TabIndex = 9;
            // 
            // labelInformeQtd
            // 
            labelInformeQtd.AutoSize = true;
            labelInformeQtd.Location = new Point(13, 499);
            labelInformeQtd.Name = "labelInformeQtd";
            labelInformeQtd.Size = new Size(124, 15);
            labelInformeQtd.TabIndex = 8;
            labelInformeQtd.Text = "Informe a quantidade:";
            // 
            // buttonAddQtdItemLoja
            // 
            buttonAddQtdItemLoja.Location = new Point(13, 524);
            buttonAddQtdItemLoja.Name = "buttonAddQtdItemLoja";
            buttonAddQtdItemLoja.Size = new Size(240, 23);
            buttonAddQtdItemLoja.TabIndex = 7;
            buttonAddQtdItemLoja.Text = "Adicionar com quantidade";
            buttonAddQtdItemLoja.UseVisualStyleBackColor = true;
            buttonAddQtdItemLoja.Click += buttonAddQtdItemLoja_Click;
            // 
            // buttonRemoverNomePesquisaAreaitens
            // 
            buttonRemoverNomePesquisaAreaitens.Location = new Point(560, 13);
            buttonRemoverNomePesquisaAreaitens.Name = "buttonRemoverNomePesquisaAreaitens";
            buttonRemoverNomePesquisaAreaitens.Size = new Size(75, 23);
            buttonRemoverNomePesquisaAreaitens.TabIndex = 6;
            buttonRemoverNomePesquisaAreaitens.Text = "Remover Cliente";
            buttonRemoverNomePesquisaAreaitens.UseVisualStyleBackColor = true;
            buttonRemoverNomePesquisaAreaitens.Click += buttonRemoverNomePesquisaAreaitens_Click;
            // 
            // textBoxIdClienteHiddenLoja
            // 
            textBoxIdClienteHiddenLoja.Location = new Point(123, 14);
            textBoxIdClienteHiddenLoja.Name = "textBoxIdClienteHiddenLoja";
            textBoxIdClienteHiddenLoja.Size = new Size(30, 23);
            textBoxIdClienteHiddenLoja.TabIndex = 5;
            textBoxIdClienteHiddenLoja.Visible = false;
            // 
            // buttonSelecionarItemLoja
            // 
            buttonSelecionarItemLoja.Location = new Point(443, 524);
            buttonSelecionarItemLoja.Name = "buttonSelecionarItemLoja";
            buttonSelecionarItemLoja.Size = new Size(192, 23);
            buttonSelecionarItemLoja.TabIndex = 4;
            buttonSelecionarItemLoja.Text = "Adicionar 1 item ao carrinho";
            buttonSelecionarItemLoja.UseVisualStyleBackColor = true;
            buttonSelecionarItemLoja.Click += buttonSelecionarItemLoja_Click;
            // 
            // listViewItensLoja
            // 
            listViewItensLoja.Columns.AddRange(new ColumnHeader[] { id, nome, precoItem, qtdEstoque, fornecedorItem });
            listViewItensLoja.FullRowSelect = true;
            listViewItensLoja.Location = new Point(13, 82);
            listViewItensLoja.MultiSelect = false;
            listViewItensLoja.Name = "listViewItensLoja";
            listViewItensLoja.Size = new Size(622, 386);
            listViewItensLoja.TabIndex = 3;
            listViewItensLoja.UseCompatibleStateImageBehavior = false;
            listViewItensLoja.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 200;
            // 
            // precoItem
            // 
            precoItem.Text = "Preço";
            precoItem.Width = 80;
            // 
            // qtdEstoque
            // 
            qtdEstoque.Text = "Em Estoque";
            qtdEstoque.Width = 80;
            // 
            // fornecedorItem
            // 
            fornecedorItem.Text = "Fornecedor";
            fornecedorItem.Width = 180;
            // 
            // buttonPesquisaClienteLoja
            // 
            buttonPesquisaClienteLoja.Location = new Point(560, 45);
            buttonPesquisaClienteLoja.Name = "buttonPesquisaClienteLoja";
            buttonPesquisaClienteLoja.Size = new Size(75, 23);
            buttonPesquisaClienteLoja.TabIndex = 2;
            buttonPesquisaClienteLoja.Text = "Pesquisar";
            buttonPesquisaClienteLoja.UseVisualStyleBackColor = true;
            buttonPesquisaClienteLoja.Click += buttonPesquisaClienteLoja_Click;
            // 
            // textBoxPesquisaClienteLoja
            // 
            textBoxPesquisaClienteLoja.Enabled = false;
            textBoxPesquisaClienteLoja.Location = new Point(13, 45);
            textBoxPesquisaClienteLoja.Name = "textBoxPesquisaClienteLoja";
            textBoxPesquisaClienteLoja.Size = new Size(528, 23);
            textBoxPesquisaClienteLoja.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(13, 17);
            label17.Name = "label17";
            label17.Size = new Size(104, 15);
            label17.TabIndex = 0;
            label17.Text = "Cliente da compra";
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabControl2);
            tabAdmin.Location = new Point(4, 24);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(1040, 578);
            tabAdmin.TabIndex = 1;
            tabAdmin.Text = "Administrador";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl2.Controls.Add(tabClientes);
            tabControl2.Controls.Add(tabFornecedores);
            tabControl2.Controls.Add(tabProdutos);
            tabControl2.Controls.Add(tabNotas);
            tabControl2.Location = new Point(6, 6);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1028, 566);
            tabControl2.TabIndex = 0;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(listViewClientes);
            tabClientes.Controls.Add(label4);
            tabClientes.Controls.Add(textBoxBuscaCliente);
            tabClientes.Controls.Add(panel1);
            tabClientes.Location = new Point(4, 24);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(1020, 538);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Gerenciar Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // listViewClientes
            // 
            listViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewClientes.Columns.AddRange(new ColumnHeader[] { nomeCompleto, cpf });
            listViewClientes.FullRowSelect = true;
            listViewClientes.Location = new Point(8, 222);
            listViewClientes.MultiSelect = false;
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(1005, 308);
            listViewClientes.TabIndex = 4;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            listViewClientes.View = View.Details;
            // 
            // nomeCompleto
            // 
            nomeCompleto.Text = "Nome Completo";
            nomeCompleto.Width = 500;
            // 
            // cpf
            // 
            cpf.Text = "CPF";
            cpf.Width = 490;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 174);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 3;
            label4.Text = "Buscar cliente pelo nome";
            // 
            // textBoxBuscaCliente
            // 
            textBoxBuscaCliente.Location = new Point(8, 192);
            textBoxBuscaCliente.Name = "textBoxBuscaCliente";
            textBoxBuscaCliente.Size = new Size(432, 23);
            textBoxBuscaCliente.TabIndex = 6;
            textBoxBuscaCliente.KeyUp += KeyUpBuscarCliente;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(textBoxCpfCliente);
            panel1.Controls.Add(buttonCadastrarCliente);
            panel1.Controls.Add(textBoxNomeCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 162);
            panel1.TabIndex = 0;
            // 
            // textBoxCpfCliente
            // 
            textBoxCpfCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCpfCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxCpfCliente.Location = new Point(522, 81);
            textBoxCpfCliente.Mask = "000,000,000-00";
            textBoxCpfCliente.Name = "textBoxCpfCliente";
            textBoxCpfCliente.Size = new Size(442, 23);
            textBoxCpfCliente.TabIndex = 4;
            // 
            // buttonCadastrarCliente
            // 
            buttonCadastrarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCadastrarCliente.Location = new Point(889, 120);
            buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            buttonCadastrarCliente.Size = new Size(75, 23);
            buttonCadastrarCliente.TabIndex = 5;
            buttonCadastrarCliente.Text = "Cadastrar";
            buttonCadastrarCliente.UseVisualStyleBackColor = true;
            buttonCadastrarCliente.Click += buttonCadastrarCliente_Click;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeCliente.Location = new Point(36, 81);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(442, 23);
            textBoxNomeCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(522, 53);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(36, 53);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(447, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            // 
            // tabFornecedores
            // 
            tabFornecedores.Controls.Add(textBoxBuscaCnpjFornecedor);
            tabFornecedores.Controls.Add(listViewFornecedores);
            tabFornecedores.Controls.Add(label8);
            tabFornecedores.Controls.Add(panel2);
            tabFornecedores.Location = new Point(4, 24);
            tabFornecedores.Name = "tabFornecedores";
            tabFornecedores.Padding = new Padding(3);
            tabFornecedores.Size = new Size(1020, 538);
            tabFornecedores.TabIndex = 1;
            tabFornecedores.Text = "Gerenciar Fornecedores";
            tabFornecedores.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscaCnpjFornecedor
            // 
            textBoxBuscaCnpjFornecedor.Location = new Point(8, 192);
            textBoxBuscaCnpjFornecedor.Mask = "00,000,000/0000-00";
            textBoxBuscaCnpjFornecedor.Name = "textBoxBuscaCnpjFornecedor";
            textBoxBuscaCnpjFornecedor.Size = new Size(433, 23);
            textBoxBuscaCnpjFornecedor.TabIndex = 5;
            textBoxBuscaCnpjFornecedor.KeyUp += KeyUpBuscarFornecedorCnpj;
            // 
            // listViewFornecedores
            // 
            listViewFornecedores.Columns.AddRange(new ColumnHeader[] { razaoSocial, cnpj });
            listViewFornecedores.Location = new Point(8, 221);
            listViewFornecedores.Name = "listViewFornecedores";
            listViewFornecedores.Size = new Size(1002, 311);
            listViewFornecedores.TabIndex = 4;
            listViewFornecedores.UseCompatibleStateImageBehavior = false;
            listViewFornecedores.View = View.Details;
            // 
            // razaoSocial
            // 
            razaoSocial.Text = "Razão Social";
            razaoSocial.Width = 500;
            // 
            // cnpj
            // 
            cnpj.Text = "CNPJ";
            cnpj.Width = 490;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 174);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 3;
            label8.Text = "Buscar por CNPJ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(buttonCadastrarFornecedor);
            panel2.Controls.Add(maskedTextBoxCnpjFornecedor);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBoxRazaoSocialFornecedor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 162);
            panel2.TabIndex = 1;
            // 
            // buttonCadastrarFornecedor
            // 
            buttonCadastrarFornecedor.Location = new Point(880, 121);
            buttonCadastrarFornecedor.Name = "buttonCadastrarFornecedor";
            buttonCadastrarFornecedor.Size = new Size(75, 23);
            buttonCadastrarFornecedor.TabIndex = 2;
            buttonCadastrarFornecedor.Text = "Cadastrar";
            buttonCadastrarFornecedor.UseVisualStyleBackColor = true;
            buttonCadastrarFornecedor.Click += buttonCadastrarFornecedor_Click;
            // 
            // maskedTextBoxCnpjFornecedor
            // 
            maskedTextBoxCnpjFornecedor.Location = new Point(522, 81);
            maskedTextBoxCnpjFornecedor.Mask = "00,000,000/0000-00";
            maskedTextBoxCnpjFornecedor.Name = "maskedTextBoxCnpjFornecedor";
            maskedTextBoxCnpjFornecedor.Size = new Size(433, 23);
            maskedTextBoxCnpjFornecedor.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(1330, 81);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(438, 16);
            maskedTextBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(1693, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 85);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxRazaoSocialFornecedor
            // 
            textBoxRazaoSocialFornecedor.BorderStyle = BorderStyle.FixedSingle;
            textBoxRazaoSocialFornecedor.Location = new Point(36, 81);
            textBoxRazaoSocialFornecedor.Name = "textBoxRazaoSocialFornecedor";
            textBoxRazaoSocialFornecedor.Size = new Size(438, 23);
            textBoxRazaoSocialFornecedor.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(522, 53);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 2;
            label5.Text = "CNPJ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(36, 53);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 1;
            label6.Text = "Razão Social";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(422, 14);
            label7.Name = "label7";
            label7.Size = new Size(144, 15);
            label7.TabIndex = 0;
            label7.Text = "Cadastro de Fornecedores";
            // 
            // tabProdutos
            // 
            tabProdutos.Controls.Add(listViewProdutos);
            tabProdutos.Controls.Add(textBoxBuscarProduto);
            tabProdutos.Controls.Add(label15);
            tabProdutos.Controls.Add(panel3);
            tabProdutos.Location = new Point(4, 24);
            tabProdutos.Name = "tabProdutos";
            tabProdutos.Padding = new Padding(3);
            tabProdutos.Size = new Size(1020, 538);
            tabProdutos.TabIndex = 2;
            tabProdutos.Text = "Gerenciar Produtos";
            tabProdutos.UseVisualStyleBackColor = true;
            // 
            // listViewProdutos
            // 
            listViewProdutos.Columns.AddRange(new ColumnHeader[] { descricao, preco, estoque, fornecedor });
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.Location = new Point(8, 222);
            listViewProdutos.MultiSelect = false;
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(1002, 310);
            listViewProdutos.TabIndex = 18;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            listViewProdutos.View = View.Details;
            // 
            // descricao
            // 
            descricao.Text = "Descrição";
            descricao.Width = 350;
            // 
            // preco
            // 
            preco.Text = "Preço";
            preco.Width = 115;
            // 
            // estoque
            // 
            estoque.Text = "Estoque";
            estoque.Width = 115;
            // 
            // fornecedor
            // 
            fornecedor.Text = "Fornecedor";
            fornecedor.Width = 350;
            // 
            // textBoxBuscarProduto
            // 
            textBoxBuscarProduto.Location = new Point(8, 192);
            textBoxBuscarProduto.Name = "textBoxBuscarProduto";
            textBoxBuscarProduto.Size = new Size(432, 23);
            textBoxBuscarProduto.TabIndex = 17;
            textBoxBuscarProduto.KeyUp += buscarProdutoKeyUp;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 174);
            label15.Name = "label15";
            label15.Size = new Size(148, 15);
            label15.TabIndex = 16;
            label15.Text = "Buscar produto pelo nome";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(buttonPesquisarForneceProduto);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBoxNomeForneceProduto);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(textBoxIdForneceProduto);
            panel3.Controls.Add(textBoxEstoqueProduto);
            panel3.Controls.Add(textBoxPrecoProduto);
            panel3.Controls.Add(textBoxDescricaoProduto);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(buttonCadastrarProduto);
            panel3.Controls.Add(maskedTextBox3);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(3, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 162);
            panel3.TabIndex = 2;
            // 
            // buttonPesquisarForneceProduto
            // 
            buttonPesquisarForneceProduto.Location = new Point(467, 107);
            buttonPesquisarForneceProduto.Name = "buttonPesquisarForneceProduto";
            buttonPesquisarForneceProduto.Size = new Size(75, 23);
            buttonPesquisarForneceProduto.TabIndex = 15;
            buttonPesquisarForneceProduto.Text = "Pesquisar";
            buttonPesquisarForneceProduto.UseVisualStyleBackColor = true;
            buttonPesquisarForneceProduto.Click += buttonPesquisarForneceProduto_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(187, 90);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 14;
            label14.Text = "Fornecedor";
            // 
            // textBoxNomeForneceProduto
            // 
            textBoxNomeForneceProduto.Enabled = false;
            textBoxNomeForneceProduto.Location = new Point(187, 108);
            textBoxNomeForneceProduto.Name = "textBoxNomeForneceProduto";
            textBoxNomeForneceProduto.Size = new Size(274, 23);
            textBoxNomeForneceProduto.TabIndex = 13;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(40, 90);
            label13.Name = "label13";
            label13.Size = new Size(97, 15);
            label13.TabIndex = 12;
            label13.Text = "Id do Fornecedor";
            // 
            // textBoxIdForneceProduto
            // 
            textBoxIdForneceProduto.Enabled = false;
            textBoxIdForneceProduto.Location = new Point(40, 108);
            textBoxIdForneceProduto.Name = "textBoxIdForneceProduto";
            textBoxIdForneceProduto.Size = new Size(127, 23);
            textBoxIdForneceProduto.TabIndex = 11;
            // 
            // textBoxEstoqueProduto
            // 
            textBoxEstoqueProduto.Location = new Point(828, 55);
            textBoxEstoqueProduto.Name = "textBoxEstoqueProduto";
            textBoxEstoqueProduto.Size = new Size(127, 23);
            textBoxEstoqueProduto.TabIndex = 10;
            // 
            // textBoxPrecoProduto
            // 
            textBoxPrecoProduto.Location = new Point(600, 55);
            textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            textBoxPrecoProduto.Size = new Size(127, 23);
            textBoxPrecoProduto.TabIndex = 9;
            // 
            // textBoxDescricaoProduto
            // 
            textBoxDescricaoProduto.Location = new Point(40, 55);
            textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            textBoxDescricaoProduto.Size = new Size(502, 23);
            textBoxDescricaoProduto.TabIndex = 8;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(828, 32);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 7;
            label12.Text = "Estoque";
            // 
            // buttonCadastrarProduto
            // 
            buttonCadastrarProduto.Location = new Point(880, 121);
            buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            buttonCadastrarProduto.Size = new Size(75, 23);
            buttonCadastrarProduto.TabIndex = 2;
            buttonCadastrarProduto.Text = "Cadastrar";
            buttonCadastrarProduto.UseVisualStyleBackColor = true;
            buttonCadastrarProduto.Click += buttonCadastrarProduto_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maskedTextBox3.BorderStyle = BorderStyle.None;
            maskedTextBox3.Location = new Point(2134, 81);
            maskedTextBox3.Mask = "000,000,000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(438, 16);
            maskedTextBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(2497, 120);
            button3.Name = "button3";
            button3.Size = new Size(75, 147);
            button3.TabIndex = 5;
            button3.Text = "Cadastrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(600, 32);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 2;
            label9.Text = "Preço";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(36, 32);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 1;
            label10.Text = "Descrição";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(437, 0);
            label11.Name = "label11";
            label11.Size = new Size(121, 15);
            label11.TabIndex = 0;
            label11.Text = "Cadastro de Produtos";
            // 
            // tabNotas
            // 
            tabNotas.Controls.Add(textBoxIdHiddenNota);
            tabNotas.Controls.Add(button9);
            tabNotas.Controls.Add(button8);
            tabNotas.Controls.Add(label22);
            tabNotas.Controls.Add(listViewNotasCliente);
            tabNotas.Controls.Add(panel4);
            tabNotas.Controls.Add(label21);
            tabNotas.Controls.Add(listViewNotas);
            tabNotas.Location = new Point(4, 24);
            tabNotas.Name = "tabNotas";
            tabNotas.Padding = new Padding(3);
            tabNotas.Size = new Size(1020, 538);
            tabNotas.TabIndex = 3;
            tabNotas.Text = "Gerenciar Notas";
            tabNotas.UseVisualStyleBackColor = true;
            // 
            // textBoxIdHiddenNota
            // 
            textBoxIdHiddenNota.Location = new Point(689, 4);
            textBoxIdHiddenNota.Name = "textBoxIdHiddenNota";
            textBoxIdHiddenNota.Size = new Size(33, 23);
            textBoxIdHiddenNota.TabIndex = 9;
            textBoxIdHiddenNota.Visible = false;
            // 
            // button9
            // 
            button9.Location = new Point(939, 493);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 13;
            button9.Text = "Emitir PDF";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonEmitirPDF_Click;
            // 
            // button8
            // 
            button8.Location = new Point(457, 493);
            button8.Name = "button8";
            button8.Size = new Size(117, 23);
            button8.TabIndex = 12;
            button8.Text = "Visualize a nota";
            button8.UseVisualStyleBackColor = true;
            button8.Click += visualizeNota_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 183);
            label22.Name = "label22";
            label22.Size = new Size(95, 15);
            label22.TabIndex = 11;
            label22.Text = "Notas do Cliente";
            // 
            // listViewNotasCliente
            // 
            listViewNotasCliente.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewNotasCliente.FullRowSelect = true;
            listViewNotasCliente.Location = new Point(7, 211);
            listViewNotasCliente.MultiSelect = false;
            listViewNotasCliente.Name = "listViewNotasCliente";
            listViewNotasCliente.Size = new Size(567, 276);
            listViewNotasCliente.TabIndex = 10;
            listViewNotasCliente.UseCompatibleStateImageBehavior = false;
            listViewNotasCliente.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Id";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cliente";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Preç Nota";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Data da Compra";
            columnHeader9.Width = 190;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.MistyRose;
            panel4.Controls.Add(maskedTextBox2);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(textBoxIdHiddenClienteNotas);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(textBoxNomeClienteNotas);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(568, 162);
            panel4.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Location = new Point(2502, 81);
            maskedTextBox2.Mask = "000,000,000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(438, 16);
            maskedTextBox2.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(418, 124);
            button7.Name = "button7";
            button7.Size = new Size(120, 23);
            button7.TabIndex = 8;
            button7.Text = "Pesquisar Notas";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonPesquisarNotas_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button10.Location = new Point(2865, 120);
            button10.Name = "button10";
            button10.Size = new Size(75, 209);
            button10.TabIndex = 5;
            button10.Text = "Cadastrar";
            button10.UseVisualStyleBackColor = true;
            // 
            // textBoxIdHiddenClienteNotas
            // 
            textBoxIdHiddenClienteNotas.Location = new Point(17, 74);
            textBoxIdHiddenClienteNotas.Name = "textBoxIdHiddenClienteNotas";
            textBoxIdHiddenClienteNotas.Size = new Size(33, 23);
            textBoxIdHiddenClienteNotas.TabIndex = 7;
            textBoxIdHiddenClienteNotas.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(338, 27);
            label20.Name = "label20";
            label20.Size = new Size(152, 15);
            label20.TabIndex = 4;
            label20.Text = "Selecione a data da compra";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(338, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(154, 73);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 5;
            button2.Text = "Pesquisar cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonPesquisarClienteNotas_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 27);
            label19.Name = "label19";
            label19.Size = new Size(105, 15);
            label19.TabIndex = 0;
            label19.Text = "Selecione o cliente";
            // 
            // textBoxNomeClienteNotas
            // 
            textBoxNomeClienteNotas.Enabled = false;
            textBoxNomeClienteNotas.Location = new Point(17, 45);
            textBoxNomeClienteNotas.Name = "textBoxNomeClienteNotas";
            textBoxNomeClienteNotas.Size = new Size(253, 23);
            textBoxNomeClienteNotas.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(580, 6);
            label21.Name = "label21";
            label21.Size = new Size(103, 15);
            label21.TabIndex = 6;
            label21.Text = "Descrição da Nota";
            // 
            // listViewNotas
            // 
            listViewNotas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewNotas.Location = new Point(580, 33);
            listViewNotas.Name = "listViewNotas";
            listViewNotas.Size = new Size(434, 454);
            listViewNotas.TabIndex = 3;
            listViewNotas.UseCompatibleStateImageBehavior = false;
            listViewNotas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Produto";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Qtd";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Preç Un";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Preç Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 630);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Mini ERP";
            tabControl1.ResumeLayout(false);
            tabVendas.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabFornecedores.ResumeLayout(false);
            tabFornecedores.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabProdutos.ResumeLayout(false);
            tabProdutos.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabNotas.ResumeLayout(false);
            tabNotas.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabVendas;
        private TabPage tabAdmin;
        private SplitContainer splitContainer1;
        private TabControl tabControl2;
        private TabPage tabClientes;
        private TabPage tabFornecedores;
        private TabPage tabProdutos;
        private TabPage tabNotas;
        private Panel panel1;
        private Button buttonCadastrarCliente;
        private TextBox textBoxNomeCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxBuscaCliente;
        private ListView listViewClientes;
        private ColumnHeader nomeCompleto;
        private ColumnHeader cpf;
        private MaskedTextBox textBoxCpfCliente;
        private Panel panel2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBoxRazaoSocialFornecedor;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBoxCnpjFornecedor;
        private TextBox textBoxDescricaoProduto;
        private Button buttonCadastrarFornecedor;
        private Label label8;
        private ListView listViewFornecedores;
        private ColumnHeader razaoSocial;
        private ColumnHeader cnpj;
        private Panel panel3;
        private Button buttonCadastrarProduto;
        private MaskedTextBox maskedTextBox3;
        private Button button3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button buttonPesquisarForneceProduto;
        private Label label14;
        private TextBox textBoxNomeForneceProduto;
        private Label label13;
        private TextBox textBoxIdForneceProduto;
        private TextBox textBoxEstoqueProduto;
        private TextBox textBoxPrecoProduto;
        private Label label12;
        private Label label15;
        private ListView listViewProdutos;
        private TextBox textBoxBuscarProduto;
        private ColumnHeader descricao;
        private ColumnHeader preco;
        private ColumnHeader estoque;
        private ColumnHeader fornecedor;
        private Label label18;
        private ListView listViewCarrinhoCompraLoja;
        private Label label16;
        private ListView listViewItensLoja;
        private Button buttonPesquisaClienteLoja;
        private TextBox textBoxPesquisaClienteLoja;
        private Label label17;
        private Button buttonSelecionarItemLoja;
        private TextBox textBoxIdClienteHiddenLoja;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader precoItem;
        private ColumnHeader qtdEstoque;
        private ColumnHeader fornecedorItem;
        private Button buttonRemoverNomePesquisaAreaitens;
        private ColumnHeader nomeItem;
        private ColumnHeader precoItemCar;
        private Label labelPrecoTotal;
        private ColumnHeader qtdItem;
        private Button button6;
        private Button button5;
        private Button buttonAddQtdItemLoja;
        private ColumnHeader nr;
        private TextBox textBoxInformeQtd;
        private Label labelInformeQtd;
        private ListView listViewNotas;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxNomeClienteNotas;
        private Label label19;
        private Label label21;
        private Button button2;
        private Label label20;
        private TextBox textBoxIdHiddenClienteNotas;
        private Button button7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader precoTotalItem;
        private Panel panel4;
        private MaskedTextBox maskedTextBox2;
        private Button button10;
        private ListView listViewNotasCliente;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label label22;
        private MaskedTextBox textBoxBuscaCnpjFornecedor;
        private Button button9;
        private Button button8;
        private TextBox textBoxIdHiddenNota;
    }
}