namespace IdlePioneerPrototype
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpBuildings = new System.Windows.Forms.GroupBox();
            this.flwBuildings = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGamexmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadGamexmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpResources = new System.Windows.Forms.GroupBox();
            this.flwResources = new System.Windows.Forms.FlowLayoutPanel();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.tickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBuildings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBuildings
            // 
            this.grpBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBuildings.Controls.Add(this.flwBuildings);
            this.grpBuildings.Location = new System.Drawing.Point(12, 27);
            this.grpBuildings.Name = "grpBuildings";
            this.grpBuildings.Size = new System.Drawing.Size(193, 511);
            this.grpBuildings.TabIndex = 0;
            this.grpBuildings.TabStop = false;
            this.grpBuildings.Text = "Buildings";
            // 
            // flwBuildings
            // 
            this.flwBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flwBuildings.AutoScroll = true;
            this.flwBuildings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwBuildings.Location = new System.Drawing.Point(2, 19);
            this.flwBuildings.Name = "flwBuildings";
            this.flwBuildings.Size = new System.Drawing.Size(185, 486);
            this.flwBuildings.TabIndex = 0;
            this.flwBuildings.WrapContents = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startStopToolStripMenuItem,
            this.tickToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGamexmlToolStripMenuItem,
            this.reloadGamexmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openGamexmlToolStripMenuItem
            // 
            this.openGamexmlToolStripMenuItem.Name = "openGamexmlToolStripMenuItem";
            this.openGamexmlToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openGamexmlToolStripMenuItem.Text = "Open game.xml";
            this.openGamexmlToolStripMenuItem.Click += new System.EventHandler(this.openGamexmlToolStripMenuItem_Click);
            // 
            // reloadGamexmlToolStripMenuItem
            // 
            this.reloadGamexmlToolStripMenuItem.Name = "reloadGamexmlToolStripMenuItem";
            this.reloadGamexmlToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.reloadGamexmlToolStripMenuItem.Text = "Reload game.xml";
            this.reloadGamexmlToolStripMenuItem.Click += new System.EventHandler(this.reloadGamexmlToolStripMenuItem_Click);
            // 
            // startStopToolStripMenuItem
            // 
            this.startStopToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            this.startStopToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.startStopToolStripMenuItem.Text = "Start/Stop";
            this.startStopToolStripMenuItem.Click += new System.EventHandler(this.startStopToolStripMenuItem_Click);
            // 
            // grpResources
            // 
            this.grpResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpResources.Controls.Add(this.flwResources);
            this.grpResources.Location = new System.Drawing.Point(211, 27);
            this.grpResources.Name = "grpResources";
            this.grpResources.Size = new System.Drawing.Size(200, 511);
            this.grpResources.TabIndex = 2;
            this.grpResources.TabStop = false;
            this.grpResources.Text = "Resources";
            // 
            // flwResources
            // 
            this.flwResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flwResources.AutoScroll = true;
            this.flwResources.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwResources.Location = new System.Drawing.Point(6, 19);
            this.flwResources.Name = "flwResources";
            this.flwResources.Size = new System.Drawing.Size(188, 486);
            this.flwResources.TabIndex = 1;
            this.flwResources.WrapContents = false;
            // 
            // tick
            // 
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // tickToolStripMenuItem
            // 
            this.tickToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tickToolStripMenuItem.Enabled = false;
            this.tickToolStripMenuItem.Name = "tickToolStripMenuItem";
            this.tickToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tickToolStripMenuItem.Text = "false";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 550);
            this.Controls.Add(this.grpResources);
            this.Controls.Add(this.grpBuildings);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBuildings.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpResources.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuildings;
        private System.Windows.Forms.FlowLayoutPanel flwBuildings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGamexmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadGamexmlToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpResources;
        private System.Windows.Forms.FlowLayoutPanel flwResources;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickToolStripMenuItem;
    }
}

