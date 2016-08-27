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

        public int lblCountText
        {
            get
            {
                return Convert.ToInt32(lblCount.Text);
            }
            set
            {
                lblCount.Text = value.ToString();
            }
        }

        public int lblStorageText
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
