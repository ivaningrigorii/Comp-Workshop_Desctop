using System;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    public partial class SupplierFirmRuller : Form
    {
        Sup.Supplier sup = new Supplier();
        public SupplierFirmRuller()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            tbSupplier.Text = "";

            sup.refreshCompanies(dataGridView2);

            dataGridView2.ClearSelection();
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherBeatweener.roleShower.startPage(this);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nmbSelect = dataGridView2.CurrentCell.RowIndex;
            tbSupplier.Text = dataGridView2.Rows[nmbSelect].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tbSupplier.Text.Equals(""))
            {
                sup.add(tbSupplier.Text);
            }

            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!tbSupplier.Text.Equals(""))
            {
                sup.updateSupplier(tbSupplier.Text,
                    Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value));
            }

            Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!tbSupplier.Text.Equals(""))
            {
                sup.dell(Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value));
            }

            Clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
