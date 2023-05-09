// See https://aka.ms/new-console-template for more information

//Nhập số nguyên a. Kiểm tra a là số nguyên âm hay dương

//Khai báo a
int a;
//Nhập a
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
//Kiểm tra a
if (a < 0)
{
    Console.WriteLine(a + " la so am");
}
else if (a > 0)
{
    Console.WriteLine(a + " la so duong");
}
else
{
    Console.WriteLine(a + " la so khong am khong duong");
}