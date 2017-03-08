using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class PasswordForm : Form
    {
      
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbNewPas.Text;
            string newpassword= tbNewPas2.Text;
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Authorization; Integrated Security = True; Connect Timeout=5";
                connection.Open();
               string sql = string.Format("SELECT Id FROM Users WHERE Email = '{0}'", email);
              
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == false)
                {
                    MessageBox.Show("Пользователь с таким email не зарегистрирован в системе!!!");
                }
                else if (newpassword != password)
                {
                    MessageBox.Show("Введенные пароли не совпадают!!!");
                }
                else if (password.Length < 6)
                {
                    MessageBox.Show("Пароль не может составлять меньше 6 символом!!!");
                }
                else
                {
                    reader.Close();
                 sql = string.Format("UPDATE Users SET Password = '{0}' WHERE Id IN(SELECT Id FROM Users WHERE Email = '{1}')", password, email);
                   command.CommandText = sql;
                   int CountRow = command.ExecuteNonQuery();
                        if (CountRow == 1)
                        {
                            MessageBox.Show("Пароль был изменён!!!");
                        }
                        else
                        {
                            MessageBox.Show("Пароль не был изменён!!!");
                        }
                        
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Закрываем соединение
                connection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
