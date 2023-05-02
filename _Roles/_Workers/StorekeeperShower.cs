using System;
using System.Windows.Forms;
using System.Drawing;

namespace course_project._Roles
{
    class StorekeeperShower: WorkerShower
    {
        public override void startPage(Form last)
        {
            SwitcherBeatweener.roleShower = this;

            base.startPage(last);

            addToMenuButtons();
        }

        #region MethodsStorekeeprActions
        private void toGetGoods(object sender, EventArgs e)
            => WindowSwither.next(_form, new _DataBase.Sup.GetGoods());
        #endregion
        private void addToMenuButtons()
        {
            ToolStripMenuItem item = _form.getMenu();

            ToolStripMenuItem[] menuItems = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("Принять поставки", null, toGetGoods)
            };

            item.DropDownItems.AddRange(menuItems);
        }
    }
}
