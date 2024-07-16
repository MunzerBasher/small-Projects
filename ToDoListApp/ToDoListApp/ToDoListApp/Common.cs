
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ToDoListApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




public static class Common
{

    public static DataUsers  CurrentUser = new DataUsers();
    
    public static void UserID()
    {
        CurrentUser.UserID = 1;
    }

    public static int ID()
    {
        return CurrentUser.UserID;
    }

    public static string ClearString(string str,char ch1, char ch2='}')
    {
        string Value = "";
        foreach(var c in str)
        {
            if(c != ch1 && c != ch2)
                Value += c;
        }
        return Value.Trim();
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

    public enum enLists
    {
        MyDay = 1,
        Important,
        Planned,
        AssignedToMe,
        Tasks
    }



    public static void SetForm(Form form, int x1 , int y1)
    {
        form.Size = new Size(x1, y1);
        int x = (Screen.PrimaryScreen.Bounds.Width - form.Size.Width) / 2;
        int y = (Screen.PrimaryScreen.Bounds.Height - form.Size.Height) / 2;
        form.Location = new Point(x, y);
    }

    public static void ListForm(Panel panel, enLists Lists = enLists.Planned)
    {
        ListViewForm listVievForm = new ListViewForm(Lists);
        Common.ShowForm(listVievForm, panel);
    }


    private static string connectionString = "Server=.;Database=ToDoListAppDB;User" +
               " Id=sa;Password=sa123456;";

    public static string ConnectionString()
    {
        return connectionString;
    }







   











}