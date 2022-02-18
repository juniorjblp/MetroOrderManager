namespace MetroOrderManager
{
    partial class FrmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
            this.PnlContent = new Bunifu.UI.WinForms.BunifuPanel();
            this.PnlLeft = new Bunifu.UI.WinForms.BunifuPanel();
            this.BtnOrders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblMenu = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.PnlBotton = new Bunifu.UI.WinForms.BunifuPanel();
            this.PnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.PbIndicator = new Bunifu.UI.WinForms.BunifuPanel();
            this.BtnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContent
            // 
            this.PnlContent.BackgroundColor = System.Drawing.Color.Transparent;
            this.PnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlContent.BackgroundImage")));
            this.PnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlContent.BorderColor = System.Drawing.Color.Transparent;
            this.PnlContent.BorderRadius = 3;
            this.PnlContent.BorderThickness = 1;
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(200, 28);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.ShowBorders = true;
            this.PnlContent.Size = new System.Drawing.Size(1083, 747);
            this.PnlContent.TabIndex = 3;
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PnlLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLeft.BackgroundImage")));
            this.PnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlLeft.BorderRadius = 0;
            this.PnlLeft.BorderThickness = 0;
            this.PnlLeft.Controls.Add(this.BtnDashboard);
            this.PnlLeft.Controls.Add(this.PbIndicator);
            this.PnlLeft.Controls.Add(this.BtnOrders);
            this.PnlLeft.Controls.Add(this.BtnProducts);
            this.PnlLeft.Controls.Add(this.BtnCustomers);
            this.PnlLeft.Controls.Add(this.BtnMenu);
            this.PnlLeft.Controls.Add(this.LblMenu);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 28);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.ShowBorders = true;
            this.PnlLeft.Size = new System.Drawing.Size(200, 747);
            this.PnlLeft.TabIndex = 2;
            // 
            // BtnOrders
            // 
            this.BtnOrders.Activecolor = System.Drawing.Color.Transparent;
            this.BtnOrders.BackColor = System.Drawing.Color.Transparent;
            this.BtnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOrders.BorderRadius = 0;
            this.BtnOrders.ButtonText = "   Vendas";
            this.BtnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrders.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOrders.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOrders.Iconimage = global::MetroOrderManager.Properties.Resources.icons8_caixa_registradora_50;
            this.BtnOrders.Iconimage_right = null;
            this.BtnOrders.Iconimage_right_Selected = null;
            this.BtnOrders.Iconimage_Selected = null;
            this.BtnOrders.IconMarginLeft = 0;
            this.BtnOrders.IconMarginRight = 0;
            this.BtnOrders.IconRightVisible = true;
            this.BtnOrders.IconRightZoom = 0D;
            this.BtnOrders.IconVisible = true;
            this.BtnOrders.IconZoom = 90D;
            this.BtnOrders.IsTab = false;
            this.BtnOrders.Location = new System.Drawing.Point(6, 301);
            this.BtnOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnOrders.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnOrders.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnOrders.selected = false;
            this.BtnOrders.Size = new System.Drawing.Size(172, 47);
            this.BtnOrders.TabIndex = 10;
            this.BtnOrders.Text = "   Vendas";
            this.BtnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrders.Textcolor = System.Drawing.Color.White;
            this.BtnOrders.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Activecolor = System.Drawing.Color.Transparent;
            this.BtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.BtnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProducts.BorderRadius = 0;
            this.BtnProducts.ButtonText = "   Produtos";
            this.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProducts.DisabledColor = System.Drawing.Color.Gray;
            this.BtnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnProducts.Iconimage = global::MetroOrderManager.Properties.Resources.icons8_etiqueta_de_preço_50;
            this.BtnProducts.Iconimage_right = null;
            this.BtnProducts.Iconimage_right_Selected = null;
            this.BtnProducts.Iconimage_Selected = null;
            this.BtnProducts.IconMarginLeft = 0;
            this.BtnProducts.IconMarginRight = 0;
            this.BtnProducts.IconRightVisible = true;
            this.BtnProducts.IconRightZoom = 0D;
            this.BtnProducts.IconVisible = true;
            this.BtnProducts.IconZoom = 90D;
            this.BtnProducts.IsTab = false;
            this.BtnProducts.Location = new System.Drawing.Point(6, 228);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnProducts.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnProducts.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnProducts.selected = false;
            this.BtnProducts.Size = new System.Drawing.Size(172, 47);
            this.BtnProducts.TabIndex = 9;
            this.BtnProducts.Text = "   Produtos";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.Textcolor = System.Drawing.Color.White;
            this.BtnProducts.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Activecolor = System.Drawing.Color.Transparent;
            this.BtnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCustomers.BorderRadius = 0;
            this.BtnCustomers.ButtonText = "   Clientes";
            this.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomers.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCustomers.Iconimage = global::MetroOrderManager.Properties.Resources.icons8_empresa_cliente_50;
            this.BtnCustomers.Iconimage_right = null;
            this.BtnCustomers.Iconimage_right_Selected = null;
            this.BtnCustomers.Iconimage_Selected = null;
            this.BtnCustomers.IconMarginLeft = 0;
            this.BtnCustomers.IconMarginRight = 0;
            this.BtnCustomers.IconRightVisible = true;
            this.BtnCustomers.IconRightZoom = 0D;
            this.BtnCustomers.IconVisible = true;
            this.BtnCustomers.IconZoom = 90D;
            this.BtnCustomers.IsTab = false;
            this.BtnCustomers.Location = new System.Drawing.Point(6, 161);
            this.BtnCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnCustomers.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnCustomers.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCustomers.selected = false;
            this.BtnCustomers.Size = new System.Drawing.Size(172, 47);
            this.BtnCustomers.TabIndex = 8;
            this.BtnCustomers.Text = "   Clientes";
            this.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.Textcolor = System.Drawing.Color.White;
            this.BtnCustomers.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // LblMenu
            // 
            this.LblMenu.AllowParentOverrides = false;
            this.LblMenu.AutoEllipsis = false;
            this.LblMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblMenu.CursorType = System.Windows.Forms.Cursors.Default;
            this.LblMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.LblMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.LblMenu.Location = new System.Drawing.Point(67, 14);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMenu.Size = new System.Drawing.Size(50, 25);
            this.LblMenu.TabIndex = 7;
            this.LblMenu.Text = "Menu";
            this.LblMenu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblMenu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Image = global::MetroOrderManager.Properties.Resources.icons8_cardápio_50;
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(150, 6);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(40, 40);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PnlBotton
            // 
            this.PnlBotton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlBotton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlBotton.BackgroundImage")));
            this.PnlBotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlBotton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlBotton.BorderRadius = 0;
            this.PnlBotton.BorderThickness = 0;
            this.PnlBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotton.Location = new System.Drawing.Point(0, 775);
            this.PnlBotton.Name = "PnlBotton";
            this.PnlBotton.ShowBorders = true;
            this.PnlBotton.Size = new System.Drawing.Size(1283, 15);
            this.PnlBotton.TabIndex = 1;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlHeader.BackgroundImage")));
            this.PnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlHeader.BorderRadius = 0;
            this.PnlHeader.BorderThickness = 0;
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.ShowBorders = true;
            this.PnlHeader.Size = new System.Drawing.Size(1283, 28);
            this.PnlHeader.TabIndex = 0;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::MetroOrderManager.Properties.Resources.icons8_fechar_janela_64;
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(1255, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PbIndicator
            // 
            this.PbIndicator.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.PbIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbIndicator.BackgroundImage")));
            this.PbIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbIndicator.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PbIndicator.BorderRadius = 0;
            this.PbIndicator.BorderThickness = 0;
            this.PbIndicator.Location = new System.Drawing.Point(1, 86);
            this.PbIndicator.Name = "PbIndicator";
            this.PbIndicator.ShowBorders = true;
            this.PbIndicator.Size = new System.Drawing.Size(5, 47);
            this.PbIndicator.TabIndex = 0;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Activecolor = System.Drawing.Color.Transparent;
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDashboard.BorderRadius = 0;
            this.BtnDashboard.ButtonText = "   Dashboard";
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDashboard.Iconimage = global::MetroOrderManager.Properties.Resources.icons8_dados_de_saúde_50;
            this.BtnDashboard.Iconimage_right = null;
            this.BtnDashboard.Iconimage_right_Selected = null;
            this.BtnDashboard.Iconimage_Selected = null;
            this.BtnDashboard.IconMarginLeft = 0;
            this.BtnDashboard.IconMarginRight = 0;
            this.BtnDashboard.IconRightVisible = true;
            this.BtnDashboard.IconRightZoom = 0D;
            this.BtnDashboard.IconVisible = true;
            this.BtnDashboard.IconZoom = 90D;
            this.BtnDashboard.IsTab = false;
            this.BtnDashboard.Location = new System.Drawing.Point(6, 86);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnDashboard.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnDashboard.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnDashboard.selected = false;
            this.BtnDashboard.Size = new System.Drawing.Size(172, 47);
            this.BtnDashboard.TabIndex = 11;
            this.BtnDashboard.Text = "   Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Textcolor = System.Drawing.Color.White;
            this.BtnDashboard.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 790);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlLeft);
            this.Controls.Add(this.PnlBotton);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMainScreen_Load);
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel PnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private Bunifu.UI.WinForms.BunifuPanel PnlBotton;
        private Bunifu.UI.WinForms.BunifuPanel PnlLeft;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private Bunifu.UI.WinForms.BunifuLabel LblMenu;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCustomers;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOrders;
        private Bunifu.Framework.UI.BunifuFlatButton BtnProducts;
        private Bunifu.UI.WinForms.BunifuPanel PnlContent;
        private Bunifu.UI.WinForms.BunifuPanel PbIndicator;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDashboard;
    }
}

