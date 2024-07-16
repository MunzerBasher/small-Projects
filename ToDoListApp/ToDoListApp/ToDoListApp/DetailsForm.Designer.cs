namespace ToDoListApp
{
    partial class TimeDue
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
            this.Tasks = new System.Windows.Forms.Button();
            this.chbStata = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.Datadue = new System.Windows.Forms.DateTimePicker();
            this.btnDue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRepeat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbOpen = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRemind = new System.Windows.Forms.Label();
            this.DateRemind = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.SystemColors.ControlText;
            this.Tasks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tasks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tasks.Location = new System.Drawing.Point(-5, -4);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(119, 45);
            this.Tasks.TabIndex = 0;
            this.Tasks.Text = "Tasks";
            this.Tasks.UseVisualStyleBackColor = false;
            this.Tasks.Click += new System.EventHandler(this.Tasks_Click);
            // 
            // chbStata
            // 
            this.chbStata.AutoSize = true;
            this.chbStata.BackColor = System.Drawing.Color.IndianRed;
            this.chbStata.ForeColor = System.Drawing.Color.IndianRed;
            this.chbStata.Location = new System.Drawing.Point(51, 58);
            this.chbStata.Name = "chbStata";
            this.chbStata.Size = new System.Drawing.Size(22, 21);
            this.chbStata.TabIndex = 1;
            this.chbStata.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTitle.Location = new System.Drawing.Point(135, 58);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(528, 35);
            this.txtTitle.TabIndex = 2;
            // 
            // txtStep
            // 
            this.txtStep.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtStep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStep.Location = new System.Drawing.Point(135, 142);
            this.txtStep.Multiline = true;
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(528, 98);
            this.txtStep.TabIndex = 4;
            this.txtStep.Text = "Steps";
            this.txtStep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtStep_MouseClick);
            this.txtStep.MouseEnter += new System.EventHandler(this.txtStep_MouseEnter);
            this.txtStep.MouseLeave += new System.EventHandler(this.txtStep_MouseLeave);
            // 
            // Datadue
            // 
            this.Datadue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datadue.Location = new System.Drawing.Point(347, 283);
            this.Datadue.Name = "Datadue";
            this.Datadue.Size = new System.Drawing.Size(316, 35);
            this.Datadue.TabIndex = 6;
            this.Datadue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnDue
            // 
            this.btnDue.AutoSize = true;
            this.btnDue.Location = new System.Drawing.Point(165, 283);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(159, 29);
            this.btnDue.TabIndex = 7;
            this.btnDue.Text = "Add due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Repeat";
            // 
            // cmbRepeat
            // 
            this.cmbRepeat.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmbRepeat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbRepeat.FormattingEnabled = true;
            this.cmbRepeat.Location = new System.Drawing.Point(135, 424);
            this.cmbRepeat.Name = "cmbRepeat";
            this.cmbRepeat.Size = new System.Drawing.Size(528, 37);
            this.cmbRepeat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add file";
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFile.Location = new System.Drawing.Point(135, 491);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(434, 35);
            this.txtFile.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add note";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtNote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNote.Location = new System.Drawing.Point(135, 565);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(528, 67);
            this.txtNote.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbOpen
            // 
            this.lbOpen.AutoSize = true;
            this.lbOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOpen.Location = new System.Drawing.Point(590, 491);
            this.lbOpen.Name = "lbOpen";
            this.lbOpen.Size = new System.Drawing.Size(73, 29);
            this.lbOpen.TabIndex = 14;
            this.lbOpen.Text = "Open";
            this.lbOpen.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(12, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbRemind
            // 
            this.lbRemind.AutoSize = true;
            this.lbRemind.Location = new System.Drawing.Point(165, 352);
            this.lbRemind.Name = "lbRemind";
            this.lbRemind.Size = new System.Drawing.Size(153, 29);
            this.lbRemind.TabIndex = 17;
            this.lbRemind.Text = "Remind Date";
            // 
            // DateRemind
            // 
            this.DateRemind.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRemind.Location = new System.Drawing.Point(347, 352);
            this.DateRemind.Name = "DateRemind";
            this.DateRemind.Size = new System.Drawing.Size(316, 35);
            this.DateRemind.TabIndex = 16;
            this.DateRemind.ValueChanged += new System.EventHandler(this.DateRemind_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Remind Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add due Date";
            // 
            // TimeDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(687, 644);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRemind);
            this.Controls.Add(this.DateRemind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbOpen);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.Datadue);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chbStata);
            this.Controls.Add(this.Tasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeDue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.Move += new System.EventHandler(this.DetailsForm_Move);
            this.Resize += new System.EventHandler(this.DetailsForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tasks;
        private System.Windows.Forms.CheckBox chbStata;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.DateTimePicker Datadue;
        private System.Windows.Forms.Label btnDue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRemind;
        private System.Windows.Forms.DateTimePicker DateRemind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}