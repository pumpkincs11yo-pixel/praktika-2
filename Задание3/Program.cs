using System;

class Program
{
	static void Main()
	{
		int chasZakaza, minZakaza, minutDostavki;
		Console.WriteLine("Введите время заказа");
		Console.Write("Часы: ");
		chasZakaza = Convert.ToInt32(Console.ReadLine());
		Console.Write("Минуты: ");
		minZakaza = Convert.ToInt32(Console.ReadLine());
		Console.Write("Сколько минут до доставки: ");
		minutDostavki = Convert.ToInt32(Console.ReadLine());
		int vsego = chasZakaza * 60 + minZakaza + minutDostavki;
		int chas = (vsego / 60) % 24;
		int minuta = vsego % 60;
		Console.Write("Время доставки: ");
		if (chas < 10) Console.Write("0" + chas);
		else Console.Write(chas);
		Console.Write(":");
		if (minuta < 10) Console.Write("0" + minuta);
		else Console.Write(minuta);
		Console.WriteLine();
	}
}