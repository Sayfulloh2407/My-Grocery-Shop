namespace My_Grocery_Shop
{
    partial class Form2
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
            this.f2q = new System.Windows.Forms.MaskedTextBox();
            this.receipt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.f2bex = new System.Windows.Forms.Button();
            this.f2bad = new System.Windows.Forms.Button();
            this.f2p = new System.Windows.Forms.Label();
            this.f2id = new System.Windows.Forms.Label();
            this.f2pn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.f2bch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.f2bsel = new System.Windows.Forms.Button();
            this.f2lb2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // f2q
            // 
            this.f2q.BackColor = System.Drawing.Color.Black;
            this.f2q.ForeColor = System.Drawing.Color.White;
            this.f2q.Location = new System.Drawing.Point(250, 434);
            this.f2q.Mask = "0000";
            this.f2q.Name = "f2q";
            this.f2q.Size = new System.Drawing.Size(49, 22);
            this.f2q.TabIndex = 46;
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.Olive;
            this.receipt.ForeColor = System.Drawing.Color.White;
            this.receipt.Location = new System.Drawing.Point(512, 249);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(77, 50);
            this.receipt.TabIndex = 45;
            this.receipt.Text = "Receipt";
            this.receipt.UseVisualStyleBackColor = false;
            this.receipt.Click += new System.EventHandler(this.receipt_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(496, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(318, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Navy;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 28);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.Text = "Refresh the list first";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Black;
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(128, 218);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 37);
            this.refresh.TabIndex = 41;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // f2bex
            // 
            this.f2bex.BackColor = System.Drawing.Color.Maroon;
            this.f2bex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2bex.ForeColor = System.Drawing.Color.White;
            this.f2bex.Location = new System.Drawing.Point(401, 469);
            this.f2bex.Name = "f2bex";
            this.f2bex.Size = new System.Drawing.Size(209, 50);
            this.f2bex.TabIndex = 40;
            this.f2bex.Text = "EXIT";
            this.f2bex.UseVisualStyleBackColor = false;
            this.f2bex.Click += new System.EventHandler(this.f2bex_Click_1);
            // 
            // f2bad
            // 
            this.f2bad.BackColor = System.Drawing.Color.Black;
            this.f2bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2bad.ForeColor = System.Drawing.Color.White;
            this.f2bad.Location = new System.Drawing.Point(128, 469);
            this.f2bad.Name = "f2bad";
            this.f2bad.Size = new System.Drawing.Size(214, 51);
            this.f2bad.TabIndex = 39;
            this.f2bad.Text = "ADD TO BASKET";
            this.f2bad.UseVisualStyleBackColor = false;
            this.f2bad.Click += new System.EventHandler(this.f2bad_Click_1);
            // 
            // f2p
            // 
            this.f2p.AutoSize = true;
            this.f2p.ForeColor = System.Drawing.Color.White;
            this.f2p.Location = new System.Drawing.Point(247, 392);
            this.f2p.Name = "f2p";
            this.f2p.Size = new System.Drawing.Size(0, 16);
            this.f2p.TabIndex = 38;
            // 
            // f2id
            // 
            this.f2id.AutoSize = true;
            this.f2id.ForeColor = System.Drawing.Color.White;
            this.f2id.Location = new System.Drawing.Point(247, 357);
            this.f2id.Name = "f2id";
            this.f2id.Size = new System.Drawing.Size(0, 16);
            this.f2id.TabIndex = 37;
            // 
            // f2pn
            // 
            this.f2pn.AutoSize = true;
            this.f2pn.ForeColor = System.Drawing.Color.White;
            this.f2pn.Location = new System.Drawing.Point(247, 327);
            this.f2pn.Name = "f2pn";
            this.f2pn.Size = new System.Drawing.Size(0, 16);
            this.f2pn.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(125, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(125, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(125, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Product Name:";
            // 
            // f2bch
            // 
            this.f2bch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.f2bch.ForeColor = System.Drawing.Color.White;
            this.f2bch.Location = new System.Drawing.Point(401, 249);
            this.f2bch.Name = "f2bch";
            this.f2bch.Size = new System.Drawing.Size(105, 51);
            this.f2bch.TabIndex = 31;
            this.f2bch.Text = "Checkout";
            this.f2bch.UseVisualStyleBackColor = false;
            this.f2bch.Click += new System.EventHandler(this.f2bch_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(439, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "SUM:";
            // 
            // f2bsel
            // 
            this.f2bsel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.f2bsel.ForeColor = System.Drawing.Color.White;
            this.f2bsel.Location = new System.Drawing.Point(128, 252);
            this.f2bsel.Name = "f2bsel";
            this.f2bsel.Size = new System.Drawing.Size(195, 48);
            this.f2bsel.TabIndex = 29;
            this.f2bsel.Text = "Select";
            this.f2bsel.UseVisualStyleBackColor = false;
            this.f2bsel.Click += new System.EventHandler(this.f2bsel_Click_1);
            // 
            // f2lb2
            // 
            this.f2lb2.BackColor = System.Drawing.Color.Navy;
            this.f2lb2.ForeColor = System.Drawing.Color.White;
            this.f2lb2.FormattingEnabled = true;
            this.f2lb2.ItemHeight = 16;
            this.f2lb2.Location = new System.Drawing.Point(356, 134);
            this.f2lb2.Name = "f2lb2";
            this.f2lb2.Size = new System.Drawing.Size(268, 84);
            this.f2lb2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(394, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "SHOPPING BASKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "AVAILABLE PRODUCTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "SHOPPING PAGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File|*.txt";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(758, 564);
            this.Controls.Add(this.f2q);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.f2bex);
            this.Controls.Add(this.f2bad);
            this.Controls.Add(this.f2p);
            this.Controls.Add(this.f2id);
            this.Controls.Add(this.f2pn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.f2bch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f2bsel);
            this.Controls.Add(this.f2lb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox f2q;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button f2bex;
        private System.Windows.Forms.Button f2bad;
        private System.Windows.Forms.Label f2p;
        private System.Windows.Forms.Label f2id;
        private System.Windows.Forms.Label f2pn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button f2bch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button f2bsel;
        private System.Windows.Forms.ListBox f2lb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}