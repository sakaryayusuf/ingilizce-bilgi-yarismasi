namespace İngilizce_Bilgi_Yarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.picturebox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.lbldoğru = new System.Windows.Forms.Label();
            this.lblyanlış = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-2, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 149);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(-2, 156);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(390, 80);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(-2, 242);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(390, 80);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(396, 156);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(390, 80);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(396, 242);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(390, 80);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(396, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(281, 71);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sonraki Soru";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // picturebox1
            // 
            this.picturebox1.Image = ((System.Drawing.Image)(resources.GetObject("picturebox1.Image")));
            this.picturebox1.Location = new System.Drawing.Point(12, 328);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(153, 149);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox1.TabIndex = 6;
            this.picturebox1.TabStop = false;
            this.picturebox1.Visible = false;
            // 
            // picturebox2
            // 
            this.picturebox2.Image = ((System.Drawing.Image)(resources.GetObject("picturebox2.Image")));
            this.picturebox2.Location = new System.Drawing.Point(208, 328);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(153, 149);
            this.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox2.TabIndex = 7;
            this.picturebox2.TabStop = false;
            this.picturebox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yanlış:";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Location = new System.Drawing.Point(750, 355);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(17, 19);
            this.lblsoru.TabIndex = 17;
            this.lblsoru.Text = "0";
            // 
            // lbldoğru
            // 
            this.lbldoğru.AutoSize = true;
            this.lbldoğru.Location = new System.Drawing.Point(750, 394);
            this.lbldoğru.Name = "lbldoğru";
            this.lbldoğru.Size = new System.Drawing.Size(17, 19);
            this.lbldoğru.TabIndex = 18;
            this.lbldoğru.Text = "0";
            // 
            // lblyanlış
            // 
            this.lblyanlış.AutoSize = true;
            this.lblyanlış.Location = new System.Drawing.Point(750, 436);
            this.lblyanlış.Name = "lblyanlış";
            this.lblyanlış.Size = new System.Drawing.Size(17, 19);
            this.lblyanlış.TabIndex = 19;
            this.lblyanlış.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblyanlış);
            this.Controls.Add(this.lbldoğru);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturebox2);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Label lbldoğru;
        private System.Windows.Forms.Label lblyanlış;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

