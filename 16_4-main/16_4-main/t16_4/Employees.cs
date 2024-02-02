using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t16_4
{
    /// <summary>
    /// Класс сотрудников
    /// </summary>
    class Employees
    {
        /// <summary>
        /// поле описывающее табельный номер
        /// </summary>
        private int number;

        public int Number { get => (number > 0) ? number:0; set => number = value; }
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        private string name;
        public string Name { get => (name != " ") ? name : "Unknown"; set => name = value; }
        /// <summary>
        /// поле описывающее фамилию
        /// </summary>
        private string surname;
        public string Surname { get => (surname != " ") ? surname : "Unknown"; set => surname = value; }
        /// <summary>
        /// поле описывающее отчество
        /// </summary>
        private string otchestvo;
        public string Otchestvo { get => (otchestvo != " ") ? otchestvo:"Unknown"; set => otchestvo = value; }
        /// <summary>
        /// поле описывающее дату рождения
        /// </summary>
        private DateTime dateofbirth;
        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        /// <summary>
        /// поле описывающее оклад
        /// </summary>
        private double salary;
        public double Salary { get => (salary >= 0) ?  salary:0; set => salary = value; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Employees() { }
        /// <summary>
        /// Поле с нынешней датой
        /// </summary>
        private DateTime datenow;
        public DateTime Datenow { get => datenow; set => datenow = value; }
        private string date;
        public string Date { get => date; set => date = value; }
        /// <summary>
        /// Конструктор с параметров
        /// </summary>
        public Employees(int number, string name, string surname, string otchestvo, DateTime dateofbirth, double salary, DateTime datenow)
        {
            this.number = number;
            this.name = name;
            this.surname = surname;
            this.otchestvo = otchestvo;
            this.dateofbirth = dateofbirth;
            this.salary = salary;
            this.datenow = datenow;
            
            if(datenow.Month<dateofbirth.Month)
            {
                date = datenow.AddYears(-dateofbirth.Year-1).ToString("yyy");
            }
            else if(datenow.Month == dateofbirth.Month)
            {
                if(datenow.Day < dateofbirth.Day)
                {
                    date = datenow.AddYears(-dateofbirth.Year - 1).ToString("yyy");
                }
                else
                {
                    date = datenow.AddYears(-dateofbirth.Year).ToString("yyy");
                }
            }
            else
            {
               date = datenow.AddYears(-dateofbirth.Year).ToString("yyy");
            }
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        public void OutPut()
        {
            WriteLine($"Табельный номер:{Number}\nИмя:{Name}\nФамилия:{Surname}\nОтчество:{Otchestvo}\nДата рождения:{Dateofbirth}\nОклад:{Salary}\nВозраст:{Date}");
        }
        public void Out()
        {
            
        }




    }
}
