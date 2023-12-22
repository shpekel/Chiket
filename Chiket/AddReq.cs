using System;
using System.CodeDom.Compiler;
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
    public partial class AddReq : Form
    {
        private int _fullname;
        public AddReq(int fullname)
        {
            InitializeComponent();
            _fullname = fullname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
            {
                
               try
                {
                    connection.Open();

                    string query = "INSERT INTO Request (responsible, hardware, type, description, executor, comment) " +
                                   "VALUES (@Responsible, @Hardware, @Type, @Description, @Executor, @Comments)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Используйте параметры для избежания SQL-инъекций
                        command.Parameters.AddWithValue("@Responsible", Responsible.Text);
                        command.Parameters.AddWithValue("@Hardware", Hardware.Text);
                        command.Parameters.AddWithValue("@Type", Type.Text);
                        command.Parameters.AddWithValue("@Description", Description.Text);
                        command.Parameters.AddWithValue("@Executor", _fullname);
                        command.Parameters.AddWithValue("@Comments", Comments.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные успешно добавлены");
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при добавлении данных");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main(_fullname);
            main.Show();
            this.Hide();
        }
    }
}
