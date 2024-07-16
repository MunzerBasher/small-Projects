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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            Common.UserID();
            DataTable dataTable = clsTask.GetAllTitles(Common.ID());
            foreach (DataRow row in dataTable.Rows)
            {
                comboBox1.Items.Add(row[0]);
            }
            //cmbRepeat.SelectedItem = cmbRepeat.Items[2];
        }
    }
}
