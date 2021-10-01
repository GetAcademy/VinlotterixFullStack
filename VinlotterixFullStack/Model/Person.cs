using System;

namespace VinlotterixFullStack.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }

        public Person(string name) : this()
        {
            Name = name;
        }
    }
}
