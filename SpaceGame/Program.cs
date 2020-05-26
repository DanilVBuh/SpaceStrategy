using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*public class Space
{
	private int amountOfPlanet;
	private Planet p;

	public int AmountOfPlanet { get => amountOfPlanet; set => amountOfPlanet = value; }
}

public class Planet
{
	private string name;
	private bool colonized;

	public string Name { get => name; set => name = value; }
	public bool IsColonized { get => colonized; set => colonized = value; }
}

public class Colony
{
	private int amountOfBuildings;
	private string name;
	private Array factory;
	public string Name { get => name; set => name = value; }
}

abstract class Factory
{
	private string name;
	private string resourseType;
	private int level;
	private int stoneForBuild;
	private int woodForBuild;
	public string Name { get => name; set => name = value; }
	public void Upgrade() { }
}

class StoneFactory : Factory{
	private int stonePerMinute;
	public void MineStoneToStorage() { }
}

class WoodFactory : Factory
{
	private int woodPerMinute;
	public void MineWoodToStorage() { }
}

abstract class ResoursesOnPlanet
{
	private int amount;
	public void Generate()	{ }
}

class Stone : ResoursesOnPlanet { }

class Wood : ResoursesOnPlanet { }*/

namespace SpaceGame
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Space mainSpace;
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
