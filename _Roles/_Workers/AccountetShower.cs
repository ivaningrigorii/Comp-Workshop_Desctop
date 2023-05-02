using System;
using System.Windows.Forms;

namespace course_project._Roles
{
    class AccountetShower: WorkerShower
    {
        int _idComp = -1;

        internal _DataBase.PeopleRuler.WorkersRuler WorkersRuler
        {
            get => default;
            set
            {
            }
        }

        #region MethodsOfAcoountetActions
        private void goodsRedaction(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.Goods.GoodsRedaction());
        private void categoryesRedaction(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.Goods.CategoryesRedaction());
        private void workersRedaction(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.PeopleRuler.ChangeWorkers());
        private void supplierFirmRedaction(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.Sup.SupplierFirmRuller());
        private void supplierRedaction(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.Sup.SupplierRuller());
        private void orderSupRedaction(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.Sup.SupOrder_accountet());
        private void orderAll(object sender, EventArgs e) =>
            WindowSwither.next(_form, new _DataBase.Sup.Все_договора(_idComp));

        #endregion

        private void addToMenuButtons()
        {
            ToolStripMenuItem item = _form.getMenu();

            ToolStripMenuItem[] menuItems = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("Редакция товаров"),
                new ToolStripMenuItem("Редакция списков людей и компаний"),
                new ToolStripMenuItem("Заказ комплектующих", null, orderSupRedaction),
                new ToolStripMenuItem("Все договора", null, orderAll)
            };
            menuItems[2].ForeColor = System.Drawing.Color.Blue;
            menuItems[3].ForeColor = System.Drawing.Color.Green;

                ToolStripMenuItem[] menuItemsChangeGoods = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Товары", null, goodsRedaction),
                    new ToolStripMenuItem("Категории", null, categoryesRedaction)
                };
                menuItems[0].DropDownItems.AddRange(menuItemsChangeGoods);

                ToolStripMenuItem[] menuItemsChangePeople = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Работники", null, workersRedaction),
                    new ToolStripMenuItem("Компании")
                };
                    ToolStripMenuItem[] menuItemsChangeCompany= new ToolStripMenuItem[]
                    {
                        new ToolStripMenuItem("Представители в подсистеме", null,  supplierRedaction),
                        new ToolStripMenuItem("Компании", null, supplierFirmRedaction)
                    };
                menuItemsChangePeople[1].DropDownItems.AddRange(menuItemsChangeCompany);

                menuItems[1].DropDownItems.AddRange(menuItemsChangePeople);

            item.DropDownItems.AddRange(menuItems);
        }

        public override void startPage(Form last)
        {
            base.startPage(last);

            SwitcherBeatweener.roleShower = this;

            addToMenuButtons();
        }
    }
}
