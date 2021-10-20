using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ип_2048
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bRowsUp_Click(object sender, EventArgs e)
        {
            //текущие количество строк
            int n = Convert.ToInt32(lRows.Text);
            //если n<8 то
            if (n < 8)
            {
                // увеличиваем n на 1
                n++;
                lRows.Text = n.ToString();
               
            }
        }

        private void bRowsDown_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lRows.Text);
            if (n > 3)
            {
                n--;
                lRows.Text = n.ToString();
            }
        }

        private void bColUp_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lColumns.Text);
            if (n < 8)
            {
                n++;
                lColumns.Text = n.ToString();
            }
        }

        private void bColDown_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lColumns.Text);
            if (n > 3)
            {
                n--;
                lColumns.Text = n.ToString();
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            //закрываетмодальное окно с резулбтатом диалог результат
            this.DialogResult = DialogResult.OK;
        }
    }
}
