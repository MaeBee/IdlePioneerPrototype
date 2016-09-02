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

        public float lblStorageText
        {
            get
            {
                return Convert.ToInt32(lblStorage.Text);
            }
            set
            {
                lblStorage.Text = value.ToString();
            }
        }

        public Resource()
        {
            InitializeComponent();
        }
    }
}
