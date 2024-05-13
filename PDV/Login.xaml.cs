using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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
using MaterialDesignThemes.Wpf;
using PDV.Classes;
using PDV.Dao;
using PDV.Enums;

namespace PDV
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        AbrirNotificacao abrirNotificacao = new AbrirNotificacao();

        public Login()
        {
            InitializeComponent();
        }

        private bool VerificarSeUsuarioExiste(string nomeUsuario, string senha)
        {
            try
            {
                using (SqlConnection conexao = ConexaoBancoDeDados.AbrirConexao())
                {
                    var usuarioExiste = usuarioDao.ConsultarUsuario(conexao, nomeUsuario, senha);

                    if (usuarioExiste != null)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                abrirNotificacao.ExibirNotificacao($"Erro ao verificar usuário: {ex}", "Erro", IconesNotificacaoEnum.Erro, BotoesNotificacaoEnum.Ok);

                return false;
            }
        }

        private void RealizarLogin()
        {
            try
            {
                if (VerificarSeCamposEstaoPreenchidos())
                {
                    if (VerificarSeUsuarioExiste(txtNomeDeUsuario.Text, txtSenha.Password.ToString()))
                    {
                        TelaSplash splash = new TelaSplash();
                        this.Close();
                        splash.Show();
                    }
                    else
                    {
                        abrirNotificacao.ExibirNotificacao("Nome de usuário ou senha incorretos.", "Falha no login", IconesNotificacaoEnum.Aviso, BotoesNotificacaoEnum.Ok);
                    }
                }
            }
            catch (Exception ex)
            {
                abrirNotificacao.ExibirNotificacao($"Erro no login: {ex}", "Falha no login", IconesNotificacaoEnum.Erro, BotoesNotificacaoEnum.Ok);
            }
        }

        private bool VerificarSeCamposEstaoPreenchidos()
        {
            if (txtNomeDeUsuario.Text == "" || txtNomeDeUsuario.Text == null || txtSenha.Password == "" || txtSenha.Password == null)
            {
                abrirNotificacao.ExibirNotificacao("Preencha todos os campos para realizar o login.", "Aviso", IconesNotificacaoEnum.Aviso, BotoesNotificacaoEnum.Ok);

                return false;
            }

            return true;
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            RealizarLogin();
        }

        private void btnCriarConta_Click(object sender, RoutedEventArgs e)
        {
            CriarConta criarConta = new CriarConta();
            this.Close();
            criarConta.Show();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}
