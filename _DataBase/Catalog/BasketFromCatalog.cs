using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.Catalog
{
    public partial class BasketFromCatalog : Form
    {
        int _idStatement;
        StatemenT _st;
        public BasketFromCatalog( int id)
        {
            InitializeComponent();

            _idStatement = id;
            _st = new StatemenT();

            Clear();
            textBox2.Text = "НОМЕР ЗАКАЗА: " + _idStatement;
        }

        public void Clear()
        {
            tbModel.Text = "";
            _st.refreshTableAboutStatment(_idStatement, dataGridView1);
            textBox1.Text = "ОБЩАЯ СУММА ЗАКАЗА: " + _st.getSumStat(_idStatement).ToString();
            dataGridView1.ClearSelection();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            try
            {
                int nmbSelect = dataGridView1.CurrentCell.RowIndex;

                if (!tbModel.Text.Equals(""))
                {
                    _st.updateQuanInOrdered(Convert.ToInt32(dataGridView1.Rows[nmbSelect].Cells[0].Value.ToString()), 
                        Convert.ToInt32(tbModel.Text));
                    Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы неверно ввели значения!");
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int nmbSelect = dataGridView1.CurrentCell.RowIndex;
                tbModel.Text = dataGridView1.Rows[nmbSelect].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Операция невозможна!");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int nmbSelect = dataGridView1.CurrentCell.RowIndex;

                if (!tbModel.Text.Equals(""))
                {
                    _st.dellGoodFromStatment(Convert.ToInt32(dataGridView1.Rows[nmbSelect].Cells[0].Value.ToString()));
                    Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы неверно ввели значения!");

            }
        }
    }
}
