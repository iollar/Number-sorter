namespace WindowsFormsAppMySort
{
    partial class FormMain
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bwGenerate = new System.ComponentModel.BackgroundWorker();
            this.bwOutput = new System.ComponentModel.BackgroundWorker();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.panBtns = new System.Windows.Forms.Panel();
            this.panIn = new System.Windows.Forms.Panel();
            this.panOut = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.labTacts = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.panBtns.SuspendLayout();
            this.panIn.SuspendLayout();
            this.panOut.SuspendLayout();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtInput.Location = new System.Drawing.Point(6, 34);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(600, 69);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(6, 34);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(600, 69);
            this.txtOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Последовательность чисел для сортировки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отсортированная последовательность:";
            // 
            // bwGenerate
            // 
            this.bwGenerate.WorkerSupportsCancellation = true;
            this.bwGenerate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGenerate_DoWork);
            this.bwGenerate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGenerate_RunWorkerCompleted);
            // 
            // bwOutput
            // 
            this.bwOutput.WorkerSupportsCancellation = true;
            this.bwOutput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwOutput_DoWork);
            this.bwOutput.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwOutput_RunWorkerCompleted);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClean.Location = new System.Drawing.Point(363, 93);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(211, 79);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Очистить";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerate.AutoEllipsis = true;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGenerate.Location = new System.Drawing.Point(0, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(574, 79);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Сгенерировать случайно";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSort.Location = new System.Drawing.Point(0, 93);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(339, 79);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Отсортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // panBtns
            // 
            this.panBtns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panBtns.Controls.Add(this.btnGenerate);
            this.panBtns.Controls.Add(this.btnClean);
            this.panBtns.Controls.Add(this.btnSort);
            this.panBtns.Location = new System.Drawing.Point(33, 285);
            this.panBtns.Name = "panBtns";
            this.panBtns.Size = new System.Drawing.Size(574, 172);
            this.panBtns.TabIndex = 2;
            // 
            // panIn
            // 
            this.panIn.BackColor = System.Drawing.SystemColors.Control;
            this.panIn.Controls.Add(this.label1);
            this.panIn.Controls.Add(this.txtInput);
            this.panIn.Location = new System.Drawing.Point(14, 42);
            this.panIn.Name = "panIn";
            this.panIn.Size = new System.Drawing.Size(614, 110);
            this.panIn.TabIndex = 0;
            // 
            // panOut
            // 
            this.panOut.Controls.Add(this.label2);
            this.panOut.Controls.Add(this.txtOutput);
            this.panOut.Location = new System.Drawing.Point(14, 158);
            this.panOut.Name = "panOut";
            this.panOut.Size = new System.Drawing.Size(614, 110);
            this.panOut.TabIndex = 1;
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.Controls.Add(this.labTacts);
            this.panMain.Controls.Add(this.labTime);
            this.panMain.Controls.Add(this.panOut);
            this.panMain.Controls.Add(this.panBtns);
            this.panMain.Controls.Add(this.panIn);
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(644, 476);
            this.panMain.TabIndex = 19;
            // 
            // labTacts
            // 
            this.labTacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTacts.AutoSize = true;
            this.labTacts.Location = new System.Drawing.Point(187, 9);
            this.labTacts.Name = "labTacts";
            this.labTacts.Size = new System.Drawing.Size(122, 20);
            this.labTacts.TabIndex = 14;
            this.labTacts.Text = "Кол-во тактов:";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(430, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(122, 20);
            this.labTime.TabIndex = 13;
            this.labTime.Text = "Время работы:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 476);
            this.Controls.Add(this.panMain);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(666, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировщик чисел";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panBtns.ResumeLayout(false);
            this.panIn.ResumeLayout(false);
            this.panIn.PerformLayout();
            this.panOut.ResumeLayout(false);
            this.panOut.PerformLayout();
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bwGenerate;
        private System.ComponentModel.BackgroundWorker bwOutput;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panBtns;
        private System.Windows.Forms.Panel panIn;
        private System.Windows.Forms.Panel panOut;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labTacts;
    }
}

