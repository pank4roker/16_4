using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datenow=DateTime.Now;
            Write("Введите количество сотрудников:");
            int n = Convert.ToInt32(ReadLine());
            Employees[] employees = new Employees[n];
            for(int i =0;i<employees.Length; i++)
            {
                Write("Введите табельтный номер: ");
                int number = Convert.ToInt32(ReadLine());
                Write("Введите имя: ");
                string name = ReadLine();
                Write("Введите фамилию: ");
                string surname = ReadLine();
                Write("Введите отчество: ");
                string otchestvo = ReadLine();
                Write("Введите дату рождения: ");
                DateTime dayofbirth = DateTime.Parse(ReadLine());
                Write("Введите оклад: ");
                double salary = Convert.ToDouble(ReadLine());
                employees[i] = new Employees(number,name,surname,otchestvo,dayofbirth,salary,datenow);
                WriteLine();
                
            }
            foreach(var employee in employees)
            {
                employee.OutPut();
                WriteLine();
            }
            ReadKey();
        }
    }
}
