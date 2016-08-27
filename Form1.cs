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
            ReadGameNew();
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
            }
            foreach (Resource res in Resources.Values)
            {
                flwResources.Controls.Add(res);
            }
        }

        public string ReadGameNew()
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
                TempBuilding.level = int.Parse(node.Attributes["level"].Value);

                // If there's more to the building, go through all the additional bits of data
                if (node.HasChildNodes)
                {

                    foreach (XmlNode bldSub in node.ChildNodes)
                    {
                        if (bldSub.Name == "production")
                        {
                            // The building is producing something. Let's get the recipes!
                        }
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
                TempResource.lblCountText = int.Parse(node.Attributes["count"].Value);
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
            ReadGameNew();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            // Calculate changes for the last 0.1s
            foreach (Building bld in Buildings.Values)
            {
                //float income = bld.TickIncome(tick.Interval);
            }
        }
    }
}
