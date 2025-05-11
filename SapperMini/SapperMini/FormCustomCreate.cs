using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapperMini
{
    public partial class FormCustomCreate : Form
    {
        private int freeZoneSquare = 10;
        public FormCustomCreate()
        {
            InitializeComponent();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBombs.Maximum = numericUpDownWidth.Value * numericUpDownHeight.Value - freeZoneSquare;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
