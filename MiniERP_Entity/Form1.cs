using Castle.Core.Internal;
using MiniERP_Entity.DataModels;

namespace MiniERP_Entity
{
    public partial class Form1 : Form
    {
        Contexto contexto = new Contexto();
        List<ClienteProduto> listaCarrinho = new List<ClienteProduto>();

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

        //CÓDIGO RELACIONADO A TAB CONTROL "GERENCIAR CLIENTE"
        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                //verifica se não existe nenhum campo null
                if (String.IsNullOrEmpty(textBoxNomeCliente.Text) || String.IsNullOrEmpty(textBoxCpfCliente.Text))
                {
                    MessageBox.Show("Não pode haver campo vazio, por favor preencha-os", "Aviso");
                }
                else
                {
                    //verifica se o cpf já esta cadastrado
                    if (VerificaCpfCliente(textBoxCpfCliente.Text))
                    {
                        MessageBox.Show("Esse CPF já está cadastrado!", "Alerta");
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
            // Verifica se há algum cliente com o mesmo CPF no contexto
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

        //Evento KeyUp da busca pelo nome do cliente - toda vez que o evento for acionado esse metodo é executado
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

                // Adiciona os clientes à ListView
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
        //FINAL DO CÓDIGO RELACIONADO A TAB CONTROL "GERENCIAR CLIENTE"

        //INICIO DO CÓDIGO RELACIONADO A TAB CONTROL "GERENCIAR FORNECEDORES"
        private void buttonCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();
                if (String.IsNullOrEmpty(textBoxRazaoSocialFornecedor.Text) || String.IsNullOrEmpty(maskedTextBoxCnpjFornecedor.Text))
                {
                    MessageBox.Show("Não pode haver campo vazio, por favor preencha-os", "Aviso");
                }
                else
                {
                    if (VerificaCnpjFornecedor(maskedTextBoxCnpjFornecedor.Text))
                    {
                        MessageBox.Show("Esse CPF já está cadastrado!", "Alerta");
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
        //FIM DO CÓDIGO RELACIONADO A TAB CONTROL "GERENCIAR FORNECEDORES"
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
                    MessageBox.Show("Não pode haver campo vazio, por favor preencha-os", "Aviso");
                }
                else
                {
                    p.Nome = textBoxDescricaoProduto.Text;
                    p.Preco = decimal.Parse(textBoxPrecoProduto.Text);
                    p.QtdEstoque = int.Parse(textBoxPrecoProduto.Text);
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
                MessageBox.Show("Você não selecionou nenhum cliente!", "Aviso");
            }
            else
            {
                textBoxIdClienteHiddenLoja.Text = idClienteSelecionado.ToString();
                textBoxPesquisaClienteLoja.Text = nomeSelecionado.ToString();
                listViewItensLoja.Enabled = true;
                buttonSelecionarItemLoja.Enabled = true;
                buttonPesquisaClienteLoja.Enabled = false;
                buttonRemoverNomePesquisaAreaitens.Visible = true;
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
                    //pega o id do campo Hidden na tab Loja
                    int idCliente = int.Parse(textBoxIdClienteHiddenLoja.Text);
                    //pega o Id do produto na ListView na tab Loja
                    int idProduto = int.Parse(item.SubItems[0].Text);
                    //Pega o nome do produto na coluna de indice 1 da listView na tab Loja
                    string nomeProduto = item.SubItems[1].Text;
                    decimal precoProduto = decimal.Parse(item.SubItems[2].Text);
                    cp.ClienteId = idCliente;
                    cp.ProdutoId = idProduto;
                    cp.Produto = new Produto { Nome = nomeProduto, Preco = precoProduto };
                    cp.QtdTotal = 1;
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
            decimal valorTotal = 0;
            //List<ClienteProduto> listaCarrinhoBanco = new List<ClienteProduto>();
            listViewCarrinhoCompraLoja.Items.Clear();
            //listaCarrinhoBanco = (from ClienteProduto cp in contexto.ClientesProdutos select cp)
            //    .ToList();

            //listaCarrinhoBanco.Sort((a, b) => a.Produto.Nome.CompareTo(b.Produto.Nome));


            foreach (var i in listaCarrinho)
            {
                int index = listaCarrinho.IndexOf(i);
                string[] itens = { index.ToString(), i.Produto.Nome, i.Produto.Preco.ToString(), i.QtdTotal.ToString() };
                listViewCarrinhoCompraLoja.Items.Add(new ListViewItem(itens));

                valorTotal += i.Produto.Preco * i.QtdTotal;

                labelPrecoTotal.Text = valorTotal.ToString();
            }
        }

        private void buttonRemoverNomePesquisaAreaitens_Click(object sender, EventArgs e)
        {
            if (listaCarrinho.Count > 0)
            {
                MessageBox.Show("Há itens no carrinho, cancele a compra primeiro!", "Aviso");
                return;
            }
            else
            {
                textBoxIdClienteHiddenLoja.Text = String.Empty;
                textBoxPesquisaClienteLoja.Text = String.Empty;
                listViewItensLoja.Enabled = false;
                buttonSelecionarItemLoja.Enabled = false;
                buttonPesquisaClienteLoja.Enabled = true;
                buttonRemoverNomePesquisaAreaitens.Visible = true;
                buttonAddQtdItemLoja.Enabled = false;
            }
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Você tem certeza que deseja cancelar a compra?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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

        private void buttonRemoverItem_Click(object sender, EventArgs e)
        {
            if (listViewItensLoja.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection linha = this.listViewItensLoja.SelectedItems;

                foreach (var i in linha)
                {
                    //listaCarrinho.RemoveAt();
                }
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
                        //pega o id do campo Hidden na tab Loja
                        int idCliente = int.Parse(textBoxIdClienteHiddenLoja.Text);
                        //pega o Id do produto na ListView na tab Loja
                        int idProduto = int.Parse(item.SubItems[0].Text);
                        //Pega o nome do produto na coluna de indice 1 da listView na tab Loja
                        string nomeProduto = item.SubItems[1].Text;

                        decimal precoProduto = decimal.Parse(item.SubItems[2].Text);
                        cp.ClienteId = idCliente;
                        cp.ProdutoId = idProduto;
                        cp.Produto = new Produto { Nome = nomeProduto, Preco = precoProduto };
                        cp.QtdTotal = int.Parse(quantidade);
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
                ClienteProduto clipro = new ClienteProduto();
                foreach (var i in listaCarrinho)
                {
                    contexto.ClientesProdutos.Add(new() { ClienteId = i.ClienteId, ProdutoId = i.ProdutoId, PrecoTotal = decimal.Parse(labelPrecoTotal.Text), QtdTotal = i.QtdTotal });
                }
                contexto.SaveChanges();
                MessageBox.Show("Pedido finalizado!");
                listViewCarrinhoCompraLoja.Items.Clear();
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
                MessageBox.Show("Você não selecionou nenhum cliente!", "Aviso");
            }
            else
            {
                textBoxIdHiddenClienteNotas.Text = idClienteSelecionado.ToString();
                textBoxNomeClienteNotas.Text = nomeSelecionado.ToString();
            }
        }

        private void buttonPesquisarNotas_Click(object sender, EventArgs e)
        {
            AtualizarListaNotas();
        }

        private void AtualizarListaNotas()
        {
            int id = int.Parse(textBoxIdHiddenClienteNotas.Text);
            List<ClienteProduto> listaNotas = new List<ClienteProduto>();

            listaNotas =
                (from ClienteProduto cp in contexto.ClientesProdutos select cp)
                    .Where(cp => cp.ClienteId == id)
                    .ToList<ClienteProduto>();

            //listaNotas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            listViewItensLoja.Items.Clear();

            foreach (var item in listaNotas)
            {
                string[] itens = { item.Id.ToString(), item.Produto.Nome, item.QtdTotal.ToString(), item.Produto.Preco.ToString(), item.PrecoTotal.ToString() };
                listViewNotas.Items.Add(new ListViewItem(itens));
            }
        }
    }
}