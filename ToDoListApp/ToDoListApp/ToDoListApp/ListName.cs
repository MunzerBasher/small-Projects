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
    public partial class ListName : Form
    {
        public ListName()
        {
            InitializeComponent();
        }

        public bool value = false;
        public bool cancel = false;

        private void ListName_Load(object sender, EventArgs e)
        {
            value = false;
            cancel = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            value = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

       

    }
}
