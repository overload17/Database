using System;
using System.Windows.Forms;

namespace Database
{
    public partial class fDelete : Form
    {
        public fMain mv;
        public IPersonDAO pd;

        public fDelete()
        {
            InitializeComponent();
        }

        public Person P { get; set; }

        private void btnYes_Click(object sender, EventArgs e)
        {
            pd.Initialize();
            pd.Delete(P);
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}