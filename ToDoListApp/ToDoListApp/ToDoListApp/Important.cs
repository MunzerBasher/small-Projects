﻿using System;
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
    public partial class Important : Form
    {
        public Important()
        {
            InitializeComponent();
        }

 

        private void Important_Load(object sender, EventArgs e)
        {
            Common.ListForm(panel1,Common.enLists.Important);
        }
    }
}
