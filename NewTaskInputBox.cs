using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOList2
{
    public partial class NewTaskInputBox : Form
    {
        ListBox Maneg;
        public NewTaskInputBox(ListBox set)
        {
            InitializeComponent();
            Maneg = set;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            string title = TitleTB.Text;
            string desc = DescTB.Text;
            Tasks tarea = new Tasks(title, desc, false);
            Maneg.Items.Add(tarea);
            SQL.sqlqueue.Enqueue("Insert into Tasks values('" + tarea.title + "', '" + tarea.description + "', " + 0 + ")");

            this.Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
