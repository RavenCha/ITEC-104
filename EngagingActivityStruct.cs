/*
 * Created by SharpDevelop.
 * User: Raven
 * Date: 9/25/2022
 * Time: 2:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace STRUCT
{
	class Program
	{
		struct Employee
{
    public string firstName;
    public string lastName;
    public int age;
    public string completedTraining;
}
		public static void Main(string[] args)
		{
		
			
	    Console.Title = "Struct";
        Employee employee1;
        Console.WriteLine("============");
        employee1.firstName = "Juan";
        employee1.lastName = "Dela Cruz";
        employee1.age = 25;
        employee1.completedTraining = "Yes";
      

        Console.WriteLine("Name: "+employee1.firstName);
        Console.WriteLine("Last Name: "+employee1.lastName);
        Console.WriteLine("Age: "+employee1.age);
        Console.WriteLine("Completed Training: "+employee1.completedTraining);
        Console.WriteLine("============");
        Console.Read();
        
				
		}
	}
}