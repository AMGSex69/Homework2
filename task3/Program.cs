//Решил попробовать сделать с методом, но и без него отлично получается) 
void weekndDay()
{
	Console.Write("Введите число дня недели: ");
	int number = Convert.ToInt32(Console.ReadLine());
	if (number == 6 || number == 7)
	{
		Console.WriteLine("Ура, СЕГОДНЯ ВЫХОДНОЙ!");
	}
	else if (number < 0 || number > 7)
	{
		Console.WriteLine("Такого дня недели нет!");
	}
	else
	{
		Console.WriteLine("К сожалению, сегодня не выходной день!");
	}
}
weekndDay();