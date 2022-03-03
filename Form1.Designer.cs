namespace FileBuilder
{
    partial class FileConstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileConstructor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Be Used For Educational Purposes Only";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(5, 68);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(144, 138);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(155, 68);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(144, 138);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.ButtonClicker);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decryption Key";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(12, 237);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(287, 31);
            this.KeyBox.TabIndex = 5;
            // 
            // FileConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 280);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileConstructor";
            this.Text = "FileConstructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KeyBox;
    }
}
