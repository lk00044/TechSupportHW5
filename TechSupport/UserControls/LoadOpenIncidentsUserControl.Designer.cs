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
            ProductCodeColumnHeader1 = new ColumnHeader();
            DateOpenedColumnHeader1 = new ColumnHeader();
            CustomerColumnHeader1 = new ColumnHeader();
            TechnicianColumnHeader1 = new ColumnHeader();
            TitleColumnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // OpenIncidentsListView
            // 
            OpenIncidentsListView.AutoArrange = false;
            OpenIncidentsListView.Columns.AddRange(new ColumnHeader[] { ProductCodeColumnHeader1, DateOpenedColumnHeader1, CustomerColumnHeader1, TechnicianColumnHeader1, TitleColumnHeader1 });
            OpenIncidentsListView.Dock = DockStyle.Fill;
            OpenIncidentsListView.Location = new Point(0, 0);
            OpenIncidentsListView.Name = "OpenIncidentsListView";
            OpenIncidentsListView.Size = new Size(728, 227);
            OpenIncidentsListView.TabIndex = 0;
            OpenIncidentsListView.UseCompatibleStateImageBehavior = false;
            OpenIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductCodeColumnHeader1
            // 
            ProductCodeColumnHeader1.Text = "Product Code";
            ProductCodeColumnHeader1.Width = 100;
            // 
            // DateOpenedColumnHeader1
            // 
            DateOpenedColumnHeader1.Text = "Date Opened";
            DateOpenedColumnHeader1.Width = 100;
            // 
            // CustomerColumnHeader1
            // 
            CustomerColumnHeader1.Text = "Customer";
            CustomerColumnHeader1.Width = 150;
            // 
            // TechnicianColumnHeader1
            // 
            TechnicianColumnHeader1.Text = "Technician";
            TechnicianColumnHeader1.Width = 150;
            // 
            // TitleColumnHeader1
            // 
            TitleColumnHeader1.Text = "Title";
            TitleColumnHeader1.Width = 200;
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
        private ColumnHeader ProductCodeColumnHeader1;
        private ColumnHeader DateOpenedColumnHeader1;
        private ColumnHeader CustomerColumnHeader1;
        private ColumnHeader TechnicianColumnHeader1;
        private ColumnHeader TitleColumnHeader1;
    }
}
