using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Step
{
    internal static class VariableVerification
    {
        static public bool CheckFio(string fio)
        {
            foreach(var c in fio)
            {
                if (c  >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == ' ')
                {
                }
                else
                {
                    throw new Exception("Ошибка");
                }
            }
            return true;
        }

        static public bool CheckAge(int age)
        {
            if (age > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("Ошибка");
            }
        }

        static public bool CheckGender(string gender)
        {
            if (gender == "мужской" || gender == "женский")
            {
                return true;
            }
            else
            {
                throw new Exception("Ошибка");
            }
        }

        static public bool CheckYear(int year)
        {
            if (year > 0 && year <= 2022)
            {
                return true;
            }
            else
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
