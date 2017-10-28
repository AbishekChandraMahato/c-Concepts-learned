using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{


    public class Account
    {
        double _balance;int _id;
        public Account(int id,double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        public int ID
        {
            get { return _id; }
            
        }

        public void withdraw(double amount)
        {
            _balance -= amount;
        }
        public void deposit(double amount)
        {
            _balance += amount;
        }
    }
    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;
        public AccountManager(Account fromAccount,Account toAccount,double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            //deadlock situation
            //lock (_fromAccount)
            //{
            //    Thread.Sleep(1000);
            //    lock (_toAccount)
            //    {
            //        _fromAccount.withdraw(_amountToTransfer);
            //        _toAccount.deposit(_amountToTransfer);
            //    }
            //}
            //solution to above deadlock!!:
            object _lock1, _lock2;
            if (_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }
            lock (_lock1)
            {
                Thread.Sleep(1000);
                lock (_lock2)
                {
                    _fromAccount.withdraw(_amountToTransfer);
                    _toAccount.deposit(_amountToTransfer);
                }
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Main started");
            Account a1 = new Account(101, 5000);
            Account a2 = new Account(102, 30000);

            AccountManager acm1 = new AccountManager(a1, a2, 1000);
            Thread t1 = new Thread(acm1.Transfer);
            t1.Name = "t1";

            AccountManager acm2 = new AccountManager(a2, a1, 2000);
            Thread t2 = new Thread(acm2.Transfer);
            t2.Name = "t2";


            t1.Start();
            t1.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Main completed");



        }

    }
}
