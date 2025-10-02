// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;


public partial class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int total = numBottles;       
        while (numBottles >= numExchange)
        {
            var exchangeBottles = numBottles / numExchange;
            var remainingEmptyBottles = numBottles % numExchange;
            total += exchangeBottles;
            numBottles = exchangeBottles + remainingEmptyBottles;
        }
        return total;
    }
}




