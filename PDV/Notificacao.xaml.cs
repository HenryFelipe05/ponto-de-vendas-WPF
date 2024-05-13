using PDV.Enums;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Notificacao.xaml
    /// </summary>
    public partial class Notificacao : Window
    {
        public Notificacao(string textoDaNotificacao, string tituloDaNotificacao, IconesNotificacaoEnum icone, BotoesNotificacaoEnum tipoBotao)
        {
            InitializeComponent();

            PreencherTelaNotificacao(textoDaNotificacao, tituloDaNotificacao, icone, tipoBotao);
        }

        private void PreencherTelaNotificacao(string textoDaNotificacao, string tituloDaNotificacao, IconesNotificacaoEnum icone, BotoesNotificacaoEnum tipoBotao)
        {
            VerificarTipoBotaoSelecionado(tipoBotao);

            txtNotificacao.Text = textoDaNotificacao;
            tituloNotificacao.Text = tituloDaNotificacao;

#pragma warning disable CS8604 // Possible null reference argument.
            iconeNotificacao.Source = new BitmapImage(new Uri(CaminhoParaIcone(icone)));
#pragma warning restore CS8604 // Possible null reference argument.
        }

        private void VerificarTipoBotaoSelecionado(BotoesNotificacaoEnum tipoBotao)
        {
            if (tipoBotao == BotoesNotificacaoEnum.Ok)
            {
                btnOk.Visibility = Visibility.Visible;
            }
            else if(tipoBotao == BotoesNotificacaoEnum.SimOuNao)
            {
                btnSim.Visibility = Visibility.Visible;
                btnNao.Visibility = Visibility.Visible;
            }
            else
            {
                btnFechar.Visibility = Visibility.Visible;
            }
        }

        public static string? CaminhoParaIcone(IconesNotificacaoEnum icone)
        {
            switch (icone)
            {
                case IconesNotificacaoEnum.Sucesso:
                    {
                        return "C:\\OneDrive\\Área de Trabalho\\Balta\\PDV\\PDV\\Recursos\\checked.png";
                    }
                case IconesNotificacaoEnum.Aviso:
                    {
                        return "C:\\OneDrive\\Área de Trabalho\\Balta\\PDV\\PDV\\Recursos\\exclamation-mark.png";
                    }
                case IconesNotificacaoEnum.Erro:
                    {
                        return "C:\\OneDrive\\Área de Trabalho\\Balta\\PDV\\PDV\\Recursos\\cancel.png";
                    }
                case IconesNotificacaoEnum.Suporte:
                    {
                        return "C:\\OneDrive\\Área de Trabalho\\Balta\\PDV\\PDV\\Recursos\\support_agent_FILL0_wght400_GRAD0_opsz24.png";
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNao_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
