using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace First_Step
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Привет мир!!");
            try
            {
                Person person = new Person("Пчельник Сергей Сергеевич", "мужской", 27);
                person.Print();
                Person director = new Person("Михаил Андреевич Иванов", "мужской", 40);
                Organization organization = new Organization("1C", 1991, director);
                Console.WriteLine();
                organization.Print();
                Worker worker = new Worker("Иван Васильевич Петров", "мужской", 30);
                HR.Empoloy(worker, organization);
                Console.WriteLine();
                worker.Print();
                HR.Dismiss(worker);
                Console.WriteLine();
                Console.WriteLine("Увольняем человека...");
                worker.Print();
                Person people = new Person();
                people.Input();
                people.Print();
            }
            catch
            {
                Console.WriteLine("Ошибка");
                return;
            }
            Console.ReadLine();
        }
    }
}
