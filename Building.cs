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

        public int level;


        public Dictionary<string, float> TickIncome(int Millisecs)
        {
            Dictionary<string, float> returnIncome = new Dictionary<string, float>();

            returnIncome.Add("", 0);

            return returnIncome; //Util.Evaluate(autoGainFunc.Replace("level", level.ToString())) * (Millisecs / 1000);
        }

        public float ClickIncome()
        {
            return 0;
            // return Util.Evaluate(clickGainFunc.Replace("level", level.ToString()));
        }

        public Building()
        {
            InitializeComponent();
        }
    }
}
