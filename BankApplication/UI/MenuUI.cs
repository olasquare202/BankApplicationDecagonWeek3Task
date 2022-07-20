using BankApplication.Models;
using BankApplication.Services;
using BankApplication.Utilities;

namespace BankApplication.UI
{
    public class MenuUI
    {

        private static IBankAccountService _bankAccountService;

        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }
        private static ITransactionService? _transactionService;
        //public static void PrintLine(string[] buf)
        //{
        //    throw new NotImplementedException();
        //}

        public static ITransactionService transactionService
        {
            get => _transactionService ??= new TransactionService();
        }

        private static ICustomerService? _customerService;
        private static int tableWidth;

        public static ICustomerService customerService
        {
            get => _customerService ??= new CustomerService();
        }
        public static object AccountBalance { get; private set; }

        public static void Menu(Customer customer)
        {
            Console.Clear();
            IndexUI.Header();
            Console.WriteLine();
            Console.WriteLine("Enter 1 to create account");
            Console.WriteLine("Enter 2 to check account balance");
            Console.WriteLine("Enter 3 to make deposit");
            Console.WriteLine("Enter 4 to make withdrawal");
            Console.WriteLine("Enter 5 to make Transfer");
            Console.WriteLine("Enter 6 to check account details");
            Console.WriteLine("Enter 7 to check account statement");
            Console.WriteLine("Enter 8 to logout");
            string? option = Console.ReadLine();
            if(String.IsNullOrEmpty(option))
            {
                option = Console.ReadLine();
            }
            Console.Clear();
            OptionHandler(option, customer);
        }

