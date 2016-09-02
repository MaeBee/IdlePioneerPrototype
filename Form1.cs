using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace IdlePioneerPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadGame();
        }

        private Dictionary<string, Building> Buildings = new Dictionary<string, Building>();
        private Dictionary<string, Resource> Resources = new Dictionary<string, Resource>();

        public void PopulateGame()
        {
            // Clear out UI to prevent duplicates
            flwBuildings.Controls.Clear();
            flwResources.Controls.Clear();

            // Loop through Lists and add controls
            foreach (Building bld in Buildings.Values)
            {
                flwBuildings.Controls.Add(bld);
                bld.UpgradeButtonClick += new EventHandler(Building_ButtonClick);
            }
            foreach (Resource res in Resources.Values)
            {
                flwResources.Controls.Add(res);
            }
        }

        public string ReadGame()
        {
            // Prepare dummy classes
            Building TempBuilding;
            Resource TempResource;

            // Clear out pre-existing game data to prevent duplicates
            Buildings.Clear();
            Resources.Clear();

            // Open XML
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(Application.StartupPath + "\\game.xml");

            // Find nodes and fill relevant Lists with data from the nodes
            foreach (XmlNode node in XMLDoc.SelectSingleNode("//game/buildings").ChildNodes)
            {
                // We have a building, so we need to create a new one to put into the Dictionary
                TempBuilding = new Building();
                // ... And fill it with data.
                TempBuilding.lblNameText = (string)node.Attributes["name"].Value;
                TempBuilding.btnUseText = (string)node.Attributes["use"].Value;
                TempBuilding.btnUpgradeText = (string)node.Attributes["upgrade"].Value;
                TempBuilding.Level = int.Parse(node.Attributes["level"].Value);

                // If there's more to the building, go through all the additional bits of data
                if (node.HasChildNodes)
                {

                    foreach (XmlNode bldSub in node.ChildNodes)
                    {
                        if (bldSub.Name == "production")
                        {
                            // The building is producing something. Let's get the recipes!
                            BuildingRecipe TempRecipe = new BuildingRecipe();
                            TempRecipe.AutoGain = (string)bldSub.Attributes["autogain"].Value;
                            TempRecipe.OnClick = (string)bldSub.Attributes["onclick"].Value;
                            TempRecipe.Resource = (string)bldSub.Attributes["resource"].Value;
                            TempBuilding.BuildingRecipes.Add(TempRecipe);
                        }
                        if (bldSub.Name == "upgrade")
                        {
                            // The building has upgrades defined. Each child node will define one resource and how it scales with levels, so we just read them all and dump them into the Dictionary we use to calculate the actual cost later on.
                            foreach (XmlNode bldUpg in bldSub.ChildNodes)
                            {
                                TempBuilding.UpgradeCost.Add((string)bldUpg.Attributes["resource"].Value, (string)bldUpg.Attributes["formula"].Value);
                            }
                        }
                        // Other building sub nodes like work places will go here
                    }
                }

                // Finally, with all data acquired, we put the object into the Dictionary.
                Buildings.Add(TempBuilding.lblNameText, TempBuilding);
            }
            foreach (XmlNode node in XMLDoc.SelectSingleNode("//game/resources").ChildNodes)
            {
                // Same as with the buildings. Make new object, fill with data, put in Dictionary.
                TempResource = new Resource();
                TempResource.lblNameText = (string)node.Attributes["name"].Value;
                TempResource.Count = int.Parse(node.Attributes["count"].Value);
                TempResource.lblStorageText = int.Parse(node.Attributes["storage"].Value);
                Resources.Add(TempResource.lblNameText, TempResource);
            }

            // Populate UI
            PopulateGame();

            return "OK";
        }

        private void openGamexmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\game.xml");
        }

        private void reloadGamexmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadGame();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            // Calculate changes for the last 0.1s
            foreach (Building bld in Buildings.Values)
            {
                foreach (KeyValuePair<string, float> Income in bld.TickIncome(tick.Interval))
                {
                    // Loop through returned resources and add them to the stockpile
                    Resource res = Resources[Income.Key];
                    if (res.Count + Income.Value < res.lblStorageText)
                    {
                        res.Count += Income.Value;
                    }
                    else
                    {
                        res.Count = res.lblStorageText;
                    }
                    Resources[Income.Key] = res;
                }
            }
            this.Update();
        }

        private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggle the timer to pause/unpause the game
            tick.Enabled = !tick.Enabled;
            tickToolStripMenuItem.Text = tick.Enabled.ToString();
        }

        protected void Building_ButtonClick(object sender, EventArgs e)
        {
            // An upgrade button has been pressed.
            // First, we need to figure out which building the user wants to upgrade and get its upgrade cost formulae
            Building bldToUpgrade = (Building)sender;
            Dictionary<string, string> UpgradeCost = bldToUpgrade.UpgradeCost;

            // Then we need to figure out if there's enough resources to upgrade. If not, we'll let the user know.
            foreach (KeyValuePair<string, string> resource in UpgradeCost)
            {
                if ((Resources[resource.Key].Count - Util.Evaluate(resource.Value.Replace("level", bldToUpgrade.Level.ToString()))) < 0)
                {
                    MessageBox.Show(resource.Key + " needed: " + Util.Evaluate(resource.Value.Replace("level", bldToUpgrade.Level.ToString())).ToString() + "\r\n" + resource.Key + " in storage: " + Resources[resource.Key].Count.ToString());
                    return;
                }
            }

            // If we haven't left yet, it means we've got the resources to go ahead with the upgrade, so we execute it and take the resources from storage.
            bldToUpgrade.Level++;
            foreach (KeyValuePair<string, string> resource in UpgradeCost)
            {
                Resources[resource.Key].Count = Resources[resource.Key].Count - Util.Evaluate(resource.Value.Replace("level", bldToUpgrade.Level.ToString()));
            }
        }
    }
}
