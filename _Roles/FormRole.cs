using System;
using System.Windows.Forms;

namespace course_project._Roles
{
    public partial class FormRole : Form
    {
        int _id;
        public FormRole(int id)
        {
            InitializeComponent();
            _id = id;
        }

        public TextBox getSetTextBox(int index)
        {
            TextBox[] textBoxes = new TextBox[]
            {
                tbName,
                tbRole,
                tbNameP1,
                tbName2P1,
                tbOP1,
                tbLP1,
                tbPassowrdP1,
                tbTelephone,
                tbSalary,
                tbCompany
            };

            index = (index >= textBoxes.Length || index < 0) ? 0 : index;

            return textBoxes[index];
        }

        public Panel getSetPanels(int index)
        {
            Panel[] panels = new Panel[]
            {
                panel1,
                panel2,
                panel3
            };

            index = (index >= panels.Length || index < 0) ? 0 : index;

            return panels[index];
        }

        public ToolStripMenuItem getMenu()
        {
            return toolStripMenuItem_tools;
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            if (!tbPassowrdP1.Text.Equals("") && !tbTelephone.Text.Equals(""))
            {
                f_database.PeopleRuler person = new f_database.PeopleRuler();
                bool res = person.changeDataPerson(tbPassowrdP1.Text, tbTelephone.Text, _id);

                if (res)
                {
                    MessageBox.Show("Данные успешно изменены!", "Справка");
                }
            }
        }  
        

        private void button1_Click(object sender, EventArgs e)
        => WindowSwither.return_(this);

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
         => WindowSwither.seak(this, new Help());
    }
}
