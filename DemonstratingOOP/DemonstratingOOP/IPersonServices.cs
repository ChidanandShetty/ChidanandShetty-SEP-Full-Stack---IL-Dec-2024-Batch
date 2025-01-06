using System;
using System.Collections.Generic;

interface IPersonService
{
    int CalculateAge();
    void DisplayAddresses();
}

interface IStudentService : IPersonService
{
    double CalculateGPA();
}

interface IInstructorService : IPersonService
{
    decimal CalculateSalary();
}
