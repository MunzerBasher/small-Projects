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
    public partial class TimeDue : Form
    {
        System.Windows.Forms.ListViewItem listView1;
        public TimeDue(System.Windows.Forms.ListViewItem listView1)
        {
            InitializeComponent();
            this.listView1 = listView1; 
        }

        private void DetailsForm_Move(object sender, EventArgs e)
        {
            Common.SetForm(this, 709, 700);
        }

        private void DetailsForm_Resize(object sender, EventArgs e)
        {
            Common.SetForm(this, 709, 700);
        }

        private void Tasks_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string note = txtNote.Text;
            string step = txtStep.Text;
            string FilePass = txtFile.Text;
            int check = 1;
            int index = 0;
            int TaskID = clsTask.GetTaskIDByTitle(listView1.Text.ToString());
            bool replay = clsTask.UpdateTaskReplay(TaskID,cmbRepeat.SelectedItem.ToString());
            int RepeatID = clsRepeats.GetRepeatIndex(cmbRepeat.SelectedItem.ToString());
            int PriorityID = clsPriorities.GetPriorityIndex(clsTask.GetTaskPriority(TaskID));
            string DueDate = Common.ClearString(btnDue.Text, '{','}');
            dynamic repeat = clsTask.GetTaskReplay(TaskID);
            foreach (var C in cmbRepeat.Items)
            {
                if (C.ToString() == repeat)
                    break;
                index++;
            }
            cmbRepeat.SelectedIndex = index;
            if (step == "Steps")
                step = "";
            string RemindDate = clsTask.GetTaskRemindData(TaskID);  
            if (clsTask.UpdateTask(TaskID, Title, DueDate,Common.ID(),1, RepeatID, 1, RemindDate, 
                PriorityID,check,note,step,FilePass))
            {
                //MessageBox.Show("it Done !");
            }
                this.Close();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = clsRepeats.GetAllRepeats();
            foreach (DataRow row in dataTable.Rows)
            {
                cmbRepeat.Items.Add(row[0]);
            }
            
            int TaskID = clsTask.GetTaskIDByTitle(listView1.Text.ToString());
            txtNote.Text = clsNode.GetNode(TaskID);
            string dueData = listView1.SubItems[2].ToString();
            dynamic repeat = clsTask.GetTaskReplay(TaskID);
            int index = 0;
            foreach (var C in cmbRepeat.Items)
            {
                if (C.ToString() == repeat)
                    break;
                index++;
            }
            cmbRepeat.SelectedIndex =index;
            txtTitle.Text = listView1.Text;
            txtStep.Text = clsTask.GetTaskStep(TaskID);
            txtNote.Text = clsTask.GetTaskNote(TaskID);
            txtFile.Text = clsTask.GetTaskFilePass(TaskID);
            btnDue.Text = Common.ClearString(dueData.Replace("ListViewSubItem: ", ""), '{', '}');
            lbRemind.Text = clsTask.GetTaskRemindData(TaskID);
            chbStata.Checked = DataTasks.GetTaskCheckValueByTitle(txtTitle.Text);
            int value = chbStata.Checked == true ? 1 : 0;
            DataTasks.UpdateTasksCheckValue(txtTitle.Text,(byte)value);
        }


        private void txtStep_MouseLeave(object sender, EventArgs e)
        {
            if (txtStep.Text.ToString().Trim().Length == 0 || txtStep.Text == string.Empty)
            {
                txtStep.Text = "Steps";
            }
        }

        private void txtStep_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtStep.Text == "Steps")
                txtStep.Text = "";
        }

        private void txtStep_MouseEnter(object sender, EventArgs e)
        {
            if (txtStep.Text == "Steps")
                txtStep.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "This is Title";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                //MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            btnDue.Text = Datadue.Value.ToString();
        }

        private void DateRemind_ValueChanged(object sender, EventArgs e)
        {
            lbRemind.Text = DateRemind.Value.ToString();
        }
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtStep.Focus();
        }

    }
}
