namespace VLib_Client {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xylosTabControl1 = new XylosTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBike = new XylosRadioButton();
            this.radioPedestrian = new XylosRadioButton();
            this.xylosButton3 = new XylosButton();
            this.xylosTextBox1 = new XylosTextBox();
            this.lblStationName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xylosTextBox2 = new XylosTextBox();
            this.xylosNotice1 = new XylosNotice();
            this.label2 = new System.Windows.Forms.Label();
            this.xylosCombobox1 = new XylosCombobox();
            this.xylosSeparator1 = new XylosSeparator();
            this.xylosButton1 = new XylosButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xylosButton2 = new XylosButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xylosSeparator3 = new XylosSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.xylosButton5 = new XylosButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xylosTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xylosTabControl1
            // 
            this.xylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.xylosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosTabControl1.Controls.Add(this.tabPage1);
            this.xylosTabControl1.Controls.Add(this.tabPage2);
            this.xylosTabControl1.FirstHeaderBorder = false;
            this.xylosTabControl1.ItemSize = new System.Drawing.Size(40, 180);
            this.xylosTabControl1.Location = new System.Drawing.Point(1, 0);
            this.xylosTabControl1.Multiline = true;
            this.xylosTabControl1.Name = "xylosTabControl1";
            this.xylosTabControl1.SelectedIndex = 0;
            this.xylosTabControl1.Size = new System.Drawing.Size(622, 539);
            this.xylosTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblStationName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.xylosTextBox2);
            this.tabPage1.Controls.Add(this.xylosNotice1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.xylosCombobox1);
            this.tabPage1.Controls.Add(this.xylosSeparator1);
            this.tabPage1.Controls.Add(this.xylosButton1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Routes calculator";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(118, 212);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 15);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "                             ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address :";
            this.label7.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.xylosButton5);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioBike);
            this.groupBox1.Controls.Add(this.radioPedestrian);
            this.groupBox1.Controls.Add(this.xylosButton3);
            this.groupBox1.Controls.Add(this.xylosTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 293);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routes";
            this.groupBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 202);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // radioBike
            // 
            this.radioBike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBike.Checked = true;
            this.radioBike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBike.EnabledCalc = true;
            this.radioBike.Location = new System.Drawing.Point(198, 67);
            this.radioBike.Name = "radioBike";
            this.radioBike.Size = new System.Drawing.Size(91, 18);
            this.radioBike.TabIndex = 16;
            this.radioBike.Text = "VLib (bikes)";
            // 
            // radioPedestrian
            // 
            this.radioPedestrian.Checked = false;
            this.radioPedestrian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPedestrian.EnabledCalc = true;
            this.radioPedestrian.Location = new System.Drawing.Point(14, 67);
            this.radioPedestrian.Name = "radioPedestrian";
            this.radioPedestrian.Size = new System.Drawing.Size(129, 18);
            this.radioPedestrian.TabIndex = 15;
            this.radioPedestrian.Text = "Pedestrian";
            // 
            // xylosButton3
            // 
            this.xylosButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosButton3.EnabledCalc = true;
            this.xylosButton3.Location = new System.Drawing.Point(305, 23);
            this.xylosButton3.Name = "xylosButton3";
            this.xylosButton3.Size = new System.Drawing.Size(116, 28);
            this.xylosButton3.TabIndex = 13;
            this.xylosButton3.Text = "Get best itinary";
            this.xylosButton3.Click += new XylosButton.ClickEventHandler(this.xylosButton3_Click);
            // 
            // xylosTextBox1
            // 
            this.xylosTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosTextBox1.EnabledCalc = true;
            this.xylosTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xylosTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.xylosTextBox1.Location = new System.Drawing.Point(10, 22);
            this.xylosTextBox1.MaxLength = 32767;
            this.xylosTextBox1.MultiLine = false;
            this.xylosTextBox1.Name = "xylosTextBox1";
            this.xylosTextBox1.ReadOnly = false;
            this.xylosTextBox1.Size = new System.Drawing.Size(279, 29);
            this.xylosTextBox1.TabIndex = 12;
            this.xylosTextBox1.Text = "Enter your final destination address here";
            this.xylosTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.xylosTextBox1.UseSystemPasswordChar = false;
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.Location = new System.Drawing.Point(118, 183);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(94, 15);
            this.lblStationName.TabIndex = 10;
            this.lblStationName.Text = "                             ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected station :";
            this.label1.Visible = false;
            // 
            // xylosTextBox2
            // 
            this.xylosTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosTextBox2.EnabledCalc = true;
            this.xylosTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xylosTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.xylosTextBox2.Location = new System.Drawing.Point(13, 66);
            this.xylosTextBox2.MaxLength = 32767;
            this.xylosTextBox2.MultiLine = false;
            this.xylosTextBox2.Name = "xylosTextBox2";
            this.xylosTextBox2.ReadOnly = false;
            this.xylosTextBox2.Size = new System.Drawing.Size(279, 31);
            this.xylosTextBox2.TabIndex = 8;
            this.xylosTextBox2.Text = "Enter your city name to list all the availables bike";
            this.xylosTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.xylosTextBox2.UseSystemPasswordChar = false;
            // 
            // xylosNotice1
            // 
            this.xylosNotice1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosNotice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xylosNotice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.xylosNotice1.Enabled = false;
            this.xylosNotice1.Location = new System.Drawing.Point(7, 13);
            this.xylosNotice1.Multiline = true;
            this.xylosNotice1.Name = "xylosNotice1";
            this.xylosNotice1.ReadOnly = true;
            this.xylosNotice1.Size = new System.Drawing.Size(423, 31);
            this.xylosNotice1.TabIndex = 7;
            this.xylosNotice1.Text = "Here, you\'ll be able to see routes from an adress to a final destination. ";
            this.xylosNotice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of every place where a bike is available : ";
            this.label2.Visible = false;
            // 
            // xylosCombobox1
            // 
            this.xylosCombobox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosCombobox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xylosCombobox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.xylosCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xylosCombobox1.EnabledCalc = true;
            this.xylosCombobox1.FormattingEnabled = true;
            this.xylosCombobox1.ItemHeight = 20;
            this.xylosCombobox1.Location = new System.Drawing.Point(255, 136);
            this.xylosCombobox1.Name = "xylosCombobox1";
            this.xylosCombobox1.Size = new System.Drawing.Size(174, 26);
            this.xylosCombobox1.TabIndex = 5;
            this.xylosCombobox1.Visible = false;
            this.xylosCombobox1.SelectedIndexChanged += new System.EventHandler(this.xylosCombobox1_SelectedIndexChanged);
            // 
            // xylosSeparator1
            // 
            this.xylosSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosSeparator1.Location = new System.Drawing.Point(13, 114);
            this.xylosSeparator1.Name = "xylosSeparator1";
            this.xylosSeparator1.Size = new System.Drawing.Size(417, 2);
            this.xylosSeparator1.TabIndex = 3;
            this.xylosSeparator1.Text = "xylosSeparator1";
            // 
            // xylosButton1
            // 
            this.xylosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosButton1.EnabledCalc = true;
            this.xylosButton1.Location = new System.Drawing.Point(310, 67);
            this.xylosButton1.Name = "xylosButton1";
            this.xylosButton1.Size = new System.Drawing.Size(116, 29);
            this.xylosButton1.TabIndex = 1;
            this.xylosButton1.Text = "Get available bikes";
            this.xylosButton1.Click += new XylosButton.ClickEventHandler(this.xylosButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.xylosButton2);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.xylosSeparator3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help / About";
            // 
            // xylosButton2
            // 
            this.xylosButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosButton2.EnabledCalc = true;
            this.xylosButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xylosButton2.Location = new System.Drawing.Point(147, 452);
            this.xylosButton2.Name = "xylosButton2";
            this.xylosButton2.Size = new System.Drawing.Size(151, 36);
            this.xylosButton2.TabIndex = 11;
            this.xylosButton2.Text = "⟳ Refresh cache datas";
            this.xylosButton2.Visible = false;
            this.xylosButton2.Click += new XylosButton.ClickEventHandler(this.xylosButton2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(252, 394);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "valerio.kevin83@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 165);
            this.label6.TabIndex = 3;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 135);
            this.label5.TabIndex = 3;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xylosSeparator3
            // 
            this.xylosSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosSeparator3.Location = new System.Drawing.Point(6, 195);
            this.xylosSeparator3.Name = "xylosSeparator3";
            this.xylosSeparator3.Size = new System.Drawing.Size(454, 2);
            this.xylosSeparator3.TabIndex = 2;
            this.xylosSeparator3.Text = "xylosSeparator3";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Help and informations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "About";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 206);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // xylosButton5
            // 
            this.xylosButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xylosButton5.EnabledCalc = true;
            this.xylosButton5.Location = new System.Drawing.Point(305, 56);
            this.xylosButton5.Name = "xylosButton5";
            this.xylosButton5.Size = new System.Drawing.Size(116, 29);
            this.xylosButton5.TabIndex = 17;
            this.xylosButton5.Text = "Get instructions";
            this.xylosButton5.Click += new XylosButton.ClickEventHandler(this.xylosButton5_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Instruction";
            this.columnHeader1.Width = 283;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Distance";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 538);
            this.Controls.Add(this.xylosTabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JCDecaux Transport Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xylosTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XylosTabControl xylosTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private XylosSeparator xylosSeparator1;
        private XylosButton xylosButton1;
        private XylosCombobox xylosCombobox1;
        private System.Windows.Forms.Label label2;
        private XylosNotice xylosNotice1;
        private XylosTextBox xylosTextBox2;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label label1;
        private XylosButton xylosButton2;
        private XylosTextBox xylosTextBox1;
        private XylosSeparator xylosSeparator3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private XylosButton xylosButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private XylosRadioButton radioBike;
        private XylosRadioButton radioPedestrian;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private XylosButton xylosButton5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

