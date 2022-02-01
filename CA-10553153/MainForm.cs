using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_10553153
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddCom_Click(object sender, EventArgs e)
        {
            AddComForm addConForm = new AddComForm();
            addConForm.Show();
            this.Hide(); // hide mainform but it's still available.
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            AddResForm addResForm = new AddResForm();
            addResForm.Show();
            this.Hide(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
