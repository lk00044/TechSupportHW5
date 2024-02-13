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
            SuspendLayout();
            // 
            // OpenIncidentsListView
            // 
            OpenIncidentsListView.Dock = DockStyle.Fill;
            OpenIncidentsListView.Location = new Point(0, 0);
            OpenIncidentsListView.Name = "OpenIncidentsListView";
            OpenIncidentsListView.Size = new Size(575, 227);
            OpenIncidentsListView.TabIndex = 0;
            OpenIncidentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // LoadOpenIncidentsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpenIncidentsListView);
            Name = "LoadOpenIncidentsUserControl";
            Size = new Size(575, 227);
            ResumeLayout(false);
        }

        #endregion

        private ListView OpenIncidentsListView;
    }
}
