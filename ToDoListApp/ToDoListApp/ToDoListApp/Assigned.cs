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
    public partial class Assigned : Form
    {
        public Assigned()
        {
            InitializeComponent();
        }

        private void Assigned_Load(object sender, EventArgs e)
        {
            Common.ListForm(panel1,Common.enLists.AssignedToMe);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
