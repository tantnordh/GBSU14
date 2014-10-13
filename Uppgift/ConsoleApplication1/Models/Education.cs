using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{
    class Education
    {
        public string EducationName { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public List<EducationStart> EducationStarts { get; set; }
    }
}
