using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetForm()
        {
            this.Size = new Size(1001, 586);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Size.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            //SetForm();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            { this.BackColor = Color.Black; }
            else
            { this.BackColor = Color.White; }
        }

        private void btnMyDay_Click(object sender, EventArgs e)
        {

        }

        private void ptnPlanned_Click(object sender, EventArgs e)
        {

        }

        private void btnUrgent_Click(object sender, EventArgs e)
        {

        }

        private void ShowD()
        {
            colorDialog1.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
        }

        private void btnMyDay_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();
            btnMyDay.BackColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ptnImpo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnMyDay_MouseHover(object sender, EventArgs e)
        //{
        //    btnMyDay.BackColor = Color.Brown;
        //}

        //private void btnMyDay_MouseLeave(object sender, EventArgs e)
        //{
        //    btnMyDay.BackColor = Color.SlateBlue;
        //}
    }
}
