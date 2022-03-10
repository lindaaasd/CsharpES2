using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Demo.Bollette.Entities
{  
    internal class Bolletta
    {
        public string UnitaDiMisura { get; set; } = "xxxxx";
        public double ConsumoTotale { get; set; }
        public DateTime DataScadenza { get; set; } = new DateTime(2000, 1, 1);
        public double Importo { get { return CalcolaBolletta(); } }
        public string TipoBolletta { get; set; } = "xxxxx";
        public Utente UtenteBolletta { get; set; }

        private double CalcolaBolletta()
        {
            return 40 + (ConsumoTotale * 10);
        }

        public override string ToString()
        {
            //string stringaDaStampare = "Bolletta" + TipoBolletta + "per l'utente \n" 
            //    + UtenteBolletta + "\n" 
            //    + "Consumo totale: " + ConsumoTotale + UnitaDiMisura 
            //    + " - Importo: " + Importo + " euro \n" 
            //    + "Data scadenza: " + DataScadenza.ToShortDateString();
            string stringaDaStampare = $"Bolletta {TipoBolletta} per l'utente \n " +
                $"{UtenteBolletta} \n Consumo totale: {ConsumoTotale} {UnitaDiMisura} " +
                $"- Importo: {Importo} euro \n Data scadenza: {DataScadenza.ToShortDateString()}";
            return stringaDaStampare;
        }

    }
}
