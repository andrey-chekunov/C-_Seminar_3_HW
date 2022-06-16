/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int x1 = Input("Enter the coordinate X1: ");
int x2 = Input("Enter the coordinate X2: ");
int y1 = Input("Enter the coordinate Y1: ");
int y2 = Input("Enter the coordinate Y2: ");
int z1 = Input("Enter the coordinate Z1: ");
int z2 = Input("Enter the coordinate Z2: ");

int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;

double xyz=Math.Sqrt(x*x+y*y+z*z);
Console.WriteLine("The distance between points in three-dimensional space: " + xyz);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
