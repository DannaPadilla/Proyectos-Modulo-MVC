using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    internal class School : Entity
    {
        public string Street { get; set; }
        public List<Student> Students { get; set }

        public School (string Id, string street): base(Id)
        {
            Street = street;
            Students= new List<Student>();
        }
        public void AddStudents (Student student)
        {
            this.Students.Add(student);
        }
    }
}
