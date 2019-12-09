using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12_p._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            LoadData1();
            LoadData2();

        }

        public async void LoadData1()
        {
           
            await Task.Run(() =>
            {
                //Thread.Sleep(5000);
                List<string[]> data = new List<string[]>();

                foreach (var i in new Task11Context().Directors)
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = i.FirstName;
                    data[data.Count - 1][1] = i.LastName;
                    data[data.Count - 1][2] = i.BirthDate.ToString();

                }

                foreach (var i in data)
                    dataGridView2.Rows.Add(i);
            });

        }

        public async void LoadData2()
        {

            
            await Task.Run(() =>
            {
                
                List<string[]> data = new List<string[]>();

                foreach (var i in new Task11Context().Characters)
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = i.Id.ToString();
                    data[data.Count - 1][1] = i.FirstName;
                    data[data.Count - 1][2] = i.LastName;
                    data[data.Count - 1][3] = i.Gender.ToString();
                    data[data.Count - 1][4] = i.Age.ToString();

                }

                foreach (var i in data)
                    dataGridView1.Rows.Add(i);
            });

        }
    }
}

