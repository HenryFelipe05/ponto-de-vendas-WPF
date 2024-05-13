using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
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
                Thread.Sleep(30);
            }
        }

        void worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            barraDeProgresso.Value = e.ProgressPercentage;

            if (barraDeProgresso.Value == 100)
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }
    }
}
