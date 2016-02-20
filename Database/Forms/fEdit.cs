using System;
using System.Windows.Forms;

namespace Database
{
    public partial class fEdit : Form
    {
        public fMain mv;
        private Person p;
        public IPersonDAO pd;

        public fEdit()
        {
            InitializeComponent();
        }

        public Person P
        {
            get { return p; }
            set
            {
                p = value;
                edtName.Text = p.Fname;
                edtLname.Text = p.Lname;
                edtAge.Text = p.Age.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            p.Lname = edtLname.Text;
            p.Fname = edtName.Text;
            p.Age = Convert.ToInt32(edtAge.Text);
            pd.Initialize();
            pd.Update(p);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}