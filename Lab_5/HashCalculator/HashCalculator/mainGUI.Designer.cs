
namespace HashCalculator
{
    partial class mainGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MD5check = new System.Windows.Forms.CheckBox();
            this.SHA1check = new System.Windows.Forms.CheckBox();
            this.SHA256check = new System.Windows.Forms.CheckBox();
            this.SHA384Check = new System.Windows.Forms.CheckBox();
            this.SHA512Check = new System.Windows.Forms.CheckBox();
            this.RIPEMD160Check = new System.Windows.Forms.CheckBox();
            this.dataText = new System.Windows.Forms.TextBox();
            this.dataFormat = new System.Windows.Forms.ComboBox();
            this.MD5Hash = new System.Windows.Forms.TextBox();
            this.SHA1Hash = new System.Windows.Forms.TextBox();
            this.SHA256Hash = new System.Windows.Forms.TextBox();
            this.SHA384Hash = new System.Windows.Forms.TextBox();
            this.SHA512Hash = new System.Windows.Forms.TextBox();
            this.RIPEMD160Hash = new System.Windows.Forms.TextBox();
            this.HashButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.importFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // MD5check
            // 
            this.MD5check.AutoSize = true;
            this.MD5check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5check.Location = new System.Drawing.Point(18, 115);
            this.MD5check.Name = "MD5check";
            this.MD5check.Size = new System.Drawing.Size(56, 21);
            this.MD5check.TabIndex = 2;
            this.MD5check.Text = "MD5";
            this.MD5check.UseVisualStyleBackColor = true;
            // 
            // SHA1check
            // 
            this.SHA1check.AutoSize = true;
            this.SHA1check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA1check.Location = new System.Drawing.Point(18, 142);
            this.SHA1check.Name = "SHA1check";
            this.SHA1check.Size = new System.Drawing.Size(68, 21);
            this.SHA1check.TabIndex = 3;
            this.SHA1check.Text = "SHA-1";
            this.SHA1check.UseVisualStyleBackColor = true;
            // 
            // SHA256check
            // 
            this.SHA256check.AutoSize = true;
            this.SHA256check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256check.Location = new System.Drawing.Point(18, 169);
            this.SHA256check.Name = "SHA256check";
            this.SHA256check.Size = new System.Drawing.Size(84, 21);
            this.SHA256check.TabIndex = 4;
            this.SHA256check.Text = "SHA-256";
            this.SHA256check.UseVisualStyleBackColor = true;
            // 
            // SHA384Check
            // 
            this.SHA384Check.AutoSize = true;
            this.SHA384Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA384Check.Location = new System.Drawing.Point(18, 196);
            this.SHA384Check.Name = "SHA384Check";
            this.SHA384Check.Size = new System.Drawing.Size(84, 21);
            this.SHA384Check.TabIndex = 5;
            this.SHA384Check.Text = "SHA-384";
            this.SHA384Check.UseVisualStyleBackColor = true;
            // 
            // SHA512Check
            // 
            this.SHA512Check.AutoSize = true;
            this.SHA512Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA512Check.Location = new System.Drawing.Point(18, 223);
            this.SHA512Check.Name = "SHA512Check";
            this.SHA512Check.Size = new System.Drawing.Size(84, 21);
            this.SHA512Check.TabIndex = 6;
            this.SHA512Check.Text = "SHA-512";
            this.SHA512Check.UseVisualStyleBackColor = true;
            // 
            // RIPEMD160Check
            // 
            this.RIPEMD160Check.AutoSize = true;
            this.RIPEMD160Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIPEMD160Check.Location = new System.Drawing.Point(18, 250);
            this.RIPEMD160Check.Name = "RIPEMD160Check";
            this.RIPEMD160Check.Size = new System.Drawing.Size(103, 21);
            this.RIPEMD160Check.TabIndex = 7;
            this.RIPEMD160Check.Text = "RIPEMD160";
            this.RIPEMD160Check.UseVisualStyleBackColor = true;
            // 
            // dataText
            // 
            this.dataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataText.Location = new System.Drawing.Point(163, 29);
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(784, 23);
            this.dataText.TabIndex = 9;
            // 
            // dataFormat
            // 
            this.dataFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFormat.FormattingEnabled = true;
            this.dataFormat.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "File"});
            this.dataFormat.Location = new System.Drawing.Point(12, 29);
            this.dataFormat.Name = "dataFormat";
            this.dataFormat.Size = new System.Drawing.Size(121, 24);
            this.dataFormat.TabIndex = 10;
            // 
            // MD5Hash
            // 
            this.MD5Hash.BackColor = System.Drawing.SystemColors.Menu;
            this.MD5Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5Hash.Location = new System.Drawing.Point(163, 115);
            this.MD5Hash.Name = "MD5Hash";
            this.MD5Hash.Size = new System.Drawing.Size(784, 23);
            this.MD5Hash.TabIndex = 11;
            // 
            // SHA1Hash
            // 
            this.SHA1Hash.BackColor = System.Drawing.SystemColors.Menu;
            this.SHA1Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA1Hash.Location = new System.Drawing.Point(163, 141);
            this.SHA1Hash.Name = "SHA1Hash";
            this.SHA1Hash.Size = new System.Drawing.Size(784, 23);
            this.SHA1Hash.TabIndex = 11;
            // 
            // SHA256Hash
            // 
            this.SHA256Hash.BackColor = System.Drawing.SystemColors.Menu;
            this.SHA256Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256Hash.Location = new System.Drawing.Point(163, 167);
            this.SHA256Hash.Name = "SHA256Hash";
            this.SHA256Hash.Size = new System.Drawing.Size(784, 23);
            this.SHA256Hash.TabIndex = 11;
            // 
            // SHA384Hash
            // 
            this.SHA384Hash.BackColor = System.Drawing.SystemColors.Menu;
            this.SHA384Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA384Hash.Location = new System.Drawing.Point(163, 193);
            this.SHA384Hash.Name = "SHA384Hash";
            this.SHA384Hash.Size = new System.Drawing.Size(784, 23);
            this.SHA384Hash.TabIndex = 11;
            // 
            // SHA512Hash
            // 
            this.SHA512Hash.BackColor = System.Drawing.SystemColors.Menu;
            this.SHA512Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA512Hash.Location = new System.Drawing.Point(163, 219);
            this.SHA512Hash.Name = "SHA512Hash";
            this.SHA512Hash.Size = new System.Drawing.Size(784, 23);
            this.SHA512Hash.TabIndex = 11;
            // 
            // RIPEMD160Hash
            // 
            this.RIPEMD160Hash.BackColor = System.Drawing.SystemColors.Menu;
            this.RIPEMD160Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIPEMD160Hash.Location = new System.Drawing.Point(163, 245);
            this.RIPEMD160Hash.Name = "RIPEMD160Hash";
            this.RIPEMD160Hash.Size = new System.Drawing.Size(784, 23);
            this.RIPEMD160Hash.TabIndex = 11;
            // 
            // HashButton
            // 
            this.HashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashButton.Location = new System.Drawing.Point(820, 569);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(94, 29);
            this.HashButton.TabIndex = 12;
            this.HashButton.Text = "HASH!";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(936, 569);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // importFileButton
            // 
            this.importFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFileButton.Location = new System.Drawing.Point(12, 71);
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(121, 29);
            this.importFileButton.TabIndex = 13;
            this.importFileButton.Text = "Import file here";
            this.importFileButton.UseVisualStyleBackColor = true;
            this.importFileButton.Click += new System.EventHandler(this.importFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "© Doan Anh Dung ☞  Do not REUP";
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.importFileButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.RIPEMD160Hash);
            this.Controls.Add(this.SHA512Hash);
            this.Controls.Add(this.SHA384Hash);
            this.Controls.Add(this.SHA256Hash);
            this.Controls.Add(this.SHA1Hash);
            this.Controls.Add(this.MD5Hash);
            this.Controls.Add(this.dataFormat);
            this.Controls.Add(this.dataText);
            this.Controls.Add(this.RIPEMD160Check);
            this.Controls.Add(this.SHA512Check);
            this.Controls.Add(this.SHA384Check);
            this.Controls.Add(this.SHA256check);
            this.Controls.Add(this.SHA1check);
            this.Controls.Add(this.MD5check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainGUI";
            this.Text = "Hash Calculator :D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MD5check;
        private System.Windows.Forms.CheckBox SHA1check;
        private System.Windows.Forms.CheckBox SHA256check;
        private System.Windows.Forms.CheckBox SHA384Check;
        private System.Windows.Forms.CheckBox SHA512Check;
        private System.Windows.Forms.CheckBox RIPEMD160Check;
        private System.Windows.Forms.TextBox dataText;
        private System.Windows.Forms.ComboBox dataFormat;
        private System.Windows.Forms.TextBox MD5Hash;
        private System.Windows.Forms.TextBox SHA1Hash;
        private System.Windows.Forms.TextBox SHA256Hash;
        private System.Windows.Forms.TextBox SHA384Hash;
        private System.Windows.Forms.TextBox SHA512Hash;
        private System.Windows.Forms.TextBox RIPEMD160Hash;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button importFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

