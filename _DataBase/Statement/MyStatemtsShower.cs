using System;
using System.Windows.Forms;
using System.Collections;

namespace course_project._DataBase.Statement
{
    public partial class MyStatemtsShower : Form
    {
        int _IdPerson;
        const int _countRadiosInPanel2 = 3;
        StatemenT _st = new StatemenT();
        RadioButton[] _radios;


        public MyStatemtsShower(int idPerson)
        {
            InitializeComponent();

            _IdPerson = idPerson;

            _radios = new RadioButton[]
            {
                rdBasket,
                rbAllSt,
                rBNotReady,
                rBReady,
                rBGet
            };

            _st.getMyBasketStatement1(_IdPerson, dataGridView1);

        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e) => WindowSwither.return_(this);

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e) => SwitcherBeatweener.roleShower.startPage(this);


        private void rdBasket_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBasket.Checked)
            {
                panel2.Visible = false;
                _st.getMyBasketStatement1(_IdPerson, dataGridView1);
            }
        }

        private void rbAllSt_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = _radios.Length - _countRadiosInPanel2; i < _radios.Length; i++)
            {
                _radios[i].Checked = false;
            }

            panel2.Visible = true;
        }
        

        private void rBNotReady_CheckedChanged(object sender, EventArgs e) => _st.getMyNotReadyStatements1(_IdPerson, dataGridView1);

        private void rBReady_CheckedChanged(object sender, EventArgs e) => _st.getReadyStatemens1(_IdPerson, dataGridView1);

        private void rBGet_CheckedChanged(object sender, EventArgs e) => _st.getIssueStatements1(_IdPerson, dataGridView1);
    }
}
