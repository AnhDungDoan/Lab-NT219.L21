
namespace TCP.IPDemo
{
    partial class Server3
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bntSend = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.lb_P = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntCheck = new System.Windows.Forms.Button();
            this.bntKey = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 294);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(394, 61);
            this.txtMessage.TabIndex = 5;
            // 
            // bntSend
            // 
            this.bntSend.Location = new System.Drawing.Point(418, 294);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(94, 61);
            this.bntSend.TabIndex = 4;
            this.bntSend.Text = "Send";
            this.bntSend.UseVisualStyleBackColor = true;
            this.bntSend.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(12, 12);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(500, 263);
            this.lsvMessage.TabIndex = 3;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // lb_P
            // 
            this.lb_P.AutoSize = true;
            this.lb_P.Location = new System.Drawing.Point(577, 108);
            this.lb_P.Name = "lb_P";
            this.lb_P.Size = new System.Drawing.Size(20, 20);
            this.lb_P.TabIndex = 7;
            this.lb_P.Text = "P:";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(665, 105);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(125, 27);
            this.txtP.TabIndex = 8;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(665, 149);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(125, 27);
            this.txtG.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "g:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(665, 192);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(125, 27);
            this.txt_a.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(665, 235);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 27);
            this.txtA.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "A";
            // 
            // bntCheck
            // 
            this.bntCheck.Location = new System.Drawing.Point(827, 108);
            this.bntCheck.Name = "bntCheck";
            this.bntCheck.Size = new System.Drawing.Size(80, 41);
            this.bntCheck.TabIndex = 25;
            this.bntCheck.Text = "Check";
            this.bntCheck.UseVisualStyleBackColor = true;
            this.bntCheck.Click += new System.EventHandler(this.bntCheck_Click);
            // 
            // bntKey
            // 
            this.bntKey.Location = new System.Drawing.Point(827, 295);
            this.bntKey.Name = "bntKey";
            this.bntKey.Size = new System.Drawing.Size(80, 60);
            this.bntKey.TabIndex = 26;
            this.bntKey.Text = "Secret Key";
            this.bntKey.UseVisualStyleBackColor = true;
            this.bntKey.Click += new System.EventHandler(this.bntKey_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(665, 295);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(125, 27);
            this.txtB.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "B";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(665, 329);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(125, 27);
            this.txtSecret.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Secret key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 31;
            this.button1.Text = "Exchange key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 60);
            this.label6.TabIndex = 53;
            this.label6.Text = "1. DES\r\n2. AES\r\n3. T-DES";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSelect.Location = new System.Drawing.Point(665, 22);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(151, 28);
            this.cbSelect.TabIndex = 52;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // Server3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 367);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntKey);
            this.Controls.Add(this.bntCheck);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.lb_P);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.bntSend);
            this.Controls.Add(this.lsvMessage);
            this.Name = "Server3";
            this.Text = "Server3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.Label lb_P;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntCheck;
        private System.Windows.Forms.Button bntKey;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSelect;
    }
}