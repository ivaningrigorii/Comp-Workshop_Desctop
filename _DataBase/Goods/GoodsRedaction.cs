using System;
using System.Windows.Forms;

namespace course_project._DataBase.Goods
{
    public partial class GoodsRedaction : Form
    {
        bool onlyActuality = true;
        byte[] photo;
        Good good = new Good();
        public GoodsRedaction()
        {
            InitializeComponent();

            Clear();
            good.updateCategoryCombobox(cBCategory);
        }

        public void Clear()
        {
            cBCategory.SelectedIndex = -1;
            cBCategory.SelectedItem = -1;
            tbModel.Text = "";
            tBPrice.Text = "";
            tbQuan.Text = "";
            chBActuality.Checked = false;
            panelPhoto.BackgroundImage = null;
            photo = null;

            if (onlyActuality)
            {
                good.refreshTableOnlyActuality(dataGridView1);
            }
            else
            {
                good.refreshTable(dataGridView1);
            }

            dataGridView1.ClearSelection();
            
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e) => WindowSwither.return_(this);
        

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e) => SwitcherBeatweener.roleShower.startPage(this);
        
        private void btADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBCategory.SelectedItem != null)
                {
                    good.add(cBCategory.Text, Convert.ToDouble(tBPrice.Text), Convert.ToInt32(tbQuan.Text),
                        chBActuality.Checked, tbModel.Text, photo);
                    Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Добавление невозможно!");
            }
        
            
        }

        private void btDEL_Click(object sender, EventArgs e)
        {
            try
            {
                good.dell(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Удаление невозможно!");
            }
            catch (Exception)
            {
                MessageBox.Show("Удаление невозможно!");
            }
            
            Clear();
        }

        private void btUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBCategory.SelectedItem != null)
                {
                    good.update_(cBCategory.Text, Convert.ToDouble(tBPrice.Text), Convert.ToInt32(tbQuan.Text),
                        chBActuality.Checked, tbModel.Text, photo,
                        Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изменение невозможно!");
            }
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btAddPhoto_Click(object sender, EventArgs e)
        {
            photo = PhotoMaker.getPhoto();
            if (photo != null)
            {
                panelPhoto.BackgroundImage = PhotoMaker.toImageFromByte(photo);
            }
        }

        private void chB_SORT_ACTUALITY_CheckedChanged(object sender, EventArgs e)
        {
            onlyActuality = chBSortActuality.Checked;
            Clear();
        }

        private void GoodsRedaction_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nmbSelect = dataGridView1.CurrentCell.RowIndex;

            photo = (byte[]) dataGridView1.Rows[nmbSelect].Cells[1].Value;

            panelPhoto.BackgroundImage = PhotoMaker.toImageFromByte(photo);

            tbModel.Text = dataGridView1.Rows[nmbSelect].Cells[2].Value.ToString();
            tbQuan.Text = dataGridView1.Rows[nmbSelect].Cells[3].Value.ToString();
            tBPrice.Text = dataGridView1.Rows[nmbSelect].Cells[4].Value.ToString();
            chBActuality.Checked = Convert.ToBoolean(dataGridView1.Rows[nmbSelect].Cells[5].Value.ToString());
            cBCategory.SelectedIndex = good.findCategoryPosition(dataGridView1.Rows[nmbSelect].Cells[6].Value.ToString());
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }
    }
}
