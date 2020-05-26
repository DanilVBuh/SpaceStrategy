using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
	public partial class Form1 : Form
	{
		Space main = new Space();
		Planet planet;
		Factory factory;
		public Form1()
		{
			InitializeComponent();
		}
		public void Show(string text)
		{
			MessageBox.Show(text);
		}

		public void RefreshStorage()
		{
			stoneInStorage.Text = main.Storage.Store[0].Amount.ToString();
			woodInStorage.Text = main.Storage.Store[1].Amount.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			addPlanetNameBox.Visible = true;
		}

		private void setNameButton_Click(object sender, EventArgs e)
		{
			string s = planetNameTextBox.Text;
			if (main.ExplorePlanet(s))
			{
					
				planetListBox.Items.Add(s);
				stoneInStorage.Text = main.Storage.Store[0].Amount.ToString();
				woodInStorage.Text = main.Storage.Store[1].Amount.ToString();
				if (this.main.Planets.Count == this.main.AmountOfPlanet)
					explorePlanetButton.Visible = false;
				spaceBox.Text = "Space: " + this.main.Planets.Count.ToString() + "/" + this.main.AmountOfPlanet.ToString() + " planets";
				addPlanetNameBox.Visible = false;
			}
			else
			{
				planetNameTextBox.Text = "";
				addPlanetNameBox.Visible = false;
				Show("You do not have enough resources or you enter something wrong");
			}
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			string s = amountPlanetsTextBox.Text;
			if (s != "" && s.All(char.IsDigit))
			{
				int n = Convert.ToInt32(s);
				this.main.AmountOfPlanet = n;
				spaceBox.Text = "Space: 0/" + n + " planets";
				RefreshStorage();
				storageBox.Visible = true;
				spaceBox.Visible = true;
				startingBox.Visible = false;
				timerSpace.Start();
			}
			else
			{
				Show("You enter something wrong");
			}
		}

		private void amountPlanetsTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void buildFactoryButton_Click_1(object sender, EventArgs e)
		{
			chooseFactoryBox.Visible = true;
		}

		private void planetListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			planetBox.Visible = true;
			resoucesBox.Visible = true;
			upgradeBox.Visible = false;
			if (planetListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = planetListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = planetListBox.Items[intselectedindex].ToString();
				foreach (Planet p in main.Planets)
				{
					if (p.Name == text)
					{
						this.planet = p;
						stoneFactories.Items.Clear();
						woodFactories.Items.Clear();
						planetBox.Text = text;
						foreach (int k in planet.Colony.Buildings.Keys)
						{
							if (k == 0)
							{
								foreach (Building b in planet.Colony.Buildings[k])
								{
									stoneFactories.Items.Add(b.Name);
								}
							}
							if (k == 1)
							{
								foreach (Building b in planet.Colony.Buildings[k])
								{
									woodFactories.Items.Add(b.Name);
								}
							}
						}
					}
				}
				//MessageBox.Show(text); 
			}
		}

		private void resourceTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = resourceTypeListBox.SelectedItem.ToString();
			if (s == "Stone")
			{
				foreach (Planet p in main.Planets)
				{
					if (p.Name == planetBox.Text)
					{
						StoneFactory sf = new StoneFactory();
						if (planet.Colony.Build(sf))
						{
							stoneFactories.Items.Add(sf.Name);
							RefreshStorage();
						}
						else
						{
							Show("You do not have enough resources or you have too much buidings");
						}
					}
				}

			}
			else if (s == "Wood")
			{
				foreach (Planet p in main.Planets)
				{
					if (p.Name == planetBox.Text)
					{
						WoodFactory wf = new WoodFactory();
						if (planet.Colony.Build(wf))
						{
							woodFactories.Items.Add(wf.Name);
							RefreshStorage();
						}
						else
						{
							Show("You do not have enough resources or you have too much buidings");
						}
					}
				}
			}
			chooseFactoryBox.Visible = false;
		}

		private void timerSpace_Tick(object sender, EventArgs e)
		{
			foreach (Planet p in main.Planets)
			{
				foreach (int k in p.Colony.Buildings.Keys)
				{
					if (k < 2)
					{
						foreach (Factory f in p.Colony.Buildings[k])
						{
							f.Mine();
						}
					}
				}
			}
			RefreshStorage();
			if (planet != null)
			{
				stoneOnPlanetLabel.Text = planet.Storage.Store[0].Amount.ToString();
				woodOnPlanetLabel.Text = planet.Storage.Store[1].Amount.ToString();
			}
		}

		private void stoneFactories_SelectedIndexChanged(object sender, EventArgs e)
		{
			upgradeBox.Visible = true;
			if (stoneFactories.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = stoneFactories.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = stoneFactories.Items[intselectedindex].ToString();
				foreach (Planet p in main.Planets)
				{
					if (p.Name == planetBox.Text)
					{
						foreach (Factory f in planet.Colony.Buildings[0])
						{
							if (f.Name == text)
							{
								this.factory = f;
								levelLabel.Text = f.Level.ToString();
							}
						}
					}
				}
			}
		}

		private void woodFactories_SelectedIndexChanged(object sender, EventArgs e)
		{
			upgradeBox.Visible = true;
			if (woodFactories.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = woodFactories.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = woodFactories.Items[intselectedindex].ToString();
				foreach (Planet p in main.Planets)
				{
					if (p.Name == planetBox.Text)
					{
						foreach (Factory f in planet.Colony.Buildings[1])
						{
							if (f.Name == text)
							{
								this.factory = f;
								levelLabel.Text = f.Level.ToString();
							}
						}
					}
				}
			}
		}

		private void upgradeButton_Click(object sender, EventArgs e)
		{
			if (factory.Upgrade())
			{
				levelLabel.Text = factory.Level.ToString();
			}
			else
			{
				Show("You do not have enough resources");
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			chooseFactoryBox.Visible = false;
		}
	}
}

