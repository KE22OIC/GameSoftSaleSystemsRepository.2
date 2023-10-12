using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoftSaleSystems
{
    public partial class FormSubscription : Form
    {
        public FormSubscription()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Text = cb.Checked ? "✓" : "";
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Text = cb.Checked ? "✓" : "";
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Text = cb.Checked ? "✓" : "";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Text = cb.Checked ? "✓" : "";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Text = cb.Checked ? "✓" : "";
        }

        private void FormSubscription_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}
