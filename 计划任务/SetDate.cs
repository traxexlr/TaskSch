using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计划任务
{
    public partial class SetDate : Form
    {
        public SetDate()
        {
            InitializeComponent();
        }
        public int value { get; set; }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = comboBox1.SelectedIndex;
            this.Dispose();

            this.Close();
        }
    }
}
