using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrivialBlue : IGestioneBlue
    {
        private List<Bluechip> lst;

        public TrivialBlue()
        {
            lst = new List<Bluechip>()
            {
                new Bluechip()
                {
                    Nome = "Intesa San Paolo",
                    Nazione = "Italia",
                    Simbolo = "I&TS"
                },
                new Bluechip()
                {
                    Nome = "Campari",
                    Nazione = "Italia",
                    Simbolo = "C<3"
                },
                new Bluechip()
                {
                    Nome = "Amazon",
                    Nazione = "USA",
                    Simbolo = "AMZ"
                },
                new Bluechip()
                {
                    Nome = "Fly Emirates",
                    Nazione = "Emirati Arabi",
                    Simbolo = "FLYEM"
                },
                new Bluechip()
                {
                    Nome = "Huawei",
                    Nazione = "Cina",
                    Simbolo = "HUA"
                },
                 new Bluechip()
                 {
                     Nome = "Samsung",
                     Nazione = "Sud Corea",
                     Simbolo = "SMG"
                 },
                 new Bluechip()
                 {
                     Nome = "Petronas",
                     Nazione = "Malesia",
                     Simbolo = "PETRA"
                 }
            };
        }
        public List<Bluechip> GetAllBluechips()
        {
            return lst;
        }

        public Bluechip GetBluechipBySimbol(string Simbolo)
        {
            return lst.Where(e => e.Simbolo == Simbolo).FirstOrDefault();
        }
    }
}
