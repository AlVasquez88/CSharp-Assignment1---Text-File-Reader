using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///I, Alvin Vasquez, 000857238, certify that this material is my original work.
///No other person's work has been used without due acknowledgement.
///<summary>
///This program stores and reads the employees.txt.
///</summary>
///version: Employee.cs
///Date: 9/21/2-24

namespace EmployeeDataBase
{
    internal class Employee
    {
        /**<param name="name">name assigned as a private field for storing the name of the Employee.</param>*/
        private String name;
        /**<param name="number">number assigned as a private field for storing the ID integer number of the Employee.</param>*/
        private int number;
        /**<param name="rate">rate assigned as private field for storing the decimal pay rate of the Employee.</param>*/
        private decimal rate;
        /**<param name="hours">hours assigned as a private field for storing the amount of hours worked of that Employee.</param> */
        private double hours;

        //Method constructor 
        public Employee(String name, int number, decimal rate, double hours) {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }
        //Access method for getting the hours of the employee
        public double GetHours() {  return hours; } 
        //Access method for getting the name of the employee
        public String GetName() {  return name; }
        //Access method for getting the number ID of the employee
        public int GetNumber() { return number; }
        //Access method for getting the pay rate of the employee
        public decimal GetRate() { return rate; }
        //ToString method that outputs the name, ID, rate of pay, and hours worked of the employee
        override
        public String ToString() { return "ID: " + number + "\tName: " + name + "\tRate of Pay: " + rate + "\tHours Worked: " + hours; }
        //Mutator method for storing the hours worked on that employee
        public void SetHours(double hours) { this.hours = hours;}
        //Mutator method for storing the name of the employee
        public void SetName(String name) { this.name = name;}
        //mutator method for storing the ID of the employee
        public void SetNumber(int number) {  this.number = number;}
        //mutator method for storing the pay rate of the employee
        public void SetRate(decimal rate) { this.rate = rate; }

    }
}
