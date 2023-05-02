using System;
using System.Windows.Forms;
using System.Drawing;

namespace course_project._Roles
{
    class ManagerShower: WorkerShower
    {

        private void goToCatalog(object slender, EventArgs e) 
            => WindowSwither.next(_form, new _DataBase.Catalog.SelecterPersons());

        private void get(object sender, EventArgs e)
            => WindowSwither.next(_form, new _DataBase.Statement.IssueStatement());

        private void addToMenuButtons()
        {
            ToolStripMenuItem item = _form.getMenu();

            ToolStripMenuItem[] menuItems = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("Подбор аккаунта", null, goToCatalog),
                new ToolStripMenuItem("Выдача готовых заказов", null, get)
            };
            menuItems[0].ForeColor = Color.BlueViolet;
            menuItems[0].ForeColor = Color.Red;
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
