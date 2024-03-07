using System;
using System.Drawing;
using System.Windows.Forms;

namespace TODOList2
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoadBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.DelBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.DoneCK = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor de tareas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.DoneCK);
            this.panel2.Controls.Add(this.TaskList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 293);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tareas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.LoadBTN);
            this.panel3.Controls.Add(this.SaveBTN);
            this.panel3.Controls.Add(this.DelBTN);
            this.panel3.Controls.Add(this.AddBTN);
            this.panel3.Location = new System.Drawing.Point(1006, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 291);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // LoadBTN
            // 
            this.LoadBTN.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.LoadBTN.Location = new System.Drawing.Point(19, 215);
            this.LoadBTN.Name = "LoadBTN";
            this.LoadBTN.Size = new System.Drawing.Size(137, 64);
            this.LoadBTN.TabIndex = 3;
            this.LoadBTN.Text = "Cargar";
            this.LoadBTN.UseVisualStyleBackColor = true;
            this.LoadBTN.Click += new System.EventHandler(this.LoadBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.SaveBTN.Location = new System.Drawing.Point(19, 146);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(137, 64);
            this.SaveBTN.TabIndex = 2;
            this.SaveBTN.Text = "Guardar todo";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // DelBTN
            // 
            this.DelBTN.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.DelBTN.Location = new System.Drawing.Point(19, 76);
            this.DelBTN.Name = "DelBTN";
            this.DelBTN.Size = new System.Drawing.Size(137, 64);
            this.DelBTN.TabIndex = 1;
            this.DelBTN.Text = "Eliminar tarea";
            this.DelBTN.UseVisualStyleBackColor = true;
            this.DelBTN.Click += new System.EventHandler(this.DelBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.AddBTN.Location = new System.Drawing.Point(19, 7);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(137, 64);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Agregar tarea";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // TaskList
            // 
            this.TaskList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 19;
            this.TaskList.Location = new System.Drawing.Point(3, 42);
            this.TaskList.MultiColumn = true;
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(976, 251);
            this.TaskList.Sorted = true;
            this.TaskList.TabIndex = 1;
            this.TaskList.Click += new System.EventHandler(this.TaskList_DrawItem);
            this.TaskList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TaskList_DrawItem);
            this.TaskList.SelectedIndexChanged += new System.EventHandler(this.TaskList_SelectedIndexChanged_1);
            // 
            // DoneCK
            // 
            this.DoneCK.AutoSize = true;
            this.DoneCK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneCK.Location = new System.Drawing.Point(82, 7);
            this.DoneCK.Name = "DoneCK";
            this.DoneCK.Size = new System.Drawing.Size(352, 27);
            this.DoneCK.TabIndex = 2;
            this.DoneCK.Text = "Marcar/Desmarcar tareas completadas";
            this.DoneCK.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 341);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Gestor de tareas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button DelBTN;
        private Button AddBTN;
        private Button LoadBTN;
        private Button SaveBTN;
        private ListBox TaskList;
        private CheckBox DoneCK;
    }
}