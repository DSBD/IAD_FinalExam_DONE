using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAD_FinalExam
{
    public class Task
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string desc, DateTime ddate)
        {
            Description = desc;
            DueDate = ddate;
        }
    }
}