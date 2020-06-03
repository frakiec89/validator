using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        EMailList eMail;

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            eMail = new EMailList();
            dataGridView1.DataSource = eMail.EMails;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                eMail.Add(textBoxValue.Text);
                Start();
            }
            catch
            {
                MessageBox.Show("Неверный  емай");
                return;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            eMail.ClearAll();
            Start();
        }

       
    }
}
