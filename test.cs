using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string food;
		Gallina myGallina = new Gallina();
		Console.WriteLine("This is your Chicken: \n");
		myGallina.GenerarGallina();
		Console.Write("\nDale gusanos (🐛)");
		food = Console.ReadLine();
		myGallina.DarComida(food);
	}
}

public class Gallina
{
	static List<string> food = new List<string>() {"🐛","🐛"};
	public void GenerarGallina () 
	{
		while (food.Count > 0)
		{
			string gallina = "🐔";
			foreach (string f in food)
			{
				gallina += f;
			}
			Console.WriteLine(gallina);
		}
		Environment.Exit(0);
		Console.WriteLine("La gallina ha fallecido :c");
	}
	public void DarComida (string giveFood)
	{
		if (giveFood == "🐛")
		{
			food.Add(giveFood);
		} else food.RemoveAt(0);
	}
}
