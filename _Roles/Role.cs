using System;
using System.Windows.Forms;

namespace course_project._Roles
{
    abstract class Role
    {
        protected FormRole _form;
        protected int _id;
        protected string _role;
        protected int _numOfPanels = 3;
        protected int _numbOfTextBoxesPersonalInformation = 8;

        public virtual void  startPage(Form last) 
        {
            _form = new FormRole(_id);
        }

        public void setId(int id)
        {
            _id = id;
        }

        public void setRole(string role)
        {
            _role = role;
        }

        public void setForm(FormRole form)
        {
            _form = form;
        }
    }
}
