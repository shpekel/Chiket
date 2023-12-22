using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiket
{
    public partial class Main : Form
    {
        private  int _fullname;
        public Main(int fullname)
        {
            InitializeComponent();
            _fullname = fullname;
        }

        

        private void AddReq_Click(object sender, EventArgs e)
        {
            AddReq form = new AddReq(_fullname);
            form.Show();
            this.Hide();
        }

        private void CheckReq_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(_fullname);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
