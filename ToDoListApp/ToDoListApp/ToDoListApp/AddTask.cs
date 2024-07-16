using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoListApp
{
    public partial class AddTask : Form
    {
        private Common.enLists Priority;
        public AddTask(Common.enLists priority)
        {
            InitializeComponent();
            this.Priority = priority;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Title = btnAdd.Text;
            string DueData = TimeDue.Value.ToString();
            string RemindData = TimeRemind.Value.ToString();
            int priorityID = clsPriorities.GetPriorityIndex(Priority.ToString());
            int Repeat = clsRepeats.GetRepeatIndex(cmbRepeat.SelectedItem.ToString());
            int UserID = Common.ID();
            if (btnAdd.Text != "Add a task")
            {
                if (DataTasks.AddTask(Title, Common.ClearString(DueData, '{', '}'), UserID, 1, Repeat, Common.ClearString(RemindData, '{', '}'), priorityID))
                {
                    MessageBox.Show("Added Successful !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Added Fill !");
                }
                return;
            }
            MessageBox.Show("Enter Tasks");
        }
        public static void SetForm(Form form, int x1, int y1)
        {
            form.Size = new Size(x1, y1);
            int x = (Screen.PrimaryScreen.Bounds.Width - form.Size.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - form.Size.Height) / 2;
            form.Location = new Point(x, y+100);
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            SetForm(this, 661, 310);
            DataTable dataTable = clsRepeats.GetAllRepeats();
            foreach (DataRow row in dataTable.Rows)
            {
                cmbRepeat.Items.Add(row[0]);
            }
            cmbRepeat.SelectedItem = cmbRepeat.Items[2];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add a task")
                btnAdd.Text = "";
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            if(btnAdd.Text.ToString().Trim().Length == 0 || btnAdd.Text == string.Empty) 
            {
                btnAdd.Text = "Add a task";
            }

        }

        private void btnRemind_Click(object sender, EventArgs e)
        {

        }

        private void btnDue_Click(object sender, EventArgs e)
        {

        }
    }
}
