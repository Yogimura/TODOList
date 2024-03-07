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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            NewTaskInputBox values = new NewTaskInputBox(TaskList);
            
            values.Show();
        }

        private void DelBTN_Click(object sender, EventArgs e)
        {
            Tasks tarea = TaskList.SelectedItem as Tasks;
            DialogResult sl = MessageBox.Show("Quiere eliminar la tarea " + tarea.ToString(), "Advertencia", MessageBoxButtons.OKCancel);

            if (sl == DialogResult.OK)
            {
                SQL.sqlqueue.Enqueue("delete from tasks where ID = " + tarea.id);
                TaskList.Items.Remove(TaskList.SelectedItem);
            }
            
        }

        private void TaskList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (DoneCK.Checked == true)
            {
                Tasks tarea = TaskList.SelectedItem as Tasks;
                if (tarea != null)
                {
                    tarea.enable = tarea.enable == true ? false : true;
                    if (tarea.enable == true)
                    {
                        SQL.sqlqueue.Enqueue("update tasks set Estado = " + 1);
                    }
                    else
                    {
                        SQL.sqlqueue.Enqueue("update tasks set Estado = " + 0);
                    }
                    TaskList.Items.Remove(tarea);
                    TaskList.Items.Add(tarea);
                }
            }
        }

        private void TaskList_Click(object sender, EventArgs e)
        {

        }

        private void TaskList_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void TaskList_DrawItem(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            
                DialogResult sl = MessageBox.Show("Quiere Guardar todos los cambios?", "Advertencia", MessageBoxButtons.OKCancel);

                if (sl == DialogResult.OK)
                {
                    SQL save = new SQL("Vladi", "TODO");
                    SQL.guardar();
                }
            
        }

        private void LoadBTN_Click(object sender, EventArgs e)
        {
            DialogResult sl = MessageBox.Show("Quiere cargar las tareas?", "Advertencia", MessageBoxButtons.OKCancel);
            if(sl == DialogResult.OK)
            {
                SQL save = new SQL("Vladi", "TODO");
                SQL.cargar(TaskList);
            }
        }
    }
}
