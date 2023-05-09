// See https://aka.ms/new-console-template for more information

/*
 Nhâp mảng có n phần tử nguyên. Tính tổng các phần tử của mảng
 */
 
 //Khai báo n
 int n, tong = 0;
 //Nhập n
 Console.Write("n = ");
 n = int.Parse(Console.ReadLine());
 //Khai báo mảng
 int[] arr = new int[n];
//Nhập các phần tử của mảng
 for (int i = 0; i < n; i++)
 {
  Console.Write("arr[" + i + "] = ");
  arr[i] = int.Parse(Console.ReadLine());
 }
 //Tính tổng các phần tử của mảng
 for (int i = 0; i < n; i++)
 {
  tong += arr[i];
 }
 //In ra tổng các phần tử của mảng
 Console.WriteLine("Tong cac phan tu cua mang la: " + tong);