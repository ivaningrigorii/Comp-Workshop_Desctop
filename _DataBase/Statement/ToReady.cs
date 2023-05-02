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
    public partial class ToReady : Form
    {
        StatemenT _st = new StatemenT();
        public ToReady()
        {
            InitializeComponent();
            clear();
        }

        private void clear()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
            }
            catch (Exception){ }
            
            _st.getNotReadyStatemens1(dataGridView2);
            dataGridView2.ClearSelection();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _st.stockMin(Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                _st.updateReady(Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Операция невозможна!");
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _st.refreshTableAboutStatment(Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString()), dataGridView1);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось выбрать!");
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
    }
}
