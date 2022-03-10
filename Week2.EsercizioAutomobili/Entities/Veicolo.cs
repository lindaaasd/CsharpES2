using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.EsercizioAutomobili.Entities
{
    internal class Veicolo
    {
        public String Targa { get; set; }
        public int Kilowatt { get; set; }
        public int AnnoImmatricolazione { get; set; }

        public double PrezzoAcquisto { get; set; }
        public string Tipologia { get; set; }
        public double Bollo { get { return CalcolaBollo(); } }

        public double CalcolaBollo()
        {
            double bollo = 0.0;
            switch (Tipologia)
            {
                case "EURO1":
                    if (Kilowatt > 100)
                    {
                        bollo = 4.35;
                    }
                    else
                    {
                        bollo = 2.90;
                    }
                    break;
                case "EURO2":
                    if (Kilowatt > 100)
                    {
                        bollo = 4.20;
                    }
                    else
                    {
                        bollo = 2.80;
                    }
                    break;
                case "EURO3":
                    if (Kilowatt > 100)
                    {
                        bollo = 4.05;
                    }
                    else
                    {
                        bollo = 2.70;
                    }
                    break;
                default:
                    if (Kilowatt > 100)
                    {
                        bollo = 3.87;
                    }
                    else
                    {
                        bollo = 2.58;
                    }
                    break;
            }
            return bollo;
        }

        public override string ToString()
        {
            return $"Targa: {Targa} - Anno immatricolazione: {AnnoImmatricolazione} \n" +
                $"Kilowatt: {Kilowatt} - Tipo Euro: {Tipologia} \n" +
                $"Prezzo Acquisto: {PrezzoAcquisto} euro - Bollo: {Bollo} euro";
        }
    }
}
