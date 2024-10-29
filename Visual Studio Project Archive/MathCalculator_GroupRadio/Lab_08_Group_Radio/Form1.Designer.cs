namespace Lab_08_Group_Radio
{
    partial class Group_radio
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
            this.rb_multi = new System.Windows.Forms.RadioButton();
            this.rb_nfact = new System.Windows.Forms.RadioButton();
            this.rb_odd = new System.Windows.Forms.RadioButton();
            this.rb_even = new System.Windows.Forms.RadioButton();
            this.gb_select = new System.Windows.Forms.GroupBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_multi
            // 
            this.rb_multi.AutoSize = true;
            this.rb_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_multi.Location = new System.Drawing.Point(19, 38);
            this.rb_multi.Name = "rb_multi";
            this.rb_multi.Size = new System.Drawing.Size(229, 33);
            this.rb_multi.TabIndex = 0;
            this.rb_multi.TabStop = true;
            this.rb_multi.Text = "Multiplex Program";
            this.rb_multi.UseVisualStyleBackColor = true;
            // 
            // rb_nfact
            // 
            this.rb_nfact.AutoSize = true;
            this.rb_nfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_nfact.Location = new System.Drawing.Point(19, 77);
            this.rb_nfact.Name = "rb_nfact";
            this.rb_nfact.Size = new System.Drawing.Size(157, 33);
            this.rb_nfact.TabIndex = 1;
            this.rb_nfact.TabStop = true;
            this.rb_nfact.Text = "N! Program";
            this.rb_nfact.UseVisualStyleBackColor = true;
            // 
            // rb_odd
            // 
            this.rb_odd.AutoSize = true;
            this.rb_odd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_odd.Location = new System.Drawing.Point(19, 116);
            this.rb_odd.Name = "rb_odd";
            this.rb_odd.Size = new System.Drawing.Size(180, 33);
            this.rb_odd.TabIndex = 2;
            this.rb_odd.TabStop = true;
            this.rb_odd.Text = "Odd Program";
            this.rb_odd.UseVisualStyleBackColor = true;
            // 
            // rb_even
            // 
            this.rb_even.AutoSize = true;
            this.rb_even.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rb_even.Location = new System.Drawing.Point(19, 155);
            this.rb_even.Name = "rb_even";
            this.rb_even.Size = new System.Drawing.Size(187, 33);
            this.rb_even.TabIndex = 3;
            this.rb_even.TabStop = true;
            this.rb_even.Text = "Even Program";
            this.rb_even.UseVisualStyleBackColor = true;
            // 
            // gb_select
            // 
            this.gb_select.BackColor = System.Drawing.Color.Transparent;
            this.gb_select.Controls.Add(this.rb_multi);
            this.gb_select.Controls.Add(this.rb_even);
            this.gb_select.Controls.Add(this.rb_nfact);
            this.gb_select.Controls.Add(this.rb_odd);
            this.gb_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gb_select.ForeColor = System.Drawing.Color.Black;
            this.gb_select.Location = new System.Drawing.Point(27, 172);
            this.gb_select.Name = "gb_select";
            this.gb_select.Size = new System.Drawing.Size(261, 208);
            this.gb_select.TabIndex = 4;
            this.gb_select.TabStop = false;
            this.gb_select.Text = "Please Select Program";
            this.gb_select.Enter += new System.EventHandler(this.gb_select_Enter);
            // 
            // tb_input
            // 
            this.tb_input.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_input.Location = new System.Drawing.Point(27, 115);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(261, 38);
            this.tb_input.TabIndex = 5;
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_input.TextChanged += new System.EventHandler(this.tb_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input number :";
            // 
            // tb_output
            // 
            this.tb_output.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_output.Location = new System.Drawing.Point(306, 115);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(265, 410);
            this.tb_output.TabIndex = 7;
            this.tb_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_output.TextChanged += new System.EventHandler(this.tb_output_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(27, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(117, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(209, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.Location = new System.Drawing.Point(27, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = ">> Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = ">>>Group Radio Project<<<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(301, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Output Process:";
            // 
            // Group_radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.gb_select);
            this.Name = "Group_radio";
            this.Text = "Group Radio";
            this.Load += new System.EventHandler(this.Group_radio_Load);
            this.gb_select.ResumeLayout(false);
            this.gb_select.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_multi;
        private System.Windows.Forms.RadioButton rb_nfact;
        private System.Windows.Forms.RadioButton rb_odd;
        private System.Windows.Forms.RadioButton rb_even;
        private System.Windows.Forms.GroupBox gb_select;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

