using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Step
{
    internal class Worker : Person
    {
        string _position;
        float _salary;
        Organization _workPlace;

        public string GetPosition()
        {
            return _position;
        }
        public float GetSalary()
        {
            return _salary;
        }
        public Organization GetWorkPlace()
        {
            return _workPlace;
        }
        public void SetPosition(string position)
        {
            _position = position;
        }
        public void SetSalary(float salary)
        {
            _salary = salary;
        }
        public void SetWorkPlace(Organization workplace)
        {
            _workPlace = workplace;
        }
        public Worker(string fio, string gender, int age)
        {
            Fio = fio;
            Gender = gender;
            Age = age;
        }

        public override void Print()
        {
            Console.WriteLine("Контактные данные человека:");
            Console.WriteLine("ФИО - " + Fio);
            Console.Write("пол - " + Gender);
            Console.WriteLine(", возраст - " + Age + " год/а,");
            if (_workPlace != null)
            {

                Console.Write("работает в компании " + GetWorkPlace().Name);
                Console.WriteLine(" на должности " + GetPosition());
                Console.WriteLine("С заработной платой " + GetSalary() + " рублей");
            }
            else
            {
                Console.WriteLine("Данный человек беден и безработен(");
            }
        }
    }
}
