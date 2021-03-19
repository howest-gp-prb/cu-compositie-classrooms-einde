using System;
using System.Collections.Generic;
using System.Text;
using Prb.Composition.Classrooms.Core.Entities;
using System.Linq;

namespace Prb.Composition.Classrooms.Core.Services
{
    public class ClassroomService
    {
        public List<Classroom> Classrooms { get; private set; }
        public ClassroomService()
        {
            Classrooms = new List<Classroom>();
            DoSeeding();
        }
        private void DoSeeding()
        {
            Classrooms.Add(new Classroom("1A"));
            Classrooms.Add(new Classroom("1B"));
            Classrooms.Add(new Classroom("2A"));
            Classrooms.Add(new Classroom("2B"));
            Classrooms.Add(new Classroom("3A"));
            Classrooms.Add(new Classroom("3B"));

        }
        private void Sort()
        {
            Classrooms = Classrooms.OrderBy(c => c.ClassName).ToList();
        }


    }
}
