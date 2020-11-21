/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

/**
 * car loan
 * calculator
 */
namespace wrappers {
	public class CarLoanCalculator

		/**
		 * Calculate what the payments would be from the price of the new car and the parameters of the monthly loan payments
		 * @param newCarPrice price of the car new
		 * @param tradeInAllowance trade-in value
		 * @param tradeInLoanBalance loan balance after trade-in
		 * @param downPaymentAndRebates total amount of rebates plus downpayment
		 * @param loanDuration loan duration in months
		 * @param salesTaxRate  sales tax as percentage
		 * @param interestRate interest rate as percentage
		 * @return {number} The x value.
		*/
		CalcPayments(newCarPrice, tradeInAllowance, tradeInLoanBalance, downPaymentAndRebates, loanDuration, salesTaxRate, interestRate)
		{
			//TODO: C# let bus = maglev.maglev.MagLev.getInstance('carloancalculator');
			//TODO: C# let args = [newCarPrice, tradeInAllowance, tradeInLoanBalance, downPaymentAndRebates, loanDuration, salesTaxRate, interestRate];
			//TODO: C# let ret = bus.call('CarLoanCalculator.CalcPayments', args);
			//TODO: C# return ret;
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
		 * @return {number} The x value.
		*/
		CalcAffordability(monthlyPayment, tradeInAllowance, tradeInLoanBalance, downPaymentAndRebates, loanDuration, salesTaxRate, interestRate)
		{
			//TODO: C# let bus = maglev.maglev.MagLev.getInstance('carloancalculator');
			//TODO: C# let args = [monthlyPayment, tradeInAllowance, tradeInLoanBalance, downPaymentAndRebates, loanDuration, salesTaxRate, interestRate];
			//TODO: C# let ret = bus.call('CarLoanCalculator.CalcAffordability', args);
			//TODO: C# return ret;
		}

	}
}

