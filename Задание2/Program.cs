using System;

class Program
{
	static void Main()
	{
		Console.Write("Введите число: ");
		int chislo = Convert.ToInt32(Console.ReadLine());
		if (chislo == 0)
		{
			Console.WriteLine("Результат: 0");
			return;
		}
		int[] ost = new int[32];
		int kol = 0;
		while (chislo > 0)
		{
			ost[kol] = chislo % 2;
			chislo = chislo / 2;
			kol = kol + 1;
		}
		Console.Write("Результат: ");
		for (int i = kol - 1; i >= 0; i--)
		{
			Console.Write(ost[i]);
		}
		Console.WriteLine();
	}
}