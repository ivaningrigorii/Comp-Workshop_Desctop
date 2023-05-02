using System;
using System.Windows.Forms;
using course_project._DataBase.Sup;


namespace course_project._DataBase.Statement
{
    public partial class MakeMarkSeller : Form
    {
        int _idPerson;
        int _idStatment;
        StatemenT _st = new StatemenT();

        public MakeMarkSeller(int idPerson)
        {
            InitializeComponent();

            
            _idPerson = idPerson;
            _idStatment = _st.findIndexOfStatmentWithoutPayment(_idPerson);
            tbSup.Text = _st.getSumStat(_st.findIndexOfStatmentWithoutPayment(_idPerson)).ToString();
            _st.refreshTableAboutStatment(_idStatment, dataGridView1);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _st.makePayment(_idStatment);
                MessageBox.Show("Оплата прошла успешно!");
            }
            catch (Exception)
            {
                MessageBox.Show("Оплата непроходит!");
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e) => SwitcherBeatweener.roleShower.startPage(this);

        private void button3_Click(object sender, EventArgs e) => WindowSwither.return_(this);

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.seak(this, new Help());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _st.printToMSWordCheque(dataGridView1, _idStatment.ToString(), tbSup.Text);
        }
    }
}
