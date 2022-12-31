namespace KopyalaBeni
{
    partial class FDataList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDataList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bTum = new DevExpress.XtraEditors.SimpleButton();
            this.bYedek = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(693, 581);
            this.gridControl1.TabIndex = 39;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 842;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // bTum
            // 
            this.bTum.Appearance.BackColor = System.Drawing.Color.Red;
            this.bTum.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTum.Appearance.Options.UseBackColor = true;
            this.bTum.Appearance.Options.UseFont = true;
            this.bTum.Dock = System.Windows.Forms.DockStyle.Left;
            this.bTum.Location = new System.Drawing.Point(0, 0);
            this.bTum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTum.Name = "bTum";
            this.bTum.Size = new System.Drawing.Size(351, 41);
            this.bTum.TabIndex = 40;
            this.bTum.Text = "Tüm Verileri Listele";
            this.bTum.Click += new System.EventHandler(this.bTum_Click);
            // 
            // bYedek
            // 
            this.bYedek.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.bYedek.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYedek.Appearance.Options.UseBackColor = true;
            this.bYedek.Appearance.Options.UseFont = true;
            this.bYedek.Dock = System.Windows.Forms.DockStyle.Right;
            this.bYedek.Location = new System.Drawing.Point(352, 0);
            this.bYedek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bYedek.Name = "bYedek";
            this.bYedek.Size = new System.Drawing.Size(341, 41);
            this.bYedek.TabIndex = 41;
            this.bYedek.Text = "Yedekteki Verileri Listele";
            this.bYedek.Click += new System.EventHandler(this.bYedek_Click);
            // 
            // FDataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 622);
            this.Controls.Add(this.bYedek);
            this.Controls.Add(this.bTum);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDataList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Listeleri";
            this.Load += new System.EventHandler(this.FDataList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton bTum;
        private DevExpress.XtraEditors.SimpleButton bYedek;
    }
}