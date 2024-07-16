namespace ToDoListApp
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
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnMyDay = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptnPlanned = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.ptnImpo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAssing = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBox1.Location = new System.Drawing.Point(595, 600);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Darck Mode";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnMyDay
            // 
            this.btnMyDay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMyDay.ContextMenuStrip = this.contextMenuStrip1;
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
            this.btnMyDay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMyDay_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 36);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // ptnPlanned
            // 
            this.ptnPlanned.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptnPlanned.ContextMenuStrip = this.contextMenuStrip1;
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
            this.btnTasks.Click += new System.EventHandler(this.btnUrgent_Click);
            // 
            // ptnImpo
            // 
            this.ptnImpo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptnImpo.ContextMenuStrip = this.contextMenuStrip1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnAssing);
            this.panel1.Controls.Add(this.btnMyDay);
            this.panel1.Controls.Add(this.btnTasks);
            this.panel1.Controls.Add(this.ptnImpo);
            this.panel1.Controls.Add(this.ptnPlanned);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 235);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAssing
            // 
            this.btnAssing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAssing.ContextMenuStrip = this.contextMenuStrip1;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(687, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnMyDay;
        private System.Windows.Forms.Button ptnPlanned;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button ptnImpo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Button btnAssing;
    }
}

