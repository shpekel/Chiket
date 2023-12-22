using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiket
{
    public partial class Form2 : Form
    {
        private int _fullname;
        public Form2(int fullname)
        {
            InitializeComponent();
            _fullname = fullname;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demEkzDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.demEkzDataSet.Request);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main(_fullname);
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем все изменения в базе данных
                this.requestTableAdapter.Update(this.demEkzDataSet.Request);

                MessageBox.Show("Изменения сохранены успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
