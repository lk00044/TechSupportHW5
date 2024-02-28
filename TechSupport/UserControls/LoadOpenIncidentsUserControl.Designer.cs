namespace Incidents.UserControls
{
    partial class LoadOpenIncidentsUserControl
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
            OpenIncidentsListView = new ListView();
            ProductCodeColumnHeader = new ColumnHeader();
            DateOpenedColumnHeader = new ColumnHeader();
            CustomerColumnHeader = new ColumnHeader();
            TechnicianColumnHeader = new ColumnHeader();
            TitleColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // OpenIncidentsListView
            // 
            OpenIncidentsListView.AutoArrange = false;
            OpenIncidentsListView.Columns.AddRange(new ColumnHeader[] { ProductCodeColumnHeader, DateOpenedColumnHeader, CustomerColumnHeader, TechnicianColumnHeader, TitleColumnHeader });
            OpenIncidentsListView.Dock = DockStyle.Fill;
            OpenIncidentsListView.Location = new Point(0, 0);
            OpenIncidentsListView.Name = "OpenIncidentsListView";
            OpenIncidentsListView.Size = new Size(728, 227);
            OpenIncidentsListView.TabIndex = 0;
            OpenIncidentsListView.UseCompatibleStateImageBehavior = false;
            OpenIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductCodeColumnHeader
            // 
            ProductCodeColumnHeader.Text = "Product Code";
            ProductCodeColumnHeader.Width = 100;
            // 
            // DateOpenedColumnHeader
            // 
            DateOpenedColumnHeader.Text = "Date Opened";
            DateOpenedColumnHeader.Width = 100;
            // 
            // CustomerColumnHeader
            // 
            CustomerColumnHeader.Text = "Customer";
            CustomerColumnHeader.Width = 150;
            // 
            // TechnicianColumnHeader
            // 
            TechnicianColumnHeader.Text = "Technician";
            TechnicianColumnHeader.Width = 150;
            // 
            // TitleColumnHeader
            // 
            TitleColumnHeader.Text = "Title";
            TitleColumnHeader.Width = 200;
            // 
            // LoadOpenIncidentsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpenIncidentsListView);
            Name = "LoadOpenIncidentsUserControl";
            Size = new Size(728, 227);
            ResumeLayout(false);
        }

        #endregion

        private ListView OpenIncidentsListView;
        private ColumnHeader ProductCodeColumnHeader;
        private ColumnHeader DateOpenedColumnHeader;
        private ColumnHeader CustomerColumnHeader;
        private ColumnHeader TechnicianColumnHeader;
        private ColumnHeader TitleColumnHeader;
    }
}
