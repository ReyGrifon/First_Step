using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Step
{
    internal class Person
    {
        string _fio;
        bool _gender;
        int _age;

        public string Fio
        {
            set
            {
                if (VariableVerification.CheckFio(value))
                {
                    _fio = value;
                }
            }
            get
            {
                return _fio;
            }
        }
        public string Gender
        {
            set
            {
                if (VariableVerification.CheckGender(value))
                {
                    if (value == "мужской")
                    {
                        _gender = false;
                    }
                    else
                    {
                        _gender = true;
                    }
                }
            }
            get
            {
                if (_gender == false)
                {
                    return "мужской";
                }
                else
                {
                    return "женский";
                }
            }
        }

        public int Age
        {
            set
            {
                    VariableVerification.CheckAge(value);
                    _age = value;
                }
            get 
            { 
                return _age; 
            }
        }

        public int GetAge()
        {
            return _age;
        }
        public Person(string fio, string gender, int age)
        {
            Fio = fio;
            Gender = gender;
            Age = age;
        }
        public Person()
        {

        }
        ~Person()
        {

        }
        public virtual void Print()
        {
            Console.WriteLine("ФИО - " + Fio);
            Console.Write("пол - " + Gender);
            Console.WriteLine(",возраст - " + Age + " год/а,");
        }
        public void Input()
        {
            string fio;
            string gender;
            int age;
            Console.WriteLine("Введите контактные данные сотрудника:");
            Console.Write("Введите Фио - ");
            fio = Console.ReadLine();
            Console.Write("Введите пол - ");
            gender = Console.ReadLine();
            Console.Write("Введите возраст - ");
            age = Convert.ToInt32(Console.ReadLine());
            Fio = fio;
            Gender = gender;
            Age = age;
        }
    }
}
