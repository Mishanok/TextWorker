using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace TextWorker
{
    public interface IMainForm
    {
        string[] Lines { get; set; }
        string FilePath { get; }
        string Content { get; set; }
        string Sym { get; }
        string Delet { get; }
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContClearClick;
        event EventHandler<int> ContDelLinesClick;
        event EventHandler ContMakeLinesClick;
        event EventHandler ContDestEngClick;
    }

    public partial class MainForm : Form, IMainForm
    {


        public MainForm()
        {
            InitializeComponent();
            butOpenFile.Click += ButOpenFile_Click;
            butSelect.Click += ButSelect_Click;
            butSaveFile.Click += ButSaveFile_Click;
            butClear.Click += ButClear_Click;
            butDelete.Click += ButDelete_Click;
            butLines.Click += ButLines_Click;
            textDel.TextChanged += TextDel_TextChanged;
            radioButSmall.CheckedChanged += RadioButSmall_CheckedChanged;
            mainTextBox.TextChanged += MainTextBox_TextChanged;
            butBack.Click += ButBack_Click;
            butForward.Click += ButForward_Click;
            butStart.Click += ButStart_Click;
            leftButton.Click += LeftButton_Click;
            rightButton.Click += RightButton_Click;
            butCleaning.Click += ButCleaning_Click;
            butNormFont.Click += ButNormFont_Click;
            butLeftClean.Click += ButLeftClean_Click;
            butRightClean.Click += ButRightClean_Click;
        }

        private void ButRightClean_Click(object sender, EventArgs e)
        {
            rightTextBox.Clear();
        }

        private void ButLeftClean_Click(object sender, EventArgs e)
        {
            leftTextBox.Clear();
        }

        private void ButNormFont_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
            mainTextBox.SelectionBackColor = Color.White;
            mainTextBox.SelectionColor = Color.Black;
        }

        private void ButCleaning_Click(object sender, EventArgs e)
        {
            mainTextBox.Clear();
        }

        string[] wordsgr { get; set; }
        string[] wordsbl { get; set; }

        private void RightButton_Click(object sender, EventArgs e)
        {
            wordsgr = rightTextBox.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            ChangeRigth();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            wordsbl = leftTextBox.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            ChangeLeft();
        }

        Stack<string> Linese = new Stack<string>();
        Stack<string> Forward = new Stack<string>();
#region Done
        private void ButStart_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = StartCont;
        }

        private void ButForward_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Forward.Pop();
            if (Forward.Count == 0) butForward.Visible = false;
        }

        private void ButBack_Click(object sender, EventArgs e)
        {
            Forward.Push(Linese.Peek());
            Linese.Pop();
            if (Linese.Count != 0)
            {
                mainTextBox.Text = Linese.Pop();
            }
            else if(Linese.Count == 0)
            {
                butBack.Visible = false;
                butBack.Enabled = false;

                butStart.Visible = false;
                butStart.Enabled = false;
            }
            butForward.Visible = true;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butBack.Enabled = true;

            butStart.Visible = true;
            butStart.Enabled = true;

            Linese.Push(mainTextBox.Text);
            do
            {
                if (String.IsNullOrEmpty(Linese.Peek())) Linese.Pop();
            } while (String.IsNullOrEmpty(Linese.Peek()));

        }

        private void RadioButSmall_CheckedChanged(object sender, EventArgs e)
        {
            butDelete.TabIndex = 0;
        }

        private void TextDel_TextChanged(object sender, EventArgs e)
        {
            butClear.TabIndex = 0;
        }

        private void ButSelect_Click(object sender, EventArgs e)
        {


            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстові файли|*.txt|Всі файли|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldFilePath.Text = dlg.FileName;
                FileOpenClick?.Invoke(this, EventArgs.Empty);
            }

            StartCont = mainTextBox.Text;

            butBack.Visible = true;
            butBack.Enabled = true;

            butStart.Visible = true;
            butStart.Enabled = true;
            Linese.Push(StartCont);
            do
            {
                if (String.IsNullOrEmpty(Linese.Peek())) Linese.Pop();
            } while (String.IsNullOrEmpty(Linese.Peek()));
        }


        private void ButLines_Click(object sender, EventArgs e)
        {
            ContMakeLinesClick?.Invoke(this, EventArgs.Empty);
            Linese.Push(mainTextBox.Text);
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (radioButSmall.Checked) { ContDelLinesClick?.Invoke(this, 0); }
            else { ContDelLinesClick?.Invoke(this, 1); }
            Linese.Push(mainTextBox.Text);
            do
            {
                if (String.IsNullOrEmpty(Linese.Peek())) Linese.Pop();
            } while (String.IsNullOrEmpty(Linese.Peek()));
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            ContClearClick?.Invoke(this, EventArgs.Empty);
            Linese.Push(mainTextBox.Text);
            do
            {
                if (String.IsNullOrEmpty(Linese.Peek())) Linese.Pop();
            } while (String.IsNullOrEmpty(Linese.Peek()));
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            string caption = "Збереження файлу";
            string message = "Зберегти  текст в даному файлі?";
            if (FilePath == null)
            {
                SaveFileDialog gld = new SaveFileDialog();
                gld.Filter = "Текстові файли|*.txt|Всі файли|*.*";

                if (gld.ShowDialog() == DialogResult.OK)
                {
                    fldFilePath.Text = gld.FileName;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { FileSaveClick?.Invoke(this, EventArgs.Empty); }
                else
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "Текстові файли|*.txt|Всі файли|*.*";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        fldFilePath.Text = dlg.FileName;
                    }
                    FileSaveClick?.Invoke(this, EventArgs.Empty);
                }
            }

        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butBack.Enabled = true;

            butStart.Visible = true;
            butStart.Enabled = true;

            FileOpenClick?.Invoke(this, EventArgs.Empty);

            StartCont = mainTextBox.Text;

            Linese.Push(StartCont);
        }



        public string FilePath
        {
            get { return fldFilePath.Text; }
        }

        public string Content { get { return mainTextBox.Text; } set { mainTextBox.Text = value; } }

        public string Sym { get { return textSym.Text.ToString(); } }

        public string Delet { get { return textDel.Text.ToString(); } }

        public string[] Lines { get { return mainTextBox.Lines; } set { mainTextBox.Lines = value; } }

        public string StartCont { get => startCont; set => startCont = value; }


        private string startCont;


        #region EVENTS
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContClearClick;
        public event EventHandler<int> ContDelLinesClick;
        public event EventHandler ContMakeLinesClick;
        public event EventHandler ContDestEngClick;
        #endregion

        private void checkBoxEng_CheckedChanged(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butBack.Enabled = true;

            butStart.Visible = true;
            butStart.Enabled = true;

            ContDestEngClick?.Invoke(this, EventArgs.Empty);

            Linese.Push(mainTextBox.Text);
        }
#endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Зробити методи зміни кольору асинхронними");

            Linese.Push(mainTextBox.Text);
            do
            {
                if (String.IsNullOrEmpty(Linese.Peek())) Linese.Pop();
            } while (String.IsNullOrEmpty(Linese.Peek()));
        }
#region FontColor      
        private void ChangeLeft()
        {
            string[] S = mainTextBox.Text.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in wordsbl)
            {
                foreach (string s in S)
                {
                    if (s == word)
                    {
                        int at = 0;
                        int start = mainTextBox.Text.Length - 1;
                        while ((start > -1) && (at > -1))
                        {
                            at = mainTextBox.Text.LastIndexOf(s, start);
                            if (at > -1)
                            {
                                mainTextBox.Select(at, s.Length);
                                mainTextBox.SelectionColor = Color.Blue;
                                mainTextBox.SelectionBackColor = Color.HotPink;
                                start = at - 1;
                            }
                        }
                    }
                }
            }
        }

        private void ChangeRigth()
        {
            string[] S = mainTextBox.Text.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in wordsgr)
            {
                foreach (string s in S)
                {
                    if (s == word)
                    {
                        int at = 0;
                        int start = mainTextBox.Text.Length - 1;
                        while ((start > -1) && (at > -1))
                        {
                            at = mainTextBox.Text.LastIndexOf(s, start);
                            if (at > -1)
                            {
                                mainTextBox.Select(at, s.Length);
                                mainTextBox.SelectionColor = Color.Green;
                                mainTextBox.SelectionBackColor = Color.Black;
                                start = at - 1;
                            }
                        }
                    }
                }
            }
        }
#endregion
    }
}
