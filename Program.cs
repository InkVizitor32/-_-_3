                    // Задача 19
                    // Напишите программу, которая принимает на вход пятизначное число и проверяет,
                    // является ли оно палиндромом. Через строку решать нельзя.
                    // 14212 -> нет
                    // 12821 -> да
                    // 23432 -> да

// Console.Clear();
// Console.WriteLine(" Введите пятизначное число ");
// int n = Convert.ToInt32(Console.ReadLine());

// int n1 = n/10000;
// int n2 = n/1000%10;

// int n4 = n/10%10;
// int n5 = n%10;

// if (n1==n5 && n2==n4) Console.WriteLine("да");
// else Console.WriteLine("нет");


//                                          Задача 21

//                     Напишите программу, которая принимает на вход координаты
//                     двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты x точки A");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки A");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки A");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки B");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
Console.WriteLine($"Расстояние между двумя точками равно {distance}");