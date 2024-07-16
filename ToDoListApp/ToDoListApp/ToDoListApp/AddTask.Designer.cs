namespace ToDoListApp
{
    partial class AddTask
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDue = new System.Windows.Forms.Button();
            this.btnRemind = new System.Windows.Forms.Button();
            this.cmbRepeat = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.TextBox();
            this.TimeDue = new System.Windows.Forms.DateTimePicker();
            this.TimeRemind = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(528, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(25, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDue
            // 
            this.btnDue.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDue.Location = new System.Drawing.Point(49, 75);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(163, 36);
            this.btnDue.TabIndex = 3;
            this.btnDue.Text = "Set due date";
            this.btnDue.UseVisualStyleBackColor = false;
            this.btnDue.Click += new System.EventHandler(this.btnDue_Click);
            // 
            // btnRemind
            // 
            this.btnRemind.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRemind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemind.Location = new System.Drawing.Point(49, 125);
            this.btnRemind.Name = "btnRemind";
            this.btnRemind.Size = new System.Drawing.Size(163, 36);
            this.btnRemind.TabIndex = 4;
            this.btnRemind.Text = "Remind me";
            this.btnRemind.UseVisualStyleBackColor = false;
            this.btnRemind.Click += new System.EventHandler(this.btnRemind_Click);
            // 
            // cmbRepeat
            // 
            this.cmbRepeat.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmbRepeat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbRepeat.FormattingEnabled = true;
            this.cmbRepeat.Location = new System.Drawing.Point(230, 177);
            this.cmbRepeat.Name = "cmbRepeat";
            this.cmbRepeat.Size = new System.Drawing.Size(419, 37);
            this.cmbRepeat.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(14, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(389, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add a task";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // TimeDue
            // 
            this.TimeDue.Location = new System.Drawing.Point(230, 74);
            this.TimeDue.Name = "TimeDue";
            this.TimeDue.Size = new System.Drawing.Size(419, 35);
            this.TimeDue.TabIndex = 8;
            // 
            // TimeRemind
            // 
            this.TimeRemind.Location = new System.Drawing.Point(230, 128);
            this.TimeRemind.Name = "TimeRemind";
            this.TimeRemind.Size = new System.Drawing.Size(419, 35);
            this.TimeRemind.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(49, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Repeat";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(661, 310);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeRemind);
            this.Controls.Add(this.TimeDue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbRepeat);
            this.Controls.Add(this.btnRemind);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask";
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDue;
        private System.Windows.Forms.Button btnRemind;
        private System.Windows.Forms.ComboBox cmbRepeat;
        private System.Windows.Forms.TextBox btnAdd;
        private System.Windows.Forms.DateTimePicker TimeDue;
        private System.Windows.Forms.DateTimePicker TimeRemind;
        private System.Windows.Forms.Button button1;
    }
}