using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.Goods
{
    public partial class CategoryesRedaction : Form
    {
        Category category = new Category();
        public CategoryesRedaction()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            tbCategory.Text = "";
            category.refreshTable(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherBeatweener.roleShower.startPage(this);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCategory.Text.Length != 0)
                {
                    category.add(tbCategory.Text);
                    Clear();
                }    
            }
            catch (Exception exp)
            {
                MessageBox.Show("Невозможно добавить!");
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCategory.Text.Length != 0)
                {
                    category.updateCategory(tbCategory.Text, 
                        Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value));
                    Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изменение невозможно!");
            }
        }

        private void btDell_Click(object sender, EventArgs e)
        {
            try
            {
                category.dell(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value));
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Удаление невозможно!");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCategory.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }
    }
}
