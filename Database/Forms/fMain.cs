using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Database.Forms;

namespace Database
{
    public partial class fMain : Form
    {
        private readonly IPersonDAO pd = DSFactory.getInstance("MSSQL");

        public fMain()
        {
            InitializeComponent();
            pd.Initialize();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            grid.Columns.Add("id", "id");
            grid.Columns.Add("lname", "lname");
            grid.Columns.Add("fname", "fname");
            grid.Columns.Add("age", "age");
            var btn1 = new DataGridViewButtonColumn();
            btn1.Text = "edit";
            btn1.Name = "btnEdit";
            btn1.UseColumnTextForButtonValue = true;
            grid.Columns.Add(btn1);
            var btn2 = new DataGridViewButtonColumn();
            btn2.Text = "delete";
            btn2.Name = "btnDelete";
            btn2.UseColumnTextForButtonValue = true;
            grid.Columns.Add(btn2);
            ShowData(pd.Read());
        }

        public void ShowData(List<Person> ps)
        {
            grid.Rows.Clear();
            foreach (var p in ps)
            {
                object[] row = {p.Id.ToString(), p.Fname, p.Lname, p.Age.ToString()};
                grid.Rows.Add(row);
            }
            grid.Refresh();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var id = int.Parse(grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                var lname = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                var fname = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                var age = int.Parse(grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                var p = new Person(id, lname, fname, age);
                var formEdit = new fEdit();
                formEdit.P = p;
                formEdit.pd = pd;
                formEdit.mv = this;
                formEdit.ShowDialog();
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    var id = int.Parse(grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var lname = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var fname = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var age = int.Parse(grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    var p = new Person(id, lname, fname, age);
                    var formDelete = new fDelete();
                    formDelete.P = p;
                    formDelete.pd = pd;
                    formDelete.mv = this;
                    formDelete.ShowDialog();
                }
            }
            ShowData(pd.Read());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new fAdd();
            formAdd.pd = pd;
            formAdd.mv = this;
            formAdd.ShowDialog();
            ShowData(pd.Read());
        }
    }
}