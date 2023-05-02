using System;
using System.Windows.Forms;
using course_project._DataBase.Sup;

namespace course_project._DataBase.Statement
{
    public partial class TimeMaker : Form
    {
        int _idPerson;
        Supplier _sp = new Supplier();
        StatemenT _st = new StatemenT();

        const int _daysMakeOrder = 1;
        const int _daysMakeStatemen = 6;

        public TimeMaker(int idPerson)
        {
            InitializeComponent();

            _idPerson = idPerson;

            tbSup.Text = _daysMakeOrder.ToString();
            tbKeep.Text = _daysMakeStatemen.ToString();
            tbSupPost.Text = _sp.getAvgMaxTimeOfSup(_idPerson).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double time = Convert.ToDouble(tbKeep.Text) +
                Convert.ToDouble(tbSup.Text) + Convert.ToDouble(tbSupPost.Text);
                _st.setTime(time, _st.findIndexOfStatmentWithoutPayment(_idPerson));

                MessageBox.Show("Время ожидания успешно изменено!");
            }
            catch (Exception)
            {
                MessageBox.Show("...");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowSwither.next(this, new course_project._DataBase.Statement.MakeMarkSeller(_idPerson));
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        => SwitcherBeatweener.roleShower.startPage(this);

        private void button3_Click(object sender, EventArgs e)
         => WindowSwither.return_(this);

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSwither.seak(this, new Help());
        }

    }
}
