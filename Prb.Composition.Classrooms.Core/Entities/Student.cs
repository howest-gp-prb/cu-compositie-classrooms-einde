using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Composition.Classrooms.Core.Entities
{
    public enum Gender { Male, Female, Unknown}
    public class Student
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Student()
        { }
        public Student(string name, string firstname, DateTime birthDate, Gender gender)
        {
            Name = name;
            Firstname = firstname;
            BirthDate = birthDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"{Name} {Firstname}";
        }
    }
}
