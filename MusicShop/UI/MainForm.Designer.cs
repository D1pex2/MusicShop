namespace MusicShop.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentTabControl = new System.Windows.Forms.TabControl();
            this.catalogTabPage = new System.Windows.Forms.TabPage();
            this.cartTabPage = new System.Windows.Forms.TabPage();
            this.customerOrdersTabPage = new System.Windows.Forms.TabPage();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.manufacturersTabPage = new System.Windows.Forms.TabPage();
            this.categoriesTabPage = new System.Windows.Forms.TabPage();
            this.statisticTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.guestTabPage = new System.Windows.Forms.TabPage();
            this.guestCatalogBlinkButton = new MusicShop.BlinkButton();
            this.customerTabPage = new System.Windows.Forms.TabPage();
            this.customerProfileBlinkButton = new MusicShop.BlinkButton();
            this.customerOrderBlinkButton = new MusicShop.BlinkButton();
            this.customerCartBlinkButton = new MusicShop.BlinkButton();
            this.customerCatalogBlinkButton = new MusicShop.BlinkButton();
            this.managerTabPage = new System.Windows.Forms.TabPage();
            this.managerStatisticBlinkButton = new MusicShop.BlinkButton();
            this.managerOrderBlinkButton = new MusicShop.BlinkButton();
            this.managerCategoryBlinkButton = new MusicShop.BlinkButton();
            this.managerManufacturerBlinkButton = new MusicShop.BlinkButton();
            this.managerCatalogBlinkButton = new MusicShop.BlinkButton();
            this.adminTabPage = new System.Windows.Forms.TabPage();
            this.connectionBlinkButton = new MusicShop.BlinkButton();
            this.usersBlinkButton = new MusicShop.BlinkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.shopNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.contentTabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.guestTabPage.SuspendLayout();
            this.customerTabPage.SuspendLayout();
            this.managerTabPage.SuspendLayout();
            this.adminTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTabControl
            // 
            this.contentTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.contentTabControl.Controls.Add(this.catalogTabPage);
            this.contentTabControl.Controls.Add(this.cartTabPage);
            this.contentTabControl.Controls.Add(this.customerOrdersTabPage);
            this.contentTabControl.Controls.Add(this.ordersTabPage);
            this.contentTabControl.Controls.Add(this.manufacturersTabPage);
            this.contentTabControl.Controls.Add(this.categoriesTabPage);
            this.contentTabControl.Controls.Add(this.statisticTabPage);
            this.contentTabControl.Controls.Add(this.usersTabPage);
            this.contentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabControl.Location = new System.Drawing.Point(0, 0);
            this.contentTabControl.Name = "contentTabControl";
            this.contentTabControl.Padding = new System.Drawing.Point(0, 0);
            this.contentTabControl.SelectedIndex = 0;
            this.contentTabControl.Size = new System.Drawing.Size(853, 561);
            this.contentTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contentTabControl.TabIndex = 22;
            this.contentTabControl.TabStop = false;
            this.contentTabControl.SelectedIndexChanged += new System.EventHandler(this.ContentTabControl_SelectedIndexChanged);
            // 
            // catalogTabPage
            // 
            this.catalogTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.catalogTabPage.Location = new System.Drawing.Point(4, 25);
            this.catalogTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.catalogTabPage.Name = "catalogTabPage";
            this.catalogTabPage.Size = new System.Drawing.Size(845, 532);
            this.catalogTabPage.TabIndex = 0;
            this.catalogTabPage.Text = "Каталог";
            // 
            // cartTabPage
            // 
            this.cartTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cartTabPage.Location = new System.Drawing.Point(4, 25);
            this.cartTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.cartTabPage.Name = "cartTabPage";
            this.cartTabPage.Size = new System.Drawing.Size(845, 532);
            this.cartTabPage.TabIndex = 1;
            this.cartTabPage.Text = "Корзина";
            // 
            // customerOrdersTabPage
            // 
            this.customerOrdersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customerOrdersTabPage.Location = new System.Drawing.Point(4, 25);
            this.customerOrdersTabPage.Name = "customerOrdersTabPage";
            this.customerOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerOrdersTabPage.Size = new System.Drawing.Size(845, 532);
            this.customerOrdersTabPage.TabIndex = 2;
            this.customerOrdersTabPage.Text = "Мои заказы";
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ordersTabPage.Location = new System.Drawing.Point(4, 25);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Size = new System.Drawing.Size(845, 532);
            this.ordersTabPage.TabIndex = 3;
            this.ordersTabPage.Text = "Заказы";
            // 
            // manufacturersTabPage
            // 
            this.manufacturersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.manufacturersTabPage.Location = new System.Drawing.Point(4, 25);
            this.manufacturersTabPage.Name = "manufacturersTabPage";
            this.manufacturersTabPage.Size = new System.Drawing.Size(845, 532);
            this.manufacturersTabPage.TabIndex = 4;
            this.manufacturersTabPage.Text = "Производители";
            // 
            // categoriesTabPage
            // 
            this.categoriesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.categoriesTabPage.Location = new System.Drawing.Point(4, 25);
            this.categoriesTabPage.Name = "categoriesTabPage";
            this.categoriesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTabPage.Size = new System.Drawing.Size(845, 532);
            this.categoriesTabPage.TabIndex = 5;
            this.categoriesTabPage.Text = "Категории";
            // 
            // statisticTabPage
            // 
            this.statisticTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.statisticTabPage.Location = new System.Drawing.Point(4, 25);
            this.statisticTabPage.Name = "statisticTabPage";
            this.statisticTabPage.Size = new System.Drawing.Size(845, 532);
            this.statisticTabPage.TabIndex = 6;
            this.statisticTabPage.Text = "Продажи товаров";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuTabControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoutLabel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.shopNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 561);
            this.panel1.TabIndex = 23;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.menuTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.menuTabControl.Controls.Add(this.guestTabPage);
            this.menuTabControl.Controls.Add(this.customerTabPage);
            this.menuTabControl.Controls.Add(this.managerTabPage);
            this.menuTabControl.Controls.Add(this.adminTabPage);
            this.menuTabControl.Location = new System.Drawing.Point(-7, 35);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(174, 468);
            this.menuTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuTabControl.TabIndex = 0;
            this.menuTabControl.TabStop = false;
            // 
            // guestTabPage
            // 
            this.guestTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guestTabPage.Controls.Add(this.guestCatalogBlinkButton);
            this.guestTabPage.Location = new System.Drawing.Point(4, 25);
            this.guestTabPage.Name = "guestTabPage";
            this.guestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.guestTabPage.Size = new System.Drawing.Size(166, 439);
            this.guestTabPage.TabIndex = 0;
            this.guestTabPage.Text = "Гость";
            // 
            // guestCatalogBlinkButton
            // 
            this.guestCatalogBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.guestCatalogBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.guestCatalogBlinkButton.FlatAppearance.BorderSize = 0;
            this.guestCatalogBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestCatalogBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestCatalogBlinkButton.Image = global::MusicShop.Properties.Resources.catalog;
            this.guestCatalogBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guestCatalogBlinkButton.Location = new System.Drawing.Point(0, 0);
            this.guestCatalogBlinkButton.Name = "guestCatalogBlinkButton";
            this.guestCatalogBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.guestCatalogBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.guestCatalogBlinkButton.TabIndex = 2;
            this.guestCatalogBlinkButton.Text = "Каталог";
            this.guestCatalogBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guestCatalogBlinkButton.UseVisualStyleBackColor = false;
            this.guestCatalogBlinkButton.Click += new System.EventHandler(this.CatalogBlinkButton_Click);
            // 
            // customerTabPage
            // 
            this.customerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customerTabPage.Controls.Add(this.customerProfileBlinkButton);
            this.customerTabPage.Controls.Add(this.customerOrderBlinkButton);
            this.customerTabPage.Controls.Add(this.customerCartBlinkButton);
            this.customerTabPage.Controls.Add(this.customerCatalogBlinkButton);
            this.customerTabPage.Location = new System.Drawing.Point(4, 25);
            this.customerTabPage.Name = "customerTabPage";
            this.customerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerTabPage.Size = new System.Drawing.Size(166, 439);
            this.customerTabPage.TabIndex = 1;
            this.customerTabPage.Text = "Покупатель";
            // 
            // customerProfileBlinkButton
            // 
            this.customerProfileBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.customerProfileBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.customerProfileBlinkButton.FlatAppearance.BorderSize = 0;
            this.customerProfileBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerProfileBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerProfileBlinkButton.Image = global::MusicShop.Properties.Resources.user;
            this.customerProfileBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerProfileBlinkButton.Location = new System.Drawing.Point(0, 123);
            this.customerProfileBlinkButton.Name = "customerProfileBlinkButton";
            this.customerProfileBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.customerProfileBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.customerProfileBlinkButton.TabIndex = 6;
            this.customerProfileBlinkButton.Text = "Мой профиль";
            this.customerProfileBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerProfileBlinkButton.UseVisualStyleBackColor = false;
            this.customerProfileBlinkButton.Click += new System.EventHandler(this.CustomerProfileBlinkButton_Click);
            // 
            // customerOrderBlinkButton
            // 
            this.customerOrderBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.customerOrderBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.customerOrderBlinkButton.FlatAppearance.BorderSize = 0;
            this.customerOrderBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerOrderBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrderBlinkButton.Image = global::MusicShop.Properties.Resources.clipboard;
            this.customerOrderBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerOrderBlinkButton.Location = new System.Drawing.Point(0, 41);
            this.customerOrderBlinkButton.Name = "customerOrderBlinkButton";
            this.customerOrderBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.customerOrderBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.customerOrderBlinkButton.TabIndex = 4;
            this.customerOrderBlinkButton.Text = "Мои заказы";
            this.customerOrderBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerOrderBlinkButton.UseVisualStyleBackColor = false;
            this.customerOrderBlinkButton.Click += new System.EventHandler(this.CustomerOrderBlinkButton_Click);
            // 
            // customerCartBlinkButton
            // 
            this.customerCartBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.customerCartBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.customerCartBlinkButton.FlatAppearance.BorderSize = 0;
            this.customerCartBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerCartBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerCartBlinkButton.Image = global::MusicShop.Properties.Resources.cart;
            this.customerCartBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerCartBlinkButton.Location = new System.Drawing.Point(0, 82);
            this.customerCartBlinkButton.Name = "customerCartBlinkButton";
            this.customerCartBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.customerCartBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.customerCartBlinkButton.TabIndex = 5;
            this.customerCartBlinkButton.Text = "Корзина";
            this.customerCartBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerCartBlinkButton.UseVisualStyleBackColor = false;
            this.customerCartBlinkButton.Click += new System.EventHandler(this.CartBlinkButton_Click);
            // 
            // customerCatalogBlinkButton
            // 
            this.customerCatalogBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.customerCatalogBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.customerCatalogBlinkButton.FlatAppearance.BorderSize = 0;
            this.customerCatalogBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerCatalogBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerCatalogBlinkButton.Image = global::MusicShop.Properties.Resources.catalog;
            this.customerCatalogBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerCatalogBlinkButton.Location = new System.Drawing.Point(0, 0);
            this.customerCatalogBlinkButton.Name = "customerCatalogBlinkButton";
            this.customerCatalogBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.customerCatalogBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.customerCatalogBlinkButton.TabIndex = 3;
            this.customerCatalogBlinkButton.Text = "Каталог";
            this.customerCatalogBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerCatalogBlinkButton.UseVisualStyleBackColor = false;
            this.customerCatalogBlinkButton.Click += new System.EventHandler(this.CatalogBlinkButton_Click);
            // 
            // managerTabPage
            // 
            this.managerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.managerTabPage.Controls.Add(this.managerStatisticBlinkButton);
            this.managerTabPage.Controls.Add(this.managerOrderBlinkButton);
            this.managerTabPage.Controls.Add(this.managerCategoryBlinkButton);
            this.managerTabPage.Controls.Add(this.managerManufacturerBlinkButton);
            this.managerTabPage.Controls.Add(this.managerCatalogBlinkButton);
            this.managerTabPage.Location = new System.Drawing.Point(4, 25);
            this.managerTabPage.Name = "managerTabPage";
            this.managerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.managerTabPage.Size = new System.Drawing.Size(166, 439);
            this.managerTabPage.TabIndex = 2;
            this.managerTabPage.Text = "Менеджер";
            // 
            // managerStatisticBlinkButton
            // 
            this.managerStatisticBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.managerStatisticBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.managerStatisticBlinkButton.FlatAppearance.BorderSize = 0;
            this.managerStatisticBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerStatisticBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerStatisticBlinkButton.Image = global::MusicShop.Properties.Resources.bar_chart;
            this.managerStatisticBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerStatisticBlinkButton.Location = new System.Drawing.Point(0, 164);
            this.managerStatisticBlinkButton.Name = "managerStatisticBlinkButton";
            this.managerStatisticBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.managerStatisticBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.managerStatisticBlinkButton.TabIndex = 10;
            this.managerStatisticBlinkButton.Text = "Статистика";
            this.managerStatisticBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerStatisticBlinkButton.UseVisualStyleBackColor = false;
            this.managerStatisticBlinkButton.Click += new System.EventHandler(this.ManagerStatisticBlinkButton_Click);
            // 
            // managerOrderBlinkButton
            // 
            this.managerOrderBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.managerOrderBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.managerOrderBlinkButton.FlatAppearance.BorderSize = 0;
            this.managerOrderBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerOrderBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerOrderBlinkButton.Image = global::MusicShop.Properties.Resources.clipboard;
            this.managerOrderBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerOrderBlinkButton.Location = new System.Drawing.Point(0, 123);
            this.managerOrderBlinkButton.Name = "managerOrderBlinkButton";
            this.managerOrderBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.managerOrderBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.managerOrderBlinkButton.TabIndex = 9;
            this.managerOrderBlinkButton.Text = "Заказы";
            this.managerOrderBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerOrderBlinkButton.UseVisualStyleBackColor = false;
            this.managerOrderBlinkButton.Click += new System.EventHandler(this.ManagerOrderBlinkButton_Click);
            // 
            // managerCategoryBlinkButton
            // 
            this.managerCategoryBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.managerCategoryBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.managerCategoryBlinkButton.FlatAppearance.BorderSize = 0;
            this.managerCategoryBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerCategoryBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerCategoryBlinkButton.Image = global::MusicShop.Properties.Resources.category;
            this.managerCategoryBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerCategoryBlinkButton.Location = new System.Drawing.Point(0, 82);
            this.managerCategoryBlinkButton.Name = "managerCategoryBlinkButton";
            this.managerCategoryBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.managerCategoryBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.managerCategoryBlinkButton.TabIndex = 8;
            this.managerCategoryBlinkButton.Text = "Категории";
            this.managerCategoryBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerCategoryBlinkButton.UseVisualStyleBackColor = false;
            this.managerCategoryBlinkButton.Click += new System.EventHandler(this.ManagerCategoryBlinkButton_Click);
            // 
            // managerManufacturerBlinkButton
            // 
            this.managerManufacturerBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.managerManufacturerBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.managerManufacturerBlinkButton.FlatAppearance.BorderSize = 0;
            this.managerManufacturerBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerManufacturerBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerManufacturerBlinkButton.Image = global::MusicShop.Properties.Resources.factory;
            this.managerManufacturerBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerManufacturerBlinkButton.Location = new System.Drawing.Point(0, 41);
            this.managerManufacturerBlinkButton.Name = "managerManufacturerBlinkButton";
            this.managerManufacturerBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.managerManufacturerBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.managerManufacturerBlinkButton.TabIndex = 7;
            this.managerManufacturerBlinkButton.Text = "Производители";
            this.managerManufacturerBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerManufacturerBlinkButton.UseVisualStyleBackColor = false;
            this.managerManufacturerBlinkButton.Click += new System.EventHandler(this.ManagerManufacturerBlinkButton_Click);
            // 
            // managerCatalogBlinkButton
            // 
            this.managerCatalogBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.managerCatalogBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.managerCatalogBlinkButton.FlatAppearance.BorderSize = 0;
            this.managerCatalogBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerCatalogBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerCatalogBlinkButton.Image = global::MusicShop.Properties.Resources.catalog;
            this.managerCatalogBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerCatalogBlinkButton.Location = new System.Drawing.Point(0, 0);
            this.managerCatalogBlinkButton.Name = "managerCatalogBlinkButton";
            this.managerCatalogBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.managerCatalogBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.managerCatalogBlinkButton.TabIndex = 6;
            this.managerCatalogBlinkButton.Text = "Каталог";
            this.managerCatalogBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerCatalogBlinkButton.UseVisualStyleBackColor = false;
            this.managerCatalogBlinkButton.Click += new System.EventHandler(this.CatalogBlinkButton_Click);
            // 
            // adminTabPage
            // 
            this.adminTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.adminTabPage.Controls.Add(this.connectionBlinkButton);
            this.adminTabPage.Controls.Add(this.usersBlinkButton);
            this.adminTabPage.Location = new System.Drawing.Point(4, 25);
            this.adminTabPage.Name = "adminTabPage";
            this.adminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminTabPage.Size = new System.Drawing.Size(166, 439);
            this.adminTabPage.TabIndex = 3;
            this.adminTabPage.Text = "Администратор";
            // 
            // connectionBlinkButton
            // 
            this.connectionBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.connectionBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.connectionBlinkButton.FlatAppearance.BorderSize = 0;
            this.connectionBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionBlinkButton.Image = ((System.Drawing.Image)(resources.GetObject("connectionBlinkButton.Image")));
            this.connectionBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.connectionBlinkButton.Location = new System.Drawing.Point(0, 41);
            this.connectionBlinkButton.Name = "connectionBlinkButton";
            this.connectionBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.connectionBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.connectionBlinkButton.TabIndex = 8;
            this.connectionBlinkButton.Text = "Подключение";
            this.connectionBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectionBlinkButton.UseVisualStyleBackColor = false;
            this.connectionBlinkButton.Click += new System.EventHandler(this.ConnectionBlinkButton_Click);
            // 
            // usersBlinkButton
            // 
            this.usersBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.usersBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.usersBlinkButton.FlatAppearance.BorderSize = 0;
            this.usersBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBlinkButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersBlinkButton.Image = global::MusicShop.Properties.Resources.users;
            this.usersBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usersBlinkButton.Location = new System.Drawing.Point(0, 0);
            this.usersBlinkButton.Name = "usersBlinkButton";
            this.usersBlinkButton.Padding = new System.Windows.Forms.Padding(3);
            this.usersBlinkButton.Size = new System.Drawing.Size(158, 40);
            this.usersBlinkButton.TabIndex = 7;
            this.usersBlinkButton.Text = "Пользователи";
            this.usersBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBlinkButton.UseVisualStyleBackColor = false;
            this.usersBlinkButton.Click += new System.EventHandler(this.UsersBlinkButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Вы вошли как:";
            // 
            // logoutLabel
            // 
            this.logoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoutLabel.Location = new System.Drawing.Point(11, 539);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(135, 13);
            this.logoutLabel.TabIndex = 0;
            this.logoutLabel.Text = "Выйти из учётной записи";
            this.logoutLabel.Visible = false;
            this.logoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginLabel.Location = new System.Drawing.Point(11, 539);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(128, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Войти в учётную запись";
            this.loginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameLabel.Location = new System.Drawing.Point(14, 521);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(129, 15);
            this.usernameLabel.TabIndex = 25;
            this.usernameLabel.Text = "username";
            // 
            // shopNameLabel
            // 
            this.shopNameLabel.AutoSize = true;
            this.shopNameLabel.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopNameLabel.Location = new System.Drawing.Point(12, 6);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(128, 24);
            this.shopNameLabel.TabIndex = 23;
            this.shopNameLabel.Text = "Music Shop";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contentTabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 561);
            this.panel2.TabIndex = 24;
            // 
            // usersTabPage
            // 
            this.usersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usersTabPage.Location = new System.Drawing.Point(4, 25);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Size = new System.Drawing.Size(845, 532);
            this.usersTabPage.TabIndex = 7;
            this.usersTabPage.Text = "Пользователи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainForm";
            this.Text = "Каталог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contentTabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuTabControl.ResumeLayout(false);
            this.guestTabPage.ResumeLayout(false);
            this.customerTabPage.ResumeLayout(false);
            this.managerTabPage.ResumeLayout(false);
            this.adminTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl contentTabControl;
        private System.Windows.Forms.TabPage catalogTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label shopNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage cartTabPage;
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage guestTabPage;
        private BlinkButton guestCatalogBlinkButton;
        private System.Windows.Forms.TabPage customerTabPage;
        private BlinkButton customerCartBlinkButton;
        private BlinkButton customerCatalogBlinkButton;
        private System.Windows.Forms.TabPage managerTabPage;
        private BlinkButton managerCatalogBlinkButton;
        private BlinkButton managerCategoryBlinkButton;
        private BlinkButton managerManufacturerBlinkButton;
        private BlinkButton managerOrderBlinkButton;
        private BlinkButton customerOrderBlinkButton;
        private BlinkButton managerStatisticBlinkButton;
        private System.Windows.Forms.TabPage customerOrdersTabPage;
        private System.Windows.Forms.TabPage ordersTabPage;
        private System.Windows.Forms.TabPage manufacturersTabPage;
        private BlinkButton customerProfileBlinkButton;
        private System.Windows.Forms.TabPage categoriesTabPage;
        private System.Windows.Forms.TabPage statisticTabPage;
        private System.Windows.Forms.TabPage adminTabPage;
        private BlinkButton usersBlinkButton;
        private BlinkButton connectionBlinkButton;
        private System.Windows.Forms.TabPage usersTabPage;
    }
}