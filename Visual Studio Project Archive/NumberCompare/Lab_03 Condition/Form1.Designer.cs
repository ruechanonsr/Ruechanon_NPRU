namespace Lab_03_Condition
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
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.bt_a = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_a
            // 
            this.tb_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_a.Location = new System.Drawing.Point(179, 111);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(382, 38);
            this.tb_a.TabIndex = 0;
            // 
            // tb_b
            // 
            this.tb_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_b.Location = new System.Drawing.Point(179, 169);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(382, 38);
            this.tb_b.TabIndex = 1;
            // 
            // bt_a
            // 
            this.bt_a.BackColor = System.Drawing.SystemColors.Info;
            this.bt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_a.Location = new System.Drawing.Point(581, 111);
            this.bt_a.Name = "bt_a";
            this.bt_a.Size = new System.Drawing.Size(153, 51);
            this.bt_a.TabIndex = 2;
            this.bt_a.Text = "Compare";
            this.bt_a.UseVisualStyleBackColor = false;
            this.bt_a.Click += new System.EventHandler(this.bt_a_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(54, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input A :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(53, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input B :";
            // 
            // bt_ex
            // 
            this.bt_ex.BackColor = System.Drawing.Color.Red;
            this.bt_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_ex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ex.Location = new System.Drawing.Point(469, 224);
            this.bt_ex.Name = "bt_ex";
            this.bt_ex.Size = new System.Drawing.Size(92, 38);
            this.bt_ex.TabIndex = 5;
            this.bt_ex.Text = "Exit";
            this.bt_ex.UseVisualStyleBackColor = false;
            this.bt_ex.Click += new System.EventHandler(this.bt_ex_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(371, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(119, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 69);
            this.label3.TabIndex = 7;
            this.label3.Text = "เครื่องเปรียบเทียบตัวเลข";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_ex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_a);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Name = "Form1";
            this.Text = "Compare Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Button bt_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_ex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

