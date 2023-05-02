using System;
using System.Windows.Forms;
using System.Drawing;


namespace course_project._Roles._Workers
{
    class MasterShower : WorkerShower
    {
        private void ready(object sender, EventArgs e)
           => WindowSwither.next(_form, new _DataBase.Statement.ToReady());

        private void addToMenuButtons()
        {
            ToolStripMenuItem item = _form.getMenu();

            ToolStripMenuItem[] menuItems = new ToolStripMenuItem[] { new ToolStripMenuItem("Собрать", null, ready) };
            menuItems[0].ForeColor = Color.BlueViolet;
            item.DropDownItems.AddRange(menuItems);
        }

        public override void startPage(Form last)
        {
            SwitcherBeatweener.roleShower = this;

            base.startPage(last);

            addToMenuButtons();
        }
    }
}
