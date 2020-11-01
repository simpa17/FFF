namespace FastFood.forms.Product
{
    partial class frmProductAdd
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbxProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbxProductStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbxProductCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIngridient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbxIngridient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnProductAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductModify = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProductModify = new Guna.UI2.WinForms.Guna2DataGridView();
            this.quanLyFastFoodDataSet1 = new FastFood.QuanLyFastFoodDataSet1();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new FastFood.QuanLyFastFoodDataSet1TableAdapters.sanPhamTableAdapter();
            this.quanLyFastFoodDataSet3 = new FastFood.QuanLyFastFoodDataSet3();
            this.sanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter1 = new FastFood.QuanLyFastFoodDataSet3TableAdapters.sanPhamTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhMucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyFastFoodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyFastFoodDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductName.DefaultText = "";
            this.tbxProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductName.DisabledState.Parent = this.tbxProductName;
            this.tbxProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductName.FocusedState.Parent = this.tbxProductName;
            this.tbxProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductName.HoverState.Parent = this.tbxProductName;
            this.tbxProductName.Location = new System.Drawing.Point(95, 61);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.PasswordChar = '\0';
            this.tbxProductName.PlaceholderText = "";
            this.tbxProductName.SelectedText = "";
            this.tbxProductName.ShadowDecoration.Parent = this.tbxProductName;
            this.tbxProductName.Size = new System.Drawing.Size(196, 29);
            this.tbxProductName.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(458, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // tbxProductStatus
            // 
            this.tbxProductStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductStatus.DefaultText = "";
            this.tbxProductStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxProductStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxProductStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductStatus.DisabledState.Parent = this.tbxProductStatus;
            this.tbxProductStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductStatus.FocusedState.Parent = this.tbxProductStatus;
            this.tbxProductStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxProductStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductStatus.HoverState.Parent = this.tbxProductStatus;
            this.tbxProductStatus.Location = new System.Drawing.Point(554, 61);
            this.tbxProductStatus.Name = "tbxProductStatus";
            this.tbxProductStatus.PasswordChar = '\0';
            this.tbxProductStatus.PlaceholderText = "";
            this.tbxProductStatus.SelectedText = "";
            this.tbxProductStatus.ShadowDecoration.Parent = this.tbxProductStatus;
            this.tbxProductStatus.Size = new System.Drawing.Size(196, 29);
            this.tbxProductStatus.TabIndex = 1;
            this.tbxProductStatus.TextChanged += new System.EventHandler(this.tbxProductStatus_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(35, 137);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 24);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrice.DefaultText = "";
            this.tbxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPrice.DisabledState.Parent = this.tbxPrice;
            this.tbxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPrice.FocusedState.Parent = this.tbxPrice;
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPrice.HoverState.Parent = this.tbxPrice;
            this.tbxPrice.Location = new System.Drawing.Point(95, 132);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PasswordChar = '\0';
            this.tbxPrice.PlaceholderText = "";
            this.tbxPrice.SelectedText = "";
            this.tbxPrice.ShadowDecoration.Parent = this.tbxPrice;
            this.tbxPrice.Size = new System.Drawing.Size(196, 29);
            this.tbxPrice.TabIndex = 1;
            this.tbxPrice.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(464, 132);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 24);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // tbxProductCategory
            // 
            this.tbxProductCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProductCategory.DefaultText = "";
            this.tbxProductCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxProductCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxProductCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductCategory.DisabledState.Parent = this.tbxProductCategory;
            this.tbxProductCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxProductCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductCategory.FocusedState.Parent = this.tbxProductCategory;
            this.tbxProductCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxProductCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxProductCategory.HoverState.Parent = this.tbxProductCategory;
            this.tbxProductCategory.Location = new System.Drawing.Point(554, 132);
            this.tbxProductCategory.Name = "tbxProductCategory";
            this.tbxProductCategory.PasswordChar = '\0';
            this.tbxProductCategory.PlaceholderText = "";
            this.tbxProductCategory.SelectedText = "";
            this.tbxProductCategory.ShadowDecoration.Parent = this.tbxProductCategory;
            this.tbxProductCategory.Size = new System.Drawing.Size(196, 29);
            this.tbxProductCategory.TabIndex = 1;
            // 
            // lblIngridient
            // 
            this.lblIngridient.BackColor = System.Drawing.Color.Transparent;
            this.lblIngridient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngridient.Location = new System.Drawing.Point(122, 194);
            this.lblIngridient.Name = "lblIngridient";
            this.lblIngridient.Size = new System.Drawing.Size(86, 24);
            this.lblIngridient.TabIndex = 0;
            this.lblIngridient.Text = "Ingridient";
            this.lblIngridient.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // tbxIngridient
            // 
            this.tbxIngridient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxIngridient.DefaultText = "";
            this.tbxIngridient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxIngridient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxIngridient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxIngridient.DisabledState.Parent = this.tbxIngridient;
            this.tbxIngridient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxIngridient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxIngridient.FocusedState.Parent = this.tbxIngridient;
            this.tbxIngridient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxIngridient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxIngridient.HoverState.Parent = this.tbxIngridient;
            this.tbxIngridient.Location = new System.Drawing.Point(214, 189);
            this.tbxIngridient.Name = "tbxIngridient";
            this.tbxIngridient.PasswordChar = '\0';
            this.tbxIngridient.PlaceholderText = "";
            this.tbxIngridient.SelectedText = "";
            this.tbxIngridient.ShadowDecoration.Parent = this.tbxIngridient;
            this.tbxIngridient.Size = new System.Drawing.Size(440, 29);
            this.tbxIngridient.TabIndex = 1;
            this.tbxIngridient.TextChanged += new System.EventHandler(this.tbxIngridient_TextChanged);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BorderRadius = 20;
            this.btnProductAdd.CheckedState.Parent = this.btnProductAdd;
            this.btnProductAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProductAdd.CustomImages.Parent = this.btnProductAdd;
            this.btnProductAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.btnProductAdd.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.ForeColor = System.Drawing.Color.White;
            this.btnProductAdd.HoverState.Parent = this.btnProductAdd;
            this.btnProductAdd.Location = new System.Drawing.Point(531, 235);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.ShadowDecoration.Parent = this.btnProductAdd;
            this.btnProductAdd.Size = new System.Drawing.Size(93, 40);
            this.btnProductAdd.TabIndex = 2;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.BorderRadius = 20;
            this.btnProductModify.CheckedState.Parent = this.btnProductModify;
            this.btnProductModify.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProductModify.CustomImages.Parent = this.btnProductModify;
            this.btnProductModify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.btnProductModify.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductModify.ForeColor = System.Drawing.Color.White;
            this.btnProductModify.HoverState.Parent = this.btnProductModify;
            this.btnProductModify.Location = new System.Drawing.Point(657, 235);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.ShadowDecoration.Parent = this.btnProductModify;
            this.btnProductModify.Size = new System.Drawing.Size(93, 40);
            this.btnProductModify.TabIndex = 2;
            this.btnProductModify.Text = "Modify";
            // 
            // dgvProductModify
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvProductModify.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductModify.AutoGenerateColumns = false;
            this.dgvProductModify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductModify.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductModify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductModify.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductModify.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductModify.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductModify.ColumnHeadersHeight = 25;
            this.dgvProductModify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.danhMucDataGridViewTextBoxColumn,
            this.thanhPhanDataGridViewTextBoxColumn});
            this.dgvProductModify.DataSource = this.sanPhamBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductModify.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductModify.EnableHeadersVisualStyles = false;
            this.dgvProductModify.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvProductModify.Location = new System.Drawing.Point(-3, 294);
            this.dgvProductModify.Name = "dgvProductModify";
            this.dgvProductModify.RowHeadersVisible = false;
            this.dgvProductModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProductModify.RowTemplate.Height = 24;
            this.dgvProductModify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductModify.Size = new System.Drawing.Size(821, 216);
            this.dgvProductModify.TabIndex = 3;
            this.dgvProductModify.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvProductModify.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvProductModify.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductModify.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductModify.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductModify.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductModify.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductModify.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvProductModify.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvProductModify.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductModify.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProductModify.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductModify.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductModify.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvProductModify.ThemeStyle.ReadOnly = false;
            this.dgvProductModify.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvProductModify.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductModify.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProductModify.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductModify.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProductModify.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvProductModify.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductModify.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductModify_CellContentClick);
            // 
            // quanLyFastFoodDataSet1
            // 
            this.quanLyFastFoodDataSet1.DataSetName = "QuanLyFastFoodDataSet1";
            this.quanLyFastFoodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "sanPham";
            this.sanPhamBindingSource.DataSource = this.quanLyFastFoodDataSet1;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyFastFoodDataSet3
            // 
            this.quanLyFastFoodDataSet3.DataSetName = "QuanLyFastFoodDataSet3";
            this.quanLyFastFoodDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource1
            // 
            this.sanPhamBindingSource1.DataMember = "sanPham";
            this.sanPhamBindingSource1.DataSource = this.quanLyFastFoodDataSet3;
            // 
            // sanPhamTableAdapter1
            // 
            this.sanPhamTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // danhMucDataGridViewTextBoxColumn
            // 
            this.danhMucDataGridViewTextBoxColumn.DataPropertyName = "DanhMuc";
            this.danhMucDataGridViewTextBoxColumn.HeaderText = "DanhMuc";
            this.danhMucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.danhMucDataGridViewTextBoxColumn.Name = "danhMucDataGridViewTextBoxColumn";
            // 
            // thanhPhanDataGridViewTextBoxColumn
            // 
            this.thanhPhanDataGridViewTextBoxColumn.DataPropertyName = "ThanhPhan";
            this.thanhPhanDataGridViewTextBoxColumn.HeaderText = "ThanhPhan";
            this.thanhPhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhPhanDataGridViewTextBoxColumn.Name = "thanhPhanDataGridViewTextBoxColumn";
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(817, 511);
            this.Controls.Add(this.dgvProductModify);
            this.Controls.Add(this.btnProductModify);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.tbxIngridient);
            this.Controls.Add(this.lblIngridient);
            this.Controls.Add(this.tbxProductCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxProductStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.lblName);
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyFastFoodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyFastFoodDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2TextBox tbxProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2TextBox tbxProductStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbxPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox tbxProductCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIngridient;
        private Guna.UI2.WinForms.Guna2TextBox tbxIngridient;
        private Guna.UI2.WinForms.Guna2Button btnProductAdd;
        private Guna.UI2.WinForms.Guna2Button btnProductModify;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductModify;
        private QuanLyFastFoodDataSet1 quanLyFastFoodDataSet1;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QuanLyFastFoodDataSet1TableAdapters.sanPhamTableAdapter sanPhamTableAdapter;
        private QuanLyFastFoodDataSet3 quanLyFastFoodDataSet3;
        private System.Windows.Forms.BindingSource sanPhamBindingSource1;
        private QuanLyFastFoodDataSet3TableAdapters.sanPhamTableAdapter sanPhamTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhMucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhanDataGridViewTextBoxColumn;
    }
}