using System;
using System.Collections.Generic;
using System.Text;

namespace Primero
{
    class Person
    {
        private string _name;
        private int _age;
        
        private Person()
        {
            _name = string.Empty;
            _age = 0;
        }
        public Person(string name, int age) : this()
        {
            _name = name;
            _age = age;
        }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        
        public void Salute()
        {
            Console.WriteLine("Hello "+_name+" with the age of "+_age);
        }
    }
}
