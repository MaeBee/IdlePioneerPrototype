using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace IdlePioneerPrototype
{
    public partial class Building : UserControl
    {
        public string lblNameText
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public string btnUseText
        {
            get
            {
                return btnUse.Text;
            }
            set
            {
                btnUse.Text = value;
            }
        }

        public string btnUpgradeText
        {
            get
            {
                return btnUpgrade.Text;
            }
            set
            {
                btnUpgrade.Text = value;
            }
        }

        private int level;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                lblLevel.Text = "Level " + value.ToString();
                lblUpgradeCost.Text = UpgradeCostList();
            }
        }

        public Dictionary<string,BuildingRecipe> BuildingRecipes = new Dictionary<string,BuildingRecipe>();
        public Dictionary<string, string> UpgradeCost = new Dictionary<string, string>();
        public Dictionary<string, string> Storage = new Dictionary<string, string>();
        public event EventHandler UpgradeButtonClick;

        public Dictionary<string, float> TickIncome(float Millisecs)
        {
            // Calculate resource income for the given time frame (usually one tick)
            Dictionary<string, float> returnIncome = new Dictionary<string, float>();
            foreach (BuildingRecipe recipe in BuildingRecipes.Values)
            {
                returnIncome.Add(recipe.Resource, Util.Evaluate(recipe.AutoGain.Replace("level", Level.ToString())) * (Millisecs / 1000));
                if (recipe.Consumes != null)
                {
                    if (returnIncome.ContainsKey(recipe.Consumes))
                    {
                        returnIncome[recipe.Consumes] -= Util.Evaluate(recipe.AutoGain.Replace("level", Level.ToString())) * (Millisecs / 1000) * recipe.Ratio;
                    }
                    else
                    {
                        returnIncome.Add(recipe.Consumes, -(Util.Evaluate(recipe.AutoGain.Replace("level", Level.ToString())) * (Millisecs / 1000) * recipe.Ratio));
                    }
                }
            }
            return returnIncome;
        }

        public Dictionary<string, float> Upgrade()
        {
            Dictionary<string, float> returnCost = new Dictionary<string, float>();
            bool upgradeable = true;
            foreach (KeyValuePair<string, string> resource in UpgradeCost)
            {

            }
            if (!upgradeable)
            {
                return returnCost;
            }
            else
            {
                return returnCost;
            }
        }

        public float GetUpgradeCost(string Resource)
        {
            // Input resource name, output the calculated amount of that resource for the next upgrade. Still will have to be looped for every resource.
            if (UpgradeCost.ContainsKey(Resource))
            {
                return Util.Evaluate(UpgradeCost[Resource].Replace("level", (Level + 1).ToString()));
            }
            else
            {
                return 0f;
            }
        }

        public float GetStorage(string Resource)
        {
            // Input resource name, output the calculated storage provided for that resource
            if (Storage.ContainsKey(Resource))
            {
                return Util.Evaluate(Storage[Resource].Replace("level", Level.ToString()));
            }
            else
            {
                return 0f;
            }
        }

        public Dictionary<string, float> ClickIncome()
        {
            // Calculate resource income for a single click
            Dictionary<string, float> returnIncome = new Dictionary<string, float>();
            foreach (BuildingRecipe recipe in BuildingRecipes.Values)
            {
                returnIncome.Add(recipe.Resource, Util.Evaluate(recipe.OnClick.Replace("level", Level.ToString())));
            }
            return returnIncome;
        }

        public Building()
        {
            InitializeComponent();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (this.UpgradeButtonClick != null)
            {
                this.UpgradeButtonClick(this, e);
            }
        }

        public string UpgradeCostList()
        {
            // Compile the upgrade cost for the next level into a string for the label. Invoked on every change of the Level var.
            string returnString = "Upgrade cost:";
            foreach (KeyValuePair<string, string> res in UpgradeCost)
            {
                returnString += "\r\n" + res.Key + ": " + GetUpgradeCost(res.Key).ToString();
            }
            return returnString;
        }

        private void Building_Load(object sender, EventArgs e)
        {
            lblUpgradeCost.Text = UpgradeCostList();
        }
    }

    public class BuildingRecipe
    {
        public string Resource;
        public string OnClick;
        public string AutoGain;
        public string Consumes;
        public float Ratio;

        public BuildingRecipe()
        {
        }
    }
}
