// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* 
void Palindrom(int num){
    int numberMinus1=num/10;
    int lastNumber=num%10;
    int forthNumber=numberMinus1%10;
    int numberMinus2=numberMinus1/10;
int thirdNumber=numberMinus2%10;
int numberMinus3=numberMinus2/10;
int secondNumber=numberMinus3%10;
int numberMinus4=numberMinus3/10;
int firstNumber=numberMinus4%10;
if (lastNumber==firstNumber&&forthNumber==secondNumber){
    Console.WriteLine(num +" is palindrom");
}
else{
    Console.WriteLine(num +" is not palindrom");
}
}


Console.WriteLine("Input five-digit number: ");
int num=Convert.ToInt32(Console.ReadLine());
if(num/10000==0||num/100000!=0){
    Console.WriteLine("Input five-digit number: ");
}
else{
    Palindrom(num);
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
//в 3D пространстве.
/*
double Distance (int x1,int y1, int z1, int x2, int y2, int z2){
    double result=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return result;
}
Console.WriteLine("Input coordinate x for first point: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y for first point: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate z for first point: ");
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate x for second point: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y for second point: ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate z for second point: ");
int z2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Distanse between first and second point is: " + Distance(x1,y1,z1,x2,y2,z2));
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cubed (int num){
    int i=1;
    while (i<=num){
        int cub=i*i*i;
        Console.Write(cub + ", ");
        i++;
    }

}
Console.WriteLine("Input any integer: ");
int num=Convert.ToInt32(Console.ReadLine());
if (num<=0){
    Console.WriteLine("Input any integer (from 1 till endless): ");
}
else {
Cubed(num);}
*/