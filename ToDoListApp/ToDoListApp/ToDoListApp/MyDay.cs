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
    public partial class MyDay : Form
    {
        public MyDay()
        {
            InitializeComponent();
        }


        private void MyDay_Load(object sender, EventArgs e)
        {
            Common.ListForm(panel1, Common.enLists.MyDay);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        
    }
}
