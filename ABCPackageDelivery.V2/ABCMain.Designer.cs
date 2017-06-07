namespace ABCPackageDelivery.V2
{
    partial class ABCMain
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
            this.mtCreateParcel = new MetroFramework.Controls.MetroTile();
            this.listMain = new System.Windows.Forms.ListBox();
            this.mtCostAnalysis = new MetroFramework.Controls.MetroTile();
            this.mtDisplayCourierDetails = new MetroFramework.Controls.MetroTile();
            this.mtDisplayShippingDetails = new MetroFramework.Controls.MetroTile();
            this.mt = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtCreateParcel
            // 
            this.mtCreateParcel.Location = new System.Drawing.Point(21, 96);
            this.mtCreateParcel.Name = "mtCreateParcel";
            this.mtCreateParcel.Size = new System.Drawing.Size(482, 69);
            this.mtCreateParcel.TabIndex = 0;
            this.mtCreateParcel.Text = "Create Parcels";
            this.mtCreateParcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreateParcel.Click += new System.EventHandler(this.mtCreateParcel_Click);
            // 
            // listMain
            // 
            this.listMain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listMain.FormattingEnabled = true;
            this.listMain.ItemHeight = 20;
            this.listMain.Location = new System.Drawing.Point(509, 101);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(577, 364);
            this.listMain.TabIndex = 0;
            // 
            // mtCostAnalysis
            // 
            this.mtCostAnalysis.Location = new System.Drawing.Point(21, 246);
            this.mtCostAnalysis.Name = "mtCostAnalysis";
            this.mtCostAnalysis.Size = new System.Drawing.Size(482, 69);
            this.mtCostAnalysis.TabIndex = 1;
            this.mtCostAnalysis.Text = "Cost Analysis";
            this.mtCostAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCostAnalysis.Click += new System.EventHandler(this.mtCostAnalysis_Click);
            // 
            // mtDisplayCourierDetails
            // 
            this.mtDisplayCourierDetails.Location = new System.Drawing.Point(21, 321);
            this.mtDisplayCourierDetails.Name = "mtDisplayCourierDetails";
            this.mtDisplayCourierDetails.Size = new System.Drawing.Size(482, 69);
            this.mtDisplayCourierDetails.TabIndex = 0;
            this.mtDisplayCourierDetails.Text = "Display Courier Details";
            this.mtDisplayCourierDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDisplayCourierDetails.Click += new System.EventHandler(this.mtDisplayCourierDetails_Click);
            // 
            // mtDisplayShippingDetails
            // 
            this.mtDisplayShippingDetails.Location = new System.Drawing.Point(21, 171);
            this.mtDisplayShippingDetails.Name = "mtDisplayShippingDetails";
            this.mtDisplayShippingDetails.Size = new System.Drawing.Size(482, 69);
            this.mtDisplayShippingDetails.TabIndex = 0;
            this.mtDisplayShippingDetails.Text = "Display Shipping Details";
            this.mtDisplayShippingDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDisplayShippingDetails.Click += new System.EventHandler(this.mtDisplayShippingDetails_Click);
            // 
            // mt
            // 
            this.mt.Location = new System.Drawing.Point(21, 396);
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(482, 69);
            this.mt.TabIndex = 2;
            this.mt.Text = "Exit";
            this.mt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt.Click += new System.EventHandler(this.mt_Click);
            // 
            // ABCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 543);
            this.Controls.Add(this.mt);
            this.Controls.Add(this.mtDisplayCourierDetails);
            this.Controls.Add(this.mtDisplayShippingDetails);
            this.Controls.Add(this.mtCostAnalysis);
            this.Controls.Add(this.listMain);
            this.Controls.Add(this.mtCreateParcel);
            this.Name = "ABCMain";
            this.Text = "ABC Delivery ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCreateParcel;
        private System.Windows.Forms.ListBox listMain;
        private MetroFramework.Controls.MetroTile mtCostAnalysis;
        private MetroFramework.Controls.MetroTile mtDisplayCourierDetails;
        private MetroFramework.Controls.MetroTile mtDisplayShippingDetails;
        private MetroFramework.Controls.MetroTile mt;
    }
}