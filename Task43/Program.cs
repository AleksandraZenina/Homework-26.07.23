// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
string Input(string text)
{
    Console.Write($"{text}");
    return Console.ReadLine();
}
void Task43()
{
 int b1=Convert.ToInt32(Input("Введите число b1: "));
 int k1=Convert.ToInt32(Input("Введите число k1: "));
 int b2=Convert.ToInt32(Input("Введите число b2: "));
 int k2=Convert.ToInt32(Input("Введите число k2: "));
    
 if (k1==k2&&b1==b2)
 {
    Console.WriteLine("Прямые совпадают");
 }
 if (k1==k2&&b1!=b2)
 {
    Console.WriteLine("Прямые параллельны");
 } 
 else
 {
   double x = (b2-b1)/(k1-k2);
   double y = k1*x + b1;
   Console.WriteLine($"\n Точка пересечения двух прямых: [{x},{y}]"); 
 }
} 
Task43();

