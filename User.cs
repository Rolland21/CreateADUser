using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployee
{

    public class User
    {

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Position { get; private set; }
        public string DM { get; private set; }
        public string Department { get; private set; }
        public string City { get; private set; }
        public string Office { get; private set; }
        public string Room { get; private set; }

        public User(string text)
        {
            Name = text.Name();
            SurName = text.Surname();
            Position = text.Position();
            DM = text.DM();
            Department = text.Department();
            City = text.City();
            Office = text.Office();
            Room = text.Room();
        }
        public User(string name, string surName, string position, string dm, string department, string city, string office, string room)
        {
            Name = name;
            SurName = surName;
            Position = position;
            DM = dm;
            Department = department;
            City = city;
            Office = office;
            Room = room;
        }
        public override bool Equals(object obj)
        {
            User user = obj as User;
            return (Name == user.Name && SurName == user.SurName && Position == user.Position && DM == user.DM && Department == user.Department && City == user.City && Office == user.Office && Room == user.Room);            
        }

    }
}
