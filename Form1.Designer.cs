namespace SysSoft2
{
    partial class Form1
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.magic = new System.Windows.Forms.Button();
            this.tbOutp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(758, 264);
            this.tbInput.TabIndex = 0;
            // 
            // magic
            // 
            this.magic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.magic.Image = global::SysSoft2.Properties.Resources._2;
            this.magic.Location = new System.Drawing.Point(12, 282);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(758, 70);
            this.magic.TabIndex = 1;
            this.magic.UseVisualStyleBackColor = true;
            this.magic.Click += new System.EventHandler(this.magic_Click);
            // 
            // tbOutp
            // 
            this.tbOutp.Location = new System.Drawing.Point(12, 358);
            this.tbOutp.Multiline = true;
            this.tbOutp.Name = "tbOutp";
            this.tbOutp.Size = new System.Drawing.Size(758, 185);
            this.tbOutp.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.tbOutp);
            this.Controls.Add(this.magic);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button magic;
        private System.Windows.Forms.TextBox tbOutp;
    }
}

