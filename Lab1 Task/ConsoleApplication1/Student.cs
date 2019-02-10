using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        private String name, id, department;
        private float cgpa;
        public Student()
        {
        }
        public Student(String name, String id, String department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetId(String id)
        {
            this.id = id;
        }
        public void SetDepartment(String department)
        {
            this.department = department;
        }
        public void SetCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public String GetName()
        {
            return name;
        }
        public String GetId()
        {
            return id;
        }
        public String GetDepartment()
        {
            return department;
        }
        public float GetCgpa()
        {
            return cgpa;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("The Name Is: " + GetName());
            System.Console.WriteLine("The Id Is: " + GetId());
            System.Console.WriteLine("The Department Is: " + GetDepartment());
            System.Console.WriteLine("The CGPA Is: " + GetCgpa());
        }
        
    }
}
