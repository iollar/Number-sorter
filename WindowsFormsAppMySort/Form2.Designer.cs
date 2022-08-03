namespace WindowsFormsAppMySort
{
    partial class FormGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuantily = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.labQuantily = new System.Windows.Forms.Label();
            this.labMinn = new System.Windows.Forms.Label();
            this.txtMinn = new System.Windows.Forms.TextBox();
            this.labMaxx = new System.Windows.Forms.Label();
            this.txtMaxx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtQuantily
            // 
            this.txtQuantily.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantily.Location = new System.Drawing.Point(455, 15);
            this.txtQuantily.Name = "txtQuantily";
            this.txtQuantily.Size = new System.Drawing.Size(239, 35);
            this.txtQuantily.TabIndex = 0;
            this.txtQuantily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(17, 185);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(677, 63);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "ВВЕСТИ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // labQuantily
            // 
            this.labQuantily.AutoSize = true;
            this.labQuantily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labQuantily.Location = new System.Drawing.Point(12, 21);
            this.labQuantily.Name = "labQuantily";
            this.labQuantily.Size = new System.Drawing.Size(410, 25);
            this.labQuantily.TabIndex = 2;
            this.labQuantily.Text = "Кол-во элементов в последовательности:";
            // 
            // labMinn
            // 
            this.labMinn.AutoSize = true;
            this.labMinn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labMinn.Location = new System.Drawing.Point(12, 72);
            this.labMinn.Name = "labMinn";
            this.labMinn.Size = new System.Drawing.Size(551, 25);
            this.labMinn.TabIndex = 4;
            this.labMinn.Text = "Минимально-возможный элемент последовательности:";
            // 
            // txtMinn
            // 
            this.txtMinn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMinn.Location = new System.Drawing.Point(595, 72);
            this.txtMinn.Name = "txtMinn";
            this.txtMinn.Size = new System.Drawing.Size(99, 35);
            this.txtMinn.TabIndex = 1;
            this.txtMinn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labMaxx
            // 
            this.labMaxx.AutoSize = true;
            this.labMaxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labMaxx.Location = new System.Drawing.Point(12, 127);
            this.labMaxx.Name = "labMaxx";
            this.labMaxx.Size = new System.Drawing.Size(559, 25);
            this.labMaxx.TabIndex = 6;
            this.labMaxx.Text = "Максимально-возможный элемент последовательности:";
            // 
            // txtMaxx
            // 
            this.txtMaxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaxx.Location = new System.Drawing.Point(595, 121);
            this.txtMaxx.Name = "txtMaxx";
            this.txtMaxx.Size = new System.Drawing.Size(99, 35);
            this.txtMaxx.TabIndex = 2;
            this.txtMaxx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 272);
            this.Controls.Add(this.labMaxx);
            this.Controls.Add(this.txtMaxx);
            this.Controls.Add(this.labMinn);
            this.Controls.Add(this.txtMinn);
            this.Controls.Add(this.labQuantily);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtQuantily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры генерируемой последовательности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantily;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label labQuantily;
        private System.Windows.Forms.Label labMinn;
        private System.Windows.Forms.TextBox txtMinn;
        private System.Windows.Forms.Label labMaxx;
        private System.Windows.Forms.TextBox txtMaxx;
    }
}