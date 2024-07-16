namespace _8Pool
{
    partial class frmTest
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
            this.poolTable1 = new _8Pool.PoolTable();
            this.poolTable2 = new _8Pool.PoolTable();
            this.poolTable3 = new _8Pool.PoolTable();
            this.SuspendLayout();
            // 
            // poolTable1
            // 
            this.poolTable1.BackColor = System.Drawing.Color.Black;
            this.poolTable1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.poolTable1.HourlyRate = 10F;
            this.poolTable1.Location = new System.Drawing.Point(18, 54);
            this.poolTable1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.poolTable1.Name = "poolTable1";
            this.poolTable1.Size = new System.Drawing.Size(585, 425);
            this.poolTable1.TabIndex = 0;
            this.poolTable1.TablePlayer = "Player";
            this.poolTable1.TableTitle = "Table";
            this.poolTable1.OnTableComplete += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.poolTable1_OnTableComplete);
            this.poolTable1.Load += new System.EventHandler(this.poolTable1_Load);
            // 
            // poolTable2
            // 
            this.poolTable2.BackColor = System.Drawing.Color.Black;
            this.poolTable2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.poolTable2.HourlyRate = 10F;
            this.poolTable2.Location = new System.Drawing.Point(26, 62);
            this.poolTable2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.poolTable2.Name = "poolTable2";
            this.poolTable2.Size = new System.Drawing.Size(585, 425);
            this.poolTable2.TabIndex = 1;
            this.poolTable2.TablePlayer = "Player";
            this.poolTable2.TableTitle = "Table";
            // 
            // poolTable3
            // 
            this.poolTable3.BackColor = System.Drawing.Color.Black;
            this.poolTable3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.poolTable3.HourlyRate = 10F;
            this.poolTable3.Location = new System.Drawing.Point(34, 70);
            this.poolTable3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.poolTable3.Name = "poolTable3";
            this.poolTable3.Size = new System.Drawing.Size(585, 425);
            this.poolTable3.TabIndex = 2;
            this.poolTable3.TablePlayer = "Player";
            this.poolTable3.TableTitle = "Table";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.poolTable3);
            this.Controls.Add(this.poolTable2);
            this.Controls.Add(this.poolTable1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PoolTable poolTable1;
        private PoolTable poolTable2;
        private PoolTable poolTable3;
    }
}