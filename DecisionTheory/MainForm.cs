using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTheory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var npTheoryFrom = new NPTheoryForm();
            npTheoryFrom.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var sTheoryFrom = new STheoryForm();
            sTheoryFrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var npTheoryFrom = new NPPracticeForm();
            npTheoryFrom.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sTheoryFrom = new SPracticeForm();
            sTheoryFrom.Show();
            this.Hide();
        }
    }
}
