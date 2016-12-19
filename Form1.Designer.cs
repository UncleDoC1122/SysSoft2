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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbOutp = new System.Windows.Forms.TextBox();
            this.magic = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.dataLexemes = new System.Windows.Forms.DataGridView();
            this.Дучуь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLexemes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbOutp);
            this.tabPage1.Controls.Add(this.magic);
            this.tabPage1.Controls.Add(this.tbInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compiler output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataLexemes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lexeme analysis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbOutp
            // 
            this.tbOutp.Location = new System.Drawing.Point(5, 286);
            this.tbOutp.Margin = new System.Windows.Forms.Padding(2);
            this.tbOutp.Multiline = true;
            this.tbOutp.Name = "tbOutp";
            this.tbOutp.Size = new System.Drawing.Size(544, 102);
            this.tbOutp.TabIndex = 5;
            // 
            // magic
            // 
            this.magic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.magic.Image = global::SysSoft2.Properties.Resources._2;
            this.magic.Location = new System.Drawing.Point(5, 177);
            this.magic.Margin = new System.Windows.Forms.Padding(2);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(544, 105);
            this.magic.TabIndex = 4;
            this.magic.UseVisualStyleBackColor = true;
            this.magic.Click += new System.EventHandler(this.magic_Click_1);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(5, 5);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(544, 168);
            this.tbInput.TabIndex = 3;
            // 
            // dataLexemes
            // 
            this.dataLexemes.AllowUserToAddRows = false;
            this.dataLexemes.AllowUserToDeleteRows = false;
            this.dataLexemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLexemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Дучуь,
            this.Type,
            this.Value});
            this.dataLexemes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLexemes.Location = new System.Drawing.Point(3, 3);
            this.dataLexemes.Name = "dataLexemes";
            this.dataLexemes.ReadOnly = true;
            this.dataLexemes.Size = new System.Drawing.Size(548, 395);
            this.dataLexemes.TabIndex = 0;
            // 
            // Дучуь
            // 
            this.Дучуь.HeaderText = "Lexeme";
            this.Дучуь.Name = "Дучуь";
            this.Дучуь.ReadOnly = true;
            this.Дучуь.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Дучуь.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Lexeme type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Type.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Lexeme value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(586, 451);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLexemes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbOutp;
        private System.Windows.Forms.Button magic;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataLexemes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дучуь;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

