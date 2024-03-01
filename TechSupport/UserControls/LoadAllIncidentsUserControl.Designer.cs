namespace AllIncidents.UserControls
{
    partial class LoadAllIncidentsUserControl
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
            components = new System.ComponentModel.Container();
            incidentControllerBindingSource = new BindingSource(components);
            DisplayAllListView = new ListView();
            ProductCodeColumnHeader = new ColumnHeader();
            DateOpenedColumnHeader = new ColumnHeader();
            DateClosedColumnHeader = new ColumnHeader();
            CustomerColumnHeader = new ColumnHeader();
            TechnicianColumnHeader = new ColumnHeader();
            TitleColumnHeader = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)incidentControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // incidentControllerBindingSource
            // 
            incidentControllerBindingSource.DataSource = typeof(Incidents.Controller.IncidentController);
            // 
            // DisplayAllListView
            // 
            DisplayAllListView.Columns.AddRange(new ColumnHeader[] { ProductCodeColumnHeader, DateOpenedColumnHeader, DateClosedColumnHeader, CustomerColumnHeader, TechnicianColumnHeader, TitleColumnHeader });
            DisplayAllListView.Dock = DockStyle.Fill;
            DisplayAllListView.Location = new Point(0, 0);
            DisplayAllListView.Name = "DisplayAllListView";
            DisplayAllListView.Size = new Size(1008, 438);
            DisplayAllListView.TabIndex = 0;
            DisplayAllListView.UseCompatibleStateImageBehavior = false;
            DisplayAllListView.View = View.Details;
            // 
            // ProductCodeColumnHeader
            // 
            ProductCodeColumnHeader.Text = "Product Code";
            ProductCodeColumnHeader.Width = 130;
            // 
            // DateOpenedColumnHeader
            // 
            DateOpenedColumnHeader.Text = "Date Opened";
            DateOpenedColumnHeader.Width = 120;
            // 
            // DateClosedColumnHeader
            // 
            DateClosedColumnHeader.Text = "Date Closed";
            DateClosedColumnHeader.Width = 120;
            // 
            // CustomerColumnHeader
            // 
            CustomerColumnHeader.Text = "Customer";
            CustomerColumnHeader.Width = 200;
            // 
            // TechnicianColumnHeader
            // 
            TechnicianColumnHeader.Text = "Technician";
            TechnicianColumnHeader.Width = 200;
            // 
            // TitleColumnHeader
            // 
            TitleColumnHeader.Text = "Title";
            TitleColumnHeader.Width = 300;
            // 
            // LoadAllIncidentsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DisplayAllListView);
            Name = "LoadAllIncidentsUserControl";
            Size = new Size(1008, 438);
            ((System.ComponentModel.ISupportInitialize)incidentControllerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource incidentControllerBindingSource;
        private ListView DisplayAllListView;
        private ColumnHeader ProductCodeColumnHeader;
        private ColumnHeader DateOpenedColumnHeader;
        private ColumnHeader CustomerColumnHeader;
        private ColumnHeader TechnicianColumnHeader;
        private ColumnHeader TitleColumnHeader;
        private ColumnHeader DateClosedColumnHeader;
    }
}
