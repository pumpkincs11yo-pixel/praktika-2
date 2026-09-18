using System;

class Program
{
	static void Main()
	{
		Console.Write("Введите двоичное число: ");
		string dvoichnoe = Console.ReadLine();
		int rezultat = 0;
		int dlina = dvoichnoe.Length;
		for (int i = 0; i < dlina; i++)
		{
			if (dvoichnoe[i] == '1')
			{
				int stepen = 1;
				for (int j = 0; j < dlina - 1 - i; j++)
				{
					stepen = stepen * 2;
				}
				rezultat = rezultat + stepen;
			}
		}
		Console.WriteLine("Результат: " + rezultat);
	}
}