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

namespace Chiket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            using (SqlConnection connection = new SqlConnection (Database.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    string Query = "SELECT * FROM Users WHERE login=" + LoginBox.Text + " AND password=" + PasswordBox.Text;
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Неверный логин или пароль");
                            }
                            else
                            {
                                int fullname = reader.GetInt32(0);
                                Main main = new Main(fullname);
                                main.Show();
                                this.Hide();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка подключения к серверу : " + ex.Message);
                }
            }
        }
    }
}
