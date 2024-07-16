namespace ToDoListApp
{
    partial class List
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
            this.ListTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListTitle
            // 
            this.ListTitle.AutoSize = true;
            this.ListTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ListTitle.Location = new System.Drawing.Point(2, -2);
            this.ListTitle.Name = "ListTitle";
            this.ListTitle.Size = new System.Drawing.Size(0, 37);
            this.ListTitle.TabIndex = 0;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 588);
            this.Controls.Add(this.ListTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListTitle;
    }
}