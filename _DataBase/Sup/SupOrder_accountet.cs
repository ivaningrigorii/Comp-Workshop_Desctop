using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    public partial class SupOrder_accountet : Form
    {
        StatemenT _st = new StatemenT();
        Supplier _sp = new Supplier();
        public SupOrder_accountet()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            _sp.refreshNeedGoodsTalbe(dataGridView1);
            _sp.refreshTalbeAllModels(dataGridView2, tbCategory.Text);

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            _sp.refreshCompanies(comboBox1);
            textBox1.Text = "Оптовая цена";
            textBox2.Text = "Количество";
            textBox3.Text = "Время доставки";
        }

        private void toolStripMenuItem_tools_Click(object sender, EventArgs e)
        {

        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e) => SwitcherBeatweener.roleShower.startPage(this);

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e) => WindowSwither.return_(this);

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _sp.sendQuerToSup(_sp.getIdCompany(comboBox1.Text), Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

                MessageBox.Show("Запрос успешно направлен\n к поставщику товаров!");
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Операция невозможна!");
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Новый товар выбран!");
            textBox3.Text = _sp.getAvgTimeOfSupOneGood(
                Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString())).ToString();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbCategory.Text = "";
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
