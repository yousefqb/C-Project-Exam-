using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Subjects
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Subject(int id,string name)
        {
            SubjectId = id;
            SubjectName = name;
        }
    }
}
