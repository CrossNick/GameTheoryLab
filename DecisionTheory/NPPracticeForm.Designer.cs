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
            this.dataGridQ = new System.Windows.Forms.DataGridView();
            this.B1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridL = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.L1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.MainTxt = new System.Windows.Forms.TextBox();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQ
            // 
            this.dataGridQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.B1Col,
            this.B2Col});
            this.dataGridQ.Location = new System.Drawing.Point(12, 230);
            this.dataGridQ.Name = "dataGridQ";
            this.dataGridQ.Size = new System.Drawing.Size(249, 150);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Матрица полезности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица потерь";
            // 
            // dataGridL
            // 
            this.dataGridL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L1Col,
            this.L2Col});
            this.dataGridL.Location = new System.Drawing.Point(16, 426);
            this.dataGridL.Name = "dataGridL";
            this.dataGridL.Size = new System.Drawing.Size(245, 150);
            this.dataGridL.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пороговое значение B1:";
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
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(216, 594);
            this.txtB1.Name = "txtB1";
            this.txtB1.ReadOnly = true;
            this.txtB1.Size = new System.Drawing.Size(45, 26);
            this.txtB1.TabIndex = 5;
            // 
            // pct1
            // 
            this.pct1.Location = new System.Drawing.Point(267, 207);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(567, 413);
            this.pct1.TabIndex = 6;
            this.pct1.TabStop = false;
            // 
            // MainTxt
            // 
            this.MainTxt.Location = new System.Drawing.Point(20, 12);
            this.MainTxt.Multiline = true;
            this.MainTxt.Name = "MainTxt";
            this.MainTxt.Size = new System.Drawing.Size(698, 189);
            this.MainTxt.TabIndex = 7;
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(724, 137);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(110, 64);
            this.PrevBtn.TabIndex = 8;
            this.PrevBtn.Text = "Назад";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(724, 12);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(110, 64);
            this.NextBtn.TabIndex = 9;
            this.NextBtn.Text = "Дальше";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // NPTheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 646);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.MainTxt);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NPTheoryForm";
            this.Text = "Критерий Неймана Пирсона";
            this.Load += new System.EventHandler(this.NPTheoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn B2Col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridL;
        private System.Windows.Forms.DataGridViewTextBoxColumn L1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn L2Col;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.TextBox MainTxt;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}