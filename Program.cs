double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

Console.WriteLine($"Total: ${total}");

void GetDiscountedPrice(int itemIndex)
{
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
}

void TotalMeetsMinimum()
{
    // Check if the total meets the minimum
}

void FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
}