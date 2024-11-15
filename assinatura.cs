Random random = new Random();
int daysUntilExpiration = random.Next(10);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Sua assinatura expirou!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Sua assinatura expira em 1 dia!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Sua assinatura expira em " + daysUntilExpiration + " dias ou menos!");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Sua assinatura expira em " + daysUntilExpiration + " dias, Renove agora mesmo!");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renove agora e Receba {discountPercentage} % de desconto");
}




