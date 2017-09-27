using System.Windows.Forms;

namespace TextWorker
{
    public interface IMEssageService
    {
        void ShowMessage(string message);
        void ShowExlamation(string message);
        void ShowError(string message);
    }

    class MessegeService : IMEssageService
    {
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowExlamation(string message)
        {
            MessageBox.Show(message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
