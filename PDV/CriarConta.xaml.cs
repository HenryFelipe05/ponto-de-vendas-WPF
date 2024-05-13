using MaterialDesignThemes.Wpf;
using PDV.Classes;
using PDV.Dao;
using PDV.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PDV
{
    /// <summary>
    /// Interaction logic for CriarConta.xaml
    /// </summary>
    public partial class CriarConta : Window
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        AbrirNotificacao abrirNotificacao = new AbrirNotificacao();

        public CriarConta()
        {
            InitializeComponent();
        }

        public void AdicionarNovoUsuario()
        {
            try
            {
                using (SqlConnection conexao = ConexaoBancoDeDados.AbrirConexao())
                {
                    if (usuarioDao.VerificarSeNomeDeUsuarioExiste(conexao, txtNomeDeUsuario.Text))
                    {
                        abrirNotificacao.ExibirNotificacao("Este nome de usuário já existe, escolha outro nome de usuário.", "Erro ao adicionar novo usuário", IconesNotificacaoEnum.Erro, BotoesNotificacaoEnum.Ok);
                        return;
                    }

                    if (usuarioDao.VerificarSeEmailExiste(conexao, txtEmail.Text))
                    {
                        abrirNotificacao.ExibirNotificacao("Este E-mail já existe, escolha outro E-mail.", "Erro ao adicionar novo usuário", IconesNotificacaoEnum.Erro, BotoesNotificacaoEnum.Ok);
                        return;
                    }

                    Usuario novoUsuario = new Usuario()
                    {
                        NomeUsuario = txtNomeDeUsuario.Text,
                        Email = txtEmail.Text,
                        Senha = txtSenha.Password.ToString()
                    };

                    usuarioDao.AdicionarNovoUsuario(conexao, novoUsuario);
                }
            }
            catch (Exception ex)
            {
                abrirNotificacao.ExibirNotificacao($"Erro: {ex}", "Erro ao adicionar novo usuário", IconesNotificacaoEnum.Erro, BotoesNotificacaoEnum.Ok);
            }
        }

        private bool VerificarSeCamposEstaoPreenchidos()
        {
            if (txtNomeDeUsuario.Text == "" || txtNomeDeUsuario.Text == null || txtEmail.Text == "" || txtEmail.Text == null ||  txtSenha.Password == "" || txtSenha.Password == null)
            {
                abrirNotificacao.ExibirNotificacao("Preencha todos os campos para criar a conta.", "Aviso", IconesNotificacaoEnum.Erro, BotoesNotificacaoEnum.Ok);

                return false;
            }

            return true;
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnCriarConta_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarSeCamposEstaoPreenchidos())
            {
                AdicionarNovoUsuario();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}
