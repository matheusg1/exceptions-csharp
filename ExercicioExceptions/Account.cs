using ExercicioExceptions.Exceptions;
using System;
using System.ComponentModel.Design;
using System.IO;

namespace ExercicioExceptions
{
    public class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new SaqueForaDoLimiteException("Valor além do limite para saque");
            }
            if (Balance < amount)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para saque");
            }
            Balance -= amount;
        }
    }
}