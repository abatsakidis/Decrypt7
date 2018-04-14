namespace Decrypt7
{
    partial class Decrypt7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decrypt7));
            this.Label1 = new System.Windows.Forms.Label();
            this.DecryptBox1 = new System.Windows.Forms.TextBox();
            this.CryptBox1 = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Crypted Password :";
            // 
            // DecryptBox1
            // 
            this.DecryptBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecryptBox1.Location = new System.Drawing.Point(93, 54);
            this.DecryptBox1.Name = "DecryptBox1";
            this.DecryptBox1.ReadOnly = true;
            this.DecryptBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DecryptBox1.Size = new System.Drawing.Size(198, 20);
            this.DecryptBox1.TabIndex = 10;
            this.DecryptBox1.WordWrap = false;
            // 
            // CryptBox1
            // 
            this.CryptBox1.Location = new System.Drawing.Point(12, 25);
            this.CryptBox1.Name = "CryptBox1";
            this.CryptBox1.Size = new System.Drawing.Size(279, 20);
            this.CryptBox1.TabIndex = 8;
            this.CryptBox1.Text = "095C4F1A0A1218000F";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDecrypt.Location = new System.Drawing.Point(12, 53);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Decrypt7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 87);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DecryptBox1);
            this.Controls.Add(this.CryptBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Decrypt7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password 7 Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox DecryptBox1;
        internal System.Windows.Forms.TextBox CryptBox1;
        internal System.Windows.Forms.Button btnDecrypt;
    }
}

