using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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


        public Building(string bldName, string bldUse, string bldUpgrade, int bldLevel)
        {
            InitializeComponent();
            this.lblNameText = bldName;
            this.btnUseText = bldUse;
            this.btnUpgradeText = bldUpgrade;
            this.level = bldLevel;
        }
    }
}
