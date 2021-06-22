
namespace Client
{
    partial class Client2
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
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.bntSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lb_P = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.bntCheck = new System.Windows.Forms.Button();
            this.bntKey = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(12, 12);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(500, 263);
            this.lsvMessage.TabIndex = 0;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // bntSend
            // 
            this.bntSend.Location = new System.Drawing.Point(418, 294);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(94, 61);
            this.bntSend.TabIndex = 1;
            this.bntSend.Text = "Send";
            this.bntSend.UseVisualStyleBackColor = true;
            this.bntSend.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 294);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(394, 61);
            this.txtMessage.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(647, 203);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(125, 27);
            this.txtB.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "B";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(647, 170);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(125, 27);
            this.txt_b.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "b";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(647, 137);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(125, 27);
            this.txtG.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "g:";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(647, 104);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(125, 27);
            this.txtP.TabIndex = 17;
            // 
            // lb_P
            // 
            this.lb_P.AutoSize = true;
            this.lb_P.Location = new System.Drawing.Point(559, 107);
            this.lb_P.Name = "lb_P";
            this.lb_P.Size = new System.Drawing.Size(20, 20);
            this.lb_P.TabIndex = 16;
            this.lb_P.Text = "P:";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "DES",
            "AES",
            "RSA"});
            this.cbSelect.Location = new System.Drawing.Point(730, 12);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(151, 28);
            this.cbSelect.TabIndex = 15;
            // 
            // bntCheck
            // 
            this.bntCheck.Location = new System.Drawing.Point(801, 107);
            this.bntCheck.Name = "bntCheck";
            this.bntCheck.Size = new System.Drawing.Size(80, 41);
            this.bntCheck.TabIndex = 24;
            this.bntCheck.Text = "Check";
            this.bntCheck.UseVisualStyleBackColor = true;
            this.bntCheck.Click += new System.EventHandler(this.bntCheck_Click);
            // 
            // bntKey
            // 
            this.bntKey.Location = new System.Drawing.Point(801, 277);
            this.bntKey.Name = "bntKey";
            this.bntKey.Size = new System.Drawing.Size(80, 60);
            this.bntKey.TabIndex = 27;
            this.bntKey.Text = "Secrect Key";
            this.bntKey.UseVisualStyleBackColor = true;
            this.bntKey.Click += new System.EventHandler(this.bntKey_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(647, 277);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 27);
            this.txtA.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "A";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(647, 310);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(125, 27);
            this.txtSecretKey.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Secret Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "P:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 34;
            this.button1.Text = "Exchange key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client2
            // 
            this.AcceptButton = this.bntSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntKey);
            this.Controls.Add(this.bntCheck);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.lb_P);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.bntSend);
            this.Controls.Add(this.lsvMessage);
            this.Name = "Client2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lb_P;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Button bntCheck;
        private System.Windows.Forms.Button bntKey;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}