using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_infor
{
    internal class Student_infor
    {
        protected string description;
        

        public Student_infor()
        {
            this.setDescription("Default Student_infor");
        }
        public Student_infor(string description)
        {
            this.setDescription(description);
        }
        public string getDescription()
        {
            return description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void displayStudent_infor()
        {
            Console.WriteLine(getDescription());
        }
    }
}
