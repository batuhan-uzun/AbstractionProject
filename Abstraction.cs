using AbstractionProject;

Employee manager = new ProjectManager() // Created a ProjectManager object of type Employee
{
    Name = "Hasan",
    Surname = "Çıldırmış",
    Department = "Project Manager",
};

manager.DepartmentInfo(); // DepartmentInfo abstract method inherited from Employee in Manager object was executed

