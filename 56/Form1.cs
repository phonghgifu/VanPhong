using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56
{
    public partial class rdNu : Form
    {
        public rdNu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdNam.Checked) MessageBox.Show("Giới tính bạn là:" + rdNam.Text);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked) MessageBox.Show("Giới tính bạn là:" + radioButton2.Text);
        }
    }
}

