using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list
{
    public partial class Form2 : Form
    {
        Form1 Parent; 
        public Form2(Form1 form)
        {
            InitializeComponent();
            Parent = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            byte counter = 0;

            int index = Convert.ToInt32(text_number.Text) - 1;

            if (index >= 0 )
            {

                string [] data = Parent.get_all_data_from_file();

                string[] new_arr = new string[data.Length - 1]; 

                if(data.Length < index + 1)
                {
                    return; 
                }

                for(byte i = 0; i < data.Length; i++)
                {
                    if (i != index)
                    {
                        new_arr[counter] = data[i];
                        counter++;
                    }
                }

                File.WriteAllLines("tasks.txt", new_arr);
                this.Close();
            }
        }

    }
}
