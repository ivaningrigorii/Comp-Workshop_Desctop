using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.PeopleRuler
{
    public partial class ChangeWorkers : Form
    {
        bool showWorkers = true;
        WorkersRuler worker = new WorkersRuler();
        public ChangeWorkers()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            worker.refreshComboboxPost(cbPost);
            

            cbPost.SelectedIndex = -1;
            tbSalary.Text = "";
            label1.Text = "";

            if (showWorkers)
            {
                worker.refreshWorkers(dataGridView1);
            }
            else
            {
                worker.refreshClients(dataGridView1);
            }
            

            dataGridView1.ClearSelection();
        }

        private void radioButtonOnlyPersonal_CheckedChanged(object sender, EventArgs e)
        {
            showWorkers = true;
            Clear();
        }

        private void radioButtonOnlyClients_CheckedChanged(object sender, EventArgs e)
        {
            showWorkers = false;
            Clear();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherBeatweener.roleShower.startPage(this);
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (cbPost.SelectedIndex != -1)
            {
                if (this.showWorkers)
                {
                    if (cbPost.Text.Equals("клиент"))
                    {
                        worker.changerWorkerToClient(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    }
                    else
                    {
                        worker.changeWorker(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                            Convert.ToDouble(tbSalary.Text), 
                            worker.postStringToInt32(cbPost.Text));
                    }
                }
                else if (!this.showWorkers && !cbPost.Text.Equals("клиент"))
                {
                    worker.changeClientToWorker(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                            Convert.ToDouble(tbSalary.Text), 
                            worker.postStringToInt32(cbPost.Text));
                }
            }
            

            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nmbSelect = dataGridView1.CurrentCell.RowIndex;

            if (showWorkers)
            {
                label1.Text = dataGridView1.Rows[nmbSelect].Cells[2].Value.ToString() + " " +
                    dataGridView1.Rows[nmbSelect].Cells[3].Value.ToString() + " " +
                    dataGridView1.Rows[nmbSelect].Cells[4].Value.ToString() + " ";
                tbSalary.Text = dataGridView1.Rows[nmbSelect].Cells[6].Value.ToString();
                cbPost.Text = dataGridView1.Rows[nmbSelect].Cells[7].Value.ToString();
            }
            else
            {
                label1.Text = dataGridView1.Rows[nmbSelect].Cells[1].Value.ToString() + " " +
                    dataGridView1.Rows[nmbSelect].Cells[2].Value.ToString() + " " +
                    dataGridView1.Rows[nmbSelect].Cells[3].Value.ToString() + " ";
                tbSalary.Text = ""+0;
                cbPost.Text = "клиент";
            }
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }
    }
}
