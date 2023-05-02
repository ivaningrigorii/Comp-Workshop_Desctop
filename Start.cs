using System;
using System.Windows.Forms;

namespace course_project
{
    public partial class Start : Form
    {
        public Start() 
            => InitializeComponent();
        private void buttonAuthorization_Click(object sender, EventArgs e) 
            => WindowSwither.next_(this, new _Initialization.Autorization_());

        private void buttonRegistration_Click(object sender, EventArgs e) 
            => WindowSwither.next_(this, new _Initialization.Registration_());

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) 
            => WindowSwither.seak(this, new Help());
    }
}
