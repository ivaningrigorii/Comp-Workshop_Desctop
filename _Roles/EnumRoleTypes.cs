using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace course_project._Roles
{
    class EnumRoleTypes
    {
        class TypeElement
        {
            public string name { get; }
            public Type type { get; }

            public TypeElement(string name, Type type)
            {
                this.name = name;
                this.type = type;
            }
        }

        private List<TypeElement> types = new List<TypeElement>()
        {
            new TypeElement("клиент", typeof(CustomerShower)),
            new TypeElement("бухгалтер", typeof(AccountetShower)),
            new TypeElement("представитель", typeof(SupplierShower)),
            new TypeElement("менеджер", typeof(ManagerShower)),
            new TypeElement("кладовщик", typeof(StorekeeperShower)),
            new TypeElement("мастер", typeof(_Workers.MasterShower))
        };

        public Type getTypeCanWithException(string nameType)
        {
            
            foreach (TypeElement item in types)
            {
                if (item.name == nameType)
                    return item.type;
            }
            
            throw new 
                Exception("Вход возможен только в роли Клиента!");
        }

    }
}
