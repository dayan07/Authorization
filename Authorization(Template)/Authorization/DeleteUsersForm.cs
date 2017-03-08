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
    public partial class DeleteUsersForm : Form
    {

        SqlConnection connection;
        string From;
        string To;
        SqlParameter param1, param2;
        public DeleteUsersForm(string from, string to)
        {
            InitializeComponent();
            From = from;
            To = to;
        }

        private void DeleteUsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                CreateConnection();
                string cmdForDelete = @"ForDelete";
                SqlCommand cmdProcedureReport1 = new SqlCommand(cmdForDelete, connection);
                // Изменение типа на StoredProcedure (по умолчанию оператор SQL)
                cmdProcedureReport1.CommandType = CommandType.StoredProcedure;
                // Входной параметр.
                param1 = new SqlParameter();
                param2 = new SqlParameter();
                param1.ParameterName = "@paramFrom";      // имя параметра
                param2.ParameterName = "@paramTo";
                param1.SqlDbType = SqlDbType.DateTime;      // тип параметра
                param2.SqlDbType = SqlDbType.DateTime;
                param1.Value = DateTime.Parse(From);
                param2.Value = DateTime.Parse(To);  // значение параметра
                cmdProcedureReport1.Parameters.Add(param1);     // добавление параметра в список параметров команды
                cmdProcedureReport1.Parameters.Add(param2);
                SqlParameter param3 = new SqlParameter();
                param3 = new SqlParameter();
                param3.ParameterName = "@counter";
                param3.SqlDbType = SqlDbType.Int;
                param3.Direction = ParameterDirection.Output; // направление действия каждого параметра
                cmdProcedureReport1.Parameters.Add(param3);
                string header = String.Format("{0,-10}", "In System for the period not behind (login)");
                listBox1.Items.Clear();
                listBox1.Items.Add(header);
                // Выполнение хранимой процедуры.
                cmdProcedureReport1.ExecuteNonQuery();
                // Возврат выходного параметра.
                String info = String.Format("{0,-10}", cmdProcedureReport1.Parameters["@counter"].Value.ToString());
                lbcountUsers.Text = info;
                SqlDataReader reader = cmdProcedureReport1.ExecuteReader();

                while (reader.Read())
                {
                    info = String.Format("{0,-10}", reader[0]);
                    listBox1.Items.Add(info);
                }
                reader.Close();
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

        private void CreateConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Authorization;Integrated Security=True";
            connection.Open();
        }

        private void btnYesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnection();
                SqlCommand cmdProcedureReport1 = YesNoTransaction(1);//транзакция реализована в хранимой процедуре, при передаче 1 COMMIT
                // Выполнение хранимой процедуры.
                cmdProcedureReport1.ExecuteNonQuery();
                MessageBox.Show("Пользователи удалены!!!");

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
    

        private SqlCommand YesNoTransaction(int param)
        {
            string cmdDelete = @"TransDelete";
            SqlCommand cmdProcedureReport1 = new SqlCommand(cmdDelete, connection);
            // Изменение типа на StoredProcedure (по умолчанию оператор SQL)
            cmdProcedureReport1.CommandType = CommandType.StoredProcedure;
            // Входной параметр.
            param1 = new SqlParameter();
            param2 = new SqlParameter();
            param1.ParameterName = "@paramFrom";      // имя параметра
            param2.ParameterName = "@paramTo";
            param1.SqlDbType = SqlDbType.DateTime;      // тип параметра
            param2.SqlDbType = SqlDbType.DateTime;
            param1.Value = DateTime.Parse(From);
            param2.Value = DateTime.Parse(To);  // значение параметра
            cmdProcedureReport1.Parameters.Add(param1);     // добавление параметра в список параметров команды
            cmdProcedureReport1.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter();
            param3 = new SqlParameter();
            param3.ParameterName = "@YesNo";
            param3.SqlDbType = SqlDbType.Bit;
            param3.Value = param;
            cmdProcedureReport1.Parameters.Add(param3);
            return cmdProcedureReport1;
        }

        private void btnNoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnection();
                SqlCommand cmdProcedureReport1 = YesNoTransaction(0);//транзакция реализована в хранимой процедуре, при передаче 1 ROLLBACK
                // Выполнение хранимой процедуры.
                int rows=cmdProcedureReport1.ExecuteNonQuery();
                if (rows==0)
                {
                    MessageBox.Show("Операция отменена пользователем!!!");
                }
                
            }
            
             catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            // Закрываем соединение
            connection.Close();
        }

    
}
       
    }
}
