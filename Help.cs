using System;
using System.Windows.Forms;

namespace course_project
{
    public partial class Help : Form
    {
        public Help() => InitializeComponent();

        private void buttonRegistration_Click(object sender, EventArgs e) => WindowSwither.show(this);
    }
}