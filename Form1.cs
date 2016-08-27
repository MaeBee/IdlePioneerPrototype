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

        private List<Building> Buildings = new List<Building>();
        private List<Resource> Resources = new List<Resource>();

        public string ReadGame()
        {
            Buildings.Clear();
            Resources.Clear();
            flwBuildings.Controls.Clear();
            flwResources.Controls.Clear();
            XmlTextReader reader = new XmlTextReader(Application.StartupPath + "\\game.xml");
            while (reader.Read())
            {
                reader.MoveToContent();
                if (reader.Name == "building")
                {
                    Buildings.Add(new Building((string)reader.GetAttribute("name"), (string)reader.GetAttribute("use"), (string)reader.GetAttribute("upgrade"), Convert.ToInt32(reader.GetAttribute("level"))));
                    //flwBuildings.Controls.Add(new Building((string)reader.GetAttribute("name"), (string)reader.GetAttribute("use"), (string)reader.GetAttribute("upgrade"), Convert.ToInt32(reader.GetAttribute("level"))));
                }
                if (reader.Name == "resource")
                {
                    Resources.Add(new Resource((string)reader.GetAttribute("name"), Convert.ToInt32(reader.GetAttribute("count")), Convert.ToInt32(reader.GetAttribute("storage"))));
                    //flwResources.Controls.Add(new Resource((string)reader.GetAttribute("name"), Convert.ToInt32(reader.GetAttribute("count")), Convert.ToInt32(reader.GetAttribute("storage"))));
                }
                /*if (reader.Name == "module")
                {
                    ID = Convert.ToInt32((string)reader.GetAttribute("id"));
                    varname = (string)reader.GetAttribute("name");
                    //arModules.Add(new ProgramModule(ID, varname, ""));
                }*/
            }
            reader.Close();
            PopulateGame();
            return "OK";
        }

        public void PopulateGame()
        {
            foreach (Building bld in Buildings)
            {
                flwBuildings.Controls.Add(bld);
            }
            foreach (Resource res in Resources)
            {
                flwResources.Controls.Add(res);
            }
        }

        public string ReadGameNew()
        {
            Buildings.Clear();
            Resources.Clear();
            flwBuildings.Controls.Clear();
            flwResources.Controls.Clear();

            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(Application.StartupPath + "\\game.xml");
            foreach (XmlNode node in XMLDoc.SelectSingleNode("//game/buildings").ChildNodes)
            {
                Buildings.Add(new Building((string)node.Attributes["name"].Value, (string)node.Attributes["use"].Value, (string)node.Attributes["upgrade"].Value, int.Parse(node.Attributes["level"].Value)));
            }
            foreach (XmlNode node in XMLDoc.SelectSingleNode("//game/resources").ChildNodes)
            {
                Resources.Add(new Resource((string)node.Attributes["name"].Value, int.Parse(node.Attributes["count"].Value), int.Parse(node.Attributes["storage"].Value)));
            }

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
    }
}
