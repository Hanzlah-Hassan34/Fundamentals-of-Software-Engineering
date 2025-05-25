using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public static class Global_Variables
    {
        public static string username { get; set; }
        private static decimal a = 0;
        public static decimal totalAmount
        {
            get { return a; }
            set { a = value; }
        }

    }
}
