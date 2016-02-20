using System.Collections.Generic;
using System.Windows.Forms;

namespace Database
{
    public partial class fMain : Form
    {
        private readonly IPersonDAO ds = DSFactory.getInstance("MSSQL");

        public fMain()
        {
            InitializeComponent();
            ds.Initialize();
            setDataGridView();
        }

        private void setDataGridView()
        {
            grid.Columns.Add("id", "id");
            grid.Columns.Add("lname", "lname");
            grid.Columns.Add("fname", "fname");
            grid.Columns.Add("age", "age");
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.Text = "edit";
            btn1.Name = "btnEdit";
            btn1.UseColumnTextForButtonValue = true;
            grid.Columns.Add(btn1);
            showData(ds.Read());
        }

        public void showData(List<Person> ps)
        {
            grid.Rows.Clear();
            foreach (var p in ps)
            {
                string[] row = {p.Id.ToString(), p.Fname, p.Lname, p.Age.ToString()};
                grid.Rows.Add(row);
            }
            grid.Refresh();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                    int id = int.Parse(grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string lname = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string fname = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int age = int.Parse(grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Person p = new Person(id, lname, fname, age);
                    fEdit formEdit = new fEdit();
                    formEdit.ShowDialog();
            }
        }
    }
}