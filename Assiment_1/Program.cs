Console.WriteLine("Inter Bill Amount ");
var billAmount = Convert.ToDouble(Console.ReadLine());
var finalPrice = 0.0;


if (billAmount >= 500)
{
    finalPrice = billAmount - (billAmount * 20 / 100);
    Console.WriteLine(finalPrice);
}
else if (billAmount < 500 && billAmount >= 300)
{
    finalPrice = billAmount - (billAmount * 10 / 100);
    Console.WriteLine(finalPrice);
}
else
{
    finalPrice = billAmount;
    Console.WriteLine(finalPrice);
}
