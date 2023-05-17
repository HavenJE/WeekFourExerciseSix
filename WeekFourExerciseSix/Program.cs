

// Exercise 6
// Write a program for the Carefree Resort named ResortPrices that prompts the user to enter the number of days for a resort stay.
// It then displays the price per night and the total price of the stay. Nightly rates are as follows:

// $200 for one or two nights
// $180 for three or four nights
// $160 for five, six or seven nights
// $145 for eight nights or more.

class ResortPrices
{
    static void Main()
    {
        int userDays, x;

        int[] daysStay = { 1, 3, 5, 7 }; 
        int[] nightRates = { 200, 180, 160, 145 };

        Console.WriteLine("How many nights you are planning to stay with us?");
        userDays = Convert.ToInt32(Console.ReadLine());

        for (x = daysStay.Length - 1;x >= 0; x--)
        {
            if (userDays >= daysStay[x])
            {
                Console.WriteLine("For {0} nights stay, our night rate is: {1}", userDays, nightRates[x]);
                x = 0;
            }
        }
    }
}