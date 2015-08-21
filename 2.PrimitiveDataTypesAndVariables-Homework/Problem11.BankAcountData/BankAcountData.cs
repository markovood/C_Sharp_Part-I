using System;
using System.Text;
class BankAcountData
{
    static void Main()
    {
        // A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name,
        // IBAN, 3 credit card numbers associated with the account.
        // Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

        Console.OutputEncoding = Encoding.UTF8;

        string firstName = "Golemiqt";
        string middleName = "Bai";
        string lastName = "Pesho";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal balance = decimal.MaxValue;
        string bankName = "The Name of Your Bank ";
        string iban = "BG78ABCD01234567890123";
        ulong creditCardNumber1 = 1122334455667788;
        ulong creditCardNumber2 = 9000111122223333;
        ulong creditCardNumber3 = 9999898998989999;
        string bullet = " \u00B7 ";
        string associatedCreditCards = "Associated credit card numbers: \n" + bullet + creditCardNumber1 + "\n" + bullet + creditCardNumber2 + " \n" + bullet + creditCardNumber3 + "\n";
        
        Console.WriteLine("Bank Account Overview: \n");
        Console.WriteLine("Bank name: {0}\nAccount holder Name: {1}\nBalance: {2}\nIBAN: {3}\n{4}",bankName,holderName,balance,iban,associatedCreditCards);
    }
}
