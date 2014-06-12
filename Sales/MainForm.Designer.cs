namespace Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tstripCustomerList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsripGetSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstripInvoices = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdummy1 = new System.Windows.Forms.ToolStripLabel();
            this.tsdummy2 = new System.Windows.Forms.ToolStripLabel();
            this.tsdummy3 = new System.Windows.Forms.ToolStripLabel();
            this.tsdummy4 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnGetinfo = new System.Windows.Forms.Button();
            this.datagridSearch = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDummy2 = new System.Windows.Forms.Label();
            this.lblDummy1 = new System.Windows.Forms.Label();
            this.txtSearchByCustomer = new System.Windows.Forms.TextBox();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblDummyInsert3 = new System.Windows.Forms.Label();
            this.lblDummyInsert2 = new System.Windows.Forms.Label();
            this.lblDummyInsert1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.datagridMain = new System.Windows.Forms.DataGridView();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSearch)).BeginInit();
            this.groupBoxCustomer.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportChatToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // supportChatToolStripMenuItem
            // 
            this.supportChatToolStripMenuItem.Name = "supportChatToolStripMenuItem";
            this.supportChatToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.supportChatToolStripMenuItem.Text = "Support Chat";
            this.supportChatToolStripMenuItem.Click += new System.EventHandler(this.supportChatToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newOrderToolStripMenuItem.Text = "Add new order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.YellowGreen;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripCustomerList,
            this.toolStripSeparator1,
            this.tsripGetSales,
            this.toolStripSeparator2,
            this.tstripInvoices,
            this.toolStripSeparator3,
            this.tsdummy1,
            this.tsdummy2,
            this.tsdummy3,
            this.tsdummy4});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(1354, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tstripCustomerList
            // 
            this.tstripCustomerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstripCustomerList.Image = ((System.Drawing.Image)(resources.GetObject("tstripCustomerList.Image")));
            this.tstripCustomerList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripCustomerList.Name = "tstripCustomerList";
            this.tstripCustomerList.Size = new System.Drawing.Size(84, 22);
            this.tstripCustomerList.Text = "Customer List";
            this.tstripCustomerList.Click += new System.EventHandler(this.tstripCustomerList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsripGetSales
            // 
            this.tsripGetSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsripGetSales.Image = ((System.Drawing.Image)(resources.GetObject("tsripGetSales.Image")));
            this.tsripGetSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsripGetSales.Name = "tsripGetSales";
            this.tsripGetSales.Size = new System.Drawing.Size(75, 22);
            this.tsripGetSales.Text = "Get All Sales";
            this.tsripGetSales.Click += new System.EventHandler(this.tsripGetSales_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tstripInvoices
            // 
            this.tstripInvoices.CheckOnClick = true;
            this.tstripInvoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstripInvoices.Image = ((System.Drawing.Image)(resources.GetObject("tstripInvoices.Image")));
            this.tstripInvoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripInvoices.Name = "tstripInvoices";
            this.tstripInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tstripInvoices.RightToLeftAutoMirrorImage = true;
            this.tstripInvoices.Size = new System.Drawing.Size(92, 22);
            this.tstripInvoices.Text = "Get All Invoices";
            this.tstripInvoices.Click += new System.EventHandler(this.tstripInvoices_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsdummy1
            // 
            this.tsdummy1.Name = "tsdummy1";
            this.tsdummy1.Size = new System.Drawing.Size(0, 22);
            // 
            // tsdummy2
            // 
            this.tsdummy2.Name = "tsdummy2";
            this.tsdummy2.Size = new System.Drawing.Size(0, 22);
            // 
            // tsdummy3
            // 
            this.tsdummy3.Name = "tsdummy3";
            this.tsdummy3.Size = new System.Drawing.Size(0, 22);
            // 
            // tsdummy4
            // 
            this.tsdummy4.Name = "tsdummy4";
            this.tsdummy4.Size = new System.Drawing.Size(0, 22);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlSearch.Controls.Add(this.btnGetinfo);
            this.pnlSearch.Controls.Add(this.datagridSearch);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblDummy2);
            this.pnlSearch.Controls.Add(this.lblDummy1);
            this.pnlSearch.Controls.Add(this.txtSearchByCustomer);
            this.pnlSearch.Controls.Add(this.txtSearchOrder);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearch.Location = new System.Drawing.Point(0, 49);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(307, 662);
            this.pnlSearch.TabIndex = 3;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
            // 
            // btnGetinfo
            // 
            this.btnGetinfo.Location = new System.Drawing.Point(77, 140);
            this.btnGetinfo.Name = "btnGetinfo";
            this.btnGetinfo.Size = new System.Drawing.Size(89, 23);
            this.btnGetinfo.TabIndex = 19;
            this.btnGetinfo.Text = "Get more info";
            this.btnGetinfo.UseVisualStyleBackColor = true;
            this.btnGetinfo.Click += new System.EventHandler(this.btnGetinfo_Click);
            // 
            // datagridSearch
            // 
            this.datagridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSearch.Location = new System.Drawing.Point(12, 196);
            this.datagridSearch.Name = "datagridSearch";
            this.datagridSearch.ReadOnly = true;
            this.datagridSearch.RowHeadersVisible = false;
            this.datagridSearch.Size = new System.Drawing.Size(275, 423);
            this.datagridSearch.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(11, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(183, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDummy2
            // 
            this.lblDummy2.AutoSize = true;
            this.lblDummy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDummy2.Location = new System.Drawing.Point(11, 113);
            this.lblDummy2.Name = "lblDummy2";
            this.lblDummy2.Size = new System.Drawing.Size(60, 15);
            this.lblDummy2.TabIndex = 14;
            this.lblDummy2.Text = "Customer";
            // 
            // lblDummy1
            // 
            this.lblDummy1.AutoSize = true;
            this.lblDummy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDummy1.Location = new System.Drawing.Point(11, 83);
            this.lblDummy1.Name = "lblDummy1";
            this.lblDummy1.Size = new System.Drawing.Size(48, 15);
            this.lblDummy1.TabIndex = 13;
            this.lblDummy1.Text = "Order #";
            // 
            // txtSearchByCustomer
            // 
            this.txtSearchByCustomer.Location = new System.Drawing.Point(77, 112);
            this.txtSearchByCustomer.Name = "txtSearchByCustomer";
            this.txtSearchByCustomer.Size = new System.Drawing.Size(195, 20);
            this.txtSearchByCustomer.TabIndex = 10;
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Location = new System.Drawing.Point(77, 86);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(195, 20);
            this.txtSearchOrder.TabIndex = 9;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Controls.Add(this.txtAddress);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Controls.Add(this.txtPhone);
            this.groupBoxCustomer.Controls.Add(this.label4);
            this.groupBoxCustomer.Controls.Add(this.btnInsert);
            this.groupBoxCustomer.Controls.Add(this.txtEmail);
            this.groupBoxCustomer.Controls.Add(this.txtSurname);
            this.groupBoxCustomer.Controls.Add(this.lblDummyInsert3);
            this.groupBoxCustomer.Controls.Add(this.lblDummyInsert2);
            this.groupBoxCustomer.Controls.Add(this.lblDummyInsert1);
            this.groupBoxCustomer.Controls.Add(this.txtName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(330, 71);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(745, 189);
            this.groupBoxCustomer.TabIndex = 12;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Add new Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Basic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contact Info:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(432, 107);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(208, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(432, 81);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "phone:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(565, 145);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(432, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(107, 79);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(208, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // lblDummyInsert3
            // 
            this.lblDummyInsert3.AutoSize = true;
            this.lblDummyInsert3.Location = new System.Drawing.Point(388, 62);
            this.lblDummyInsert3.Name = "lblDummyInsert3";
            this.lblDummyInsert3.Size = new System.Drawing.Size(37, 13);
            this.lblDummyInsert3.TabIndex = 3;
            this.lblDummyInsert3.Text = "e-mail:";
            // 
            // lblDummyInsert2
            // 
            this.lblDummyInsert2.AutoSize = true;
            this.lblDummyInsert2.Location = new System.Drawing.Point(49, 82);
            this.lblDummyInsert2.Name = "lblDummyInsert2";
            this.lblDummyInsert2.Size = new System.Drawing.Size(52, 13);
            this.lblDummyInsert2.TabIndex = 2;
            this.lblDummyInsert2.Text = "Surname:";
            // 
            // lblDummyInsert1
            // 
            this.lblDummyInsert1.AutoSize = true;
            this.lblDummyInsert1.Location = new System.Drawing.Point(63, 58);
            this.lblDummyInsert1.Name = "lblDummyInsert1";
            this.lblDummyInsert1.Size = new System.Drawing.Size(38, 13);
            this.lblDummyInsert1.TabIndex = 1;
            this.lblDummyInsert1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.datagridMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(307, 311);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1047, 400);
            this.pnlMain.TabIndex = 13;
            // 
            // datagridMain
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Gray;
            this.datagridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.datagridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridMain.DefaultCellStyle = dataGridViewCellStyle12;
            this.datagridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridMain.Location = new System.Drawing.Point(23, 19);
            this.datagridMain.Name = "datagridMain";
            this.datagridMain.RowHeadersVisible = false;
            this.datagridMain.Size = new System.Drawing.Size(1024, 381);
            this.datagridMain.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Sales.Properties.Resources.logoOrange;
            this.pbLogo.Location = new System.Drawing.Point(1111, 80);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(231, 189);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "Powered by Sales Team";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Sales 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSearch)).EndInit();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tstripCustomerList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsripGetSales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tstripInvoices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblDummyInsert3;
        private System.Windows.Forms.Label lblDummyInsert2;
        private System.Windows.Forms.Label lblDummyInsert1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView datagridSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDummy2;
        private System.Windows.Forms.Label lblDummy1;
        private System.Windows.Forms.TextBox txtSearchByCustomer;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.DataGridView datagridMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsdummy1;
        private System.Windows.Forms.ToolStripLabel tsdummy2;
        private System.Windows.Forms.ToolStripLabel tsdummy3;
        private System.Windows.Forms.ToolStripLabel tsdummy4;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.Button btnGetinfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}