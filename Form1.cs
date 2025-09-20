using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace to_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string file_name = "tasks.txt";

        public void add_to_file(string task , bool completed = false)
        {
            if(task == null || task ==  "")
            {
                MessageBox.Show("task is empty you didn't write nothing" , "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            task = task + '|' + completed.ToString();

            File.AppendAllText(file_name, task + Environment.NewLine);
        }
        public string[] get_all_data_from_file()
        {
            string[] data = File.ReadAllLines(file_name);

            if (data.Length < 1)
            {
                MessageBox.Show("you don't have any tasks", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return data; 
        }

        private void overwrite_file(string[] tasks)
        {
            File.WriteAllLines(file_name, tasks);
        }
        private (string, bool)[] split_record(string[] records)
        {
            (string, bool)[] Tasks = new (string, bool)[records.Length];

            for(short i = 0; i < records.Length; i++)
            {

                string[] cut_rec = records[i].Split('|');

                Tasks[i] = (cut_rec[0], Convert.ToBoolean(cut_rec[1]));
            }

            return Tasks;
        }
        private void btn_add_validate_Click(object sender, EventArgs e)
        {
            string task = input_add.Text;
            add_to_file(task);
            input_add.Text = "";
        }
        private void btn_all_tasks_Click(object sender, EventArgs e)
        {
            gp_add_task.Enabled = false;
            gp_add_task.Visible = false;

            checkedList.Items.Clear();

            string[] Records = get_all_data_from_file();

            (string, bool)[] Tasks = split_record(Records);


            if(Tasks.Length <= 0 )
            {
                gp_add_task.Enabled = true;
                gp_add_task.Visible = true;
                return;
            }            


            for(short i = 0; i < Tasks.Length; i++)
            {
                checkedList.Items.Add(Tasks[i].Item1, Tasks[i].Item2);
            }


            checkedList.Enabled = true;
            checkedList.Visible = true;
            checkedList2.Enabled = false;
            checkedList2.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            checkedList.Enabled = false;
            checkedList.Visible = false;
            checkedList2.Enabled = false;
            checkedList2.Visible = false;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            checkedList2.Enabled = false;
            checkedList2.Visible = false;
            checkedList.Enabled = false;
            checkedList.Visible = false;
            gp_add_task.Enabled = true;
            gp_add_task.Visible = true;
        }
        private void btn_completed_Click(object sender, EventArgs e)
        {
            gp_add_task.Enabled = false;
            gp_add_task.Visible = false;
            checkedList.Enabled = false;
            checkedList.Visible = false;


            checkedList2.Enabled = true;
            checkedList2.Visible = true;

            checkedList2.Items.Clear();



            if (checkedList.CheckedItems.Count > 0)
            {
                for(int i = 0; i < checkedList.Items.Count; i++)
                {
                    if (checkedList.GetItemChecked(i))
                    {
                        checkedList2.Items.Add(checkedList.Items[i]);
                    }
                }

                for (int i = 0; i < checkedList2.Items.Count; i++)
                {
                    checkedList2.SetItemChecked(i, true);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(this);
            checkedList2.Enabled = false;
            checkedList2.Visible = false;
            gp_add_task.Enabled = false;
            gp_add_task.Visible = false;
            checkedList.Enabled = false;
            checkedList.Visible = false;
            form2.ShowDialog();
        }

        private void save_tasks()
        {
            string[] tasks = new string[checkedList.Items.Count];

            for (short i = 0; i < checkedList.Items.Count; i++)
            {
                string text = checkedList.Items[i].ToString();
                bool isChecked = checkedList.GetItemChecked(i);
                tasks[i] = $"{text}|{isChecked}";
            }

            overwrite_file(tasks);
        }

        private void checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                save_tasks();
            });

        }

   
    }
}
