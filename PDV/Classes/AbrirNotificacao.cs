using PDV.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PDV.Classes
{
    public class AbrirNotificacao
    {
        private readonly string somAlerta = "C:\\OneDrive\\Área de Trabalho\\Balta\\PDV\\PDV\\Recursos\\error-warning-login-denied-132113.wav";

        public void ExibirNotificacao(string textoDaNotificacao, string tituloDaNotificacao, IconesNotificacaoEnum icone, BotoesNotificacaoEnum tipoBotao)
        {
            Notificacao notificacao = new Notificacao(textoDaNotificacao, tituloDaNotificacao, icone, tipoBotao);
            notificacao.Show();
            ReproduzirSomNotificacao();
        }

        private void ReproduzirSomNotificacao()
        {
            try
            {
                if (File.Exists(somAlerta))
                {
                    MediaPlayer mediaPlayer = new MediaPlayer();

                    mediaPlayer.Volume = 0.5;

                    mediaPlayer.Open(new Uri(somAlerta));
                    mediaPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao reproduzir som: " + ex.Message);
            }
        }
    }
}
