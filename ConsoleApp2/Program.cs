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
            Turner turnerObject = new Turner("Хм хм хм", 22, 10, 292, 1, 0); 
            
            
            employeeObject.showInfo(); 
            turnerObject++; 
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
            return _fio;
        }

        public int getAge() 
        {
            return _age;
        }

        public int getStage() 
        {
            return _stage;
        }

        public int getNumber() 
        {
            return _number;
        }

        public void showInfo() 
        { 
            Console.WriteLine("Ваше Ф.И.О: " + _fio + "\nВаш возраст: " + _age + "\nВаш стаж: " + _stage + "\nВаш табельный номер: " + _number );
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
            return _department;
        }

        public int getExp() 
        {
            return _experience;
        }
      
        public static Turner operator ++(Turner Experience) 
        {
            Experience._experience += 1;
            return Experience;
        }
    }   
}