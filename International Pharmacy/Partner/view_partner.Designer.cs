namespace International_Pharmacy
{
    partial class view_partner
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition8 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radMultiColumnComboBox2 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            this.gridViewTemplate2 = new Telerik.WinControls.UI.GridViewTemplate();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMultiColumnComboBox2
            // 
            // 
            // radMultiColumnComboBox2.NestedRadGridView
            // 
            this.radMultiColumnComboBox2.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox2.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox2.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox2.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.radMultiColumnComboBox2.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox2.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox2.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox2.EditorControl.Size = new System.Drawing.Size(300, 187);
            this.radMultiColumnComboBox2.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox2.Location = new System.Drawing.Point(635, 91);
            this.radMultiColumnComboBox2.Name = "radMultiColumnComboBox2";
            this.radMultiColumnComboBox2.NullText = "Partner ID";
            this.radMultiColumnComboBox2.Size = new System.Drawing.Size(197, 36);
            this.radMultiColumnComboBox2.TabIndex = 140;
            this.radMultiColumnComboBox2.TabStop = false;
            this.radMultiColumnComboBox2.ThemeName = "TelerikMetro";
            // 
            // radGridView1
            // 
            this.radGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGridView1.Location = new System.Drawing.Point(6, 198);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition8;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(1);
            this.radGridView1.Size = new System.Drawing.Size(1306, 187);
            this.radGridView1.TabIndex = 138;
            this.radGridView1.ThemeName = "Windows8";
            // 
            // gridViewTemplate1
            // 
            gridViewTextBoxColumn2.HeaderText = "column1";
            gridViewTextBoxColumn2.MinWidth = 55;
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 55;
            this.gridViewTemplate1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2});
            this.gridViewTemplate1.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate2});
            this.gridViewTemplate1.ViewDefinition = tableViewDefinition7;
            // 
            // gridViewTemplate2
            // 
            this.gridViewTemplate2.ViewDefinition = tableViewDefinition6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 139;
            this.label1.Text = "Partner ID";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::International_Pharmacy.Properties.Resources.circled_left;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(41, 37);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(61, 50);
            this.pictureBox7.TabIndex = 137;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::International_Pharmacy.Properties.Resources._31914_200;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1132, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 50);
            this.pictureBox2.TabIndex = 136;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::International_Pharmacy.Properties.Resources.Edit_clear_mirrored_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1252, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // view_partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 452);
            this.Controls.Add(this.radMultiColumnComboBox2);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "view_partner";
            this.Load += new System.EventHandler(this.view_partner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}