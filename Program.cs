Console.Write("Введите номер вагона в который заходите: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер вагона который видите: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a  < b)
{
    int c = a+b-1;
    Console.WriteLine("В электричке " + c + " вагонов");
}
else
{
Console.WriteLine("Подсчитатьколичество невозможно)");
}