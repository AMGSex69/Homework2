//Вообще не уверен, что это законно, но я наконец-то узнал как щелкать такие задачки:))
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string numberTXT = Convert.ToString(number);
if (numberTXT.Length > 2)
{
	Console.WriteLine("Третья цифра: " + numberTXT[2]);
}
else
{
	Console.WriteLine("Простите, тертьего числа не существует!");
}