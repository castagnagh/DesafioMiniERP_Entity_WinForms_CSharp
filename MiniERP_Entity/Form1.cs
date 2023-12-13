using Castle.Core.Internal;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MiniERP_Entity.DataModels;

namespace MiniERP_Entity
{
    public partial class Form1 : Form
    {
        Contexto contexto = new Contexto();
        List<ClienteProduto> listaCarrinho = new List<ClienteProduto>();
        List<ClienteProduto> listaItensDaNota = new List<ClienteProduto>();
        public Form1()
        {
            InitializeComponent();
            AtualizaListaClientes();
            AtualizaListaFornecedores();
            AtualizaListaProdutos();
            AtualizaListaItensLoja();

            listViewItensLoja.Enabled = false;
            buttonSelecionarItemLoja.Enabled = false;
            buttonPesquisaClienteLoja.Enabled = true;
            buttonRemoverNomePesquisaAreaitens.Visible = false;
            buttonAddQtdItemLoja.Enabled = false;
            textBoxInformeQtd.Enabled = false;

        }

        //C�DIGO RELACIONADO A TAB CONTROL "GERENCIAR CLIENTE"
        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                //verifica se n�o existe nenhum campo null
                if (String.IsNullOrEmpty(textBoxNomeCliente.Text) || String.IsNullOrEmpty(textBoxCpfCliente.Text))
                {
                    MessageBox.Show("N�o pode haver campo vazio, por favor preencha-os", "Aviso");
                }
                else
                {
                    //verifica se o cpf j� esta cadastrado
                    if (VerificaCpfCliente(textBoxCpfCliente.Text))
                    {
                        MessageBox.Show("Esse CPF j� est� cadastrado!", "Alerta");
                        textBoxCpfCliente.Text = String.Empty;
                    }
                    else
                    {
                        cliente.Nome = textBoxNomeCliente.Text;
                        cliente.Cpf = textBoxCpfCliente.Text;
                        contexto.Clientes.Add(cliente);
                        contexto.SaveChanges();
                        textBoxNomeCliente.Text = String.Empty;
                        textBoxCpfCliente.Text = String.Empty;
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso");
                        AtualizaListaClientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar" + ex.Message, "Aviso");
            }
        }

        private bool VerificaCpfCliente(string cpf)
        {
            // Verifica se h� algum cliente com o mesmo CPF no contexto
            return contexto.Clientes.Any(c => c.Cpf == cpf);
        }

