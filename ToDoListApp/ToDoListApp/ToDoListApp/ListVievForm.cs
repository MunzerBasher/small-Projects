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
    public partial class ListViewForm : Form
    {
        private Common.enLists enLists = Common.enLists.Planned;

        public ListViewForm(Common.enLists enLists)
        {
            InitializeComponent();
            this.enLists = enLists;
        }

        private void _FillListView(System.Windows.Forms.ListView listView1, DataTable dataTable)
        {
            if (dataTable != null)
            {
                int i = 1;
                foreach (DataRow dr in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dr[1].ToString());
                    item.SubItems.Add(dr[0].ToString());//item[1] ID
                    item.SubItems.Add(dr[2].ToString());//item[2] Date
                    item.SubItems.Add(dr[3].ToString());//item[3] Priority
                    item.SubItems.Add(dr[4].ToString());//item[4] Cot
                    item.SubItems.Add(dr[5].ToString());//item[5] Repeat
                    if (i % 2 == 0)
                        item.BackColor = Color.AliceBlue;
                    else
                    {
                        item.BackColor = Color.DarkGreen;
                    }
                    item.Checked = DataTasks.GetTaskCheckValueByTitle(dr[1].ToString());
                    listView1.Items.Add(item);
                    i++;
                }
            }

        }

        private void _FillList(Common.enLists enLists, int UserID)
        {
            listView1.Clear();
            switch (enLists)
            {
                case Common.enLists.MyDay:
                    {
                        _FillListView(listView1, clsTask.GetMyDayTasks(UserID));
                        break;
                    }
                case Common.enLists.Important:
                    {
                        _FillListView(listView1, clsTask.GetImportantTasks(UserID));
                        break;
                    }
                case Common.enLists.Planned:
                    {
                        _FillListView(listView1, clsTask.GetPlannedTasks(UserID));
                        break;
                    }
                case Common.enLists.AssignedToMe:
                    {
                        _FillListView(listView1, clsTask.GetAssignedToMeTasks(UserID));
                        break;
                    }
                case Common.enLists.Tasks:
                    {
                        _FillListView(listView1, clsTask.GetAllTasks(UserID));
                        break;
                    }

            }

        }

        private void ListVievForm_Load(object sender, EventArgs e)
        {
            Common.UserID();
            _FillList(enLists, Common.ID());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(enLists);
            addTask.ShowDialog();
            _FillList(enLists, Common.ID());
        }

       

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                TimeDue detailsForm = new TimeDue(listView1.SelectedItems[0]);
                detailsForm.ShowDialog();
                listView1.SelectedItems[0].Checked = true ? false : true;

            }
            _FillList(enLists, Common.ID());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                clsTask.DeleteTask(item.Text);
                _FillList(enLists, Common.ID());
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].Checked == true)
                {
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.BalloonTipTitle = "To Do List App";
                    notifyIcon1.BalloonTipText = "Task is Complete !";
                    notifyIcon1.ShowBalloonTip(3000);
                    DataTasks.UpdateTasksCheckValue(listView1.SelectedItems[0].Text, 1);
                }
                else
                {
                    DataTasks.UpdateTasksCheckValue(listView1.SelectedItems[0].Text, 0);
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.BalloonTipTitle = "To Do List App";
                    notifyIcon1.BalloonTipText = "Task is UnComplete !";
                    notifyIcon1.ShowBalloonTip(3000);
                }
            }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
