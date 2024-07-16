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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMyDay_Click(object sender, EventArgs e)
        {
            MyDay myDay = new MyDay();
            Common.ShowForm(myDay, MainPanel);
        }

        private void ptnImpo_Click(object sender, EventArgs e)
        {
            Important important = new Important();
            Common.ShowForm(important,MainPanel);
        }

        private void ptnPlanned_Click(object sender, EventArgs e)
        {
            Planned planned = new Planned();
            Common .ShowForm(planned,MainPanel);
        }

        private void btnAssing_Click(object sender, EventArgs e)
        {
            Assigned assigned = new Assigned();
            Common.ShowForm (assigned,MainPanel);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks();
            Common.ShowForm(task,MainPanel);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            Common.ShowForm(search,MainPanel);
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            List list = new List();
            Common.ShowForm(list,MainPanel);
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }
    }
}
