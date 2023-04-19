namespace My_Grocery_Shop
{
    partial class Form3
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.f3tb2 = new System.Windows.Forms.MaskedTextBox();
            this.f3tbpn = new System.Windows.Forms.TextBox();
            this.f3tb3 = new System.Windows.Forms.TextBox();
            this.f3b2 = new System.Windows.Forms.Button();
            this.f3b1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(394, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kg",
            "Litre",
            "Piece"});
            this.comboBox1.Location = new System.Drawing.Point(262, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // f3tb2
            // 
            this.f3tb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.f3tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3tb2.ForeColor = System.Drawing.Color.White;
            this.f3tb2.Location = new System.Drawing.Point(262, 152);
            this.f3tb2.Mask = "L0000L";
            this.f3tb2.Name = "f3tb2";
            this.f3tb2.Size = new System.Drawing.Size(125, 27);
            this.f3tb2.TabIndex = 24;
            this.f3tb2.Tag = "";
            // 
            // f3tbpn
            // 
            this.f3tbpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.f3tbpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3tbpn.ForeColor = System.Drawing.Color.White;
            this.f3tbpn.Location = new System.Drawing.Point(262, 110);
            this.f3tbpn.Name = "f3tbpn";
            this.f3tbpn.Size = new System.Drawing.Size(126, 27);
            this.f3tbpn.TabIndex = 23;
            // 
            // f3tb3
            // 
            this.f3tb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.f3tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3tb3.ForeColor = System.Drawing.Color.White;
            this.f3tb3.Location = new System.Drawing.Point(262, 195);
            this.f3tb3.Name = "f3tb3";
            this.f3tb3.Size = new System.Drawing.Size(126, 27);
            this.f3tb3.TabIndex = 22;
            // 
            // f3b2
            // 
            this.f3b2.BackColor = System.Drawing.Color.Red;
            this.f3b2.ForeColor = System.Drawing.Color.White;
            this.f3b2.Location = new System.Drawing.Point(315, 331);
            this.f3b2.Name = "f3b2";
            this.f3b2.Size = new System.Drawing.Size(137, 47);
            this.f3b2.TabIndex = 21;
            this.f3b2.Text = "EXIT";
            this.f3b2.UseVisualStyleBackColor = false;
            this.f3b2.Click += new System.EventHandler(this.f3b2_Click_1);
            // 
            // f3b1
            // 
            this.f3b1.BackColor = System.Drawing.Color.Lime;
            this.f3b1.Location = new System.Drawing.Point(99, 331);
            this.f3b1.Name = "f3b1";
            this.f3b1.Size = new System.Drawing.Size(141, 47);
            this.f3b1.TabIndex = 20;
            this.f3b1.Text = "ADD PRODUCT";
            this.f3b1.UseVisualStyleBackColor = false;
            this.f3b1.Click += new System.EventHandler(this.f3b1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADD PRODUCT";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.f3tb2);
            this.Controls.Add(this.f3tbpn);
            this.Controls.Add(this.f3tb3);
            this.Controls.Add(this.f3b2);
            this.Controls.Add(this.f3b1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox f3tb2;
        private System.Windows.Forms.TextBox f3tbpn;
        private System.Windows.Forms.TextBox f3tb3;
        private System.Windows.Forms.Button f3b2;
        private System.Windows.Forms.Button f3b1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}