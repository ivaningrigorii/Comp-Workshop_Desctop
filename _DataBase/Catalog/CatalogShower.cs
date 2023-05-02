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
    public partial class CatalogShower : Form
    {
        int _idPerson;
        int _idStatment;
        CataloG _catalog = new CataloG();
        StatemenT _st = new StatemenT();
        BasketFromCatalog basket;
        int _min = -1, _max = 1000000000;
        List<CheckBox> _checkBoxes = new List<CheckBox>();


        public CatalogShower(int idPerson)
        {
            InitializeComponent();

            this._idPerson = idPerson;
            _st.deleteStatmentsWithoutPayment(_idPerson);
            MessageBox.Show("Кликните на товар в каталоге,\nчтобы его добавить в корзину!");

            Goods.Category categories = new Goods.Category();
            List<string> categoryStrngs= categories.getCategoryesArrayString();
            int x = 15, y = 0;

            foreach (var item in categoryStrngs)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Checked = true;
                checkBox.Text = item;
                checkBox.Location = new Point(x, y);
                checkBox.Cursor = Cursors.Hand;
                checkBox.Width = 200;
                y += 40;
                _checkBoxes.Add(checkBox);
            }

            foreach (var item in _checkBoxes)
            {
                panel3.Controls.Add(item);
            }

            _catalog.refreshTable(dataGridView1, findCheckBoxes(), _min, _max, !chBSortActuality.Checked);

            _st.addStatment(_idPerson);
            _idStatment = _st.findIndexOfStatmentWithoutPayment(_idPerson);
        }

        private List<string> findCheckBoxes()
        {
            List<string> res = new List<string>();

            foreach (var item in _checkBoxes)
            {
                if (item.Checked)
                {
                    res.Add(item.Text);
                }
            }

            return res;
        }

        private void CatalogShower_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (!tbModel.Text.Equals(""))
            {
                try
                {
                    _min = Convert.ToInt32(tbModel.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы ввели неврное значение!");
                }
                
            }
            else
            {
                _min = 0;
            }

            if (!textBox1.Text.Equals(""))
            {
                try
                {
                    _max = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы ввели неврное значение!");
                }
            }
            else
            {
                _max = 1000000000;
            }

            _catalog.refreshTable(dataGridView1, findCheckBoxes(), _min, _max, !chBSortActuality.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата производится у кассы.\n" +
                $"Ваш НОМЕР ЗАКАЗА: {_idStatment}" +
                $"\nОзнакомиться с текущем заказом \nможно в истории заказов!");
            SwitcherBeatweener.roleShower.startPage(this);
        }

        private void chBSortActuality_CheckedChanged(object sender, EventArgs e)
        {
            SwitcherBeatweener.roleShower.startPage(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int nmbSelect = dataGridView1.CurrentCell.RowIndex;

                var res = MessageBox.Show("Вы желаете добавить этот товар в корзину?", "Замечание", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    _st.addGoodToStatment(_idStatment, Convert.ToInt32(dataGridView1.Rows[nmbSelect].Cells[0].Value.ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выполнение транзакции невозможно!");
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            SwitcherBeatweener.roleShower.startPage(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.seak(this, new Help());
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                basket.Clear();
                basket.ShowDialog();
                basket.Owner = this;
            }
            catch(Exception exp)
            {
                basket = new BasketFromCatalog(_idStatment);

                basket.Clear();
                
                basket.Owner = this;

            }
            
        }
    }
}
