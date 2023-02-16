using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    internal static class Program
    {
        // name é o identificador único da aplicação
        static Mutex mutex = new Mutex(true, name: "d4709732-f5aa-404f-ba0e-a0a8a4201ff6");

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FrmLogin());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show("Este programa já está sendo executado!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
