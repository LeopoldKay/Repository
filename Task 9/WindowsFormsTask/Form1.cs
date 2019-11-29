using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToSqlTask;
 

namespace WindowsFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataContext dataConext = new DataContext(ConfigurationManager.ConnectionStrings["WinFormContext"].ToString());
            dataConext.GetTable<Director>().InsertOnSubmit(new LinqToSqlTask.Director()
            { FirstName = textBox1.Text, LastName = textBox2.Text, BirthDate = DateTime.Parse(textBox3.Text) });
            dataConext.SubmitChanges();

        }
    }
}
