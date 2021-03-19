using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Prb.Composition.Classrooms.Core.Entities;

namespace Prb.Composition.Classrooms.Core.Services
{
    public class StudentService
    {
        public List<Student> Students { get; private set; }
        public StudentService()
        {
            Students = new List<Student>();
            DoSeeding();
            Sort();
        }
        private void DoSeeding()
        {
            Students.Add(new Student("Bakker", "Bram", new DateTime(2005, 5, 13), Gender.Male));
            Students.Add(new Student("Antierens", "An", new DateTime(2005, 6, 14), Gender.Female));
            Students.Add(new Student("Carlier", "Charles", new DateTime(2005, 7, 15), Gender.Male));
            Students.Add(new Student("Debrom", "Dean", new DateTime(2005, 8, 16), Gender.Male));
            Students.Add(new Student("Everaert", "Els", new DateTime(2005, 9, 17), Gender.Female));
            Students.Add(new Student("Filips", "Filip", new DateTime(2006, 5, 13), Gender.Female));
            Students.Add(new Student("Geeraert", "Gerda", new DateTime(2006, 6, 14), Gender.Female));
            Students.Add(new Student("Haviksen", "Harald", new DateTime(2006, 7, 15), Gender.Male));
            Students.Add(new Student("Israel", "Ismael", new DateTime(2006, 8, 16), Gender.Male));
            Students.Add(new Student("Jefferson", "Jessica", new DateTime(2006, 9, 17), Gender.Female));
            Students.Add(new Student("Kachels", "Karel", new DateTime(2007, 5, 13), Gender.Male));
            Students.Add(new Student("Lemmens", "Lien", new DateTime(2007, 6, 14), Gender.Female));
            Students.Add(new Student("Maertens", "Miel", new DateTime(2007, 7, 15), Gender.Male));
            Students.Add(new Student("Nuyens", "Niels", new DateTime(2007, 8, 16), Gender.Male));
            Students.Add(new Student("Oprah", "Odette", new DateTime(2007, 9, 17), Gender.Female));
            Students.Add(new Student("Philips", "Philip", new DateTime(2008, 5, 13), Gender.Female));
            Students.Add(new Student("Quintens", "Quinta", new DateTime(2008, 6, 14), Gender.Female));
            Students.Add(new Student("Ravensijde", "Ralf", new DateTime(2008, 7, 15), Gender.Male));
            Students.Add(new Student("Stybar", "Stan", new DateTime(2008, 8, 16), Gender.Male));
            Students.Add(new Student("Taverne", "Tina", new DateTime(2008, 9, 17), Gender.Female));
            Students.Add(new Student("Uytenbroek", "Ulla", new DateTime(2008, 9, 17), Gender.Female));
            Students.Add(new Student("Vandevelde", "Vera", new DateTime(2008, 9, 17), Gender.Female));
            Students.Add(new Student("Willems", "Wilma", new DateTime(2008, 9, 17), Gender.Female));
            Students.Add(new Student("Xanadu", "Xantha", new DateTime(2008, 9, 17), Gender.Female));
            Students.Add(new Student("Yperman", "Yvette", new DateTime(2008, 9, 17), Gender.Female));
            Students.Add(new Student("Zwavels", "Zulma", new DateTime(2008, 9, 17), Gender.Female));
        }
        private void Sort()
        {
            Students = Students.OrderBy(s => s.Name).ThenBy(s => s.Firstname).ToList();
        }

        public List<Student> AvailableStudents(Classroom classroom)
        {
            List<Student> availableStudents = new List<Student>();
            foreach (Student student in Students)
            {
                if(! classroom.StudentsInClassroom.Contains(student))
                {
                    availableStudents.Add(student);
                }
            }
            return availableStudents;
        }
    }
}
