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
using System.ComponentModel;
using System.Threading;

namespace PDV
{
    /// <summary>
    /// Interaction logic for TelaSplash.xaml
    /// </summary>
    public partial class TelaSplash : Window
    {

        public TelaSplash()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                (sender as BackgroundWorker).ReportProgress(i);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                Thread.Sleep(100);
            }
        }

        void worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            barraDeProgresso.Value = e.ProgressPercentage;

            if (barraDeProgresso.Value == 0)
            {
                textoBarradeProgresso.Text = "Carregando as configurações";
            }

            if (barraDeProgresso.Value == 25)
            {
                textoBarradeProgresso.Text = "Testando a comunicação com os periféricos";
            }

            if (barraDeProgresso.Value == 50)
            {
                textoBarradeProgresso.Text = "Sincronizando informações";
            }

            if (barraDeProgresso.Value == 75)
            {
                textoBarradeProgresso.Text = "Configurando workspace do usuário";
            }

            if (barraDeProgresso.Value == 100)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }
    }
}
