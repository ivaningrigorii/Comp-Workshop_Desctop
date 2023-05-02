using System;
using course_project._Roles;
using course_project.f_database;
using System.Windows.Forms;

namespace course_project._Initialization
{
    class SystemInicialization
    {
        PeopleRuler _person = new PeopleRuler();
        bool _mistakeInicialization = false;
        

        public bool MistakeInicializetion { get => _mistakeInicialization; }

        internal Role Role
        {
            get => default;
            set
            {
            }
        }

        public void registr(string surname, string name, string otchestvo, string login, string password, string telephone)
        {
            
            _mistakeInicialization = false;
            
  
            string[] strings = new string[] { surname, name, otchestvo, login, password, telephone };

            foreach (var item in strings)
            {
                if (item == "")
                {
                    _mistakeInicialization = true;
                    return;
                }
            }

            _mistakeInicialization = !_person.registration(surname, name, otchestvo, login, password, telephone);
        }

        public void autoriz(string login, string password, Form form)
        {
            int id;

            if (!_person.findPerson(login, password, out id))
                throw new Exception("Вход невозможен, вы неверно ввели данные!");

            string role = _person.getRole(id);
            EnumRoleTypes typeEnummer = new EnumRoleTypes();

            Type type = typeEnummer.getTypeCanWithException(role);

            object roleInRefer = Activator.CreateInstance(type);

            Role roleInSystem = roleInRefer as Role;
            roleInSystem.setId(id);
            roleInSystem.setRole(role);


            roleInSystem.startPage(form);
        }
    }
}
