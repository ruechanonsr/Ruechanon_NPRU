namespace ClassicCalculator
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(160, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 55);
            this.label4.TabIndex = 36;
            this.label4.Text = "เครื่องคิดเลขโบราณ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(68, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(91, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Input B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Input A";
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Red;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_exit.ForeColor = System.Drawing.Color.Snow;
            this.bt_exit.Location = new System.Drawing.Point(407, 272);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(128, 53);
            this.bt_exit.TabIndex = 32;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.Yellow;
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_clear.Location = new System.Drawing.Point(267, 272);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(134, 52);
            this.bt_clear.TabIndex = 31;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_sum
            // 
            this.tb_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_sum.Location = new System.Drawing.Point(170, 217);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(365, 41);
            this.tb_sum.TabIndex = 30;
            this.tb_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_b
            // 
            this.tb_b.BackColor = System.Drawing.SystemColors.Info;
            this.tb_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_b.Location = new System.Drawing.Point(170, 158);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(365, 41);
            this.tb_b.TabIndex = 29;
            this.tb_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_a
            // 
            this.tb_a.BackColor = System.Drawing.SystemColors.Info;
            this.tb_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_a.Location = new System.Drawing.Point(170, 100);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(365, 41);
            this.tb_a.TabIndex = 28;
            this.tb_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.Crimson;
            this.bt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_1.Location = new System.Drawing.Point(557, 100);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(52, 48);
            this.bt_1.TabIndex = 37;
            this.bt_1.Text = "+";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.Color.Blue;
            this.bt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_2.Location = new System.Drawing.Point(624, 100);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(52, 48);
            this.bt_2.TabIndex = 38;
            this.bt_2.Text = "-";
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_3.Location = new System.Drawing.Point(557, 158);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(52, 48);
            this.bt_3.TabIndex = 39;
            this.bt_3.Text = "x";
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_4
            // 
            this.bt_4.BackColor = System.Drawing.Color.DarkViolet;
            this.bt_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_4.Location = new System.Drawing.Point(624, 158);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(52, 48);
            this.bt_4.TabIndex = 40;
            this.bt_4.Text = "÷";
            this.bt_4.UseVisualStyleBackColor = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(757, 364);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_4;
    }
}

