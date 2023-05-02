using System;
using System.Windows.Forms;
using course_project._Roles;
using course_project.f_database;

namespace course_project._Initialization
{
    public partial class Autorization_ : Form
    {
        SystemInicialization inicialization = new SystemInicialization();
        public Autorization_()
        {
            InitializeComponent();
        }

        internal EnumRoleTypes EnumRoleTypes
        {
            get => default;
            set
            {
            }
        }

        private void toolStripMenuItem_toBack_Click(object sender, EventArgs e)
             => WindowSwither.return_(this);

        private void buttonInput_Click(object sender, EventArgs e)
        {
            try
            {
                inicialization.autoriz(textBox1.Text, textBox2.Text, this);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Справка");
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
            => WindowSwither.seak(this, new Help());

        private void buttonRegistration_Click(object sender, EventArgs e)
            => WindowSwither.return_(this);
    }
}
