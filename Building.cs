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
            }
        }

        public List<BuildingRecipe> BuildingRecipes = new List<BuildingRecipe>();
        public Dictionary<string, string> UpgradeCost = new Dictionary<string, string>();
        public event EventHandler UpgradeButtonClick;

        public Dictionary<string, float> TickIncome(float Millisecs)
        {
            // Calculate resource income for the given time frame (usually one tick)
            Dictionary<string, float> returnIncome = new Dictionary<string, float>();
            foreach (BuildingRecipe recipe in BuildingRecipes)
            {
                returnIncome.Add(recipe.Resource, Util.Evaluate(recipe.AutoGain.Replace("level", Level.ToString())) * (Millisecs / 1000));
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


        public Dictionary<string, float> ClickIncome()
        {
            // Calculate resource income for a single click
            Dictionary<string, float> returnIncome = new Dictionary<string, float>();
            foreach (BuildingRecipe recipe in BuildingRecipes)
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
    }

    public class BuildingRecipe
    {
        public string Resource;
        public string OnClick;
        public string AutoGain;

        public BuildingRecipe()
        {
        }
    }
}
