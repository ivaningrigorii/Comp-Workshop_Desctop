using System;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    public partial class GetGoods : Form
    {
        Supplier _sp = new Supplier();
        public GetGoods()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            _sp.refreshAllForKeeper(dataGridView2);
            dataGridView2.ClearSelection();
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                 id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString());
                _sp.payContract(id);
                id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString());
                _sp.setStock(id, Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[4].Value.ToString()));
                MessageBox.Show("Поставка принята");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            Clear();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Поставка выбрана!");
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
    }
}
