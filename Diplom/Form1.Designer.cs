namespace Diplom
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GenAlg = new System.Windows.Forms.TabPage();
            this.typecoding = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.xmin = new System.Windows.Forms.TextBox();
            this.xmax = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.GenAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GenAlg);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // GenAlg
            // 
            this.GenAlg.Controls.Add(this.xmax);
            this.GenAlg.Controls.Add(this.xmin);
            this.GenAlg.Controls.Add(this.button1);
            this.GenAlg.Controls.Add(this.typecoding);
            this.GenAlg.Location = new System.Drawing.Point(4, 22);
            this.GenAlg.Name = "GenAlg";
            this.GenAlg.Padding = new System.Windows.Forms.Padding(3);
            this.GenAlg.Size = new System.Drawing.Size(793, 622);
            this.GenAlg.TabIndex = 0;
            this.GenAlg.Text = "Генетический алгоритм";
            this.GenAlg.UseVisualStyleBackColor = true;
            // 
            // typecoding
            // 
            this.typecoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typecoding.FormattingEnabled = true;
            this.typecoding.Items.AddRange(new object[] {
            "Целочисленное",
            "Вещественное"});
            this.typecoding.Location = new System.Drawing.Point(589, 57);
            this.typecoding.Name = "typecoding";
            this.typecoding.Size = new System.Drawing.Size(187, 28);
            this.typecoding.TabIndex = 0;
            this.typecoding.Text = "Тип кодирования";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xmin
            // 
            this.xmin.Location = new System.Drawing.Point(589, 118);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(65, 20);
            this.xmin.TabIndex = 2;
            // 
            // xmax
            // 
            this.xmax.Location = new System.Drawing.Point(711, 118);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(65, 20);
            this.xmax.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 697);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.GenAlg.ResumeLayout(false);
            this.GenAlg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GenAlg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox typecoding;
        private System.Windows.Forms.TextBox xmax;
        private System.Windows.Forms.TextBox xmin;
    }
}

