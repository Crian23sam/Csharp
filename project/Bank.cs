using System;
using System.Collections.Generic;

class BankManagmentSystem
{
	public static void Main(string[] args)
	{
		Bank bank = new Bank();
		int choice=0;

		do
		{
			Console.WriteLine("Bank Managment System");
			Console.WriteLine("1. Create Account");
			Console.WriteLine("2. Deposit");
			Console.WriteLine("3. Withdraw");
			Console.WriteLine("4. Check Balance");
			Console.WriteLine("5. Exit");
			Console.Write("Enter your choice(1-5):");
			choice=int.Parse(Console.ReadLine());

			switch(choice)
			{
				case 1:
					bank.CreateAccount();
					break;
				case 2:
					bank.Deposit();
					break;
				case 3:
					bank.Withdraw();
					break;
				case 4:
					bank.CheckBalance();
					break;
				case 5:
					Console.WriteLine("Thankyou");
					break;
				default:
					Console.WriteLine("Invalid choice");
					break;
			}
		}while(choice!=5);
	}
}

class Bank
{
	private List<Account> accounts  = new List<Account>();

	public void CreateAccount()
	{
		Console.Write("Enter account holder name:");
		string name  = Console.ReadLine();
		
		Console.Write("Enter Initial deposit amount:");
		double initialDeposit=double.Parse(Console.ReadLine());

		Account newAccount=new Account(name,initialDeposit);
		accounts.Add(newAccount);
		Console.WriteLine("Account created successfully. Your Account ID is:"+newAccount.AccountId);
	}

	public void Deposit()
	{
		Console.Write("Enter Account ID:");
		int accountId=int.Parse(Console.ReadLine());
		Account account=FindAccount(accountId);

		if(account!=null)
		{
			Console.Write("Enter Deposit Amount:");
			double amount=double.Parse(Console.ReadLine());
			account.Deposit(amount);
			Console.WriteLine("Deposit successful Current balance:"+account.Balance);
		}
		else
		{
			Console.WriteLine("Account not found.");
		}
	}
	
	public void Withdraw()
	{
		Console.Write("Enter Account ID:");
		int accountId=int.Parse(Console.ReadLine());
		Account account=FindAccount(accountId);

		if(account!=null)
		{
			Console.Write("Enter Withdrawal amount:");
			double amount=double.Parse(Console.ReadLine());

			if(account.Withdraw(amount))
			{
				Console.WriteLine("Withdrawal Successful. Current Balance:"+account.Balance);
			}

			else
			{
				Console.WriteLine("Insufficient Balance.");
			}
		}
		
		else
		{
			Console.WriteLine("Account not found");
		}
	}

	public void CheckBalance()
	{
		Console.Write("Enter Account ID:");
		int accountId=int.Parse(Console.ReadLine());
		Account account=FindAccount(accountId);

		if(account!=null)
		{
			Console.WriteLine("Current Balance:"+account.Balance);
		}
		
		else
		{
			Console.WriteLine("Account not found");
		}
	}

	private Account FindAccount(int accountId)
	{
		return accounts.Find(a=>a.AccountId==accountId);
	}
}


class Account
{
	private static int nextAccountId=1;

	public int AccountId{get;private set;}
	public string Name{get;private set;}
	public double Balance{get;private set;}

	public Account(string name,double initialDeposit)
	{
		AccountId=nextAccountId++;
		Name=name;
		Balance=initialDeposit;
	}
	
	public void Deposit(double amount)
	{
		Balance+=amount;
	}
	
	public bool Withdraw(double amount)
	{
		if(amount<=Balance)
		{
			Balance-=amount;
			return true;
		}
		return false;
	}
}