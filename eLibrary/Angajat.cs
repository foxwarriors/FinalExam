using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary
{
    public class Angajat : Persoana
    {
        public string OraIntrareInTura { get; set; }
        public string OraIesireDinTura { get; set; }
        public void CheckIn()
        {
            Console.WriteLine($"Angajatul {this.Nume} a intrat in tura la ora {OraIntrareInTura}");
        }
        public void CheckOut()
        {
            Console.WriteLine($"Angajatul {this.Nume} a iesit din tura la ora {OraIesireDinTura}");
        }
    }
}
