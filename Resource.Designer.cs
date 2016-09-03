namespace IdlePioneerPrototype
{
    partial class Resource
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblNameText";
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(76, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 23);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "lblCountText";
            // 
            // lblStorage
            // 
            this.lblStorage.Location = new System.Drawing.Point(123, 0);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(47, 23);
            this.lblStorage.TabIndex = 2;
            this.lblStorage.Text = "lblStorageText";
            // 
            // lblIncome
            // 
            this.lblIncome.Location = new System.Drawing.Point(176, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(86, 23);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "lblIncomeText";
            // 
            // Resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblName);
            this.Name = "Resource";
            this.Size = new System.Drawing.Size(264, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblIncome;
    }
}
