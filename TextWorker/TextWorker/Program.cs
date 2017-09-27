using System;
using TextWorker.BL;
using System.Windows.Forms;

namespace TextWorker
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessegeService service = new MessegeService();
            FileManager manager = new FileManager();
            Changer changer = new Changer(form.Content, form.Lines);              

            MainPresenter presenter = new MainPresenter(form, manager, service, changer); 

            Application.Run(form);
        }
    }
}
