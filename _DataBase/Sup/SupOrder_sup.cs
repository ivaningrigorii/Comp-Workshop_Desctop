using System;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    public partial class SupOrder_sup : Form
    {
        int _idSup;
        Supplier _sup = new Supplier();
        public SupOrder_sup(int idSup)
        {
            InitializeComponent();
            _idSup = idSup;
            Clear();
        }

        private void Clear()
        {
            textBox3.Text = "Сообщение бухгалтерии";
            _sup.refreshSupContarcts(dataGridView2, _idSup);
            dataGridView2.ClearSelection();
        }

        private void toolStripMenuItem_tools_Click(object sender, EventArgs e)
        {

        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e) => SwitcherBeatweener.roleShower.startPage(this);

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e) => WindowSwither.return_(this);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _sup.udateStatusContract(2, textBox3.Text,
                Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                Clear();
                MessageBox.Show("Операция выполнена!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _sup.udateStatusContract(3, textBox3.Text,
                Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                Clear();
                MessageBox.Show("Операция выполнена!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Выбрано!");
        }
    }
}
