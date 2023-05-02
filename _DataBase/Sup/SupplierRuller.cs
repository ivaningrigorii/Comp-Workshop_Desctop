using System;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    public partial class SupplierRuller : Form
    {
        bool onlyFirmPresenters = true;
        SupplierPresenters presenters = new SupplierPresenters();
        public SupplierRuller()
        {
            InitializeComponent();
            Clear();
            dataGridView2.ClearSelection();
        }

        private void Clear()
        {
            label1.Text = "";
            presenters.refreshNullFirms(dataGridView2);

            if (onlyFirmPresenters)
            {
                presenters.refreshPeopleInFirms(dataGridView1);
            }
            else
            {
                presenters.refreshNullPerson(dataGridView1);
            }
            presenters.refreshComboboxSupplier(cbPost);
            cbPost.SelectedIndex = -1;
            dataGridView2.ClearSelection();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.return_(this);
        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherBeatweener.roleShower.startPage(this);
        }

        private void radioButtonOnlyPersonal_CheckedChanged(object sender, EventArgs e)
        {
            onlyFirmPresenters = true;
            Clear();
        }

        private void radioButtonOnlyClients_CheckedChanged(object sender, EventArgs e)
        {
            onlyFirmPresenters = false;
            Clear();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            try
            {
                int nmbSelect = dataGridView1.CurrentCell.RowIndex;

                if (onlyFirmPresenters)
                {
                    if (cbPost.Text != "-----" && dataGridView1.CurrentCell != null)
                    {
                        presenters.updatePresenters(presenters.supStringToInt32(cbPost.Text), 
                            Convert.ToInt32(dataGridView1.Rows[nmbSelect].Cells[1].Value));
                    }
                    else if(dataGridView1.CurrentCell != null)
                    {
                        presenters.dell(Convert.ToInt32(dataGridView1.Rows[nmbSelect].Cells[1].Value));
                    }
                }
                else if (cbPost.Text != "-----" && dataGridView1.CurrentCell != null)
                {
                    presenters.addPresenter(presenters.supStringToInt32(cbPost.Text),
                            Convert.ToInt32(dataGridView1.Rows[nmbSelect].Cells[0].Value.ToString()));
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Операция невозможна!");
            }

            Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nmbSelect = dataGridView1.CurrentCell.RowIndex;

            if (onlyFirmPresenters)
            {
                label1.Text = dataGridView1.Rows[nmbSelect].Cells[2].Value.ToString() + " " +
                   dataGridView1.Rows[nmbSelect].Cells[3].Value.ToString() + " " +
                   dataGridView1.Rows[nmbSelect].Cells[4].Value.ToString() + " ";
                cbPost.Text = dataGridView1.Rows[nmbSelect].Cells[6].Value.ToString();
            }
            else
            {
                label1.Text = dataGridView1.Rows[nmbSelect].Cells[1].Value.ToString() + " " +
                   dataGridView1.Rows[nmbSelect].Cells[2].Value.ToString() + " " +
                   dataGridView1.Rows[nmbSelect].Cells[3].Value.ToString() + " ";
                cbPost.Text = "-----";
            }
        }
    }
}
