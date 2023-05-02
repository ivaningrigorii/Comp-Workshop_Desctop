using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    public partial class Все_договора : Form
    {
        int _accountetId = -1;
        Supplier _sp = new Supplier();
        public Все_договора(int isId)
        {
            InitializeComponent();

            _accountetId = isId;
            Clear();
        }


        private void Clear()
        {
            if (_accountetId < 0)
            {
                _sp.refreshAll(dataGridView1);
            }
            else
            {
                _sp.refreshAll(dataGridView1, _accountetId);
            }
        }

        private void вернутьсяВПрофильToolStripMenuItem_Click(object sender, EventArgs e) => SwitcherBeatweener.roleShower.startPage(this);

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e) => WindowSwither.return_(this);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
