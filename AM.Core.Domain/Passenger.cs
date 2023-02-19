using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";"
                + "PassportNumber:" + PassportNumber + ";"
                + "EmailAdresse:" + EmailAddress + ";"
                + "FirstName:" + FirstName + ";"
                + "LastName:" + LastName + ";"
                + "TelNumber:" + TelNumber + ";"
                + "Age:" + Age;
        }

        public bool CheckProfile(string firstName, string lastName) { 
        if (FirstName==firstName&& LastName==lastName) 
                return true;
        return false;
                }
        /*
        //Q11.b
        public bool CheckProfile(string lastname, string firstname, string emailAdresse)
        {
            if (lastname == LastName && firstname == FirstName && emailAdresse==EmailAdresse)
                return true;
            return false;
        }
        */
        //Q11.c (on a remplacer les 2 fonctions Q11.a et 11.B - c'est comme un optimisation de code mais il est plus difficle et complexe)

        public bool CheckProfile(string firstname, string lastname, string email = null)
        {
            if (EmailAddress == null)
            
                return FirstName == firstname && LastName == lastname;
            
            else
                return FirstName == firstname && LastName == lastname && EmailAddress == email;
        }
        public virtual string GetPassengerType()
        {
            return "I am a Passenger";
        }

        public void GetAge(DateTime birthDate, int calculatedAge)
        {
            // Calculer l'âge en soustrayant la date de naissance de la date actuelle
            Age = DateTime.Now.Year - birthDate.Year;

            // Si la date de naissance n'est pas encore passée cette année, réduire l'âge de 1
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                Age--;
            }

            calculatedAge = Age;
        }

        public void GetAge(Passenger aPassenger)
        {
            // Calculer l'âge à partir de la date de naissance du passager
            GetAge(aPassenger.BirthDate, aPassenger.Age);
        }
    }
}
