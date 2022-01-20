using System;

namespace lab01_9033_OOP
{
    class Person
    {
        private string name;

        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
