using PDV.Classes;
using PDV.Dao;
using PDV.Enums;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace PDV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AbrirNotificacao abrirNotificacao = new AbrirNotificacao();
        private List<Produto> _produtos = new List<Produto>();
        private List<Fornecedor> _fornecedores = new List<Fornecedor>();
        private ProdutoDao produtoDao = new ProdutoDao();
        private FornecedorDao fornecedorDao = new FornecedorDao();
        private string? fornecedorSelecionado;

        public MainWindow()
        {
            InitializeComponent();
            EsconderConteudo();
        }

        private void CarregarComboBoxFornecedores()
        {
            using (SqlConnection conexao = ConexaoBancoDeDados.AbrirConexao())
            {
                _fornecedores = fornecedorDao.ConsultarFornecedores(conexao);

                _fornecedores.Insert(0, new Fornecedor { IdFornecedor = 0, NomeFornecedor = "Selecione um fornecedor" });

                cmbFornecedor.ItemsSource = _fornecedores;

                cmbFornecedor.DisplayMemberPath = "NomeFornecedor";
                cmbFornecedor.SelectedValuePath = "IdFornecedor";

                cmbFornecedor.SelectedIndex = 0;
            }
        }

        private void CarregarProdutosNaTabela()
        {
            using (SqlConnection conexao = ConexaoBancoDeDados.AbrirConexao())
            {
                _produtos = produtoDao.ConsultarProdutos(conexao);
            }

            dgProdutos.ItemsSource = _produtos;
        }

        private Produto CriarNovoProduto()
        {
            Produto novoProduto = new Produto()
            {
                NomeProduto = txtNomeProduto.Text,
                Preco = Convert.ToDouble(txtPrecoProduto.Text),
                Embalagem = txtEmbalagemProduto.Text,
                Estoque = Convert.ToInt32(txtEstoqueProduto.Text),
                Fornecedor = fornecedorSelecionado,
                DataAdicionado = DateTime.Now,
            };

            return novoProduto;
        }

        private void CadastrarProduto(Produto novoProduto)
        {
            using (SqlConnection conexao = ConexaoBancoDeDados.AbrirConexao())
            {
                produtoDao.AdicionarNovoProduto(conexao, novoProduto);
            }

            abrirNotificacao.ExibirNotificacao("Produto adicionado com sucesso", "Cadastrar Produto", IconesNotificacaoEnum.Sucesso, BotoesNotificacaoEnum.Ok);
        }

        private void LimparCamposDoCadastroDeProdutos()
        {
            txtNomeProduto.Text = "";
            txtPrecoProduto.Text = "";
            txtEstoqueProduto.Text = "";
            txtEmbalagemProduto.Text = "";
            cmbFornecedor.SelectedIndex = 0;
        }

        private bool VerificarCamposDoCadastroDeProdutos()
        {
            if(txtNomeProduto.Text == "" || txtPrecoProduto.Text == "" || txtEstoqueProduto.Text == "" || txtEmbalagemProduto.Text == "" || cmbFornecedor.SelectedIndex == 0)
            {
                abrirNotificacao.ExibirNotificacao("Preencha todos os campos para cadastrar o produto", "Cadastrar Produto", IconesNotificacaoEnum.Aviso, BotoesNotificacaoEnum.Ok);

                return false;
            }

            return true;
        }

        private void EsconderConteudo()
        {
            dgProdutos.Visibility = Visibility.Collapsed;
            txtDgProdutos.Visibility = Visibility.Collapsed;
        }

        private void btnVenda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            CarregarProdutosNaTabela();
            EsconderConteudo();

            dgProdutos.Visibility = Visibility.Visible;
            txtDgProdutos.Visibility = Visibility.Visible;
        }

        private void btnCadastros_Click(object sender, RoutedEventArgs e)
        {
            EsconderConteudo();
            CarregarComboBoxFornecedores();
        }

        private void btnFerramentas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSuporte_Click(object sender, RoutedEventArgs e)
        {
            abrirNotificacao.ExibirNotificacao("E-mail: henry@inlive.com.br \nTelefone: +55 (14) 98141-3203", "Contato Para Suporte", IconesNotificacaoEnum.Suporte, BotoesNotificacaoEnum.Fechar);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void cmbFornecedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFornecedor.SelectedItem != null)
            {
                Fornecedor? _fornecedorSelecionado = cmbFornecedor.SelectedItem as Fornecedor;
                fornecedorSelecionado = _fornecedorSelecionado.NomeFornecedor.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarCamposDoCadastroDeProdutos())
            {
                Produto novoProduto = CriarNovoProduto();

                CadastrarProduto(novoProduto);

                LimparCamposDoCadastroDeProdutos();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            LimparCamposDoCadastroDeProdutos();
            EsconderConteudo();
        }
    }
}