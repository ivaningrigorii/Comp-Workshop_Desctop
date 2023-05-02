using System;
using System.Windows.Forms;
using course_project.f_database;
using System.Collections.Generic;

namespace course_project._Roles
{
    class SupplierShower : Role
    {
        _DataBase.Sup.Supplier _supplier = new _DataBase.Sup.Supplier();

        #region SupplierShowerMethodsAction
        private void accounterOrders(object sender, EventArgs e)
            => WindowSwither.next(_form, new _DataBase.Sup.SupOrder_sup(_supplier.getIdToIDPerson(_id)));
        private void allOrders(object sender, EventArgs e)
            => WindowSwither.next(_form, new _DataBase.Sup.Все_договора(_supplier.getIdToIDPerson(_id)));

        #endregion

        private void addToMenuButtons()
        {
            ToolStripMenuItem item = _form.getMenu();

            ToolStripMenuItem[] items = new ToolStripMenuItem[]
            {
                 new ToolStripMenuItem("Просмотр запросов бухгалтера", null, accounterOrders),
                 new ToolStripMenuItem("Все договоры", null, allOrders)
            };

            items[0].ForeColor = System.Drawing.Color.Blue;
            items[1].ForeColor = System.Drawing.Color.Green;
            item.DropDownItems.AddRange(items);
        }

        public override void startPage(Form last)
        {
            SwitcherBeatweener.roleShower = this;
            base.startPage(last);
            addToMenuButtons();

            WindowSwither.next(last, _form);

            dellPanels();
            addInformationInTextBoxes();
        }

        private void dellPanels() => 
            _form.getSetPanels(1).Visible = false;

        private void addInformationInTextBoxes()
        {
            PeopleRuler person = new PeopleRuler();
            List<string> data = person.findPersonData(_id);

            _form.getSetTextBox(0).Text = data[0];
            _form.getSetTextBox(1).Text = "<<< " + _role + " >>>";

            for (int i = 2; i < _numbOfTextBoxesPersonalInformation; i++)
            {
                _form.getSetTextBox(i).Text = data[i-2];
            }

            _form.getSetTextBox(9).Text = person.getSupplierNameCompany(_id);

        }
    }
}
