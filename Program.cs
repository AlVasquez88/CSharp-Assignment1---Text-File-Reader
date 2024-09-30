using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**<summary>I, Alvin Vasquez, 000857238, certify that this material is my original work.
 No other person's work has been used without due acknowledgement.
This program is the output program file that displays when sorting and reading employees.txt
file.
version: Program.cs
Date: 9/21/2-24</summary>*/

namespace EmployeeDataBase
{
    internal class Program
    {
        const string DATAFILE = "employees.txt";
        static void Main(string[] args)
        {
            
            ///I applied the similar concept to the Person.cs sample exercise as a useful template to begin this assignment.
            
            
            Employee[] employee = new Employee[100];
            ///<param name="numberOfEmployees">assigned as an integer field to store the index amount of employees in the employees.txt file.</param>
            int numberOfEmployees = 0;
            ///using exception handling to ensure that numberOfEmployees is reading the array with the EmployeeReader method.
            try
            {
                numberOfEmployees = EmployeeReader(employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Read DATAFILE." + ex.Message);
                return;
            }

            ///<param name="running">assigned as a boolean field to be used in the while loop.</param>
            bool running = true;
            while (running)
            {
                Console.Clear(); //Clearing the console before loading the main menu

                Console.Write("_::COFFEE KNIGHTS INC.::_\n=========================\n" +
                    "Menu\n____\n" +
                    "[1] - Sort by Employee Name\n" +
                    "[2] - Sort by Employee ID\n" +
                    "[3] - Sort by Employee Pay Rate\n" +
                    "[4] - Sort by Employee Hours\n" +
                    "[5] - Sort by Employee Gross Pay\n" +
                    "[6] - Exit\n\n" +
                    "Option: ");
                ///<param name="option">Assigned as String field to read the appropiate cases within the switch statement before execution.</param>
                String option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ///<summary>
                        ///Using Lambda expression while using Comparer T class with Create() method and ComepareTo() method to sort
                        ///one name that is employee1 and take another name as employee2 and sort it in ascending order with
                        ///the GetName method.
                        ///Citation for Lambda Expressions:https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions 
                        ///Citation for Comparer T Class.Create(Comparison T) Method: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.comparer-1.create?view=net-8.0
                        ///Citation for ComepareTo() Method: https://learn.microsoft.com/en-us/dotnet/api/system.string.compareto?view=net-8.0 
                        /// Citation for Sort(): https://www.c-sharpcorner.com/article/how-to-sort-an-array-in-c-sharp/
                        /// </summary>
                        

                        try //using exception handling in case the the program was able to run through without the text file.
                        {
                            Array.Sort(employee, 0, numberOfEmployees, Comparer<Employee>.Create((employee1, employee2) => employee1.GetName().CompareTo(employee2.GetName())));
                            ///displaying the table ToString after the array assortment with the EmployeeTable method.
                            EmployeeTable(employee, numberOfEmployees);
                            ///displaying how choosing option 1 is sorted by name.
                            Console.WriteLine("\nEmployees sorted by name(ascended).");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot Find Employee names." + ex.Message);
                        }
                        break;
                    case "2":
                        try //using exception handling in case the user chooses option 2 without the text file present.
                        {
                            ///<summary>
                            ///sorting the employees.txt file by ID number using lambda expression, Comparer T method.Create(), and ComepareTo() method
                            ///to sort the ID numbers in ascending order.
                            /// </summary>
                            
                            Array.Sort(employee, 0, numberOfEmployees, Comparer<Employee>.Create((employee1, employee2) => employee1.GetNumber().CompareTo(employee2.GetNumber())));
                            //displays the array as a table ToString after the array assortment with the EmployeeTable method.
                            EmployeeTable(employee, numberOfEmployees);
                            //displaying how choosing option 2 is sorted by Employee ID number.
                            Console.WriteLine("\nEmployees sorted by ID numbers(ascended).");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot find Employee ID number." + ex.Message);
                        }
                        break;
                    case "3":
                        try //Using exception handling in case the user chooses case 3 without the respective txt file
                        {
                            ///<summary>
                            ///sorting the employees.txt file by Pay Rate using lambda expression, Comparer T method.Create(), and ComepareTo() method
                            ///to sort the Employee Pay Rate in ascending order.
                            /// </summary>
                            
                            Array.Sort(employee, 0, numberOfEmployees, Comparer<Employee>.Create((employee1, employee2) => employee1.GetRate().CompareTo(employee2.GetRate())));
                            ///reversing the assortment with the Reverse() method to sort the array in descending order
                            ///Citation for Reverse(): https://www.c-sharpcorner.com/article/how-to-sort-an-array-in-c-sharp/
                            Array.Reverse(employee, 0, numberOfEmployees);
                            //displays the array as a table ToString after the assortment with the EmployeeTable method.
                            EmployeeTable(employee, numberOfEmployees);
                            //displays how choosing option 3 is sorted by Employee Pay Rate.
                            Console.WriteLine("\nEmployees sorted by Pay Rate(descended).");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot find Employee Pay Rate" + ex.Message);
                        }
                        break;
                    case "4":
                        try //Using exception handling in case the user chooses case 4 without the respective text file
                        {
                            ///<summary>
                            ///sorting the employees.txt file by Hours Worked using lambda expression, Comparer T method.Create(), and ComepareTo() method
                            ///to sort the Employee Hours in ascending order.
                            /// </summary>
                            
                            Array.Sort(employee, 0, numberOfEmployees, Comparer<Employee>.Create((employee1, employee2) => employee1.GetHours().CompareTo(employee2.GetHours())));
                            //reversing the assortment in descending order
                            Array.Reverse(employee, 0, numberOfEmployees);
                            //displaying the array as a table ToString
                            EmployeeTable(employee, numberOfEmployees);
                            //displaying how choosing option 4 is sorted by Hours worked on each employee.
                            Console.WriteLine("\nEmployees sorted by Hours Worked(descended).");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot find Employee Hours." + ex.Message);
                        }
                        break;
                    case "5":
                        try //Using exception handling in case the user choose case 5 without the respective text file
                        {
                            ///<summary>
                            ///sorting the employees.txt file by Hours Worked and Pay Rate using lambda expression, Comparer T method.Create(), and ComepareTo() method
                            ///to sort the Employee Hours in ascending order where employee1 for Employee Pay Rate is multiplied by employee1 for Hours Worked. This also applies
                            ///to employee2 for employee Pay Rate being multipied by employee2 for hours worked.
                            ///citation for being able to multiply using lambda expressions: https://www.csharptutorial.net/csharp-tutorial/csharp-lambda-expression/
                            /// </summary>
                            
                            Array.Sort(employee, 0, numberOfEmployees, Comparer<Employee>.Create((employee1, employee2) =>
                            (employee1.GetRate() * (decimal)employee1.GetHours()).CompareTo(employee2.GetRate() * (decimal)employee2.GetHours())));
                            //sorting the array in descending order
                            Array.Reverse(employee, 0, numberOfEmployees);
                            //displaying the array as a table ToString
                            EmployeeTable(employee, numberOfEmployees);
                            Console.WriteLine("\nEmployees sorted by Gross Pay(descended).");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot find Employee Gross Pay." + ex.Message);
                        }
                        break;
                    case "6":
                        //displaying Exiting message to close the program
                        Console.WriteLine("\nExiting...");
                        running = false;//set running boolean to false in order to close the program
                        break;
                    default:
                        //displays error message if the user enters a keyword that is out of the switch statement range
                        Console.Error.WriteLine("Invalid option entered.");
                        break;
                }
                Console.Write("\nPress any ket to continue... ");//loading display
                Console.ReadKey(); //waiting for any key to be pressed
            }
        }

