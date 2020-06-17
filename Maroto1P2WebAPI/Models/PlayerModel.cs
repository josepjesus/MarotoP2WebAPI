using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maroto1P2WebAPI.Models
{
    public class PlayerModel
    {

        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _birthday;
        public DateTime BirthDay
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
    }
}