        public static void OptionHandler(string option, Customer customer)
        {
            IndexUI.Header();
            if (option == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 to create a savings account: ");
                Console.WriteLine("Enter 2 to create a current account: ");

                string? typeOfAccount = Console.ReadLine();
                if (typeOfAccount == "1")
                {
                    string accountNumber = AccountNumberGenerator.AccountGenerator();
                    BankAccount bankAccount = new BankAccount(customer.Id, accountNumber, AccountType.Savings);

                     Console.WriteLine("Enter your Initial Deposit");

                    string? amount = Console.ReadLine();
                    while (!Validation.IsValidAmount(amount))
                    {
                        Console.WriteLine("#{0} is invalid, Please be reasonable");
                        amount = Console.ReadLine();
                    }
                    bankAccount.AccountBalance = Convert.ToDecimal(amount);
                    Console.WriteLine("Awesome! Your Savings Account Was Successfully Created, Your Account details is:");
                    Console.WriteLine("Account Number: {0}", accountNumber);
                    bankAccountService.CreateBankAccount(bankAccount);
                    Transaction transaction = new Transaction(bankAccount.Id,"Initial Deposit", bankAccount.AccountBalance, TransactionType.Deposit,DateTime.Now,bankAccount.AccountBalance);
                   bool successful =  transactionService.SaveTransaction(transaction);   
                    Console.WriteLine("\n\nPress Enter to Continue");


                    Console.ReadLine();
                    Menu(customer);

                }
                else if (typeOfAccount == "2")
                {

                    string accountNumber = AccountNumberGenerator.AccountGenerator();
                    BankAccount bankAccount = new BankAccount(customer.Id, accountNumber, AccountType.Current);

                    Console.WriteLine("Enter your Initial Deposit");

                    string? amount = Console.ReadLine();
                    while (!Validation.IsValidAmount(amount))
                    {
                        Console.WriteLine("{0} is invalid, Please be reasonable");
                        amount = Console.ReadLine();
                    }
                    bankAccount.AccountBalance = Convert.ToDecimal(amount);
                    Console.WriteLine("Awesome! Your current Account Was Successfully Created, Your Account details is:");
                    Console.WriteLine("Account Number: {0}", accountNumber);
                    bankAccountService.CreateBankAccount(bankAccount);
                    Transaction transaction = new Transaction(bankAccount.Id, "Initial deposit", Convert.ToDecimal(amount), TransactionType.Deposit, DateTime.Now, bankAccount.AccountBalance);
                    transactionService.SaveTransaction(transaction);
                    Console.WriteLine("\n\nPress Enter to Continue");

                    Console.ReadLine();
                    Menu(customer);


                    //bankAccount.AccountBalance = amount;

                    //Console.WriteLine("Enter Account number");
                    //var accountnumber = Convert.ToInt32(Console.ReadLine());

                    //check if accout number exists in the list of account numbers
                    //if it does call your deposit function

                    //deposit(amount, accountnumber, TransactionType.Deposit);
                }

                

            }
            else if (option == "2")
            {
                Console.Write("Verify your account number: ");
                string? accountNumber = Console.ReadLine();
                BankAccount? bankAccount = bankAccountService.GetBankAccountByAccountNumber(accountNumber);
                if (bankAccount != null)
                {
                    if (bankAccount.CustomerId == customer.Id)
                    {
                        Console.WriteLine("Account Balance: {0}", bankAccount.AccountBalance);
                        Console.WriteLine("\n\nPress Enter to Continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Unauthorized to check account balance of another customer");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("AccountNumber does not exist");

                    Console.WriteLine("\n\nPress Enter to Create a New Account");
                    Console.ReadLine();
                }
                Menu(customer);
                //Console.Write("Enter amount: ");
                //string amount = Console.ReadLine();
            }
            else if (option == "3")
            {
                Console.Write("Enter Account Number: ");
                string? accountNumber = Console.ReadLine();
                if (!bankAccountService.VerifyBankAccountByAccountNumber(accountNumber))
                {
                    Console.WriteLine("Account number does not exist");
                    Console.ReadLine();
                }
                else
                {
                    BankAccount? bankAccount = bankAccountService.GetBankAccountByAccountNumber(accountNumber);
                    while (bankAccount.CustomerId != customer.Id)
                    {
                        Console.WriteLine("Unauthorized to check account balance of another customer");
                        accountNumber = Console.ReadLine();
                        bankAccount = bankAccountService.GetBankAccountByAccountNumber(accountNumber);
                    }
                    Console.Write("Enter amount: ");
                    string amount = Console.ReadLine();
                    while (!Validation.IsValidAmount(amount))
                    {
                        Console.WriteLine("{0} is invalid, Please be reasonable");
                        amount = Console.ReadLine();
                    }
                    if (Convert.ToDecimal(amount) <= 0)
                    {
                        Console.WriteLine("Invalid amount");
                        Console.Read();
                    }
                    bankAccount = bankAccountService.DepositIntoAccount(bankAccount, Convert.ToDecimal(amount));
                    if (bankAccount != null)
                    {
                        Transaction transaction = new Transaction(bankAccount.Id, "Deposit", Convert.ToDecimal(amount), TransactionType.Deposit, DateTime.Now, bankAccount.AccountBalance);
                        transactionService.SaveTransaction(transaction);
                        Console.WriteLine("Transaction successful");
                        Console.WriteLine("\n\nPress Enter to Continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Transaction failed");
                        Console.WriteLine("\n\nPress Enter to Continue");
                        Console.ReadLine();

                    }
                }
                Menu(customer);
            }

            else if (option == "4")
            {
                Console.Write("Enter Account Number: ");
                string? accountNumber = Console.ReadLine();
                if (!bankAccountService.VerifyBankAccountByAccountNumber(accountNumber))
                {
                    Console.WriteLine("Account number does not exist");
                    Console.ReadLine();
                }
                else
                {
                    BankAccount? bankAccount = bankAccountService.GetBankAccountByAccountNumber(accountNumber);
                    while (bankAccount.CustomerId != customer.Id)
                    {
                        Console.WriteLine("Unauthorized to check account balance of another customer");
                        accountNumber = Console.ReadLine();
                        bankAccount = _bankAccountService.GetBankAccountByAccountNumber(accountNumber);
                    }
                    Console.Write("Enter amount: ");
                    string amount = Console.ReadLine();
                    while (!Validation.IsValidAmount(amount))
                    {
                        Console.WriteLine("#{0} is invalid, Please be reasonable");
                        amount = Console.ReadLine();
                    }
                    if (Convert.ToDecimal(amount) <= 0)
                    {
                        Console.WriteLine("Invalid amount");
                        Console.Read();
                    }
                    bankAccount = bankAccountService.WithdrawFromBankAccount(bankAccount, Convert.ToDecimal(amount));
                    if (bankAccount != null)
                    {
                        Transaction transaction = new Transaction(bankAccount.Id, "Withdraw", Convert.ToDecimal(amount), TransactionType.Withdraw, DateTime.Now, bankAccount.AccountBalance);
                        transactionService.SaveTransaction(transaction);
                        Console.WriteLine("Transaction successful");
                        Console.WriteLine("\n\nPress Enter to Continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Transaction failed");
                        Console.ReadLine();
                        Console.WriteLine("\n\nDo you want to make another transaction? Press Enter to Continue");
                    }
                }
                Menu(customer);
            }
            else if (option == "5")
            {
                Console.Write("Enter your account number: ");
                string? senderAccountNo = Console.ReadLine();
                while (!bankAccountService.VerifyBankAccountByAccountNumber(senderAccountNo))
                {
                    Console.WriteLine("Account number does not exist.");
                    //Console.WriteLine("Please Enter Your Own Account Number");
                    senderAccountNo = Console.ReadLine();
                }
                Console.Write("Enter receiver's account number: ");
                string receiverAccountNo = Console.ReadLine();
                while (!bankAccountService.VerifyBankAccountByAccountNumber(receiverAccountNo))
                {
                    Console.WriteLine("Account number does not exist.");
                    receiverAccountNo = Console.ReadLine();
                }
                Console.WriteLine("Enter amount: ");
                string? amount = Console.ReadLine();
                while (!Validation.IsValidAmount(amount))
                {
                    Console.WriteLine("#{0} is invalid, Please be reasonable");
                    amount = Console.ReadLine();
                }
                Console.WriteLine("Transfer details: ");
                string description = Console.ReadLine();
                while (String.IsNullOrEmpty(description))
                {
                    Console.WriteLine("Please enter tranfer details: ");
                    description = Console.ReadLine();
                }
                BankAccount senderAccount = bankAccountService.GetBankAccountByAccountNumber(senderAccountNo);
                BankAccount receiverAccount = bankAccountService.GetBankAccountByAccountNumber(receiverAccountNo);
                bankAccountService.BankAccountTransfer(senderAccount, receiverAccount, Convert.ToDecimal(amount));
                Customer receiver = customerService.GetCustomerById(receiverAccount.CustomerId);
                Transaction transactionSender = new Transaction(senderAccount.Id, $"Transfer - {customer.FirstName}, {customer.LastName}", Convert.ToDecimal(amount), TransactionType.Withdraw, DateTime.Now, senderAccount.AccountBalance);
                Transaction transactionreceiver = new Transaction(receiverAccount.Id, $"Transfer - {receiver.FirstName} {customer.LastName}", Convert.ToDecimal(amount), TransactionType.Deposit, DateTime.Now, receiverAccount.AccountBalance);
                transactionService.SaveTransaction(transactionSender);
                transactionService.SaveTransaction(transactionreceiver);
                Console.WriteLine("Transaction Successful");
                Console.WriteLine("\n\nPress Enter to Continue");
                Console.ReadLine();
                Menu(customer);
            }

            else if (option == "6")
            {
                
                TableGenerator.PrintLine();
                Console.WriteLine();
                List<BankAccount> bankAccounts = _bankAccountService.GetAllBankAccountByCustomerId(customer.Id);
                string[] header = new string[4]
                {
                    "FULLNAME",
                    "ACCOUNT NO",
                    "ACCOUNT TYPE",
                    "BALANCE"
                };
                //Console.WriteLine();
                BankApplication.Models.TableGenerator.PrintRow(header);
                var buf = new string[4];
                foreach (BankAccount bankAccount in bankAccounts) //for (var i = 0; i < n; i++)
                {
                    Console.WriteLine(); //string[] newRow = new string[6]
                    
                   
                    Console.WriteLine();


                    buf[0] = customer.FirstName + " " + customer.LastName;
                    buf[1] = bankAccount.AccountNmuber;
                    buf[2] = bankAccount.AccountType.ToString();
                    buf[3] = bankAccount.AccountBalance.ToString();
                }

                BankApplication.Models.TableGenerator.PrintLine();
                BankApplication.Models.TableGenerator.PrintRow(buf);
                BankApplication.Models.TableGenerator.PrintLine();
                Console.ReadLine();
                Menu(customer);

                
            }

           

            else if (option == "7")
            {
                Console.Write("Enter your account number: ");
                string? accountNo = Console.ReadLine();
                string[] header = new string[4]
                {
                    "DATE",
                    "DESCRIPTION",
                    "AMOUNT",
                    "BALANCE"
                };
                //Console.WriteLine();
                BankApplication.Models.TableGenerator.PrintRow(header);
                var buf = new string[4];
                while (!bankAccountService.VerifyBankAccountByAccountNumber(accountNo))
                {
                    Console.WriteLine("Account number does not exist.");
                    //Console.WriteLine("Please Enter Your Own Account Number");
                    accountNo = Console.ReadLine();
                }
                BankAccount account = bankAccountService.GetBankAccountByAccountNumber(accountNo);
                List<Transaction> transactions = transactionService.GetTransactionstByAccountId(account.Id);
                foreach (Transaction transaction in transactions)
                {
                    buf[0] = transaction.CreatedDate.ToString();
                    buf[1] = transaction.Description;
                    buf[2] = transaction.Amount.ToString();
                    buf[3] = transaction.Balance.ToString();
                }
                //Console.WriteLine($"Date: {transaction.CreatedDate}");
                //    Console.WriteLine($"Purpose of transaction: {}");
                //    Console.WriteLine($"Amount: {transaction.Amount}");
                //    Console.WriteLine($"Account Balance: {transaction.Balance}");

                BankApplication.Models.TableGenerator.PrintLine();
                BankApplication.Models.TableGenerator.PrintRow(buf);
                BankApplication.Models.TableGenerator.PrintLine();




                //DATE
                //DESCRIPTION
                //AMOUNT
                //BALANCE
                //Console.Write("Enter your account number: ");
                //string? accountNo = Console.ReadLine();
                //while (!bankAccountService.VerifyBankAccountByAccountNumber(accountNo))
                //{
                //    Console.WriteLine("Account number does not exist.");
                //    //Console.WriteLine("Please Enter Your Own Account Number");
                //    accountNo = Console.ReadLine();
                //}
                //BankAccount account = bankAccountService.GetBankAccountByAccountNumber(accountNo);
                //List<Transaction> transactions = transactionService.GetTransactionstByAccountId(account.Id);
                //foreach(Transaction transaction in transactions)

                //{

                //    Console.WriteLine($"Date: {transaction.CreatedDate}");
                //    Console.WriteLine($"Purpose of transaction: {transaction.Description}");
                //    Console.WriteLine($"Amount: {transaction.Amount}");
                //    Console.WriteLine($"Account Balance: {transaction.Balance}");
                //    Console.WriteLine();
                    
                //}
                Console.WriteLine("\n\nPress Enter to Continue");
                Console.ReadLine();
                Menu(customer);
            }
            else
                if (!Validation.IsValidCommand(option))
                {
                    Console.WriteLine("Please, input a valid option");
                    Console.WriteLine("\n\nPress Enter to Continue");
                    Console.ReadLine();
                    Menu(customer);
            }
                if(Convert.ToInt32(option) < 1 || Convert.ToInt32(option) >= 8)
                {
                    Console.WriteLine("{0} is invalid", option);
                    Console.Clear();
                    Console.WriteLine("\n\nPress Enter to Continue");
                    Console.ReadLine();
                    Menu(customer);
                }
                
            }
        }
    }

