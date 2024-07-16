namespace ToDoListApp
{
    partial class SignUp
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbForgot = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sign in To Do List App ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(182, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "To Do List";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.Highlight;
            this.userName.Location = new System.Drawing.Point(20, 181);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(129, 29);
            this.userName.TabIndex = 13;
            this.userName.Text = "UserName";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(170, 181);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(398, 35);
            this.txtuserName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(20, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 256);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(398, 35);
            this.txtPassword.TabIndex = 14;
            // 
            // lbForgot
            // 
            this.lbForgot.AutoSize = true;
            this.lbForgot.BackColor = System.Drawing.Color.Transparent;
            this.lbForgot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbForgot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbForgot.Location = new System.Drawing.Point(430, 307);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(138, 20);
            this.lbForgot.TabIndex = 16;
            this.lbForgot.Text = "Forgot Password?";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(25, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(543, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Log in";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Sign.Location = new System.Drawing.Point(-3, -6);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(97, 37);
            this.Sign.TabIndex = 18;
            this.Sign.Text = "Sign";
            this.Sign.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 588);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbForgot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbForgot;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Sign;
    }
}