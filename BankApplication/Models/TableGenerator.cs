using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public static class TableGenerator
    {
        public static int tableWidth = 150;
        public static void AccountDetails()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        //public static void AccountStatement()
        //{
        //    Console.WriteLine(new String('-', tableWidth));
        //}
        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }


        public static void PrintRow(string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}



//public static class PrintTables
//{
//    private static int tableWidth = 115;
//    public static void DisplayTransactionHistorySavings(SavingsAccount account)
//    {
//        PrintDash();
//        PrintHeadings("Account Name", "Account Number", "Amount", "Balance", "Date", "Narration");
//        PrintDash();

//        foreach (var item in account.Transactions)
//        {
//            PrintHeadings(account.AccountName, account.AccountNumber, item.Amount.ToString(), account.Balance.ToString(), item.Date.ToShortDateString(), item.Narration);
//        }

//        PrintDash();
//    }

//    internal static void bankAccount(List<AccountType> savings)
//    {
//        throw new NotImplementedException();
//    }

//    public static void DisplayTransactionHistoryCurrent(CurrentAccount account)
//    {
//        PrintDash();
//        PrintHeadings("Account Name", "Account Number", "Amount", "Date", "Narration");
//        PrintDash();

//        foreach (var item in account.Transactions)
//        {
//            PrintHeadings(account.AccountName, account.AccountNumber, item.Amount.ToString(), item.Date.ToShortDateString(), item.Narration);
//        }

//        PrintDash();
//    }

//    public static void DisplayAccountDetails(List<SavingsAccount> savingsAccounts, List<CurrentAccount> currentAccount)
//    {
//        PrintDash();
//        PrintHeadings("ACCOUNT NAME", "EMAIL", "PHONE NUMBER", "ACCOUNT NUMBER", "ACCOUNT TYPE", "BALANCE");
//        PrintDash();

//        foreach (var account in savingsAccounts)
//        {
//            PrintHeadings(account.AccountName, account.Email, account.PhoneNumber, account.AccountNumber, account.AccountType.ToString(), account.Balance.ToString());
//        }

//        foreach (var account in currentAccount)
//        {
//            PrintHeadings(account.AccountName, account.Email, account.PhoneNumber, account.AccountNumber, account.AccountType.ToString(), account.Balance.ToString());
//        }


//        PrintDash();
//    }
//    private static void PrintDash() => Console.WriteLine(new string('-', tableWidth));

//    private static void PrintHeadings(params string[] columns)
//    {
//        int columnWidth = (tableWidth - columns.Length) / columns.Length;
//        const string columnSeperator = "|";

//        string row = columns.Aggregate(columnSeperator, (seperator, columnText) => seperator + GetCenterAlignedText(columnText, columnWidth) + columnSeperator);

//        Console.WriteLine(row);
//    }

//    private static string GetCenterAlignedText(string text, int columnWidth)
//    {
//        text = text.Length > columnWidth ? text.Substring(0, columnWidth - 3) + "..." : text;

//        return string.IsNullOrEmpty(text)
//            ? new string(' ', columnWidth)
//            : text.PadRight(columnWidth - ((columnWidth - text.Length) / 2)).PadLeft(columnWidth);
//    }
//}
