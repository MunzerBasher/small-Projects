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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            string name = txtName.Text; 
            string phone = txtPhone.Text;
            string salary = txtSalary.Text;

            //listView1.Items.Add(number).SubItems.Add(name);
            ListViewItem item = new ListViewItem(number);
            if ((int.Parse(number) % 2 == 0))
                item.BackColor = Color.Brown; //item.ForeColor = Color.Red;
            item.SubItems.Add(name);
            item.SubItems.Add(phone);
            item.SubItems.Add(salary);
            listView1.Items.Add(item);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                //listView1.SelectedItems[0].SubItems[0]
                
            }
        }
    }
}
