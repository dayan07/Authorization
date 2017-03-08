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
    public partial class AutorizForm : Form
    {
        string userName;
        string password;
        int Id;
        public AutorizForm()
        {
            InitializeComponent();
        }

        void tbPassword_GotFocus(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Пароль")
            {
                tbPassword.ForeColor = Color.Black;
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
            }
        }

        void tbPassword_LostFocus(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length == 0)
            {
                tbPassword.ForeColor = Color.LightGray;
                tbPassword.Text = "Пароль";
                tbPassword.PasswordChar ='\0';
            }
        }

        void tbName_LostFocus(object sender, EventArgs e)
        {
            if (tbName.Text.Length==0)
           {
            tbName.ForeColor = Color.LightGray;
            tbName.Text = "Имя пользователя";
           }
        }

        void tbName_GotFocus(object sender, EventArgs e)
        {
            if (tbName.Text == "Имя пользователя")
            {
                tbName.ForeColor = Color.Black;
                tbName.Text = "";
            }
        }      

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForm frmPass = new PasswordForm();
            frmPass.ShowDialog();
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrForm frmReg = new RegistrForm();
            frmReg.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            userName = tbName.Text;
            password = tbPassword.Text;
            prbControl.Visible = true;
            lbContol.Visible = true;
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Authorization; Integrated Security = True; Connect Timeout=5";
                connection.Open();
                string sql = string.Format("SELECT Id FROM Users WHERE Login = '{0}' AND Password='{1}'", userName, password);
                
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == false)
                    {
                    lbError.Visible = true;
                    prbControl.Visible = false;
                    lbContol.Visible = false;
                }
                else
                {
                    lbError.Visible = false;
                       
                    prbControl.Visible = false;
                    lbContol.Visible = false;
                    Id = Convert.ToInt32(reader["Id"]);
                    reader.Close();
                    MainForm mnForm = new MainForm(Id);
                    mnForm.ShowDialog();
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
        }
    }


