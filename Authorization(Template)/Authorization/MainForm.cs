using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        string cmdReport1;
        SqlCommand cmdProcedureReport1;
        int UserId;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(int Id)
        {
            InitializeComponent();
            UserId = Id;
        }
       private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Authorization; Integrated Security = True; Connect Timeout=5";
                connection.Open();
                string sql = string.Format("SELECT LastName + ' '+ FirstName AS FIO FROM UsersInfo WHERE Id = '{0}'", UserId);

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["FIO"].ToString();
                }
                reader.Close();
                sql= string.Format("SELECT Login FROM Users WHERE Id = '{0}'", UserId);
                command.CommandText = sql;
                string Login = (string)command.ExecuteScalar();
                if (Login=="Admin")
                {
                    btnGo.Visible = true;
                    btnGo2.Visible = true;
                    btnGo3.Visible = true;
                    btnGo4.Visible = true;
                    btnReport3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    tbFrom.Visible = true;
                    tbLimit.Visible = true;
                    tbto.Visible = true;
                    lstReport1.Visible = true;
                    tbFrom.ForeColor = Color.LightGray;
                    tbFrom.Text = "dd.mm.yyyy hh:mm:ss";
                    tbto.ForeColor = Color.LightGray;
                    tbto.Text = "dd.mm.yyyy hh:mm:ss";
                    btnDelete.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Закрываем соединение
                connection.Close();
            }
   
        }
    
        private SqlDataReader ExecProcedure(string cmdReport1, SqlCommand cmdProcedureReport1)
        {
            SqlDataReader reader;
            cmdProcedureReport1.CommandText = cmdReport1;
            reader = cmdProcedureReport1.ExecuteReader();
            while (reader.Read())
            {
                String info = String.Format("{0,-14}|{1,-20}|{2,-20}|{3,-20}", reader[0], reader[1], reader[2], reader[3]);
                lstReport1.Items.Add(info);
            }
            reader.Close();
            return reader;
        }
        private SqlDataReader ExecProcedure2(string cmdReport1, SqlCommand cmdProcedureReport1)
        {
            SqlDataReader reader;
            cmdProcedureReport1.CommandText = cmdReport1;
            reader = cmdProcedureReport1.ExecuteReader();
            while (reader.Read())
            {
                String info = String.Format("{0,-14}|{1,-14}|{2,-20}|{3,-20}|{4,-20}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                lstReport1.Items.Add(info);
            }
            reader.Close();
            return reader;
        }
        private SqlDataReader ExecProcedure3(string cmdReport1, SqlCommand cmdProcedureReport1)
        {
            SqlDataReader reader;
            cmdProcedureReport1.CommandText = cmdReport1;
            reader = cmdProcedureReport1.ExecuteReader();
            while (reader.Read())
            {
                String info = String.Format("{0,-14}|{1,-14}|{2,-20}", reader[0], reader[1], reader[2]);
                lstReport1.Items.Add(info);
            }
            reader.Close();
            return reader;
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                tbLimit.Enabled = false;
                cmdReport1 = @"Report1";
                CreateConnect(out connection, cmdReport1, out cmdProcedureReport1);
                // Выполнение хранимых процедур.
                string header = String.Format("{0,-10}|{1,-10}|{2,-10}|{3,-20}",
                                        "LastName", "FirstName", "ComputerName", "In System for the period (min)");
                lstReport1.Items.Clear();
                lstReport1.Items.Add(header);

                SqlDataReader reader = ExecProcedure(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report2";
                reader = ExecProcedure(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report3";
                reader = ExecProcedure(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report4";
                reader = ExecProcedure(cmdReport1, cmdProcedureReport1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnGo2_Click(object sender, EventArgs e)
        {
            try
            {
                tbLimit.Enabled = false;
                cmdReport1 = @"Report21";
                CreateConnect(out connection, cmdReport1, out cmdProcedureReport1);
                // Выполнение хранимых процедур.
                string header = String.Format("{0,-10}|{1,-10}|{2,-10}|{3,-10},|{4,-10}",
                                        "LastName", "FirstName", "BeginDate", "EndDate", "In System for the period(second)");
                lstReport1.Items.Clear();
                lstReport1.Items.Add(header);
                SqlDataReader reader = ExecProcedure2(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report22";
                reader = ExecProcedure2(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report23";
                reader = ExecProcedure2(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report24";
                reader = ExecProcedure2(cmdReport1, cmdProcedureReport1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            try
            {
                cmdReport1 = @"Report31";
                CreateConnect(out connection, cmdReport1, out cmdProcedureReport1);
                // Выполнение хранимых процедур.
                string header = String.Format("{0,-10}|{1,-10}|{2,-10}",
                                        "LastName", "FirstName", "In System (second)");
                lstReport1.Items.Clear();
                lstReport1.Items.Add(header);
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@paramLimit";      // имя параметра
                param3.SqlDbType = SqlDbType.Int;
                param3.Value = Int32.Parse(tbLimit.Text);
                cmdProcedureReport1.Parameters.Add(param3);     // добавление параметра в список параметров команды
                SqlDataReader reader = ExecProcedure3(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report32";
                reader = ExecProcedure3(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report33";
                reader = ExecProcedure3(cmdReport1, cmdProcedureReport1);
                cmdReport1 = @"Report34";
                reader = ExecProcedure3(cmdReport1, cmdProcedureReport1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnGo4_Click(object sender, EventArgs e)
        {
            try
            {
                tbLimit.Enabled = false;
                cmdReport1 = @"Report41";
                CreateConnect(out connection, cmdReport1, out cmdProcedureReport1);
                // Выполнение хранимых процедур.
                string header = String.Format("{0,-10}", "In System for the period all users(min)");
                lstReport1.Items.Clear();
                lstReport1.Items.Add(header);
                // Выходной параметр.
                SqlParameter param4 = new SqlParameter();
                param4 = new SqlParameter();
                param4.ParameterName = "@sum";
                param4.SqlDbType = SqlDbType.Int;
                param4.Direction = ParameterDirection.Output; // направление действия каждого параметра
                cmdProcedureReport1.Parameters.Add(param4);

                // Выполнение хранимой процедуры.
                cmdProcedureReport1.ExecuteNonQuery();
                // Возврат выходного параметра.
                String info = String.Format("{0,-10}", cmdProcedureReport1.Parameters["@sum"].Value.ToString());
                lstReport1.Items.Add(info);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        private void btnReport3_Click(object sender, EventArgs e)
        {
            tbLimit.Enabled = true;
            tbLimit.ForeColor = Color.LightGray;
            tbLimit.Text = "sssss";

        }
        private void CreateConnect(out SqlConnection connection, string cmdReport1, out SqlCommand cmdProcedureReport1)
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Authorization;Integrated Security=True";
            connection.Open();

            cmdProcedureReport1 = new SqlCommand(cmdReport1, connection);
            // Изменение типа на StoredProcedure (по умолчанию оператор SQL)
            cmdProcedureReport1.CommandType = CommandType.StoredProcedure;

            // Входной параметр.
            SqlParameter param1 = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            param1.ParameterName = "@paramFrom";      // имя параметра
            param2.ParameterName = "@paramTo";
            param1.SqlDbType = SqlDbType.DateTime;      // тип параметра
            param2.SqlDbType = SqlDbType.DateTime;
            param1.Value = DateTime.Parse(tbFrom.Text);
            param2.Value = DateTime.Parse(tbto.Text);  // значение параметра
            cmdProcedureReport1.Parameters.Add(param1);     // добавление параметра в список параметров команды
            cmdProcedureReport1.Parameters.Add(param2);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUsersForm delForm = new DeleteUsersForm(tbFrom.Text,tbto.Text);
            delForm.ShowDialog();
           
        }
    }
}
