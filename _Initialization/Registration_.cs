using System;
using System.Windows.Forms;
using course_project.f_database;

namespace course_project._Initialization
{
    public partial class Registration_ : Form
    {
        public Registration_() => InitializeComponent();

        public Registration_(string name, string surname, string otch, string telephone)
        {
            InitializeComponent();

            tbName.Text = name;
            tbSurname.Text = surname;
            tbTelephone.Text = telephone;
            tbOtchestvo.Text = otch;
        }

        internal SystemInicialization SystemInicialization
        {
            get => default;
            set
            {
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) => WindowSwither.seak(this, new Help());

        private void buttonRegistration_Click(object sender, EventArgs e) => WindowSwither.return_(this);
        

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            TextBox[] texts = new TextBox[] { tbName, tbOtchestvo, tbSurname, tbTelephone };

            foreach (var item in texts)
            {
                if (item.Text.Equals(""))
                {
                    MessageBox.Show("Не все данные введены!");

                    return;
                }
            }

            WindowSwither.next(this, new RegistrationNext(tbName.Text, tbSurname.Text, tbOtchestvo.Text, tbTelephone.Text));
        }
    }
}
