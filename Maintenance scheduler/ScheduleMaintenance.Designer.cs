﻿namespace Maintenance_scheduler
{
    partial class ScheduleMaintenance
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
            this.components = new System.ComponentModel.Container();
            this.MaintenanceNotif = new System.Windows.Forms.NotifyIcon(this.components);
            // 
            // MaintenanceNotif
            // 
            this.MaintenanceNotif.Text = "notifyIcon1";
            this.MaintenanceNotif.Visible = true;
            // 
            // ScheduleMaintenance
            // 
            this.ServiceName = "Schedule maintenance";

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MaintenanceNotif;
    }
}
