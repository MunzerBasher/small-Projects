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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static void ShowForm(Form frm, Panel pnl)
        {
            frm.BackColor = pnl.BackColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;

            pnl.Controls.Clear();
            pnl.Controls.Add(frm);
            frm.Show();


        }
        private void ShowMain()
        {
            Form1 form1 = new Form1();
            ShowForm(form1, MainPanel);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Main main = new Main();
            Common.ShowForm(main, MainPanel);
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Common.ShowForm(main, MainPanel);
        }


        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
           // menuStrip1.BackColor = Color.White;
        }


        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
           // menuStrip1.BackColor = Color.Black;
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

   

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Common.SetForm(this, 709, 700);
        }
    }
}
