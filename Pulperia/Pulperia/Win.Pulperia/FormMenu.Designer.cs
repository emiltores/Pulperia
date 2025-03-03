namespace Win.Pulperia
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            pulperiaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            venderToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reportesDeProductosToolStripMenuItem = new ToolStripMenuItem();
            reporteDeClientesToolStripMenuItem = new ToolStripMenuItem();
            reporteDiarioToolStripMenuItem = new ToolStripMenuItem();
            reporteSemanalToolStripMenuItem = new ToolStripMenuItem();
            reporteMensualToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pulperiaToolStripMenuItem, reportesToolStripMenuItem, seguridadToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pulperiaToolStripMenuItem
            // 
            pulperiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, clientesToolStripMenuItem, venderToolStripMenuItem });
            pulperiaToolStripMenuItem.Name = "pulperiaToolStripMenuItem";
            pulperiaToolStripMenuItem.Size = new Size(62, 20);
            pulperiaToolStripMenuItem.Text = "Pulperia";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(128, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(128, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // venderToolStripMenuItem
            // 
            venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            venderToolStripMenuItem.Size = new Size(128, 22);
            venderToolStripMenuItem.Text = "Vender";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesDeProductosToolStripMenuItem, reporteDeClientesToolStripMenuItem, reporteDiarioToolStripMenuItem, reporteSemanalToolStripMenuItem, reporteMensualToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeProductosToolStripMenuItem
            // 
            reportesDeProductosToolStripMenuItem.Name = "reportesDeProductosToolStripMenuItem";
            reportesDeProductosToolStripMenuItem.Size = new Size(193, 22);
            reportesDeProductosToolStripMenuItem.Text = "Reportes de Productos";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            reporteDeClientesToolStripMenuItem.Size = new Size(193, 22);
            reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // reporteDiarioToolStripMenuItem
            // 
            reporteDiarioToolStripMenuItem.Name = "reporteDiarioToolStripMenuItem";
            reporteDiarioToolStripMenuItem.Size = new Size(193, 22);
            reporteDiarioToolStripMenuItem.Text = "Reporte Diario";
            // 
            // reporteSemanalToolStripMenuItem
            // 
            reporteSemanalToolStripMenuItem.Name = "reporteSemanalToolStripMenuItem";
            reporteSemanalToolStripMenuItem.Size = new Size(193, 22);
            reporteSemanalToolStripMenuItem.Text = "Reporte Semanal";
            // 
            // reporteMensualToolStripMenuItem
            // 
            reporteMensualToolStripMenuItem.Name = "reporteMensualToolStripMenuItem";
            reporteMensualToolStripMenuItem.Size = new Size(193, 22);
            reporteMensualToolStripMenuItem.Text = "Reporte Mensual";
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(72, 20);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(180, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pulperiaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem venderToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reportesDeProductosToolStripMenuItem;
        private ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private ToolStripMenuItem reporteDiarioToolStripMenuItem;
        private ToolStripMenuItem reporteSemanalToolStripMenuItem;
        private ToolStripMenuItem reporteMensualToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}