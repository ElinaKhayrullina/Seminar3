//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
//в 3D пространстве.

double Distance (double x1,double y1, double x2, double y2){
    double result=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return result;
}
Console.WriteLine("Input coordinate x for first point: ");
double x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y for first point: ");
double y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate x for second point: ");
double x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y for second point: ");
double y2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Distanse between first and second point is: " + Distance(x1,y1,x2,y2));