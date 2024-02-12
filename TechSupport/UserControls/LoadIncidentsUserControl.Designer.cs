namespace IncidentsLocal.UserControls
{
    partial class LoadIncidentsUserControl
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
            IncidentsDataGridView = new DataGridView();
            incidentControllerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)incidentControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // IncidentsDataGridView
            // 
            IncidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncidentsDataGridView.Location = new Point(0, 0);
            IncidentsDataGridView.Name = "IncidentsDataGridView";
            IncidentsDataGridView.RowHeadersWidth = 51;
            IncidentsDataGridView.Size = new Size(689, 361);
            IncidentsDataGridView.TabIndex = 0;
            // 
            // incidentControllerBindingSource
            // 
            incidentControllerBindingSource.DataSource = typeof(Incidents.Controller.IncidentController);
            // 
            // LoadIncidentsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IncidentsDataGridView);
            Name = "LoadIncidentsUserControl";
            Size = new Size(689, 361);
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)incidentControllerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView IncidentsDataGridView;
        private BindingSource incidentControllerBindingSource;
    }
}
