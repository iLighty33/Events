// See https://aka.ms/new-console-template for more information
using Events;
Acc account = new(100);

account.Put(20);

Console.WriteLine($"Сумма на счете: {account.Sum}");

account.Take(70);

Console.WriteLine($"Сумма на счете: {account.Sum}");

account.Take(180);

Console.WriteLine($"Сумма на счете: {account.Sum}");
