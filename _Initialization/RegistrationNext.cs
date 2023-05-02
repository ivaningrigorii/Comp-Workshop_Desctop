using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._Initialization
{
    public partial class RegistrationNext : Form
    {
        SystemInicialization _inicialization = new SystemInicialization();
        string _name;
        string _surname;
        string _otchestvo;
        string _telephone;

        public RegistrationNext(string name, string surname, string otchestvo, string telephone)
        {
            InitializeComponent();

            _name = name;
            _surname = surname;
            _otchestvo = otchestvo;
            _telephone = telephone;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
            => WindowSwither.seak(this, new Help());

        private void buttonRegistration_Click(object sender, EventArgs e)
            => WindowSwither.next(this, new Registration_(_name, _surname, _otchestvo, _telephone));

        private void button1_Click(object sender, EventArgs e)
            => WindowSwither.return_(this);

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            try
            {
                _inicialization.registr(_surname, _name, _otchestvo, tbLogin.Text, tbPassword.Text, _telephone);

                if (_inicialization.MistakeInicializetion) throw new Exception("Регистрация невозможна!");

                MessageBox.Show("Вы успешно зарегистрированны!");

                WindowSwither.return_(this);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Справка");
            }
        }
    }
}
