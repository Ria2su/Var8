using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2 {

    class Program {

        static void Main(string[] args)
        {
            Employee employeeObject = new Employee("Хм хм хм", 22, 10, 292); 
            Turner turnerObject = new Turner("Хм хм хм", 22, 10, 292, 2, 1);
            string number;
            bool isOpen = true;
            
            while (isOpen) 
            {
                Console.WriteLine("Введите цифру для вывода информации: \n" + "1 - Ф.И.О.\n" + "2 - Возраст\n" + "3 - Табельный номер \n" + "4 - Стаж \n" + "5 - Опыт работы \n" + "6 - Номер цеха \n"
                   + "7 - Смена цеха \n" + "8 - Прибавка к опыту на предприятии \n" + "9 - Вывод полной информации \n" + "10 - Выйти");
                number = Console.ReadLine();

                switch (number)
            {
                case "1":
                    turnerObject.getFio();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                    break;
                case "2":
                    turnerObject.getAge();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "3":
                    turnerObject.getNumber();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "4":
                    turnerObject.getStage();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "5":
                    turnerObject.getExp(); 
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "6":
                    turnerObject.getDepartment();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "7":
                    Console.WriteLine("Введите индекс цеха, в который вы хотите перевести работника: ");
                        turnerObject.ChangeDepartment(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Работник переведен в цех " + turnerObject.getDepartment());
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "8":
                    turnerObject++;
                        Console.WriteLine("Опыт работы на предприятии увеличен на 1 год. Опыт работы: " + turnerObject.getExp());
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "9":
                    turnerObject.ShowInfo();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "10":
                    isOpen = false;
                        break;
                default:
                    Console.WriteLine("Введите правильное значение");
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
            }



            }
        }
    }
    
    
    class Employee {

        private string _fio; 
        private int _age;    
        private int _stage;  
        private int _number; 

        public Employee(string fio, int age, int stage, int number) 
        { 
            _fio    = fio;
            _age    = age;
            _stage  = stage;
            _number = number;
        }

        public string getFio() 
        {
            Console.WriteLine("Ф.И.О: " + _fio);
            return _fio;
        }

        public int getAge() 
        {
            Console.WriteLine("Возраст: " + _age);
            return _age;
        }

        public int getStage() 
        {
            Console.WriteLine("Стаж: " + _stage);
            return _stage;
        }

        public int getNumber() 
        {
            Console.WriteLine("Табельный номер: " + _number);
            return _number;
        }
        


    }


    class Turner : Employee 
    {
        
        private int _department;
        private int _experience;

        public Turner(string fio, int age, int stage, int number, int department, int experience)
          : base(fio, age, stage, number) 
        {
            _department = department;
            _experience = experience;
        }

        public void ChangeDepartment(int newValue) 
        {
            _department = newValue;
        }

        public int getDepartment() 
        {
            Console.WriteLine("Номер цеха: " + _department);
            return _department;
        }

        public int getExp() 
        {
            Console.WriteLine("Опыт работы: " + _experience);
            return _experience;
        }

        public static Turner operator ++(Turner Experience) 
        {
            Experience._experience += 1;
            return Experience;
        }
         public void ShowInfo()
        {
            Console.WriteLine("Ваше Ф.И.О: " + _fio + "\nВаш возраст: " + _age + "\nВаш стаж: " + _stage + "\nВаш табельный номер: " + _number + "\nОпыт работы на предприятии: " 
                + _experience + "\nВаш цех: " + _department);
        }
    }   
}