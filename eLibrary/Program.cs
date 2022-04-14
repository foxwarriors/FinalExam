using System;
using System.Collections.Generic;
using System.Linq;

namespace eLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Angajat> Angajati = new List<Angajat>()
            {
                new Angajat{ID=1,Nume="Enache Mirela",OraIntrareInTura="08:00",OraIesireDinTura="16:00" },
                new Angajat{ID=1,Nume="Tudose Titel",OraIntrareInTura="08:05",OraIesireDinTura="16:30" },
                new Angajat{ID=1,Nume="Cristea Costel",OraIntrareInTura="10:15",OraIesireDinTura="17:10" },
                new Angajat{ID=1,Nume="Popa Marius",OraIntrareInTura="12:00",OraIesireDinTura="20:11" },
            };

            List<Client> Clienti = new List<Client>()
            {
                new Client{ID = 1, Nume = "Popescu Viorel", CarteImprumutata = "Amintiri din Copilarie", DataImprumut = "12/02/2019", DataMaximRetur = "20/03/2019" },                
                new Client{ID = 2, Nume = "Aliona Mirel", CarteImprumutata = "Basme", DataImprumut = "12/02/2019", DataMaximRetur = "20/03/2019" },
                new Client{ID = 3, Nume = "Costache Mircea", CarteImprumutata = "Matematica", DataImprumut = "12/02/2019", DataMaximRetur = "20/03/2019" },
                new Client{ID = 4, Nume = "Ciuca Alina", CarteImprumutata = "Capra cu trei iezi", DataImprumut = "12/02/2019", DataMaximRetur = "20/03/2019" },
                new Client{ID = 5, Nume = "Dumitrescu Paul", CarteImprumutata = "Fizica cuantica", DataImprumut = "12/02/2019", DataMaximRetur = "20/03/2019" },
                new Client{ID = 6, Nume = "Dobre Tudor", CarteImprumutata = "Informatica clasa a IX-a", DataImprumut = "12/02/2019", DataMaximRetur = "20/03/2019" }
            };
            foreach(var client in Clienti)
            {
                client.AdaugareEvidentaClienti();
            }

            foreach (var client in Clienti)
            {
                //Afisare numele tuturor clientilor
                Console.WriteLine(client.Nume);
            }

            Console.WriteLine("--------------Afisare Clienti in ordine alfabetica--------------");
            IEnumerable<Client> query = Clienti.OrderBy(nume => nume.Nume);
            foreach(var nume in query)
            {
                Console.WriteLine(nume.Nume);
            }


            Console.WriteLine("---Afisare data imprumut + data retur + ce carte a imprumutat un client specific dupa id---");
            Console.WriteLine("Introduceti un ID:");
            int id = int.Parse(Console.ReadLine());
            Client result = Clienti.Find(client => client.ID == id);
            if (result != null)
            {
                result.CeCarte(id);
                result.CandImprumut(id);
                result.CandRetur(id);
            }
            else
                throw new Exception();


            Console.WriteLine("---Carti imprumutate de clienti---");
            for(int i=0;i<Clienti.Count;i++)
            {
                Console.WriteLine(Clienti[i].CarteImprumutata);
            }



            Console.WriteLine("---Ora la care angajatii au intrat si respectiv iesit din tura---");
            for(int i=0;i<Angajati.Count;i++)
            {
                Angajati[i].CheckIn();
                Angajati[i].CheckOut();

            }


        }
    }
}
