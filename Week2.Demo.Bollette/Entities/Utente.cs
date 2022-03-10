using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Demo.Bollette.Entities
{
    internal class Utente
    {
        private string _codice = "xxxxx";
        private string _nome = "xxxx";
        private string _cognome = "xxxxx";
        private DateTime _dataNascita = new DateTime(2000, 1, 1);

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        public override string ToString()
        {
            return $"Codice Utente {Codice} - Nome: {Nome} - Cognome: {Cognome} - Data di nascita: {DataNascita.ToShortDateString()}";
        }

    }
}
