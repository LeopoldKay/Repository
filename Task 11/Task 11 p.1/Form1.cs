using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_11_p._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            var file = new FileInfo(@"C:\Study\ShowFileInfo.txt");

            if (file.Exists)
            {
                using (FileStream stream = new FileStream(@"C:\Study\ShowFileInfo.txt", FileMode.Open))
                {

                    var dir = await JsonSerializer.DeserializeAsync<List<Character>>(stream);

                    List<string[]> data = new List<string[]>();

                    foreach (var i in dir)
                    {
                        data.Add(new string[3]);
                        data[data.Count - 1][0] = i.FirstName;
                        data[data.Count - 1][1] = i.LastName;
                        data[data.Count - 1][2] = i.BirthDate.ToString();

                    }

                    foreach (var i in data)
                        dataGridView1.Rows.Add(i);

                }
            }

        }


        private async void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Character> dir = new List<Character>();

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[0].Value != null)
                    dir.Add(new Character() { FirstName = Convert.ToString(dr.Cells[0].Value), LastName = Convert.ToString(dr.Cells[1].Value), BirthDate = Convert.ToDateTime(dr.Cells[2].Value) });
            }

            using (FileStream stream = new FileStream(@"C:\Study\ShowFileInfo.txt", FileMode.OpenOrCreate))
            {

                await JsonSerializer.SerializeAsync(stream, dir);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newDir = new Character() { FirstName = textBox1.Text, LastName = textBox2.Text, BirthDate = Convert.ToDateTime(textBox3.Text) };

            string[] data = new string[3];
            data[0] = newDir.FirstName;
            data[1] = newDir.LastName;
            data[2] = newDir.BirthDate.ToString();

            dataGridView1.Rows.Add(data);

        }
    }
}
