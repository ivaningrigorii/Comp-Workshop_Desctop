using System;
using System.Windows.Forms;
using course_project.f_database;
using System.Collections.Generic;
using course_project._DataBase.PeopleRuler;

namespace course_project._Roles
{
    abstract class WorkerShower : Role
    {
        private void dellPanels()
        {
            _form.getSetPanels(2).Visible = false;
        }

        private void addInformationInTextBoxes()
        {
            PeopleRuler person = new PeopleRuler();
            List<string> data = person.findPersonData(_id);

            _form.getSetTextBox(0).Text = data[0];
            _form.getSetTextBox(1).Text = "<<< " + _role + " >>>";
            _form.getSetTextBox(2).Text = data[0];
            _form.getSetTextBox(3).Text = data[1];
            _form.getSetTextBox(4).Text = data[2];
            _form.getSetTextBox(5).Text = data[3];
            _form.getSetTextBox(6).Text = data[4];
            _form.getSetTextBox(7).Text = data[5];

            WorkersRuler worker = new WorkersRuler();
            _form.getSetTextBox(8).Text = worker.getSalary(_id);

        }

        public override void startPage(Form last)
        {
            _form = new FormRole(_id);

            WindowSwither.next(last, _form);

            dellPanels();
            addInformationInTextBoxes();
        }
    }
}
