using System;
class EmployeeData
{
    static void Main()
    {
        // A marketing company wants to keep record of its employees. Each record would have the following characteristics:

        // First name
        // Last name
        // Age (0...100)
        // Gender (m or f)
        // Personal ID number (e.g. 8306112507)
        // Unique employee number (27560000…27569999)
        
        // Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.
        // Print the data at the console.

        string firstName = "Golemiqt";
        string lastName = "Pesho";
        byte age = 100;
        char gender = 'M';
        ulong idNumber = 1506112507;
        uint employeeNumber = 27560001;

        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nId Number: {4}\nEmployee Number: {5}\n",firstName,lastName,age,gender,idNumber,employeeNumber);
    }
}
