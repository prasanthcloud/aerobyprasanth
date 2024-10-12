using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDPROJECT2
{
    public partial class Mainpage : UserControl
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adminlogin mainForm = new Adminlogin();
            mainForm.Show();

            Visible = false;

        }
    }
}
