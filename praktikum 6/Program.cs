using System;

namespace praktikum_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("mike", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "math");
            teacher.GetNameAndAge();

            Students students = new Students("sara", 19, "10506", "sara1234@amikom.ac.id");
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
