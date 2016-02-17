using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database
{
    public partial class AddChangeForm : Form
    {
        public int iIdRecord { get; set; }
        public AddChangeForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {

        }
    }
}
