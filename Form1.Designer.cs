namespace Calculator
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
            textBox1 = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            n0 = new Button();
            n00 = new Button();
            dot = new Button();
            bc = new Button();
            bmult = new Button();
            bad = new Button();
            bac = new Button();
            bdiv = new Button();
            bsub = new Button();
            bequal = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(153, 35);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(427, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // n1
            // 
            n1.BackColor = SystemColors.ActiveCaption;
            n1.Font = new Font("Segoe UI", 18F);
            n1.Location = new Point(169, 292);
            n1.Name = "n1";
            n1.Size = new Size(71, 60);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = SystemColors.ActiveCaption;
            n2.Font = new Font("Segoe UI", 18F);
            n2.Location = new Point(246, 292);
            n2.Name = "n2";
            n2.Size = new Size(71, 60);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.BackColor = SystemColors.ActiveCaption;
            n3.Font = new Font("Segoe UI", 18F);
            n3.Location = new Point(323, 292);
            n3.Name = "n3";
            n3.Size = new Size(71, 60);
            n3.TabIndex = 1;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n4
            // 
            n4.BackColor = SystemColors.ActiveCaption;
            n4.Font = new Font("Segoe UI", 18F);
            n4.Location = new Point(169, 226);
            n4.Name = "n4";
            n4.Size = new Size(71, 60);
            n4.TabIndex = 1;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.BackColor = SystemColors.ActiveCaption;
            n5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n5.Location = new Point(246, 226);
            n5.Name = "n5";
            n5.Size = new Size(71, 60);
            n5.TabIndex = 1;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.BackColor = SystemColors.ActiveCaption;
            n6.Font = new Font("Segoe UI", 18F);
            n6.Location = new Point(323, 226);
            n6.Name = "n6";
            n6.Size = new Size(71, 60);
            n6.TabIndex = 1;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n7
            // 
            n7.BackColor = SystemColors.ActiveCaption;
            n7.Font = new Font("Segoe UI", 18F);
            n7.Location = new Point(169, 160);
            n7.Name = "n7";
            n7.Size = new Size(71, 60);
            n7.TabIndex = 1;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.BackColor = SystemColors.ActiveCaption;
            n8.Font = new Font("Segoe UI", 18F);
            n8.Location = new Point(246, 160);
            n8.Name = "n8";
            n8.Size = new Size(71, 60);
            n8.TabIndex = 1;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.BackColor = SystemColors.ActiveCaption;
            n9.Font = new Font("Segoe UI", 18F);
            n9.Location = new Point(323, 160);
            n9.Name = "n9";
            n9.Size = new Size(71, 60);
            n9.TabIndex = 1;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // n0
            // 
            n0.BackColor = SystemColors.ActiveCaption;
            n0.Font = new Font("Segoe UI", 18F);
            n0.Location = new Point(169, 358);
            n0.Name = "n0";
            n0.Size = new Size(71, 60);
            n0.TabIndex = 1;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // n00
            // 
            n00.BackColor = SystemColors.ActiveCaption;
            n00.Font = new Font("Segoe UI", 18F);
            n00.Location = new Point(246, 358);
            n00.Name = "n00";
            n00.Size = new Size(71, 60);
            n00.TabIndex = 1;
            n00.Text = "00";
            n00.UseVisualStyleBackColor = false;
            n00.Click += n00_Click;
            // 
            // dot
            // 
            dot.BackColor = SystemColors.ActiveCaption;
            dot.Font = new Font("Segoe UI", 18F);
            dot.Location = new Point(323, 358);
            dot.Name = "dot";
            dot.Size = new Size(71, 60);
            dot.TabIndex = 1;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // bc
            // 
            bc.BackColor = SystemColors.ActiveCaption;
            bc.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bc.Location = new Point(400, 160);
            bc.Name = "bc";
            bc.Size = new Size(71, 60);
            bc.TabIndex = 1;
            bc.Text = "C";
            bc.UseVisualStyleBackColor = false;
            bc.Click += bc_Click;
            // 
            // bmult
            // 
            bmult.BackColor = SystemColors.ActiveCaption;
            bmult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bmult.Location = new Point(400, 226);
            bmult.Name = "bmult";
            bmult.Size = new Size(71, 60);
            bmult.TabIndex = 1;
            bmult.Text = "x";
            bmult.UseVisualStyleBackColor = false;
            bmult.Click += bmult_Click;
            // 
            // bad
            // 
            bad.BackColor = SystemColors.ActiveCaption;
            bad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bad.Location = new Point(400, 292);
            bad.Name = "bad";
            bad.Size = new Size(71, 126);
            bad.TabIndex = 1;
            bad.Text = "+";
            bad.UseVisualStyleBackColor = false;
            bad.Click += bad_Click;
            // 
            // bac
            // 
            bac.BackColor = SystemColors.ActiveCaption;
            bac.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bac.Location = new Point(509, 160);
            bac.Name = "bac";
            bac.Size = new Size(71, 60);
            bac.TabIndex = 1;
            bac.Text = "AC";
            bac.UseVisualStyleBackColor = false;
            bac.Click += bac_Click;
            // 
            // bdiv
            // 
            bdiv.BackColor = SystemColors.ActiveCaption;
            bdiv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdiv.Location = new Point(509, 226);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(71, 60);
            bdiv.TabIndex = 1;
            bdiv.Text = "÷";
            bdiv.UseVisualStyleBackColor = false;
            bdiv.Click += bdiv_Click;
            // 
            // bsub
            // 
            bsub.BackColor = SystemColors.ActiveCaption;
            bsub.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bsub.Location = new Point(509, 292);
            bsub.Name = "bsub";
            bsub.Size = new Size(71, 60);
            bsub.TabIndex = 1;
            bsub.Text = "-";
            bsub.UseVisualStyleBackColor = false;
            bsub.Click += bsub_Click;
            // 
            // bequal
            // 
            bequal.BackColor = SystemColors.ActiveCaption;
            bequal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bequal.Location = new Point(509, 358);
            bequal.Name = "bequal";
            bequal.Size = new Size(71, 60);
            bequal.TabIndex = 1;
            bequal.Text = "=";
            bequal.UseVisualStyleBackColor = false;
            bequal.Click += bequal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 538);
            Controls.Add(bad);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(bac);
            Controls.Add(bc);
            Controls.Add(n9);
            Controls.Add(bequal);
            Controls.Add(bsub);
            Controls.Add(bdiv);
            Controls.Add(bmult);
            Controls.Add(n6);
            Controls.Add(dot);
            Controls.Add(n00);
            Controls.Add(n0);
            Controls.Add(n8);
            Controls.Add(n5);
            Controls.Add(n7);
            Controls.Add(n4);
            Controls.Add(n1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button n00;
        private Button dot;
        private Button bc;
        private Button bmult;
        private Button bad;
        private Button bac;
        private Button bdiv;
        private Button bsub;
        private Button bequal;
    }
}
