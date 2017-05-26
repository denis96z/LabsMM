namespace Lab2
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRk = new System.Windows.Forms.TextBox();
            this.tbLk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbP0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUc0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbI0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbRungeKutta = new System.Windows.Forms.RadioButton();
            this.rbTrap = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(148, 9);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(624, 540);
            this.zedGraph.TabIndex = 3;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rk:";
            // 
            // tbRk
            // 
            this.tbRk.Location = new System.Drawing.Point(42, 9);
            this.tbRk.Name = "tbRk";
            this.tbRk.Size = new System.Drawing.Size(100, 20);
            this.tbRk.TabIndex = 5;
            this.tbRk.Text = "0,2";
            // 
            // tbLk
            // 
            this.tbLk.Location = new System.Drawing.Point(42, 35);
            this.tbLk.Name = "tbLk";
            this.tbLk.Size = new System.Drawing.Size(100, 20);
            this.tbLk.TabIndex = 7;
            this.tbLk.Text = "60e-6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lk:";
            // 
            // tbCk
            // 
            this.tbCk.Location = new System.Drawing.Point(42, 61);
            this.tbCk.Name = "tbCk";
            this.tbCk.Size = new System.Drawing.Size(100, 20);
            this.tbCk.TabIndex = 9;
            this.tbCk.Text = "150e-6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ck:";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(42, 87);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(100, 20);
            this.tbR.TabIndex = 11;
            this.tbR.Text = "0,35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "R:";
            // 
            // tbP0
            // 
            this.tbP0.Location = new System.Drawing.Point(42, 113);
            this.tbP0.Name = "tbP0";
            this.tbP0.Size = new System.Drawing.Size(100, 20);
            this.tbP0.TabIndex = 13;
            this.tbP0.Text = "0,5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "P0:";
            // 
            // tbTs
            // 
            this.tbTs.Location = new System.Drawing.Point(42, 139);
            this.tbTs.Name = "tbTs";
            this.tbTs.Size = new System.Drawing.Size(100, 20);
            this.tbTs.TabIndex = 15;
            this.tbTs.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ts:";
            // 
            // tbTw
            // 
            this.tbTw.Location = new System.Drawing.Point(42, 165);
            this.tbTw.Name = "tbTw";
            this.tbTw.Size = new System.Drawing.Size(100, 20);
            this.tbTw.TabIndex = 17;
            this.tbTw.Text = "2000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tw:";
            // 
            // tbLe
            // 
            this.tbLe.Location = new System.Drawing.Point(42, 191);
            this.tbLe.Name = "tbLe";
            this.tbLe.Size = new System.Drawing.Size(100, 20);
            this.tbLe.TabIndex = 19;
            this.tbLe.Text = "12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Le:";
            // 
            // tbUc0
            // 
            this.tbUc0.Location = new System.Drawing.Point(42, 217);
            this.tbUc0.Name = "tbUc0";
            this.tbUc0.Size = new System.Drawing.Size(100, 20);
            this.tbUc0.TabIndex = 21;
            this.tbUc0.Text = "3000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Uc0:";
            // 
            // tbI0
            // 
            this.tbI0.Location = new System.Drawing.Point(42, 243);
            this.tbI0.Name = "tbI0";
            this.tbI0.Size = new System.Drawing.Size(100, 20);
            this.tbI0.TabIndex = 23;
            this.tbI0.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "I0:";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(15, 341);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(127, 23);
            this.btnSolve.TabIndex = 24;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(42, 269);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 26;
            this.tbN.Text = "50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "N:";
            // 
            // rbRungeKutta
            // 
            this.rbRungeKutta.AutoSize = true;
            this.rbRungeKutta.Checked = true;
            this.rbRungeKutta.Location = new System.Drawing.Point(20, 295);
            this.rbRungeKutta.Name = "rbRungeKutta";
            this.rbRungeKutta.Size = new System.Drawing.Size(122, 17);
            this.rbRungeKutta.TabIndex = 27;
            this.rbRungeKutta.TabStop = true;
            this.rbRungeKutta.Text = "Метод Рунге-Кутты";
            this.rbRungeKutta.UseVisualStyleBackColor = true;
            // 
            // rbTrap
            // 
            this.rbTrap.AutoSize = true;
            this.rbTrap.Location = new System.Drawing.Point(20, 318);
            this.rbTrap.Name = "rbTrap";
            this.rbTrap.Size = new System.Drawing.Size(122, 17);
            this.rbTrap.TabIndex = 28;
            this.rbTrap.TabStop = true;
            this.rbTrap.Text = "Метод трапеций (н)";
            this.rbTrap.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rbTrap);
            this.Controls.Add(this.rbRungeKutta);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbI0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUc0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbP0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraph);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRk;
        private System.Windows.Forms.TextBox tbLk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbP0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUc0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbI0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbRungeKutta;
        private System.Windows.Forms.RadioButton rbTrap;
    }
}

