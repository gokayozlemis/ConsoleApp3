Console.Write("Lütfen bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

if (sayi < 10)
{
    Console.WriteLine("Sayı 10'dan küçüktür");
}
else if (sayi == 10)  
{
    Console.WriteLine("Sayı 10'a eşittir");
}
else  
{
    Console.WriteLine("Sayı 10'dan büyüktür");
}
if (sayi % 2 == 0)
{
    Console.WriteLine("Sayı çifttir.");
}
else
{
    Console.WriteLine("Sayı tektir.");
}