namespace MDCT
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.compression_sampling = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.file_compression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ratio_textbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.block_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.decompress_ratio = new System.Windows.Forms.TextBox();
            this.decompress_block = new System.Windows.Forms.TextBox();
            this.decompress_sampling = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.file_decompress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(768, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Decompress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(768, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Compress";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.compression_sampling);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.file_compression);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.ratio_textbox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.block_textbox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 190);
            this.panel1.TabIndex = 2;
            // 
            // compression_sampling
            // 
            this.compression_sampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compression_sampling.Location = new System.Drawing.Point(317, 57);
            this.compression_sampling.Multiline = true;
            this.compression_sampling.Name = "compression_sampling";
            this.compression_sampling.Size = new System.Drawing.Size(276, 26);
            this.compression_sampling.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sampling Rate";
            // 
            // file_compression
            // 
            this.file_compression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_compression.Location = new System.Drawing.Point(6, 57);
            this.file_compression.Multiline = true;
            this.file_compression.Name = "file_compression";
            this.file_compression.Size = new System.Drawing.Size(305, 26);
            this.file_compression.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "File";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(768, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "Open";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ratio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blocks";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(602, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(716, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ratio_textbox
            // 
            this.ratio_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratio_textbox.Location = new System.Drawing.Point(663, 70);
            this.ratio_textbox.Name = "ratio_textbox";
            this.ratio_textbox.Size = new System.Drawing.Size(47, 32);
            this.ratio_textbox.TabIndex = 5;
            this.ratio_textbox.Text = " 2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(716, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // block_textbox
            // 
            this.block_textbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.block_textbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.block_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_textbox.Location = new System.Drawing.Point(663, 17);
            this.block_textbox.Name = "block_textbox";
            this.block_textbox.Size = new System.Drawing.Size(47, 32);
            this.block_textbox.TabIndex = 2;
            this.block_textbox.Text = " 2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.decompress_ratio);
            this.panel2.Controls.Add(this.decompress_block);
            this.panel2.Controls.Add(this.decompress_sampling);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.file_decompress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 190);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ratio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Blocks";
            // 
            // decompress_ratio
            // 
            this.decompress_ratio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompress_ratio.Location = new System.Drawing.Point(602, 70);
            this.decompress_ratio.Name = "decompress_ratio";
            this.decompress_ratio.Size = new System.Drawing.Size(169, 32);
            this.decompress_ratio.TabIndex = 23;
            // 
            // decompress_block
            // 
            this.decompress_block.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompress_block.Location = new System.Drawing.Point(602, 19);
            this.decompress_block.Name = "decompress_block";
            this.decompress_block.Size = new System.Drawing.Size(169, 32);
            this.decompress_block.TabIndex = 22;
            // 
            // decompress_sampling
            // 
            this.decompress_sampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompress_sampling.Location = new System.Drawing.Point(317, 57);
            this.decompress_sampling.Multiline = true;
            this.decompress_sampling.Name = "decompress_sampling";
            this.decompress_sampling.Size = new System.Drawing.Size(276, 26);
            this.decompress_sampling.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sampling Rate";
            // 
            // file_decompress
            // 
            this.file_decompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_decompress.Location = new System.Drawing.Point(6, 57);
            this.file_decompress.Multiline = true;
            this.file_decompress.Name = "file_decompress";
            this.file_decompress.Size = new System.Drawing.Size(305, 26);
            this.file_decompress.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "File";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(3, 108);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(768, 28);
            this.progressBar2.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 35);
            this.button8.TabIndex = 16;
            this.button8.Text = "Open";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(813, 441);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox compression_sampling;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox file_compression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox ratio_textbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox block_textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox decompress_ratio;
        private System.Windows.Forms.TextBox decompress_block;
        private System.Windows.Forms.TextBox decompress_sampling;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox file_decompress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button8;
    }
}