        private void AtualizaListaClientes()
        {
            try
            {
                //LINQ
                //faz a consulta e grava em uma lista
                List<Cliente> listaCli =
                    (from Cliente c in contexto.Clientes select c)
                    .ToList<Cliente>();
                //ordena pelo nome
                listaCli.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                //limpar a lista para popular novamente ordenada
                listViewClientes.Items.Clear();
                //foreach para percorrer a lista
                foreach (var c in listaCli)
                {
                    string[] itens = { c.Nome, c.Cpf };
                    listViewClientes.Items.Add(new ListViewItem(itens));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar" + ex.Message, "Aviso");
            }
        }

        //Evento KeyUp da busca pelo nome do cliente - toda vez que o evento for acionado esse metodo � executado
        private void KeyUpBuscarCliente(object sender, KeyEventArgs e)
        {
            //ele armazena o conteudo digitado
            string nome = textBoxBuscaCliente.Text;
            try
            {
                //Cria uma lista
                List<Cliente> listaBusca = new List<Cliente>();

                //limpa a lista antes, de jogar todos os dados pra listaBusca para sempre atualizar as buscas de acordo com o digitado
                listaBusca.Clear();

                // Consulta LINQ - adiciona na lista conforme o texto no textBoxBuscaCliente
                listaBusca = contexto.Clientes
                    .Where(c => c.Nome.Contains(nome))
                    .ToList<Cliente>();

                //Ordena pelo nome
                listaBusca.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                // Atualiza a ListView com os resultados
                listViewClientes.Items.Clear();

                // Adiciona os clientes � ListView
                foreach (var cliente in listaBusca)
                {
                    string[] itens = { cliente.Nome, cliente.Cpf };
                    listViewClientes.Items.Add(new ListViewItem(itens));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar clientes: " + ex.Message, "Aviso");
            }
        }
        //FINAL DO C�DIGO RELACIONADO A TAB CONTROL "GERENCIAR CLIENTE"

        //INICIO DO C�DIGO RELACIONADO A TAB CONTROL "GERENCIAR FORNECEDORES"
        private void buttonCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();
                if (String.IsNullOrEmpty(textBoxRazaoSocialFornecedor.Text) || String.IsNullOrEmpty(maskedTextBoxCnpjFornecedor.Text))
                {
                    MessageBox.Show("N�o pode haver campo vazio, por favor preencha-os", "Aviso");
                }
                else
                {
                    if (VerificaCnpjFornecedor(maskedTextBoxCnpjFornecedor.Text))
                    {
                        MessageBox.Show("Esse CPF j� est� cadastrado!", "Alerta");
                        maskedTextBoxCnpjFornecedor.Text = String.Empty;
                    }
                    else
                    {
                        fornecedor.RazaoSocial = textBoxRazaoSocialFornecedor.Text;
                        fornecedor.Cnpj = maskedTextBoxCnpjFornecedor.Text;
                        contexto.Fornecedores.Add(fornecedor);
                        contexto.SaveChanges();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Aviso");
                        textBoxRazaoSocialFornecedor.Text = String.Empty;
                        maskedTextBoxCnpjFornecedor.Text = String.Empty;
                        AtualizaListaFornecedores();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro: " + ex.Message, "Erro");
            }
        }

        private bool VerificaCnpjFornecedor(string cnpj)
        {
            return contexto.Fornecedores.Any(f => f.Cnpj == cnpj);
        }

        public void AtualizaListaFornecedores()
        {
            List<Fornecedor> listaFornecedores =
                (from Fornecedor f in contexto.Fornecedores select f)
                    .ToList<Fornecedor>();
            listaFornecedores.Sort((a, b) => a.RazaoSocial.CompareTo(b.RazaoSocial));

            listViewFornecedores.Items.Clear();

            foreach (var f in listaFornecedores)
            {
                string[] itens = { f.RazaoSocial, f.Cnpj };
                listViewFornecedores.Items.Add(new ListViewItem(itens));
            }
        }

        private void KeyUpBuscarFornecedorCnpj(object sender, KeyEventArgs e)
        {
            try
            {
                string cnpj = textBoxBuscaCnpjFornecedor.Text;
                List<Fornecedor> listaBuscaFornecedor = new List<Fornecedor>();
                listaBuscaFornecedor.Clear();
                listaBuscaFornecedor = contexto.Fornecedores
                    .Where(f => f.Cnpj.Contains(cnpj))
                    .ToList();

                listaBuscaFornecedor.Sort((a, b) => a.RazaoSocial.CompareTo(b.RazaoSocial));

                listViewFornecedores.Items.Clear();
                foreach (var f in listaBuscaFornecedor)
                {
                    string[] itens = { f.RazaoSocial, f.Cnpj };
                    listViewFornecedores.Items.Add(new ListViewItem(itens));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro");
            }
        }
        //FIM DO C�DIGO RELACIONADO A TAB CONTROL "GERENCIAR FORNECEDORES"
        private void buttonPesquisarForneceProduto_Click(object sender, EventArgs e)
        {
            FormBuscaFornecedor bf = new FormBuscaFornecedor();
            bf.ShowDialog();
            textBoxIdForneceProduto.Text = bf.IdFornecedor.ToString();
            textBoxNomeForneceProduto.Text = bf.RazaoSocial;
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                if (String.IsNullOrEmpty(textBoxDescricaoProduto.Text) ||
                    String.IsNullOrEmpty(textBoxPrecoProduto.Text) ||
                    String.IsNullOrEmpty(textBoxEstoqueProduto.Text) ||
                    String.IsNullOrEmpty(textBoxIdForneceProduto.Text) ||
                    String.IsNullOrEmpty(textBoxNomeForneceProduto.Text))
                {
                    MessageBox.Show("N�o pode haver campo vazio, por favor preencha-os", "Aviso");
                }
                else
                {
                    p.Nome = textBoxDescricaoProduto.Text;
                    p.Preco = decimal.Parse(textBoxPrecoProduto.Text);
                    p.QtdEstoque = int.Parse(textBoxEstoqueProduto.Text);
                    p.FornecedorId = int.Parse(textBoxIdForneceProduto.Text);
                    contexto.Produtos.Add(p);
                    contexto.SaveChanges();
                    textBoxDescricaoProduto.Text = String.Empty;
                    textBoxPrecoProduto.Text = String.Empty;
                    textBoxEstoqueProduto.Text = String.Empty;
                    textBoxIdForneceProduto.Text = String.Empty;
                    textBoxNomeForneceProduto.Text = String.Empty;
                    MessageBox.Show("Produto cadastrado com sucesso", "Aviso");
                    AtualizaListaProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocoreu um erro: " + ex.Message, "Erro");
            }
        }

        private void AtualizaListaProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos =
                (from Produto p in contexto.Produtos select p)
                    .ToList<Produto>();
            listaProdutos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            listViewProdutos.Items.Clear();

            foreach (var produto in listaProdutos)
            {
                string[] itens = { produto.Nome, produto.Preco.ToString(), produto.QtdEstoque.ToString(), produto.Fornecedor.RazaoSocial.ToString() };
                listViewProdutos.Items.Add(new ListViewItem(itens));
            }
        }

        private void buscarProdutoKeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string produto = textBoxBuscarProduto.Text;
                List<Produto> listaBuscaProduto = new List<Produto>();
                listaBuscaProduto.Clear();


                listaBuscaProduto = contexto.Produtos
                    .Where(p => p.Nome.Contains(produto))
                    .ToList<Produto>();


                listaBuscaProduto.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                listViewProdutos.Items.Clear();

                foreach (var p in listaBuscaProduto)
                {
                    string[] itens = { p.Nome, p.Preco.ToString(), p.QtdEstoque.ToString(), p.Fornecedor.RazaoSocial };
                    listViewProdutos.Items.Add(new ListViewItem(itens));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void buttonPesquisaClienteLoja_Click(object sender, EventArgs e)
        {
            listaCarrinho.Clear();
            FormBuscarCliente bc = new FormBuscarCliente();
            bc.ShowDialog();
            int idClienteSelecionado = bc.IdCliente;
            string nomeSelecionado = bc.Nome;

            if (String.IsNullOrEmpty(idClienteSelecionado.ToString()) || String.IsNullOrEmpty(nomeSelecionado))
            {
                MessageBox.Show("Voc� n�o selecionou nenhum cliente!", "Aviso");
            }
            else
            {
                textBoxIdClienteHiddenLoja.Text = idClienteSelecionado.ToString();
                textBoxPesquisaClienteLoja.Text = nomeSelecionado.ToString();
                listViewItensLoja.Enabled = true;
                buttonSelecionarItemLoja.Enabled = true;
                buttonPesquisaClienteLoja.Enabled = false;
                buttonRemoverNomePesquisaAreaitens.Visible = true;
                buttonRemoverNomePesquisaAreaitens.Enabled = true;
                buttonAddQtdItemLoja.Enabled = true;
                textBoxInformeQtd.Enabled = true;
            }

        }

        private void AtualizaListaItensLoja()
        {
            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos =
                (from Produto p in contexto.Produtos select p)
                    .ToList<Produto>();
            listaProdutos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            listViewItensLoja.Items.Clear();

            foreach (var produto in listaProdutos)
            {
                string[] itens = { produto.Id.ToString(), produto.Nome, produto.Preco.ToString(), produto.QtdEstoque.ToString(), produto.Fornecedor.RazaoSocial.ToString() };
                listViewItensLoja.Items.Add(new ListViewItem(itens));
            }
        }

        private void buttonSelecionarItemLoja_Click(object sender, EventArgs e)
        {
            ClienteProduto cp = new ClienteProduto();
            if (listViewItensLoja.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection linha = this.listViewItensLoja.SelectedItems;

                foreach (ListViewItem item in linha)
                {
                    //pega o Id do produto na ListView na tab Loja
                    int idProduto = int.Parse(item.SubItems[0].Text);
                    //Pega o nome do produto na coluna de indice 1 da listView na tab Loja
                    string nomeProduto = item.SubItems[1].Text;
                    decimal precoProduto = decimal.Parse(item.SubItems[2].Text);
                    cp.ProdutoId = idProduto;
                    cp.Produto = new Produto { Nome = nomeProduto };
                    cp.PrecoUnitario = precoProduto;
                    cp.QtdTotal = 1;
                    cp.PrecoTotal = 1 * precoProduto;
                    listaCarrinho.Add(cp);
                    AtualizarListaItens();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item", "Aviso");
            }
        }

        private void AtualizarListaItens()
        {
            decimal valorTotalItem = 0;
            decimal valorTotalCompra = 0;

            listViewCarrinhoCompraLoja.Items.Clear();

            foreach (var i in listaCarrinho)
            {
                int index = listaCarrinho.IndexOf(i);
                valorTotalItem = i.PrecoUnitario * i.QtdTotal;

                string[] itens = { index.ToString(), i.Produto.Nome, i.PrecoUnitario.ToString(), i.QtdTotal.ToString(), valorTotalItem.ToString() };
                listViewCarrinhoCompraLoja.Items.Add(new ListViewItem(itens));
                valorTotalCompra += valorTotalItem;
                labelPrecoTotal.Text = valorTotalCompra.ToString();
            }
        }

        private void buttonRemoverNomePesquisaAreaitens_Click(object sender, EventArgs e)
        {
            buttonCancelarCompra_Click(sender, e);
            textBoxIdClienteHiddenLoja.Text = String.Empty;
            textBoxPesquisaClienteLoja.Text = String.Empty;
            listViewItensLoja.Enabled = false;
            buttonSelecionarItemLoja.Enabled = false;
            buttonPesquisaClienteLoja.Enabled = true;
            buttonRemoverNomePesquisaAreaitens.Visible = true;
            buttonAddQtdItemLoja.Enabled = false;
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Voc� tem certeza que deseja cancelar a compra?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {
                listaCarrinho.Clear();
                listViewCarrinhoCompraLoja.Items.Clear();
                labelPrecoTotal.Text = String.Empty;
            }
            else
            {
                return;
            }
        }
        private void buttonAddQtdItemLoja_Click(object sender, EventArgs e)
        {
            textBoxInformeQtd.Focus();
            string quantidade = textBoxInformeQtd.Text;
            ClienteProduto cp = new ClienteProduto();

            if (!String.IsNullOrEmpty(textBoxInformeQtd.Text))
            {
                if (listViewItensLoja.SelectedItems.Count > 0)
                {
                    ListView.SelectedListViewItemCollection linha = this.listViewItensLoja.SelectedItems;

                    foreach (ListViewItem item in linha)
                    {
                        //pega o Id do produto na ListView na tab Loja
                        int idProduto = int.Parse(item.SubItems[0].Text);
                        //Pega o nome do produto na coluna de indice 1 da listView na tab Loja
                        string nomeProduto = item.SubItems[1].Text;

                        decimal precoProduto = decimal.Parse(item.SubItems[2].Text);
                        cp.ProdutoId = idProduto;
                        cp.Produto = new Produto { Nome = nomeProduto };
                        cp.PrecoUnitario = precoProduto;
                        cp.QtdTotal = int.Parse(quantidade);
                        cp.PrecoTotal = int.Parse(quantidade) * precoProduto;
                        listaCarrinho.Add(cp);
                        AtualizarListaItens();
                        textBoxInformeQtd.Text = String.Empty;

                    }
                }
                else
                {
                    MessageBox.Show("Selecione um item", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Digite a quantidade e selecione o item", "Aviso");
                return;
            }
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteID = int.Parse(textBoxIdClienteHiddenLoja.Text);
                decimal valorTotalCompra = decimal.Parse(labelPrecoTotal.Text);

                List<ClienteProduto> listaClienteProdutos = new List<ClienteProduto>();
                foreach (var produtoCarrinho in listaCarrinho)
                {

                    ClienteProduto clipro = new ClienteProduto
                    {
                        ProdutoId = produtoCarrinho.ProdutoId,
                        PrecoTotal = produtoCarrinho.PrecoTotal,
                        QtdTotal = produtoCarrinho.QtdTotal,
                        PrecoUnitario = produtoCarrinho.PrecoUnitario
                    };

                    listaClienteProdutos.Add(clipro);
                }
                contexto.Notas.Add(new Nota
                {
                    ClienteId = clienteID,
                    PrecoTotalCompra = valorTotalCompra,
                    clienteProdutos = listaClienteProdutos
                });

                contexto.SaveChanges();
                MessageBox.Show("Pedido finalizado!");
                listaCarrinho.Clear();
                listViewCarrinhoCompraLoja.Items.Clear();
                labelPrecoTotal.Text = String.Empty;
                buttonRemoverNomePesquisaAreaitens.Enabled = false;
                buttonRemoverNomePesquisaAreaitens_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }


        private void buttonPesquisarClienteNotas_Click(object sender, EventArgs e)
        {
            FormBuscarCliente bc = new FormBuscarCliente();
            bc.ShowDialog();

            int idClienteSelecionado = bc.IdCliente;
            string nomeSelecionado = bc.Nome;

            if (String.IsNullOrEmpty(idClienteSelecionado.ToString()) || String.IsNullOrEmpty(nomeSelecionado))
            {
                MessageBox.Show("Voc� n�o selecionou nenhum cliente!", "Aviso");
            }
            else
            {
                textBoxIdHiddenClienteNotas.Text = idClienteSelecionado.ToString();
                textBoxNomeClienteNotas.Text = nomeSelecionado.ToString();
            }
        }

        private void buttonPesquisarNotas_Click(object sender, EventArgs e)
        {
            listViewNotasCliente.Items.Clear();
            int id = int.Parse(textBoxIdHiddenClienteNotas.Text);
            List<Nota> listaNotas = new List<Nota>();
            listaNotas.Clear();
            listaNotas =
                (from Nota n in contexto.Notas select n)
                .Where(c => c.ClienteId == id)
                .ToList<Nota>();

            listViewItensLoja.Items.Clear();

            foreach (var item in listaNotas)
            {
                string[] itens = { item.Id.ToString(), item.Cliente.Nome, item.PrecoTotalCompra.ToString(), item.Data.ToString() };
                listViewNotasCliente.Items.Add(new ListViewItem(itens));
            }
        }

        private void visualizeNota_Click(object sender, EventArgs e)
        {
            if (listViewNotasCliente.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection linha = this.listViewNotasCliente.SelectedItems;

                listViewNotas.Items.Clear();
                foreach (ListViewItem item in linha)
                {
                    int idNota = int.Parse(item.SubItems[0].Text);
                    textBoxIdHiddenNota.Text = idNota.ToString();
                    listaItensDaNota = contexto.ClientesProdutos
                        .Where(cp => cp.NotaId == idNota)
                        .ToList();
                    foreach (var i in listaItensDaNota)
                    {
                        string[] itens = { i.Id.ToString(), i.Produto.Nome, i.QtdTotal.ToString(), i.PrecoUnitario.ToString(), i.PrecoTotal.ToString() };
                        listViewNotas.Items.Add(new ListViewItem(itens));
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um item", "Aviso");
            }
        }

        private void buttonEmitirPDF_Click(object sender, EventArgs e)
        {
            string idNota = textBoxIdHiddenNota.Text;
            string nomeDoArquivo = ($"nota{idNota}.pdf");
            GerarPdf(nomeDoArquivo);
        }

        private void GerarPdf(string arquivo)
        {
            using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);

                //cria a tabela passa as porcentagens e usa toda a largura da pagina
                float[] columnWidths = { 5, 40, 8, 10, 15 };
                Table tabela = new Table(UnitValue.CreatePercentArray(columnWidths))
                    .UseAllAvailableWidth();

                //Titulo da tabela
                var fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                tabela.AddHeaderCell(new Cell(1, 5).Add(new Paragraph("Emiss�o de Nota Nr " + textBoxIdHiddenNota.Text)
                    .SetFont(fonte)
                    .SetFontSize(18)
                    .SetPadding(10)
                    .SetTextAlignment(TextAlignment.CENTER)));

                //Cabe�alho com os titulos das colunas
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Cod")));
                tabela.AddHeaderCell(new Cell()
                    .SetPaddingLeft(5)
                    .Add(new Paragraph("Descri��o do Produto")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Qtd")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetPaddingRight(10)
                    .Add(new Paragraph("Pre�o Un")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetPaddingRight(10)
                    .Add(new Paragraph("Pre�o Total")));
                tabela.SetSkipFirstHeader(false);

                decimal valorTotalCompra = 0;
                foreach (ClienteProduto i in listaItensDaNota)
                {
                    valorTotalCompra += i.PrecoTotal;
                    tabela.AddCell(new Cell()
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(i.Id.ToString())));

                    tabela.AddCell(new Cell()
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(i.Produto.Nome)));

                    tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(i.QtdTotal.ToString())));

                    tabela.AddCell(new Cell()
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetPaddingRight(10)
                        .Add(new Paragraph(i.PrecoUnitario.ToString())));

                    tabela.AddCell(new Cell()
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetPaddingRight(10)
                        .Add(new Paragraph(i.PrecoTotal.ToString())));
                }
                tabela.AddCell(new Cell(1, 5)
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetPaddingRight(10)
                        .Add(new Paragraph("TOTAL: " + valorTotalCompra.ToString())));

                var cellFooter = new Cell(1, 5)
                    .Add(new Paragraph("Cliente: " + textBoxNomeClienteNotas.Text))
                    .SetFont(fonte)
                    .SetFontSize(10)
                    .SetPaddingLeft(10)
                    .SetBorder(Border.NO_BORDER);

                tabela.AddFooterCell(cellFooter);

                document.Add(tabela);
                document.Close();

                pdfDocument.Close();

                MessageBox.Show("Arquivo PDF gerado em " + arquivo);

            }
        }
    }
}