        ///<summary>
        ///<param name="EmployeeReader">
        ///method that can read the entire text file using ReadAllLines() method with the
        ///parts array that uses the foreach loop that reads 4 index fields within the array in order to read the text file. 
        ///</param>
        ///citation for File.ReadAllLines() method: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
        /// </summary>
        
        static int EmployeeReader(Employee[] employee)
        {
            ///<param name="count">assigned as the counter for the parts array.</param>
            int count = 0;

            
            foreach (string line in File.ReadAllLines(DATAFILE))
            {
                ///<param name="parts">assigned to read each field within the foreach loop</param>
                string[] parts = line.Split(',');

                ///<summary>if the user requests a specific option within the while switch loop, the if statement will read
                ///one of four indexes within the foreach loop and count them into the employee array.
                ///</summary>
                ///<param name="name">Assigned </param>
                
                if (parts.Length == 4)
                {
                    string name = parts[0];
                    int number = int.Parse(parts[1]);
                    decimal rate = decimal.Parse(parts[2]);
                    double hours = double.Parse(parts[3]);


                    employee[count++] = new Employee(name, number, rate, hours);

                }
            }
            return count;
        }

        /// <summary>
        /// EmployeeTable() method outputs what EmployeeReader() method has collected and uses a for loop to output
        /// the text file in a ToString method.
        /// </summary>

        static void EmployeeTable(Employee[] employee, int count)
        {
            Console.Clear();
            Console.WriteLine("Employees:\n=========\n");

            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine(employee[i].ToString());
            }
        }
    }
}
