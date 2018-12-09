namespace DecisionTheory
{
    partial class NPPracticeForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecisionNumber = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridQ = new System.Windows.Forms.DataGridView();
            this.B1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridL = new System.Windows.Forms.DataGridView();
            this.L1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadQ = new System.Windows.Forms.Button();
            this.btnLoadL = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            this.MainChart.Location = new System.Drawing.Point(539, 6);
            this.MainChart.Name = "MainChart";
            series3.Name = "Series1";
            this.MainChart.Series.Add(series3);
            this.MainChart.Size = new System.Drawing.Size(462, 461);
            this.MainChart.TabIndex = 6;
            this.MainChart.Text = "chart1";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(12, 414);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(175, 66);
            this.btnCompute.TabIndex = 9;
            this.btnCompute.Text = "Найти решение";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(197, 414);
            this.txtFinal.Multiline = true;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFinal.Size = new System.Drawing.Size(329, 66);
            this.txtFinal.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Колличество решений: ";
            // 
            // txtDecisionNumber
            // 
            this.txtDecisionNumber.Location = new System.Drawing.Point(219, 6);
            this.txtDecisionNumber.Name = "txtDecisionNumber";
            this.txtDecisionNumber.Size = new System.Drawing.Size(49, 26);
            this.txtDecisionNumber.TabIndex = 8;
            this.txtDecisionNumber.Text = "0";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(305, 6);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(110, 35);
            this.btnSet.TabIndex = 9;
            this.btnSet.Text = "Задать";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(217, 21);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(49, 26);
            this.txtB1.TabIndex = 5;
            this.txtB1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пороговое значение B1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица потерь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Матрица полезности";
            // 
            // dataGridQ
            // 
            this.dataGridQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.B1Col,
            this.B2Col});
            this.dataGridQ.Location = new System.Drawing.Point(10, 80);
            this.dataGridQ.MultiSelect = false;
            this.dataGridQ.Name = "dataGridQ";
            this.dataGridQ.Size = new System.Drawing.Size(249, 190);
            this.dataGridQ.TabIndex = 0;
            // 
            // B1Col
            // 
            this.B1Col.HeaderText = "B1";
            this.B1Col.Name = "B1Col";
            this.B1Col.ReadOnly = true;
            // 
            // B2Col
            // 
            this.B2Col.HeaderText = "B2";
            this.B2Col.Name = "B2Col";
            this.B2Col.ReadOnly = true;
            // 
            // dataGridL
            // 
            this.dataGridL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L1Col,
            this.L2Col});
            this.dataGridL.Location = new System.Drawing.Point(265, 80);
            this.dataGridL.Name = "dataGridL";
            this.dataGridL.Size = new System.Drawing.Size(249, 190);
            this.dataGridL.TabIndex = 2;
            // 
            // L1Col
            // 
            this.L1Col.HeaderText = "L1";
            this.L1Col.Name = "L1Col";
            this.L1Col.ReadOnly = true;
            // 
            // L2Col
            // 
            this.L2Col.HeaderText = "L2";
            this.L2Col.Name = "L2Col";
            this.L2Col.ReadOnly = true;
            // 
            // btnLoadQ
            // 
            this.btnLoadQ.Location = new System.Drawing.Point(11, 276);
            this.btnLoadQ.Name = "btnLoadQ";
            this.btnLoadQ.Size = new System.Drawing.Size(127, 79);
            this.btnLoadQ.TabIndex = 6;
            this.btnLoadQ.Text = "Загрузить матрицу полезности";
            this.btnLoadQ.UseVisualStyleBackColor = true;
            this.btnLoadQ.Click += new System.EventHandler(this.btnLoadQ_Click);
            // 
            // btnLoadL
            // 
            this.btnLoadL.Location = new System.Drawing.Point(338, 276);
            this.btnLoadL.Name = "btnLoadL";
            this.btnLoadL.Size = new System.Drawing.Size(172, 79);
            this.btnLoadL.TabIndex = 7;
            this.btnLoadL.Text = "Загрузить матрицу потерь";
            this.btnLoadL.UseVisualStyleBackColor = true;
            this.btnLoadL.Click += new System.EventHandler(this.btnLoadL_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(144, 276);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 79);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Преобразовать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ИЛИ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.btnLoadL);
            this.groupBox1.Controls.Add(this.btnLoadQ);
            this.groupBox1.Controls.Add(this.dataGridL);
            this.groupBox1.Controls.Add(this.dataGridQ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtB1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 361);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NPPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtDecisionNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MainChart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NPPracticeForm";
            this.Text = "Критерий Неймана Пирсона";
            this.Load += new System.EventHandler(this.NPPracticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDecisionNumber;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn B2Col;
        private System.Windows.Forms.DataGridView dataGridL;
        private System.Windows.Forms.DataGridViewTextBoxColumn L1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn L2Col;
        private System.Windows.Forms.Button btnLoadQ;
        private System.Windows.Forms.Button btnLoadL;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}