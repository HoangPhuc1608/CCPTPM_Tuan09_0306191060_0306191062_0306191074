using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Tuan09.Models
{
    public class Admin : Member
    {
        private int permision;

        public int Permision { get => permision; set => permision = value; }

        public bool setPermision() 
        {
            return true;
        }
    }
}
