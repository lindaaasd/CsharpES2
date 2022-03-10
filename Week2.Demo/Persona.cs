using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Demo
{
    internal class Persona
    {
        public static string Codice = "PERS";

        //campi
        private string _nome = "Giovanni";
        private string _password;
        private double _stipendio = 1234.5;

        //proprietà
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; } 
        }

        public DateTime DataNascita { get; set; } = new DateTime(1990, 1, 1);

        //proprietà calcolata e read-only
        public int Eta
        {
            get { return DateTime.Today.Year - DataNascita.Year; }
        }

        //proprietà write-only
        public string Password
        {
            set { _password = value; }
        }
        

        public bool ValidaPassword(string passwordDaControllare)
        {
            if(passwordDaControllare == _password)
            {
                return true;
            }
            return false;
        }

        public string GetClasseSociale()
        {
            if(_stipendio > 2000)
            {
                return "Persona ricca";
            }
            else
            {
                return "Ceto medio";
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Data di nascita: {DataNascita.ToShortDateString()}";
        }
    }
}
