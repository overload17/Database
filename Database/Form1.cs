using System;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            AddChangeForm EditForm = new AddChangeForm();
            EditForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'peopleDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.peopleDataSet.book);

        }
    }
}
