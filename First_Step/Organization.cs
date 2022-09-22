using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Step
{
    internal class Organization
    {
        string _name;
        int _yearOfFoundation;
        Person _director;

        public string Name
        {
            get 
            { 
                return _name;
            }
            set 
            { 
                _name = value; 
            }
        }
        void SetYear(int year)
        {
            if (VariableVerification.CheckYear(year))
            {
                _yearOfFoundation = year;
            }
        }

        int GetYear()
        {
            return _yearOfFoundation;
        }

        public Organization(string name, int yearOfFoundation, Person director)
        {
            Name = name;
            SetYear(yearOfFoundation);
            _director = director;
        }

        public void Print()
        {
            Console.WriteLine("Контактные данные компании");
            Console.Write("Название компании - " + Name);
            Console.WriteLine(", Год основания - " + GetYear());
            Console.WriteLine("Контактные данные директора:");
            _director.Print();
        }
    }
}
