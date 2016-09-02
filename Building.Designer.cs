namespace IdlePioneerPrototype
{
    partial class Building
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUse = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(3, 24);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(18, 23);
            this.btnUse.TabIndex = 0;
            this.btnUse.Text = "btnUseText";
            this.btnUse.UseVisualStyleBackColor = true;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(27, 24);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(132, 23);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "btnUpgradeText";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblNameText";
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(110, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(52, 23);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level 0";
            // 
            // Building
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnUse);
            this.Name = "Building";
            this.Size = new System.Drawing.Size(162, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLevel;
    }
}
