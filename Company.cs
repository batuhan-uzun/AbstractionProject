using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionProject
{
    public abstract class Employee
    {
        public string Name { get; set; } // 
        public string Surname { get; set; } // Employee properties
        public string Department { get; set; } //
        public abstract void DepartmentInfo(); // Defined abstract method to use in different ways in each department
    }
    
    public class SoftwareDeveloper : Employee
    {
        public override void DepartmentInfo() // Abstract method overridden for Software Developer
        {
            Console.WriteLine("I am {Name} {Surname}, working as a Software Developer");
        }
    }

    public class ProjectManager : Employee
    {
        public override void DepartmentInfo() // Abstract method overridden for Project Manager
        {
            Console.WriteLine("I am {Name} {Surname}, working as a Project Manager");
        }
    }

    public class SalesRepresentative : Employee
    {
        public override void DepartmentInfo() // Abstract method overridden for Sales Representative
        {
            Console.WriteLine("I am {Name} {Surname}, working as a Sales Representative");
        }
    }
}
