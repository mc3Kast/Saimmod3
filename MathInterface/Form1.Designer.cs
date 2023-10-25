namespace MathInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbN = new TextBox();
            tbP1 = new TextBox();
            btRun = new Button();
            lbA = new Label();
            lbPotk = new Label();
            tbP2 = new TextBox();
            lbL = new Label();
            lbW = new Label();
            SuspendLayout();
            // 
            // tbN
            // 
            tbN.Location = new Point(12, 12);
            tbN.Name = "tbN";
            tbN.Size = new Size(69, 23);
            tbN.TabIndex = 0;
            tbN.Text = "1000000";
            // 
            // tbP1
            // 
            tbP1.Location = new Point(94, 12);
            tbP1.Name = "tbP1";
            tbP1.Size = new Size(38, 23);
            tbP1.TabIndex = 1;
            tbP1.Text = "0,4";
            // 
            // btRun
            // 
            btRun.Location = new Point(308, 12);
            btRun.Name = "btRun";
            btRun.Size = new Size(75, 23);
            btRun.TabIndex = 2;
            btRun.Text = "run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(21, 77);
            lbA.Name = "lbA";
            lbA.Size = new Size(15, 15);
            lbA.TabIndex = 3;
            lbA.Text = "A";
            // 
            // lbPotk
            // 
            lbPotk.AutoSize = true;
            lbPotk.Location = new Point(129, 77);
            lbPotk.Name = "lbPotk";
            lbPotk.Size = new Size(31, 15);
            lbPotk.TabIndex = 4;
            lbPotk.Text = "Potk";
            // 
            // tbP2
            // 
            tbP2.Location = new Point(168, 13);
            tbP2.Name = "tbP2";
            tbP2.Size = new Size(38, 23);
            tbP2.TabIndex = 5;
            tbP2.Text = "0,45";
            // 
            // lbL
            // 
            lbL.AutoSize = true;
            lbL.Location = new Point(21, 106);
            lbL.Name = "lbL";
            lbL.Size = new Size(13, 15);
            lbL.TabIndex = 6;
            lbL.Text = "L";
            // 
            // lbW
            // 
            lbW.AutoSize = true;
            lbW.Location = new Point(129, 106);
            lbW.Name = "lbW";
            lbW.Size = new Size(18, 15);
            lbW.TabIndex = 7;
            lbW.Text = "W";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbW);
            Controls.Add(lbL);
            Controls.Add(tbP2);
            Controls.Add(lbPotk);
            Controls.Add(lbA);
            Controls.Add(btRun);
            Controls.Add(tbP1);
            Controls.Add(tbN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbN;
        private TextBox tbP1;
        private Button btRun;
        private Label lbA;
        private Label lbPotk;
        private TextBox tbP2;
        private Label lbL;
        private Label lbW;
    }
}