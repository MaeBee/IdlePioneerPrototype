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
    public partial class Resource : UserControl
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

        private float count;
        public float Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                lblCount.Text = value.ToString();
            }
        }

        private float storage;
        public float Storage
        {
            get
            {
                return storage;
            }
            set
            {
                storage = value;
                lblStorage.Text = value.ToString();
            }
        }

        private float income;
        public float Income
        {
            set
            {
                income = value;
                lblIncome.Text = "(" + value + "/sec)";
            }
            get
            {
                return income;
            }
        }

        public Resource()
        {
            InitializeComponent();
        }
    }
}
