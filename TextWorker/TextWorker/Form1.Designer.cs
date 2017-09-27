namespace TextWorker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftTextBox = new System.Windows.Forms.TextBox();
            this.rightTextBox = new System.Windows.Forms.TextBox();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.butSaveFile = new System.Windows.Forms.Button();
            this.checkBoxEng = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSym = new System.Windows.Forms.TextBox();
            this.butLines = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textDel = new System.Windows.Forms.TextBox();
            this.butClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButSmall = new System.Windows.Forms.RadioButton();
            this.radioButBig = new System.Windows.Forms.RadioButton();
            this.butDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fldFilePath = new System.Windows.Forms.TextBox();
            this.butSelect = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.butForward = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.butCleaning = new System.Windows.Forms.Button();
            this.butNormFont = new System.Windows.Forms.Button();
            this.butLeftClean = new System.Windows.Forms.Button();
            this.butRightClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftTextBox
            // 
            this.leftTextBox.Location = new System.Drawing.Point(13, 28);
            this.leftTextBox.Multiline = true;
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.leftTextBox.Size = new System.Drawing.Size(231, 209);
            this.leftTextBox.TabIndex = 1;
            // 
            // rightTextBox
            // 
            this.rightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightTextBox.Location = new System.Drawing.Point(760, 28);
            this.rightTextBox.Multiline = true;
            this.rightTextBox.Name = "rightTextBox";
            this.rightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rightTextBox.Size = new System.Drawing.Size(231, 209);
            this.rightTextBox.TabIndex = 2;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butOpenFile.Location = new System.Drawing.Point(11, 520);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(75, 23);
            this.butOpenFile.TabIndex = 3;
            this.butOpenFile.Text = "Відкрити";
            this.butOpenFile.UseVisualStyleBackColor = true;
            // 
            // butSaveFile
            // 
            this.butSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSaveFile.Location = new System.Drawing.Point(11, 547);
            this.butSaveFile.Name = "butSaveFile";
            this.butSaveFile.Size = new System.Drawing.Size(75, 23);
            this.butSaveFile.TabIndex = 4;
            this.butSaveFile.Text = "Зберегти";
            this.butSaveFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxEng
            // 
            this.checkBoxEng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEng.AutoSize = true;
            this.checkBoxEng.Location = new System.Drawing.Point(761, 298);
            this.checkBoxEng.Name = "checkBoxEng";
            this.checkBoxEng.Size = new System.Drawing.Size(222, 17);
            this.checkBoxEng.TabIndex = 5;
            this.checkBoxEng.Text = "Видалити літери латинського алфавіту";
            this.checkBoxEng.UseVisualStyleBackColor = true;
            this.checkBoxEng.CheckedChanged += new System.EventHandler(this.checkBoxEng_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Розділити текст на рядки за символом";
            // 
            // textSym
            // 
            this.textSym.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textSym.Location = new System.Drawing.Point(760, 355);
            this.textSym.Name = "textSym";
            this.textSym.Size = new System.Drawing.Size(222, 20);
            this.textSym.TabIndex = 7;
            // 
            // butLines
            // 
            this.butLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butLines.Location = new System.Drawing.Point(760, 381);
            this.butLines.Name = "butLines";
            this.butLines.Size = new System.Drawing.Size(75, 23);
            this.butLines.TabIndex = 8;
            this.butLines.Text = "Розділити";
            this.butLines.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Видалити непотрібнй текст з таким вмістом";
            // 
            // textDel
            // 
            this.textDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textDel.Location = new System.Drawing.Point(761, 423);
            this.textDel.Name = "textDel";
            this.textDel.Size = new System.Drawing.Size(223, 20);
            this.textDel.TabIndex = 10;
            // 
            // butClear
            // 
            this.butClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClear.Location = new System.Drawing.Point(760, 449);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 11;
            this.butClear.Text = "Видалити";
            this.butClear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Видалити речення";
            // 
            // radioButSmall
            // 
            this.radioButSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButSmall.AutoSize = true;
            this.radioButSmall.Location = new System.Drawing.Point(760, 491);
            this.radioButSmall.Name = "radioButSmall";
            this.radioButSmall.Size = new System.Drawing.Size(47, 17);
            this.radioButSmall.TabIndex = 13;
            this.radioButSmall.TabStop = true;
            this.radioButSmall.Text = "малі";
            this.radioButSmall.UseVisualStyleBackColor = true;
            // 
            // radioButBig
            // 
            this.radioButBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButBig.AutoSize = true;
            this.radioButBig.Location = new System.Drawing.Point(880, 491);
            this.radioButBig.Name = "radioButBig";
            this.radioButBig.Size = new System.Drawing.Size(57, 17);
            this.radioButBig.TabIndex = 14;
            this.radioButBig.TabStop = true;
            this.radioButBig.Text = "великі";
            this.radioButBig.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butDelete.Location = new System.Drawing.Point(760, 515);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 15;
            this.butDelete.Text = "Видалити";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Слова синім кольором";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(857, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Слова зеленім кольором";
            // 
            // fldFilePath
            // 
            this.fldFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fldFilePath.Location = new System.Drawing.Point(11, 464);
            this.fldFilePath.Name = "fldFilePath";
            this.fldFilePath.Size = new System.Drawing.Size(229, 20);
            this.fldFilePath.TabIndex = 18;
            // 
            // butSelect
            // 
            this.butSelect.AllowDrop = true;
            this.butSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSelect.Location = new System.Drawing.Point(11, 490);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(75, 23);
            this.butSelect.TabIndex = 0;
            this.butSelect.Text = "Вибрати";
            this.butSelect.UseVisualStyleBackColor = true;
            // 
            // butBack
            // 
            this.butBack.Enabled = false;
            this.butBack.Location = new System.Drawing.Point(250, 2);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 19;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Visible = false;
            // 
            // butStart
            // 
            this.butStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butStart.Enabled = false;
            this.butStart.Location = new System.Drawing.Point(679, 2);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 20;
            this.butStart.Text = "Початковий текст";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Visible = false;
            // 
            // butForward
            // 
            this.butForward.Location = new System.Drawing.Point(332, 2);
            this.butForward.Name = "butForward";
            this.butForward.Size = new System.Drawing.Size(75, 23);
            this.butForward.TabIndex = 21;
            this.butForward.Text = "Вперед";
            this.butForward.UseVisualStyleBackColor = true;
            this.butForward.Visible = false;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(11, 243);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 22;
            this.leftButton.Text = "Виділити";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.Location = new System.Drawing.Point(916, 243);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 23;
            this.rightButton.Text = "Виділити";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Location = new System.Drawing.Point(250, 28);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(504, 557);
            this.mainTextBox.TabIndex = 24;
            this.mainTextBox.Text = "";
            // 
            // butCleaning
            // 
            this.butCleaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCleaning.Location = new System.Drawing.Point(581, 2);
            this.butCleaning.Name = "butCleaning";
            this.butCleaning.Size = new System.Drawing.Size(75, 23);
            this.butCleaning.TabIndex = 25;
            this.butCleaning.Text = "Очистити";
            this.butCleaning.UseVisualStyleBackColor = true;
            // 
            // butNormFont
            // 
            this.butNormFont.Location = new System.Drawing.Point(15, 339);
            this.butNormFont.Name = "butNormFont";
            this.butNormFont.Size = new System.Drawing.Size(229, 23);
            this.butNormFont.TabIndex = 26;
            this.butNormFont.Text = "Стандартний текст";
            this.butNormFont.UseVisualStyleBackColor = true;
            // 
            // butLeftClean
            // 
            this.butLeftClean.Location = new System.Drawing.Point(169, 243);
            this.butLeftClean.Name = "butLeftClean";
            this.butLeftClean.Size = new System.Drawing.Size(75, 23);
            this.butLeftClean.TabIndex = 27;
            this.butLeftClean.Text = "Очистити";
            this.butLeftClean.UseVisualStyleBackColor = true;
            // 
            // butRightClean
            // 
            this.butRightClean.Location = new System.Drawing.Point(760, 243);
            this.butRightClean.Name = "butRightClean";
            this.butRightClean.Size = new System.Drawing.Size(75, 23);
            this.butRightClean.TabIndex = 28;
            this.butRightClean.Text = "Очистити";
            this.butRightClean.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.butRightClean);
            this.Controls.Add(this.butLeftClean);
            this.Controls.Add(this.butNormFont);
            this.Controls.Add(this.butCleaning);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.butForward);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.fldFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.radioButBig);
            this.Controls.Add(this.radioButSmall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.textDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butLines);
            this.Controls.Add(this.textSym);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxEng);
            this.Controls.Add(this.butSaveFile);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.rightTextBox);
            this.Controls.Add(this.leftTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MainForm";
            this.Text = "TextWorker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.TextBox rightTextBox;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Button butSaveFile;
        private System.Windows.Forms.CheckBox checkBoxEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSym;
        private System.Windows.Forms.Button butLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDel;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButSmall;
        private System.Windows.Forms.RadioButton radioButBig;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fldFilePath;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butForward;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.Button butCleaning;
        private System.Windows.Forms.Button butNormFont;
        private System.Windows.Forms.Button butLeftClean;
        private System.Windows.Forms.Button butRightClean;
    }
}

