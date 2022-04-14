using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary
{
    public class Client:Persoana
    {
        public string CarteImprumutata { get; set; }
        public string DataImprumut { get; set; }
        public string DataMaximRetur { get; set; } //Perioada Maxima pana cand trebuie returnata cartea

        static int nr = 0;
        public void AdaugareEvidentaClienti()
        {     
            nr++;
        }

        public void ScadereEvidentaClienti()
        {
            nr--;
        }
      
        public void CandImprumut(int id)
        {         
                Console.WriteLine(this.Nume + " a imprumutat cartea la data de " + DataImprumut);
        }

        public void CandRetur(int id)
        {            
                Console.WriteLine(this.Nume + " va trebui sa faca returul maxim la data de " + DataMaximRetur);
        }
        public void CeCarte(int id)
        {          
                Console.WriteLine(this.Nume + " a imprumutat: " + this.CarteImprumutata);
        }
    }
}
