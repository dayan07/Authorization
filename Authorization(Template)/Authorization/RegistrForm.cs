using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class RegistrForm : Form
    {

     
        public RegistrForm()
        {
            InitializeComponent();
         
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            string email = tbEmail.Text;
            string password = tbPas.Text;
            string newpassword = tbPas2.Text;
            string login = tbLogin.Text;
            string surname = tbSurName.Text;
            string name = tbName.Text;

            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Authorization; Integrated Security = True; Connect Timeout=5";
                connection.Open();
                string sql= string.Format("SELECT Id FROM Users WHERE Login = '{0}'", login);
                string sql2 = string.Format("INSERT INTO Users (Login,Password,Email) VALUES ('{0}', '{1}', '{2}')", login, password, email);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
               
                    if (newpassword != password)
                {
                    MessageBox.Show("Введенные пароли не совпадают!!!");
                }
                else if (password.Length<6)
                {
                    MessageBox.Show("Пароль не может составлять меньше 6 символом!!!");
                }
                else if (reader.Read()==true)
                {
                    MessageBox.Show("Такой логин уже имеется в системе!!!");
                }
                else if (String.IsNullOrEmpty(password)|| String.IsNullOrEmpty(newpassword)|| String.IsNullOrEmpty(login)|| String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Поля, отмеченные звездочкой, обязательны для заполнения!!!");
                }
                else
                {
                    reader.Close();
                    command.CommandText = sql2;
                    int CountRow = command.ExecuteNonQuery();
                    sql2 = string.Format("INSERT INTO UsersInfo(Id, LastName, FirstName, Code) VALUES(@@identity, '{0}', '{1}',56789)", name, surname);
                    command.CommandText = sql2;
                    int CountRow2 = command.ExecuteNonQuery();
                    if (CountRow == 1 && CountRow2 == 1)
                    {
                        MessageBox.Show("Пользователь создан!!!");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не был создан!!!");

                    }

                }

            }
            catch (SqlException ex)
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
