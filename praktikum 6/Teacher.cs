using System;

namespace praktikum_6
{
    public class Teacher : Person
    {
        public Teacher(string name, int age, string teacherid, string subject) : base(name, age)
        {
            Name = name;
            Age = age;
            TeacherId = teacherid;
            Subject = subject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }
    }
}
