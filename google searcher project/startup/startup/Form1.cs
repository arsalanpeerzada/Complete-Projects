using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace startup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"newfile.txt";

            if (checkBox1.Checked == true)
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("https://www.google.com.pk/#q=" + txtSearch.Text, path);
            }
            else
            {
                WebClient Client1 = new WebClient();
                Client1.DownloadFile("https://www." + txtSearch.Text, path);
            }

            string[] data = File.ReadAllLines(path);

            foreach (string item in data)
            {
                string[] Trim = item.Split(new[] { '=', ' ', '\"', }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Trim.Length; i++)
                {
                    if (Trim[i] == "href")
                    {
                        dataGridView1.Rows.Add(Trim[i + 1]);
                        //Console.WriteLine(Trim[i + 1]);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            MessageBox.Show(dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString(),"Result");
        }
    }
}

        
       

        

        

        

        

       

       

       

        
    }
}
