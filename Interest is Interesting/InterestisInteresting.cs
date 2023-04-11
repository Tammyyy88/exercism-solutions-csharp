using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
          if (balance < 0m)
              return 3.213f;
          else if (balance < 1000m)
              return 0.5f;
          else if (balance >= 1000m && balance < 5000m)
              return 1.621f;
          else if (balance >= 5000m)
              return 2.475f;
          else
              return 0;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) * 0.01m;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
       return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
            
    }
 }

