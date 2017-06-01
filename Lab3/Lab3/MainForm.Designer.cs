namespace Lab3
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
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbF0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbK0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbA0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraph
            // 
            this.pbGraph.Location = new System.Drawing.Point(121, 12);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(651, 537);
            this.pbGraph.TabIndex = 0;
            this.pbGraph.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "L:";
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(15, 29);
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(100, 20);
            this.tbL.TabIndex = 2;
            this.tbL.Text = "10";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(15, 69);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(100, 20);
            this.tbR.TabIndex = 4;
            this.tbR.Text = "0,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "R:";
            // 
            // tbTenv
            // 
            this.tbTenv.Location = new System.Drawing.Point(15, 109);
            this.tbTenv.Name = "tbTenv";
            this.tbTenv.Size = new System.Drawing.Size(100, 20);
            this.tbTenv.TabIndex = 6;
            this.tbTenv.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tenv:";
            // 
            // tbF0
            // 
            this.tbF0.Location = new System.Drawing.Point(15, 149);
            this.tbF0.Name = "tbF0";
            this.tbF0.Size = new System.Drawing.Size(100, 20);
            this.tbF0.TabIndex = 8;
            this.tbF0.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "F0:";
            // 
            // tbK0
            // 
            this.tbK0.Location = new System.Drawing.Point(15, 189);
            this.tbK0.Name = "tbK0";
            this.tbK0.Size = new System.Drawing.Size(100, 20);
            this.tbK0.TabIndex = 10;
            this.tbK0.Text = "0,2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "K0:";
            // 
            // tbKn
            // 
            this.tbKn.Location = new System.Drawing.Point(15, 229);
            this.tbKn.Name = "tbKn";
            this.tbKn.Size = new System.Drawing.Size(100, 20);
            this.tbKn.TabIndex = 12;
            this.tbKn.Text = "0,1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "KN:";
            // 
            // tbA0
            // 
            this.tbA0.Location = new System.Drawing.Point(15, 269);
            this.tbA0.Name = "tbA0";
            this.tbA0.Size = new System.Drawing.Size(100, 20);
            this.tbA0.TabIndex = 14;
            this.tbA0.Text = "0,01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "α0:";
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(15, 309);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(100, 20);
            this.tbAn.TabIndex = 16;
            this.tbAn.Text = "0,009";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "αN:";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(15, 349);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 18;
            this.tbN.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "N:";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(14, 375);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSolve.Size = new System.Drawing.Size(101, 23);
            this.btnSolve.TabIndex = 19;
            this.btnSolve.Text = "Решение:";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbA0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbK0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbF0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGraph);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №3";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbF0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbK0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbA0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSolve;
    }
}

