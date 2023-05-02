using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.Statement
{
    public partial class IssueStatement : Form
    {
        StatemenT _st = new StatemenT();
        public IssueStatement()
        {
            InitializeComponent();
            clear();
        }

        private void clear()
        {
            _st.refreshTableFullInformAbouStatement(dataGridView1);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _st.updateIssue(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show("Операция невозможна!");
            }

            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Заказ выбран!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _st.easyPrint(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
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
