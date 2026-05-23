namespace CashierApplication
{
    partial class frmLoginAccount
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
            this.Usernametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Passwordtxtbox = new System.Windows.Forms.TextBox();
            this.Loginbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Usernametxtbox
            // 
            this.Usernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxtbox.Location = new System.Drawing.Point(12, 50);
            this.Usernametxtbox.Multiline = true;
            this.Usernametxtbox.Name = "Usernametxtbox";
            this.Usernametxtbox.Size = new System.Drawing.Size(322, 35);
            this.Usernametxtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Passwordtxtbox
            // 
            this.Passwordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxtbox.Location = new System.Drawing.Point(12, 144);
            this.Passwordtxtbox.Multiline = true;
            this.Passwordtxtbox.Name = "Passwordtxtbox";
            this.Passwordtxtbox.ShortcutsEnabled = false;
            this.Passwordtxtbox.Size = new System.Drawing.Size(322, 35);
            this.Passwordtxtbox.TabIndex = 3;
            this.Passwordtxtbox.TabStop = false;
            // 
            // Loginbttn
            // 
            this.Loginbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbttn.Location = new System.Drawing.Point(12, 207);
            this.Loginbttn.Name = "Loginbttn";
            this.Loginbttn.Size = new System.Drawing.Size(322, 51);
            this.Loginbttn.TabIndex = 4;
            this.Loginbttn.Text = "LOGIN";
            this.Loginbttn.UseVisualStyleBackColor = true;
            this.Loginbttn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLoginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 295);
            this.Controls.Add(this.Loginbttn);
            this.Controls.Add(this.Passwordtxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usernametxtbox);
            this.Controls.Add(this.label1);
            this.Name = "frmLoginAccount";
            this.Text = "Login Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usernametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passwordtxtbox;
        private System.Windows.Forms.Button Loginbttn;
    }
}