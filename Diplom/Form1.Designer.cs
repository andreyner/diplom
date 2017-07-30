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
            this.label5 = new System.Windows.Forms.Label();
            this.RangGen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NGen = new System.Windows.Forms.NumericUpDown();
            this.Individ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xmax = new System.Windows.Forms.TextBox();
            this.xmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typecoding = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeTurnir = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pc = new System.Windows.Forms.NumericUpDown();
            this.Pm = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.generation = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.GenAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Individ)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTurnir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pm)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generation)).BeginInit();
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
            this.GenAlg.Controls.Add(this.groupBox2);
            this.GenAlg.Controls.Add(this.Pm);
            this.GenAlg.Controls.Add(this.label8);
            this.GenAlg.Controls.Add(this.Pc);
            this.GenAlg.Controls.Add(this.label7);
            this.GenAlg.Controls.Add(this.groupBox1);
            this.GenAlg.Controls.Add(this.label5);
            this.GenAlg.Controls.Add(this.RangGen);
            this.GenAlg.Controls.Add(this.label4);
            this.GenAlg.Controls.Add(this.label3);
            this.GenAlg.Controls.Add(this.NGen);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Разрядность гена";
            // 
            // RangGen
            // 
            this.RangGen.Location = new System.Drawing.Point(711, 249);
            this.RangGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RangGen.Name = "RangGen";
            this.RangGen.Size = new System.Drawing.Size(65, 20);
            this.RangGen.TabIndex = 10;
            this.RangGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Особей";
            // 
            // NGen
            // 
            this.NGen.Location = new System.Drawing.Point(711, 202);
            this.NGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NGen.Name = "NGen";
            this.NGen.Size = new System.Drawing.Size(65, 20);
            this.NGen.TabIndex = 7;
            this.NGen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xmax";
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
            // xmax
            // 
            this.xmax.Location = new System.Drawing.Point(711, 118);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(65, 20);
            this.xmax.TabIndex = 3;
            this.xmax.Text = "10";
            // 
            // xmin
            // 
            this.xmin.Location = new System.Drawing.Point(589, 118);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(65, 20);
            this.xmin.TabIndex = 2;
            this.xmin.Text = "-10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 537);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sizeTurnir);
            this.groupBox1.Location = new System.Drawing.Point(604, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Турнирный отбор";
            // 
            // sizeTurnir
            // 
            this.sizeTurnir.Location = new System.Drawing.Point(105, 31);
            this.sizeTurnir.Name = "sizeTurnir";
            this.sizeTurnir.Size = new System.Drawing.Size(64, 20);
            this.sizeTurnir.TabIndex = 0;
            this.sizeTurnir.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Размер турнира";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вероятность скрещивания";
            // 
            // Pc
            // 
            this.Pc.DecimalPlaces = 2;
            this.Pc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Pc.Location = new System.Drawing.Point(711, 287);
            this.Pc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pc.Name = "Pc";
            this.Pc.Size = new System.Drawing.Size(65, 20);
            this.Pc.TabIndex = 14;
            this.Pc.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // Pm
            // 
            this.Pm.DecimalPlaces = 2;
            this.Pm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Pm.Location = new System.Drawing.Point(711, 326);
            this.Pm.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pm.Name = "Pm";
            this.Pm.Size = new System.Drawing.Size(65, 20);
            this.Pm.TabIndex = 16;
            this.Pm.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Вероятность мутации";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generation);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(398, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Критерий остановки";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Поколений";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // generation
            // 
            this.generation.Location = new System.Drawing.Point(106, 34);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(64, 20);
            this.generation.TabIndex = 1;
            this.generation.Value = new decimal(new int[] {
            100,
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
            ((System.ComponentModel.ISupportInitialize)(this.RangGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Individ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTurnir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generation)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NGen;
        private System.Windows.Forms.NumericUpDown Individ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RangGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sizeTurnir;
        private System.Windows.Forms.NumericUpDown Pc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Pm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown generation;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

