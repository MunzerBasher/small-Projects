namespace ToDoListApp
{
    partial class Main
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnAddList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAssing = new System.Windows.Forms.Button();
            this.btnMyDay = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.ptnImpo = new System.Windows.Forms.Button();
            this.ptnPlanned = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnAddList);
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(687, 598);
            this.MainPanel.TabIndex = 1;
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddList.Location = new System.Drawing.Point(0, 540);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(686, 44);
            this.btnAddList.TabIndex = 0;
            this.btnAddList.Text = "     New list";
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(545, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btnAssing);
            this.panel2.Controls.Add(this.btnMyDay);
            this.panel2.Controls.Add(this.btnTasks);
            this.panel2.Controls.Add(this.ptnImpo);
            this.panel2.Controls.Add(this.ptnPlanned);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 235);
            this.panel2.TabIndex = 7;
            // 
            // btnAssing
            // 
            this.btnAssing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAssing.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAssing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAssing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssing.Location = new System.Drawing.Point(-3, 137);
            this.btnAssing.Name = "btnAssing";
            this.btnAssing.Size = new System.Drawing.Size(686, 48);
            this.btnAssing.TabIndex = 6;
            this.btnAssing.Text = "Assigned to me";
            this.btnAssing.UseVisualStyleBackColor = false;
            this.btnAssing.Click += new System.EventHandler(this.btnAssing_Click);
            // 
            // btnMyDay
            // 
            this.btnMyDay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMyDay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMyDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMyDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyDay.Location = new System.Drawing.Point(0, 0);
            this.btnMyDay.Name = "btnMyDay";
            this.btnMyDay.Size = new System.Drawing.Size(683, 41);
            this.btnMyDay.TabIndex = 2;
            this.btnMyDay.Text = "My Day";
            this.btnMyDay.UseVisualStyleBackColor = false;
            this.btnMyDay.Click += new System.EventHandler(this.btnMyDay_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTasks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTasks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTasks.Location = new System.Drawing.Point(-5, 185);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(688, 48);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // ptnImpo
            // 
            this.ptnImpo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptnImpo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ptnImpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ptnImpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ptnImpo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptnImpo.Location = new System.Drawing.Point(0, 41);
            this.ptnImpo.Name = "ptnImpo";
            this.ptnImpo.Size = new System.Drawing.Size(683, 48);
            this.ptnImpo.TabIndex = 5;
            this.ptnImpo.Text = "Important";
            this.ptnImpo.UseVisualStyleBackColor = false;
            this.ptnImpo.Click += new System.EventHandler(this.ptnImpo_Click);
            // 
            // ptnPlanned
            // 
            this.ptnPlanned.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptnPlanned.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ptnPlanned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ptnPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ptnPlanned.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptnPlanned.Location = new System.Drawing.Point(0, 89);
            this.ptnPlanned.Name = "ptnPlanned";
            this.ptnPlanned.Size = new System.Drawing.Size(683, 48);
            this.ptnPlanned.TabIndex = 3;
            this.ptnPlanned.Text = "Planned";
            this.ptnPlanned.UseVisualStyleBackColor = false;
            this.ptnPlanned.Click += new System.EventHandler(this.ptnPlanned_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hi MUNZER BASHER";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(687, 598);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAssing;
        private System.Windows.Forms.Button btnMyDay;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button ptnImpo;
        private System.Windows.Forms.Button ptnPlanned;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}