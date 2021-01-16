/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * car loan
 * calculator
 */
namespace mindpowered.carloancalculator {
	public delegate void MyCallbackDelegate(object o);

	public class CarLoanCalculator
	{
		public CarLoanCalculator()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::carloancalculator.CarLoanCalculator myinstance = new global::carloancalculator.CarLoanCalculator(bus);
		}

		/**
		 * Calculate what the payments would be from the price of the new car and the parameters of the monthly loan payments
		 * @param newCarPrice price of the car new
		 * @param tradeInAllowance trade-in value
		 * @param tradeInLoanBalance loan balance after trade-in
		 * @param downPaymentAndRebates total amount of rebates plus downpayment
		 * @param loanDuration loan duration in months
		 * @param salesTaxRate  sales tax as percentage
		 * @param interestRate interest rate as percentage
		 * @return {object[]} payments and total interest
		*/
		public object[] CalcPayments(double newCarPrice, double tradeInAllowance, double tradeInLoanBalance, double downPaymentAndRebates, double loanDuration, double salesTaxRate, double interestRate)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(newCarPrice);
			args.push(tradeInAllowance);
			args.push(tradeInLoanBalance);
			args.push(downPaymentAndRebates);
			args.push(loanDuration);
			args.push(salesTaxRate);
			args.push(interestRate);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("CarLoanCalculator.CalcPayments", args, async_callback);
			return ret;
		}

		/**
		 * Calculate the price of the car from the monthly loan payment information
		 * @param monthlyPayment monthly payment amount
		 * @param tradeInAllowance trade-in value
		 * @param tradeInLoanBalance loan balance after trade-in
		 * @param downPaymentAndRebates total amount of rebates plus downpayment
		 * @param loanDuration loan duration in months
		 * @param salesTaxRate sales tax rate as percentage
		 * @param interestRate interest rate as percentage
		 * @return {double} target price with tax and fees
		*/
		public double CalcAffordability(double monthlyPayment, double tradeInAllowance, double tradeInLoanBalance, double downPaymentAndRebates, double loanDuration, double salesTaxRate, double interestRate)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(monthlyPayment);
			args.push(tradeInAllowance);
			args.push(tradeInLoanBalance);
			args.push(downPaymentAndRebates);
			args.push(loanDuration);
			args.push(salesTaxRate);
			args.push(interestRate);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("CarLoanCalculator.CalcAffordability", args, async_callback);
			return ret;
		}

	}
}

