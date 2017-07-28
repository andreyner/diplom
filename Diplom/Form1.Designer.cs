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
            this.xmax = new System.Windows.Forms.TextBox();
            this.xmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typecoding = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Individ = new System.Windows.Forms.NumericUpDown();
            this.Gen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.GenAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Individ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.GenAlg.Controls.Add(this.label5);
            this.GenAlg.Controls.Add(this.numericUpDown1);
            this.GenAlg.Controls.Add(this.label4);
            this.GenAlg.Controls.Add(this.label3);
            this.GenAlg.Controls.Add(this.Gen);
            this.GenAlg.Controls.Add(this.Individ);
            this.GenAlg.Controls.Add(this.label2);
            this.GenAlg.Controls.Add(this.label1);
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
            // xmax
            // 
            this.xmax.Location = new System.Drawing.Point(711, 118);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(65, 20);
            this.xmax.TabIndex = 3;
            this.xmax.Text = "500";
            // 
            // xmin
            // 
            this.xmin.Location = new System.Drawing.Point(589, 118);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(65, 20);
            this.xmin.TabIndex = 2;
            this.xmin.Text = "-500";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xmin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xmax";
            // 
            // Individ
            // 
            this.Individ.Location = new System.Drawing.Point(711, 162);
            this.Individ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Individ.Name = "Individ";
            this.Individ.Size = new System.Drawing.Size(65, 20);
            this.Individ.TabIndex = 6;
            this.Individ.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(711, 202);
            this.Gen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(65, 20);
            this.Gen.TabIndex = 7;
            this.Gen.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Особей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Параметров (генов)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Разрядность гена";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(711, 249);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            ((System.ComponentModel.ISupportInitialize)(this.Individ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Gen;
        private System.Windows.Forms.NumericUpDown Individ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

