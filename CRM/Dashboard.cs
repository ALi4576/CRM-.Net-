using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 62)
            {
                panel1.Visible = false;
                panel1.Width = 180;
                bunifuImageButton1.Location = new Point(130, 25);
                bunifuTransition1.ShowSync(panel1);
            }
            else 
            {
                panel1.Visible = false;
                panel1.Width = 62;
                bunifuImageButton1.Location = new Point(12, 25);
                bunifuTransition1.ShowSync(panel1);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
