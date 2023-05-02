using System.Windows.Forms;
using System.Collections.Generic;
using course_project.f_database;
using System;

namespace course_project._Roles
{
    class CustomerShower: Role
    {
        internal _DataBase.CataloG CataloG
        {
            get => default;
            set
            {
            }
        }

        private void createNewStatement(object sender, EventArgs e)
        {
            var res = MessageBox.Show("При переходе старые \nнеоплаченные заказы будут очищены!\n" + "Желаете продолжить?", "Заметка", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes) 
                WindowSwither.next(_form, new _DataBase.Catalog.CatalogShower(_id));
        }

        private void goToHistoryOfStatements(object sender, EventArgs e) => WindowSwither.next(_form, new _DataBase.Statement.MyStatemtsShower(_id));

        private void dellPanels()
        {
            for (int i = 1; i < _numOfPanels; i++)
            {
                _form.getSetPanels(i).Visible = false;
            }
        }
        private void addInformationInTextBoxes()
        {
            PeopleRuler person = new PeopleRuler();
            List<string> data = person.findPersonData(_id);
            _form.getSetTextBox(1).Text = "<<< " + _role + " >>>";
            _form.getSetTextBox(0).Text = data[0];

            for (int i = 2; i < _numbOfTextBoxesPersonalInformation; i++)
            {
                _form.getSetTextBox(i).Text = data[i-2];
            }
        }
        private void addToMenuButtons()
        {
            ToolStripMenuItem item = _form.getMenu();

            ToolStripMenuItem[] items = new ToolStripMenuItem[]
            {
                 new ToolStripMenuItem("Составить новый заказ", null, createNewStatement),
                 new ToolStripMenuItem("Истроия покупок и состояние заказов", null, goToHistoryOfStatements),

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
    }
}
