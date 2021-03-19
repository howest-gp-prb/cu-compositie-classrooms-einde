using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Prb.Composition.Classrooms.Core.Entities
{
    public class Classroom
    {
        public string ClassName { get; set; }
        public List<Student> StudentsInClassroom { get; set; }
        public Classroom()
        {
            StudentsInClassroom = new List<Student>();
        }
        public Classroom(string className) : this()
        {
            ClassName = className;
        }
        public override string ToString()
        {
            return $"{ClassName}";
        }
        public void AddStudent(Student student)
        {
            StudentsInClassroom.Add(student);
            Sort();
        }
        public void RemoveStudent(Student student)
        {
            StudentsInClassroom.Remove(student);
        }
        private void Sort()
        {
            StudentsInClassroom = StudentsInClassroom.OrderBy(s => s.Name).ThenBy(s => s.Firstname).ToList();
        }
    }
}
