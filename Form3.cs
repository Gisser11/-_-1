using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "student20DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.student20DataSet.Студенты);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn clickedColumn = null;
            

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    clickedColumn = dataGridView1.Columns[0];
                    break;
                case 1:
                    clickedColumn = dataGridView1.Columns[1];
                    break;
                case 2:
                    clickedColumn = dataGridView1.Columns[2];
                    break;
            }

            if (clickedColumn != null)
            {
                if (radioButton1.Checked)
                {
                    dataGridView1.Sort(clickedColumn, ListSortDirection.Ascending);
                }
                else
                {
                    dataGridView1.Sort(clickedColumn, ListSortDirection.Descending);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "ФИО='" + this.comboBox1.Text + "'";

            var __ = студентыBindingSource.Filter = "ФИО='" + this.comboBox1.Text + "'";
            Console.WriteLine(__);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int i = 0;
                int j = 0;
                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                };
                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        { break; }
                        if (textBox1.Text == dataGridView1.Rows[i].Cells[j].Value.ToString())
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.AliceBlue;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        }
                    }
                };
            }

        }
    }
}
