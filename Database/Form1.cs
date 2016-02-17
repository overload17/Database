using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database
{
    public partial class Form1 : Form
    {
        private MySqlConnection _connection;
        private string _database;
        private MySqlDataAdapter _mySqlDataAdapter;
        private string _password;
        private string _server;
        private string _uid;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _server = "localhost";
            _database = "people";
            _uid = "root";
            _password = "root";
            string connectionString;
            connectionString = "SERVER=" + _server + ";" + "DATABASE=" + _database + ";" + "UID=" + _uid + ";" +
                               "PASSWORD=" + _password + ";";

            _connection = new MySqlConnection(connectionString);

            if (OpenConnection())
            {
                _mySqlDataAdapter = new MySqlDataAdapter("select * from book", _connection);
                var ds = new DataSet();
                _mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                CloseConnection();
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            var changes = ((DataTable) dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                _mySqlDataAdapter = new MySqlDataAdapter("select * from book", _connection);
                var mcb = new MySqlCommandBuilder(_mySqlDataAdapter);
                _mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                _mySqlDataAdapter.Update(changes);
                ((DataTable) dataGridView1.DataSource).AcceptChanges();
            }
        }

        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}