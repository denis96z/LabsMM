namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.btnSolve = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbA0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbF0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(11, 292);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSolve.Size = new System.Drawing.Size(101, 23);
            this.btnSolve.TabIndex = 38;
            this.btnSolve.Text = "Решение:";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(12, 266);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 37;
            this.tbN.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "N:";
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(12, 226);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(100, 20);
            this.tbAn.TabIndex = 35;
            this.tbAn.Text = "0,009";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "αN:";
            // 
            // tbA0
            // 
            this.tbA0.Location = new System.Drawing.Point(12, 186);
            this.tbA0.Name = "tbA0";
            this.tbA0.Size = new System.Drawing.Size(100, 20);
            this.tbA0.TabIndex = 33;
            this.tbA0.Text = "0,01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "α0:";
            // 
            // tbF0
            // 
            this.tbF0.Location = new System.Drawing.Point(12, 144);
            this.tbF0.Name = "tbF0";
            this.tbF0.Size = new System.Drawing.Size(100, 20);
            this.tbF0.TabIndex = 27;
            this.tbF0.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "F0:";
            // 
            // tbTenv
            // 
            this.tbTenv.Location = new System.Drawing.Point(12, 104);
            this.tbTenv.Name = "tbTenv";
            this.tbTenv.Size = new System.Drawing.Size(100, 20);
            this.tbTenv.TabIndex = 25;
            this.tbTenv.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tenv:";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(12, 64);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(100, 20);
            this.tbR.TabIndex = 23;
            this.tbR.Text = "0,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "R:";
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(12, 24);
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(100, 20);
            this.tbL.TabIndex = 21;
            this.tbL.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "L:";
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(118, 24);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(757, 523);
            this.zedGraph.TabIndex = 39;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 557);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbA0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbF0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbA0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbF0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraph;
    }
}

