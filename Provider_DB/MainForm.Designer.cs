namespace Provider_DB
{
	partial class MainForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tab_edit = new System.Windows.Forms.TabPage();
			this.tabTables = new System.Windows.Forms.TabControl();
			this.t_agreements = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_agreement_del = new System.Windows.Forms.Button();
			this.btn_agreement_add = new System.Windows.Forms.Button();
			this.btn_agreement_change = new System.Windows.Forms.Button();
			this.id_rate = new System.Windows.Forms.ComboBox();
			this.id_co_worker = new System.Windows.Forms.ComboBox();
			this.date_connection = new System.Windows.Forms.DateTimePicker();
			this.num_apartments = new System.Windows.Forms.NumericUpDown();
			this.id_coverage_area = new System.Windows.Forms.ComboBox();
			this.password = new System.Windows.Forms.TextBox();
			this.balance = new System.Windows.Forms.NumericUpDown();
			this.login = new System.Windows.Forms.TextBox();
			this.id_user = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.agreements_list = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.t_users = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.user_contact_phone_num = new System.Windows.Forms.TextBox();
			this.user_address = new System.Windows.Forms.TextBox();
			this.user_passport_data = new System.Windows.Forms.TextBox();
			this.user_patronymic = new System.Windows.Forms.TextBox();
			this.user_name = new System.Windows.Forms.TextBox();
			this.user_surname = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_user_del = new System.Windows.Forms.Button();
			this.btn_user_add = new System.Windows.Forms.Button();
			this.иет_user_change = new System.Windows.Forms.Button();
			this.users_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.t_transactions = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.transaction_date = new System.Windows.Forms.DateTimePicker();
			this.transaction_amount = new System.Windows.Forms.NumericUpDown();
			this.operation_type = new System.Windows.Forms.TextBox();
			this.id_agreement = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btn_transaction_del = new System.Windows.Forms.Button();
			this.btn_transaction_add = new System.Windows.Forms.Button();
			this.btn_transaction_change = new System.Windows.Forms.Button();
			this.transactions_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.t_co_workers = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.co_worker_address = new System.Windows.Forms.TextBox();
			this.co_worker_passport_data = new System.Windows.Forms.TextBox();
			this.co_worker_patronymic = new System.Windows.Forms.TextBox();
			this.co_worker_name = new System.Windows.Forms.TextBox();
			this.co_worker_surname = new System.Windows.Forms.TextBox();
			this.co_worker_post = new System.Windows.Forms.TextBox();
			this.co_worker_contact_phone_num = new System.Windows.Forms.TextBox();
			this.co_worker_salary = new System.Windows.Forms.NumericUpDown();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.btn_co_worker_del = new System.Windows.Forms.Button();
			this.btn_co_worker_add = new System.Windows.Forms.Button();
			this.btn_co_worker_change = new System.Windows.Forms.Button();
			this.co_workers_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.t_rates = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rate_validity = new System.Windows.Forms.DateTimePicker();
			this.rate_cost = new System.Windows.Forms.NumericUpDown();
			this.rate_notes = new System.Windows.Forms.TextBox();
			this.rate_description = new System.Windows.Forms.TextBox();
			this.rate_name = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.btn_rate_del = new System.Windows.Forms.Button();
			this.btn_rate_add = new System.Windows.Forms.Button();
			this.btn_rate_change = new System.Windows.Forms.Button();
			this.rates_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.t_coverage_areas = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.num_house = new System.Windows.Forms.NumericUpDown();
			this.street = new System.Windows.Forms.TextBox();
			this.district = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.btn_coverage_area_del = new System.Windows.Forms.Button();
			this.btn_coverage_area_add = new System.Windows.Forms.Button();
			this.btn_coverage_area_change = new System.Windows.Forms.Button();
			this.coverage_areas_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tab_sql_query = new System.Windows.Forms.TabPage();
			this.ResultsList = new System.Windows.Forms.TextBox();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.btn_result_clear = new System.Windows.Forms.Button();
			this.btn_query_exec = new System.Windows.Forms.Button();
			this.tabQuery = new System.Windows.Forms.TabControl();
			this.tab_query_1 = new System.Windows.Forms.TabPage();
			this.comboBox_Query1 = new System.Windows.Forms.ComboBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.tab_query_2 = new System.Windows.Forms.TabPage();
			this.comboBox_Query2 = new System.Windows.Forms.ComboBox();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.tab_query_3 = new System.Windows.Forms.TabPage();
			this.comboBox_Query3 = new System.Windows.Forms.ComboBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.tab_query_4 = new System.Windows.Forms.TabPage();
			this.comboBox_Query4 = new System.Windows.Forms.ComboBox();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.tab_query_5 = new System.Windows.Forms.TabPage();
			this.label44 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.tab_query_6 = new System.Windows.Forms.TabPage();
			this.comboBox_Query6 = new System.Windows.Forms.ComboBox();
			this.label46 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tab_edit.SuspendLayout();
			this.tabTables.SuspendLayout();
			this.t_agreements.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_apartments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agreements_list)).BeginInit();
			this.t_users.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.users_list)).BeginInit();
			this.t_transactions.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transaction_amount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transactions_list)).BeginInit();
			this.t_co_workers.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.co_worker_salary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.co_workers_list)).BeginInit();
			this.t_rates.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rate_cost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rates_list)).BeginInit();
			this.t_coverage_areas.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_house)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coverage_areas_list)).BeginInit();
			this.tab_sql_query.SuspendLayout();
			this.groupBox.SuspendLayout();
			this.tabQuery.SuspendLayout();
			this.tab_query_1.SuspendLayout();
			this.tab_query_2.SuspendLayout();
			this.tab_query_3.SuspendLayout();
			this.tab_query_4.SuspendLayout();
			this.tab_query_5.SuspendLayout();
			this.tab_query_6.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_edit
			// 
			this.tab_edit.Controls.Add(this.tabTables);
			this.tab_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tab_edit.Location = new System.Drawing.Point(4, 27);
			this.tab_edit.Name = "tab_edit";
			this.tab_edit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_edit.Size = new System.Drawing.Size(752, 507);
			this.tab_edit.TabIndex = 1;
			this.tab_edit.Text = "Просмотр/Редакторование таблиц";
			this.tab_edit.UseVisualStyleBackColor = true;
			// 
			// tabTables
			// 
			this.tabTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabTables.Controls.Add(this.t_agreements);
			this.tabTables.Controls.Add(this.t_users);
			this.tabTables.Controls.Add(this.t_transactions);
			this.tabTables.Controls.Add(this.t_co_workers);
			this.tabTables.Controls.Add(this.t_rates);
			this.tabTables.Controls.Add(this.t_coverage_areas);
			this.tabTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabTables.Location = new System.Drawing.Point(7, 7);
			this.tabTables.Name = "tabTables";
			this.tabTables.SelectedIndex = 0;
			this.tabTables.Size = new System.Drawing.Size(739, 494);
			this.tabTables.TabIndex = 1;
			this.tabTables.SelectedIndexChanged += new System.EventHandler(this.tabTablesChanged);
			// 
			// t_agreements
			// 
			this.t_agreements.Controls.Add(this.groupBox1);
			this.t_agreements.Controls.Add(this.agreements_list);
			this.t_agreements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.t_agreements.Location = new System.Drawing.Point(4, 25);
			this.t_agreements.Name = "t_agreements";
			this.t_agreements.Padding = new System.Windows.Forms.Padding(3);
			this.t_agreements.Size = new System.Drawing.Size(731, 465);
			this.t_agreements.TabIndex = 0;
			this.t_agreements.Text = "Договоры";
			this.t_agreements.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btn_agreement_del);
			this.groupBox1.Controls.Add(this.btn_agreement_add);
			this.groupBox1.Controls.Add(this.btn_agreement_change);
			this.groupBox1.Controls.Add(this.id_rate);
			this.groupBox1.Controls.Add(this.id_co_worker);
			this.groupBox1.Controls.Add(this.date_connection);
			this.groupBox1.Controls.Add(this.num_apartments);
			this.groupBox1.Controls.Add(this.id_coverage_area);
			this.groupBox1.Controls.Add(this.password);
			this.groupBox1.Controls.Add(this.balance);
			this.groupBox1.Controls.Add(this.login);
			this.groupBox1.Controls.Add(this.id_user);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(425, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 453);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// btn_agreement_del
			// 
			this.btn_agreement_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_agreement_del.Location = new System.Drawing.Point(219, 422);
			this.btn_agreement_del.Name = "btn_agreement_del";
			this.btn_agreement_del.Size = new System.Drawing.Size(75, 25);
			this.btn_agreement_del.TabIndex = 14;
			this.btn_agreement_del.Text = "-";
			this.btn_agreement_del.UseVisualStyleBackColor = true;
			// 
			// btn_agreement_add
			// 
			this.btn_agreement_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_agreement_add.Location = new System.Drawing.Point(219, 391);
			this.btn_agreement_add.Name = "btn_agreement_add";
			this.btn_agreement_add.Size = new System.Drawing.Size(75, 25);
			this.btn_agreement_add.TabIndex = 13;
			this.btn_agreement_add.Text = "+";
			this.btn_agreement_add.UseVisualStyleBackColor = true;
			this.btn_agreement_add.Click += new System.EventHandler(this.btn_agreement_add_Click);
			// 
			// btn_agreement_change
			// 
			this.btn_agreement_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_agreement_change.Location = new System.Drawing.Point(219, 360);
			this.btn_agreement_change.Name = "btn_agreement_change";
			this.btn_agreement_change.Size = new System.Drawing.Size(75, 25);
			this.btn_agreement_change.TabIndex = 12;
			this.btn_agreement_change.Text = "изменить";
			this.btn_agreement_change.UseVisualStyleBackColor = true;
			this.btn_agreement_change.Click += new System.EventHandler(this.btn_agreement_change_Click);
			// 
			// id_rate
			// 
			this.id_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_rate.FormattingEnabled = true;
			this.id_rate.Location = new System.Drawing.Point(134, 247);
			this.id_rate.Name = "id_rate";
			this.id_rate.Size = new System.Drawing.Size(160, 23);
			this.id_rate.TabIndex = 11;
			// 
			// id_co_worker
			// 
			this.id_co_worker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_co_worker.FormattingEnabled = true;
			this.id_co_worker.Location = new System.Drawing.Point(134, 218);
			this.id_co_worker.Name = "id_co_worker";
			this.id_co_worker.Size = new System.Drawing.Size(160, 23);
			this.id_co_worker.TabIndex = 10;
			// 
			// date_connection
			// 
			this.date_connection.Location = new System.Drawing.Point(155, 191);
			this.date_connection.Name = "date_connection";
			this.date_connection.Size = new System.Drawing.Size(138, 21);
			this.date_connection.TabIndex = 9;
			// 
			// num_apartments
			// 
			this.num_apartments.Location = new System.Drawing.Point(174, 164);
			this.num_apartments.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.num_apartments.Name = "num_apartments";
			this.num_apartments.Size = new System.Drawing.Size(120, 21);
			this.num_apartments.TabIndex = 8;
			// 
			// id_coverage_area
			// 
			this.id_coverage_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_coverage_area.FormattingEnabled = true;
			this.id_coverage_area.Location = new System.Drawing.Point(172, 135);
			this.id_coverage_area.Name = "id_coverage_area";
			this.id_coverage_area.Size = new System.Drawing.Size(121, 23);
			this.id_coverage_area.TabIndex = 7;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(185, 108);
			this.password.MaxLength = 15;
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(108, 21);
			this.password.TabIndex = 6;
			// 
			// balance
			// 
			this.balance.Location = new System.Drawing.Point(213, 49);
			this.balance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.balance.Name = "balance";
			this.balance.Size = new System.Drawing.Size(80, 21);
			this.balance.TabIndex = 4;
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(185, 76);
			this.login.MaxLength = 15;
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(108, 21);
			this.login.TabIndex = 5;
			// 
			// id_user
			// 
			this.id_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_user.FormattingEnabled = true;
			this.id_user.Location = new System.Drawing.Point(154, 20);
			this.id_user.Name = "id_user";
			this.id_user.Size = new System.Drawing.Size(140, 23);
			this.id_user.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 247);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 15);
			this.label9.TabIndex = 8;
			this.label9.Text = "Тарифный план :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(54, 218);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = "Сотрудник :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 191);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Дата подключения :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Номер квартиры :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(98, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Код дома :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(122, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Пароль :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(132, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Логин :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(152, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Баланс :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Пользователь :";
			// 
			// agreements_list
			// 
			this.agreements_list.AllowUserToAddRows = false;
			this.agreements_list.AllowUserToDeleteRows = false;
			this.agreements_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.agreements_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.agreements_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.agreements_list.Location = new System.Drawing.Point(6, 6);
			this.agreements_list.Name = "agreements_list";
			this.agreements_list.ReadOnly = true;
			this.agreements_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.agreements_list.Size = new System.Drawing.Size(413, 453);
			this.agreements_list.TabIndex = 18;
			this.agreements_list.CurrentCellChanged += new System.EventHandler(this.showAgreement);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Код договора";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 115;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Пользователь";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Баланс";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Логин";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Пароль";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Код дома";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "№ квартиры";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 105;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Дата подкл.";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 105;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Сотрудник";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Тарифный план";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 130;
			// 
			// t_users
			// 
			this.t_users.Controls.Add(this.groupBox2);
			this.t_users.Controls.Add(this.users_list);
			this.t_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.t_users.Location = new System.Drawing.Point(4, 25);
			this.t_users.Name = "t_users";
			this.t_users.Padding = new System.Windows.Forms.Padding(3);
			this.t_users.Size = new System.Drawing.Size(731, 465);
			this.t_users.TabIndex = 1;
			this.t_users.Text = "Пользователи";
			this.t_users.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.user_contact_phone_num);
			this.groupBox2.Controls.Add(this.user_address);
			this.groupBox2.Controls.Add(this.user_passport_data);
			this.groupBox2.Controls.Add(this.user_patronymic);
			this.groupBox2.Controls.Add(this.user_name);
			this.groupBox2.Controls.Add(this.user_surname);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.btn_user_del);
			this.groupBox2.Controls.Add(this.btn_user_add);
			this.groupBox2.Controls.Add(this.иет_user_change);
			this.groupBox2.Location = new System.Drawing.Point(425, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(300, 453);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// user_contact_phone_num
			// 
			this.user_contact_phone_num.Location = new System.Drawing.Point(154, 155);
			this.user_contact_phone_num.MaxLength = 8;
			this.user_contact_phone_num.Name = "user_contact_phone_num";
			this.user_contact_phone_num.Size = new System.Drawing.Size(140, 21);
			this.user_contact_phone_num.TabIndex = 8;
			// 
			// user_address
			// 
			this.user_address.Location = new System.Drawing.Point(94, 128);
			this.user_address.MaxLength = 50;
			this.user_address.Name = "user_address";
			this.user_address.Size = new System.Drawing.Size(200, 21);
			this.user_address.TabIndex = 7;
			this.user_address.Enter += new System.EventHandler(this.user_address_Enter);
			this.user_address.Leave += new System.EventHandler(this.user_address_Leave);
			// 
			// user_passport_data
			// 
			this.user_passport_data.Location = new System.Drawing.Point(154, 101);
			this.user_passport_data.MaxLength = 10;
			this.user_passport_data.Name = "user_passport_data";
			this.user_passport_data.Size = new System.Drawing.Size(140, 21);
			this.user_passport_data.TabIndex = 6;
			// 
			// user_patronymic
			// 
			this.user_patronymic.Location = new System.Drawing.Point(94, 74);
			this.user_patronymic.MaxLength = 30;
			this.user_patronymic.Name = "user_patronymic";
			this.user_patronymic.Size = new System.Drawing.Size(200, 21);
			this.user_patronymic.TabIndex = 5;
			// 
			// user_name
			// 
			this.user_name.Location = new System.Drawing.Point(94, 47);
			this.user_name.MaxLength = 15;
			this.user_name.Name = "user_name";
			this.user_name.Size = new System.Drawing.Size(200, 21);
			this.user_name.TabIndex = 4;
			// 
			// user_surname
			// 
			this.user_surname.Location = new System.Drawing.Point(94, 20);
			this.user_surname.MaxLength = 30;
			this.user_surname.Name = "user_surname";
			this.user_surname.Size = new System.Drawing.Size(200, 21);
			this.user_surname.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(7, 155);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(141, 15);
			this.label15.TabIndex = 30;
			this.label15.Text = "Контактный телефон :";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(41, 128);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(47, 15);
			this.label14.TabIndex = 29;
			this.label14.Text = "Адрес :";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(15, 101);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(133, 15);
			this.label13.TabIndex = 28;
			this.label13.Text = "Паспортные данные :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(19, 74);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 15);
			this.label12.TabIndex = 27;
			this.label12.Text = "Отчество :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(50, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 15);
			this.label11.TabIndex = 26;
			this.label11.Text = "Имя :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(20, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 15);
			this.label10.TabIndex = 25;
			this.label10.Text = "Фамилия :";
			// 
			// btn_user_del
			// 
			this.btn_user_del.AllowDrop = true;
			this.btn_user_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_user_del.Location = new System.Drawing.Point(219, 422);
			this.btn_user_del.Name = "btn_user_del";
			this.btn_user_del.Size = new System.Drawing.Size(75, 25);
			this.btn_user_del.TabIndex = 11;
			this.btn_user_del.Text = "-";
			this.btn_user_del.UseVisualStyleBackColor = true;
			// 
			// btn_user_add
			// 
			this.btn_user_add.AllowDrop = true;
			this.btn_user_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_user_add.Location = new System.Drawing.Point(219, 391);
			this.btn_user_add.Name = "btn_user_add";
			this.btn_user_add.Size = new System.Drawing.Size(75, 25);
			this.btn_user_add.TabIndex = 10;
			this.btn_user_add.Text = "+";
			this.btn_user_add.UseVisualStyleBackColor = true;
			this.btn_user_add.Click += new System.EventHandler(this.btn_user_add_Click);
			// 
			// иет_user_change
			// 
			this.иет_user_change.AllowDrop = true;
			this.иет_user_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.иет_user_change.Location = new System.Drawing.Point(219, 360);
			this.иет_user_change.Name = "иет_user_change";
			this.иет_user_change.Size = new System.Drawing.Size(75, 25);
			this.иет_user_change.TabIndex = 9;
			this.иет_user_change.Text = "изменить";
			this.иет_user_change.UseVisualStyleBackColor = true;
			this.иет_user_change.Click += new System.EventHandler(this.btn_user_change_Click);
			// 
			// users_list
			// 
			this.users_list.AllowUserToAddRows = false;
			this.users_list.AllowUserToDeleteRows = false;
			this.users_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.users_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.users_list.Location = new System.Drawing.Point(6, 6);
			this.users_list.Name = "users_list";
			this.users_list.ReadOnly = true;
			this.users_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.users_list.Size = new System.Drawing.Size(413, 453);
			this.users_list.TabIndex = 20;
			this.users_list.SelectionChanged += new System.EventHandler(this.showUser);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Код польз.";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Пасп. данные";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 120;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Контактный тел.";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 130;
			// 
			// t_transactions
			// 
			this.t_transactions.Controls.Add(this.groupBox3);
			this.t_transactions.Controls.Add(this.transactions_list);
			this.t_transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.t_transactions.Location = new System.Drawing.Point(4, 25);
			this.t_transactions.Name = "t_transactions";
			this.t_transactions.Padding = new System.Windows.Forms.Padding(3);
			this.t_transactions.Size = new System.Drawing.Size(731, 465);
			this.t_transactions.TabIndex = 2;
			this.t_transactions.Text = "Денежные операции";
			this.t_transactions.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.transaction_date);
			this.groupBox3.Controls.Add(this.transaction_amount);
			this.groupBox3.Controls.Add(this.operation_type);
			this.groupBox3.Controls.Add(this.id_agreement);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.btn_transaction_del);
			this.groupBox3.Controls.Add(this.btn_transaction_add);
			this.groupBox3.Controls.Add(this.btn_transaction_change);
			this.groupBox3.Location = new System.Drawing.Point(425, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(300, 453);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// transaction_date
			// 
			this.transaction_date.Location = new System.Drawing.Point(158, 109);
			this.transaction_date.Name = "transaction_date";
			this.transaction_date.Size = new System.Drawing.Size(136, 21);
			this.transaction_date.TabIndex = 6;
			// 
			// transaction_amount
			// 
			this.transaction_amount.Location = new System.Drawing.Point(158, 76);
			this.transaction_amount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.transaction_amount.Name = "transaction_amount";
			this.transaction_amount.Size = new System.Drawing.Size(136, 21);
			this.transaction_amount.TabIndex = 5;
			// 
			// operation_type
			// 
			this.operation_type.Location = new System.Drawing.Point(158, 49);
			this.operation_type.MaxLength = 30;
			this.operation_type.Name = "operation_type";
			this.operation_type.Size = new System.Drawing.Size(136, 21);
			this.operation_type.TabIndex = 4;
			// 
			// id_agreement
			// 
			this.id_agreement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_agreement.FormattingEnabled = true;
			this.id_agreement.Location = new System.Drawing.Point(158, 20);
			this.id_agreement.Name = "id_agreement";
			this.id_agreement.Size = new System.Drawing.Size(136, 23);
			this.id_agreement.TabIndex = 3;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(38, 109);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(114, 15);
			this.label19.TabIndex = 28;
			this.label19.Text = "Дата транзакции :";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(42, 76);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(110, 15);
			this.label18.TabIndex = 27;
			this.label18.Text = "Сумма операции :";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(58, 49);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(94, 15);
			this.label17.TabIndex = 26;
			this.label17.Text = "Вид операции :";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(43, 20);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(109, 15);
			this.label16.TabIndex = 25;
			this.label16.Text = "Номер договора :";
			// 
			// btn_transaction_del
			// 
			this.btn_transaction_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_transaction_del.Location = new System.Drawing.Point(219, 422);
			this.btn_transaction_del.Name = "btn_transaction_del";
			this.btn_transaction_del.Size = new System.Drawing.Size(75, 25);
			this.btn_transaction_del.TabIndex = 9;
			this.btn_transaction_del.Text = "-";
			this.btn_transaction_del.UseVisualStyleBackColor = true;
			// 
			// btn_transaction_add
			// 
			this.btn_transaction_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_transaction_add.Location = new System.Drawing.Point(219, 391);
			this.btn_transaction_add.Name = "btn_transaction_add";
			this.btn_transaction_add.Size = new System.Drawing.Size(75, 25);
			this.btn_transaction_add.TabIndex = 8;
			this.btn_transaction_add.Text = "+";
			this.btn_transaction_add.UseVisualStyleBackColor = true;
			this.btn_transaction_add.Click += new System.EventHandler(this.btn_transaction_add_Click);
			// 
			// btn_transaction_change
			// 
			this.btn_transaction_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_transaction_change.Location = new System.Drawing.Point(219, 360);
			this.btn_transaction_change.Name = "btn_transaction_change";
			this.btn_transaction_change.Size = new System.Drawing.Size(75, 25);
			this.btn_transaction_change.TabIndex = 7;
			this.btn_transaction_change.Text = "изменить";
			this.btn_transaction_change.UseVisualStyleBackColor = true;
			this.btn_transaction_change.Click += new System.EventHandler(this.btn_transaction_change_Click);
			// 
			// transactions_list
			// 
			this.transactions_list.AllowUserToAddRows = false;
			this.transactions_list.AllowUserToDeleteRows = false;
			this.transactions_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.transactions_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.transactions_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
			this.transactions_list.Location = new System.Drawing.Point(6, 6);
			this.transactions_list.Name = "transactions_list";
			this.transactions_list.ReadOnly = true;
			this.transactions_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.transactions_list.Size = new System.Drawing.Size(413, 453);
			this.transactions_list.TabIndex = 20;
			this.transactions_list.SelectionChanged += new System.EventHandler(this.showTransaction);
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "Код операции";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 115;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.HeaderText = "Код договора";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Width = 115;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.HeaderText = "Вид операции";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 115;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.HeaderText = "Сумма операции";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Width = 130;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.HeaderText = "Дата транзакции";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			this.dataGridViewTextBoxColumn15.Width = 135;
			// 
			// t_co_workers
			// 
			this.t_co_workers.Controls.Add(this.groupBox4);
			this.t_co_workers.Controls.Add(this.co_workers_list);
			this.t_co_workers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.t_co_workers.Location = new System.Drawing.Point(4, 25);
			this.t_co_workers.Name = "t_co_workers";
			this.t_co_workers.Padding = new System.Windows.Forms.Padding(3);
			this.t_co_workers.Size = new System.Drawing.Size(731, 465);
			this.t_co_workers.TabIndex = 3;
			this.t_co_workers.Text = "Сотрудники";
			this.t_co_workers.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.co_worker_address);
			this.groupBox4.Controls.Add(this.co_worker_passport_data);
			this.groupBox4.Controls.Add(this.co_worker_patronymic);
			this.groupBox4.Controls.Add(this.co_worker_name);
			this.groupBox4.Controls.Add(this.co_worker_surname);
			this.groupBox4.Controls.Add(this.co_worker_post);
			this.groupBox4.Controls.Add(this.co_worker_contact_phone_num);
			this.groupBox4.Controls.Add(this.co_worker_salary);
			this.groupBox4.Controls.Add(this.label27);
			this.groupBox4.Controls.Add(this.label26);
			this.groupBox4.Controls.Add(this.label25);
			this.groupBox4.Controls.Add(this.label24);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.btn_co_worker_del);
			this.groupBox4.Controls.Add(this.btn_co_worker_add);
			this.groupBox4.Controls.Add(this.btn_co_worker_change);
			this.groupBox4.Location = new System.Drawing.Point(425, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(300, 453);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			// 
			// co_worker_address
			// 
			this.co_worker_address.Location = new System.Drawing.Point(94, 128);
			this.co_worker_address.MaxLength = 50;
			this.co_worker_address.Name = "co_worker_address";
			this.co_worker_address.Size = new System.Drawing.Size(200, 21);
			this.co_worker_address.TabIndex = 7;
			// 
			// co_worker_passport_data
			// 
			this.co_worker_passport_data.Location = new System.Drawing.Point(154, 101);
			this.co_worker_passport_data.MaxLength = 10;
			this.co_worker_passport_data.Name = "co_worker_passport_data";
			this.co_worker_passport_data.Size = new System.Drawing.Size(140, 21);
			this.co_worker_passport_data.TabIndex = 6;
			// 
			// co_worker_patronymic
			// 
			this.co_worker_patronymic.Location = new System.Drawing.Point(94, 74);
			this.co_worker_patronymic.MaxLength = 30;
			this.co_worker_patronymic.Name = "co_worker_patronymic";
			this.co_worker_patronymic.Size = new System.Drawing.Size(200, 21);
			this.co_worker_patronymic.TabIndex = 5;
			// 
			// co_worker_name
			// 
			this.co_worker_name.Location = new System.Drawing.Point(94, 47);
			this.co_worker_name.MaxLength = 15;
			this.co_worker_name.Name = "co_worker_name";
			this.co_worker_name.Size = new System.Drawing.Size(200, 21);
			this.co_worker_name.TabIndex = 4;
			// 
			// co_worker_surname
			// 
			this.co_worker_surname.Location = new System.Drawing.Point(94, 20);
			this.co_worker_surname.MaxLength = 30;
			this.co_worker_surname.Name = "co_worker_surname";
			this.co_worker_surname.Size = new System.Drawing.Size(200, 21);
			this.co_worker_surname.TabIndex = 3;
			// 
			// co_worker_post
			// 
			this.co_worker_post.Location = new System.Drawing.Point(154, 182);
			this.co_worker_post.MaxLength = 50;
			this.co_worker_post.Name = "co_worker_post";
			this.co_worker_post.Size = new System.Drawing.Size(140, 21);
			this.co_worker_post.TabIndex = 9;
			// 
			// co_worker_contact_phone_num
			// 
			this.co_worker_contact_phone_num.Location = new System.Drawing.Point(154, 155);
			this.co_worker_contact_phone_num.MaxLength = 9;
			this.co_worker_contact_phone_num.Name = "co_worker_contact_phone_num";
			this.co_worker_contact_phone_num.Size = new System.Drawing.Size(140, 21);
			this.co_worker_contact_phone_num.TabIndex = 8;
			// 
			// co_worker_salary
			// 
			this.co_worker_salary.Location = new System.Drawing.Point(194, 209);
			this.co_worker_salary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.co_worker_salary.Name = "co_worker_salary";
			this.co_worker_salary.Size = new System.Drawing.Size(100, 21);
			this.co_worker_salary.TabIndex = 10;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(118, 209);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(70, 15);
			this.label27.TabIndex = 32;
			this.label27.Text = "Зарплата :";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(69, 182);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(79, 15);
			this.label26.TabIndex = 31;
			this.label26.Text = "Должность :";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(7, 158);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(141, 15);
			this.label25.TabIndex = 30;
			this.label25.Text = "Контактный телефон :";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(41, 128);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(47, 15);
			this.label24.TabIndex = 29;
			this.label24.Text = "Адрес :";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(15, 101);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(133, 15);
			this.label23.TabIndex = 28;
			this.label23.Text = "Паспортные данные :";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(19, 74);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(69, 15);
			this.label22.TabIndex = 27;
			this.label22.Text = "Отчество :";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(50, 47);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 15);
			this.label21.TabIndex = 26;
			this.label21.Text = "Имя :";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(20, 20);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 15);
			this.label20.TabIndex = 25;
			this.label20.Text = "Фамилия :";
			// 
			// btn_co_worker_del
			// 
			this.btn_co_worker_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_co_worker_del.Location = new System.Drawing.Point(219, 422);
			this.btn_co_worker_del.Name = "btn_co_worker_del";
			this.btn_co_worker_del.Size = new System.Drawing.Size(75, 25);
			this.btn_co_worker_del.TabIndex = 13;
			this.btn_co_worker_del.Text = "-";
			this.btn_co_worker_del.UseVisualStyleBackColor = true;
			// 
			// btn_co_worker_add
			// 
			this.btn_co_worker_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_co_worker_add.Location = new System.Drawing.Point(219, 391);
			this.btn_co_worker_add.Name = "btn_co_worker_add";
			this.btn_co_worker_add.Size = new System.Drawing.Size(75, 25);
			this.btn_co_worker_add.TabIndex = 12;
			this.btn_co_worker_add.Text = "+";
			this.btn_co_worker_add.UseVisualStyleBackColor = true;
			this.btn_co_worker_add.Click += new System.EventHandler(this.btn_co_worker_add_Click);
			// 
			// btn_co_worker_change
			// 
			this.btn_co_worker_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_co_worker_change.Location = new System.Drawing.Point(219, 360);
			this.btn_co_worker_change.Name = "btn_co_worker_change";
			this.btn_co_worker_change.Size = new System.Drawing.Size(75, 25);
			this.btn_co_worker_change.TabIndex = 11;
			this.btn_co_worker_change.Text = "изменить";
			this.btn_co_worker_change.UseVisualStyleBackColor = true;
			this.btn_co_worker_change.Click += new System.EventHandler(this.btn_co_worker_change_Click);
			// 
			// co_workers_list
			// 
			this.co_workers_list.AllowUserToAddRows = false;
			this.co_workers_list.AllowUserToDeleteRows = false;
			this.co_workers_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.co_workers_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.co_workers_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
			this.co_workers_list.Location = new System.Drawing.Point(6, 6);
			this.co_workers_list.Name = "co_workers_list";
			this.co_workers_list.ReadOnly = true;
			this.co_workers_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.co_workers_list.Size = new System.Drawing.Size(413, 453);
			this.co_workers_list.TabIndex = 20;
			this.co_workers_list.SelectionChanged += new System.EventHandler(this.showCo_worker);
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.HeaderText = "Код сотрудника";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn21.ReadOnly = true;
			this.dataGridViewTextBoxColumn21.Width = 130;
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn23.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn24.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn25
			// 
			this.dataGridViewTextBoxColumn25.HeaderText = "Пасп. данные";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn25.ReadOnly = true;
			this.dataGridViewTextBoxColumn25.Width = 125;
			// 
			// dataGridViewTextBoxColumn26
			// 
			this.dataGridViewTextBoxColumn26.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn26.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.HeaderText = "Контактный тел.";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn27.ReadOnly = true;
			this.dataGridViewTextBoxColumn27.Width = 130;
			// 
			// dataGridViewTextBoxColumn28
			// 
			this.dataGridViewTextBoxColumn28.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn28.ReadOnly = true;
			this.dataGridViewTextBoxColumn28.Width = 115;
			// 
			// dataGridViewTextBoxColumn29
			// 
			this.dataGridViewTextBoxColumn29.HeaderText = "Зарплата";
			this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
			this.dataGridViewTextBoxColumn29.ReadOnly = true;
			// 
			// t_rates
			// 
			this.t_rates.Controls.Add(this.groupBox5);
			this.t_rates.Controls.Add(this.rates_list);
			this.t_rates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.t_rates.Location = new System.Drawing.Point(4, 25);
			this.t_rates.Name = "t_rates";
			this.t_rates.Padding = new System.Windows.Forms.Padding(3);
			this.t_rates.Size = new System.Drawing.Size(731, 465);
			this.t_rates.TabIndex = 4;
			this.t_rates.Text = "Тарифы";
			this.t_rates.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.rate_validity);
			this.groupBox5.Controls.Add(this.rate_cost);
			this.groupBox5.Controls.Add(this.rate_notes);
			this.groupBox5.Controls.Add(this.rate_description);
			this.groupBox5.Controls.Add(this.rate_name);
			this.groupBox5.Controls.Add(this.label32);
			this.groupBox5.Controls.Add(this.label31);
			this.groupBox5.Controls.Add(this.label30);
			this.groupBox5.Controls.Add(this.label29);
			this.groupBox5.Controls.Add(this.label28);
			this.groupBox5.Controls.Add(this.btn_rate_del);
			this.groupBox5.Controls.Add(this.btn_rate_add);
			this.groupBox5.Controls.Add(this.btn_rate_change);
			this.groupBox5.Location = new System.Drawing.Point(425, 6);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(300, 453);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			// 
			// rate_validity
			// 
			this.rate_validity.Location = new System.Drawing.Point(162, 74);
			this.rate_validity.Name = "rate_validity";
			this.rate_validity.Size = new System.Drawing.Size(132, 21);
			this.rate_validity.TabIndex = 5;
			// 
			// rate_cost
			// 
			this.rate_cost.Location = new System.Drawing.Point(219, 101);
			this.rate_cost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.rate_cost.Name = "rate_cost";
			this.rate_cost.Size = new System.Drawing.Size(75, 21);
			this.rate_cost.TabIndex = 6;
			// 
			// rate_notes
			// 
			this.rate_notes.Location = new System.Drawing.Point(144, 128);
			this.rate_notes.MaxLength = 30;
			this.rate_notes.Name = "rate_notes";
			this.rate_notes.Size = new System.Drawing.Size(150, 21);
			this.rate_notes.TabIndex = 7;
			// 
			// rate_description
			// 
			this.rate_description.Location = new System.Drawing.Point(144, 47);
			this.rate_description.MaxLength = 50;
			this.rate_description.Name = "rate_description";
			this.rate_description.Size = new System.Drawing.Size(150, 21);
			this.rate_description.TabIndex = 4;
			// 
			// rate_name
			// 
			this.rate_name.Location = new System.Drawing.Point(144, 20);
			this.rate_name.MaxLength = 15;
			this.rate_name.Name = "rate_name";
			this.rate_name.Size = new System.Drawing.Size(150, 21);
			this.rate_name.TabIndex = 3;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(52, 128);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(86, 15);
			this.label32.TabIndex = 25;
			this.label32.Text = "Примечания :";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(135, 101);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(78, 15);
			this.label31.TabIndex = 25;
			this.label31.Text = "Стоимость :";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(3, 74);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(153, 15);
			this.label30.TabIndex = 25;
			this.label30.Text = "Дата окон. действия ТП :";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(68, 47);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(70, 15);
			this.label29.TabIndex = 25;
			this.label29.Text = "Описание :";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(37, 20);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(101, 15);
			this.label28.TabIndex = 25;
			this.label28.Text = "Наименование :";
			// 
			// btn_rate_del
			// 
			this.btn_rate_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rate_del.Location = new System.Drawing.Point(219, 422);
			this.btn_rate_del.Name = "btn_rate_del";
			this.btn_rate_del.Size = new System.Drawing.Size(75, 25);
			this.btn_rate_del.TabIndex = 10;
			this.btn_rate_del.Text = "-";
			this.btn_rate_del.UseVisualStyleBackColor = true;
			// 
			// btn_rate_add
			// 
			this.btn_rate_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rate_add.Location = new System.Drawing.Point(219, 391);
			this.btn_rate_add.Name = "btn_rate_add";
			this.btn_rate_add.Size = new System.Drawing.Size(75, 25);
			this.btn_rate_add.TabIndex = 9;
			this.btn_rate_add.Text = "+";
			this.btn_rate_add.UseVisualStyleBackColor = true;
			this.btn_rate_add.Click += new System.EventHandler(this.btn_rate_add_Click);
			// 
			// btn_rate_change
			// 
			this.btn_rate_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rate_change.Location = new System.Drawing.Point(219, 360);
			this.btn_rate_change.Name = "btn_rate_change";
			this.btn_rate_change.Size = new System.Drawing.Size(75, 25);
			this.btn_rate_change.TabIndex = 8;
			this.btn_rate_change.Text = "изменить";
			this.btn_rate_change.UseVisualStyleBackColor = true;
			this.btn_rate_change.Click += new System.EventHandler(this.btn_rate_change_Click);
			// 
			// rates_list
			// 
			this.rates_list.AllowUserToAddRows = false;
			this.rates_list.AllowUserToDeleteRows = false;
			this.rates_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rates_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rates_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
			this.rates_list.Location = new System.Drawing.Point(6, 6);
			this.rates_list.Name = "rates_list";
			this.rates_list.ReadOnly = true;
			this.rates_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.rates_list.Size = new System.Drawing.Size(413, 453);
			this.rates_list.TabIndex = 20;
			this.rates_list.SelectionChanged += new System.EventHandler(this.showRate);
			// 
			// dataGridViewTextBoxColumn31
			// 
			this.dataGridViewTextBoxColumn31.HeaderText = "Код тарифа";
			this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn31.ReadOnly = true;
			this.dataGridViewTextBoxColumn31.Width = 110;
			// 
			// dataGridViewTextBoxColumn32
			// 
			this.dataGridViewTextBoxColumn32.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
			this.dataGridViewTextBoxColumn32.ReadOnly = true;
			this.dataGridViewTextBoxColumn32.Width = 110;
			// 
			// dataGridViewTextBoxColumn33
			// 
			this.dataGridViewTextBoxColumn33.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
			this.dataGridViewTextBoxColumn33.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn34
			// 
			this.dataGridViewTextBoxColumn34.HeaderText = "Дата оконч.";
			this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn34.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn35
			// 
			this.dataGridViewTextBoxColumn35.HeaderText = "Стоимость";
			this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
			this.dataGridViewTextBoxColumn35.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn36
			// 
			this.dataGridViewTextBoxColumn36.HeaderText = "Примечания";
			this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
			this.dataGridViewTextBoxColumn36.ReadOnly = true;
			this.dataGridViewTextBoxColumn36.Width = 105;
			// 
			// t_coverage_areas
			// 
			this.t_coverage_areas.Controls.Add(this.groupBox6);
			this.t_coverage_areas.Controls.Add(this.coverage_areas_list);
			this.t_coverage_areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.t_coverage_areas.Location = new System.Drawing.Point(4, 25);
			this.t_coverage_areas.Name = "t_coverage_areas";
			this.t_coverage_areas.Padding = new System.Windows.Forms.Padding(3);
			this.t_coverage_areas.Size = new System.Drawing.Size(731, 465);
			this.t_coverage_areas.TabIndex = 5;
			this.t_coverage_areas.Text = "Покрытие";
			this.t_coverage_areas.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.num_house);
			this.groupBox6.Controls.Add(this.street);
			this.groupBox6.Controls.Add(this.district);
			this.groupBox6.Controls.Add(this.label35);
			this.groupBox6.Controls.Add(this.label34);
			this.groupBox6.Controls.Add(this.label33);
			this.groupBox6.Controls.Add(this.btn_coverage_area_del);
			this.groupBox6.Controls.Add(this.btn_coverage_area_add);
			this.groupBox6.Controls.Add(this.btn_coverage_area_change);
			this.groupBox6.Location = new System.Drawing.Point(425, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(300, 453);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			// 
			// num_house
			// 
			this.num_house.Location = new System.Drawing.Point(219, 74);
			this.num_house.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.num_house.Name = "num_house";
			this.num_house.Size = new System.Drawing.Size(75, 21);
			this.num_house.TabIndex = 5;
			// 
			// street
			// 
			this.street.Location = new System.Drawing.Point(94, 47);
			this.street.MaxLength = 30;
			this.street.Name = "street";
			this.street.Size = new System.Drawing.Size(200, 21);
			this.street.TabIndex = 4;
			// 
			// district
			// 
			this.district.Location = new System.Drawing.Point(94, 20);
			this.district.MaxLength = 30;
			this.district.Name = "district";
			this.district.Size = new System.Drawing.Size(200, 21);
			this.district.TabIndex = 3;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(128, 74);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(85, 15);
			this.label35.TabIndex = 25;
			this.label35.Text = "Номер дома :";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(39, 47);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(49, 15);
			this.label34.TabIndex = 25;
			this.label34.Text = "Улица :";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(39, 20);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(49, 15);
			this.label33.TabIndex = 25;
			this.label33.Text = "Район :";
			// 
			// btn_coverage_area_del
			// 
			this.btn_coverage_area_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_coverage_area_del.Location = new System.Drawing.Point(219, 422);
			this.btn_coverage_area_del.Name = "btn_coverage_area_del";
			this.btn_coverage_area_del.Size = new System.Drawing.Size(75, 25);
			this.btn_coverage_area_del.TabIndex = 8;
			this.btn_coverage_area_del.Text = "-";
			this.btn_coverage_area_del.UseVisualStyleBackColor = true;
			// 
			// btn_coverage_area_add
			// 
			this.btn_coverage_area_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_coverage_area_add.Location = new System.Drawing.Point(219, 391);
			this.btn_coverage_area_add.Name = "btn_coverage_area_add";
			this.btn_coverage_area_add.Size = new System.Drawing.Size(75, 25);
			this.btn_coverage_area_add.TabIndex = 7;
			this.btn_coverage_area_add.Text = "+";
			this.btn_coverage_area_add.UseVisualStyleBackColor = true;
			this.btn_coverage_area_add.Click += new System.EventHandler(this.btn_coverage_area_add_Click);
			// 
			// btn_coverage_area_change
			// 
			this.btn_coverage_area_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_coverage_area_change.Location = new System.Drawing.Point(219, 360);
			this.btn_coverage_area_change.Name = "btn_coverage_area_change";
			this.btn_coverage_area_change.Size = new System.Drawing.Size(75, 25);
			this.btn_coverage_area_change.TabIndex = 6;
			this.btn_coverage_area_change.Text = "изменить";
			this.btn_coverage_area_change.UseVisualStyleBackColor = true;
			this.btn_coverage_area_change.Click += new System.EventHandler(this.btn_coverage_area_change_Click);
			// 
			// coverage_areas_list
			// 
			this.coverage_areas_list.AllowUserToAddRows = false;
			this.coverage_areas_list.AllowUserToDeleteRows = false;
			this.coverage_areas_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coverage_areas_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.coverage_areas_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44});
			this.coverage_areas_list.Location = new System.Drawing.Point(6, 6);
			this.coverage_areas_list.Name = "coverage_areas_list";
			this.coverage_areas_list.ReadOnly = true;
			this.coverage_areas_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.coverage_areas_list.Size = new System.Drawing.Size(413, 453);
			this.coverage_areas_list.TabIndex = 20;
			this.coverage_areas_list.SelectionChanged += new System.EventHandler(this.showCoverage_area);
			// 
			// dataGridViewTextBoxColumn41
			// 
			this.dataGridViewTextBoxColumn41.HeaderText = "Код дома";
			this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn41.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn42
			// 
			this.dataGridViewTextBoxColumn42.HeaderText = "Район";
			this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
			this.dataGridViewTextBoxColumn42.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn43
			// 
			this.dataGridViewTextBoxColumn43.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn43.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn44
			// 
			this.dataGridViewTextBoxColumn44.HeaderText = "Номер дома";
			this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
			this.dataGridViewTextBoxColumn44.ReadOnly = true;
			this.dataGridViewTextBoxColumn44.Width = 110;
			// 
			// tab_sql_query
			// 
			this.tab_sql_query.Controls.Add(this.ResultsList);
			this.tab_sql_query.Controls.Add(this.groupBox);
			this.tab_sql_query.Location = new System.Drawing.Point(4, 27);
			this.tab_sql_query.Name = "tab_sql_query";
			this.tab_sql_query.Padding = new System.Windows.Forms.Padding(3);
			this.tab_sql_query.Size = new System.Drawing.Size(752, 507);
			this.tab_sql_query.TabIndex = 0;
			this.tab_sql_query.Text = "Запросы/Отчёт";
			this.tab_sql_query.UseVisualStyleBackColor = true;
			// 
			// ResultsList
			// 
			this.ResultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsList.Location = new System.Drawing.Point(7, 193);
			this.ResultsList.Multiline = true;
			this.ResultsList.Name = "ResultsList";
			this.ResultsList.Size = new System.Drawing.Size(739, 308);
			this.ResultsList.TabIndex = 3;
			// 
			// groupBox
			// 
			this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox.Controls.Add(this.btn_result_clear);
			this.groupBox.Controls.Add(this.btn_query_exec);
			this.groupBox.Controls.Add(this.tabQuery);
			this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox.Location = new System.Drawing.Point(6, 6);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(740, 180);
			this.groupBox.TabIndex = 0;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "SQL_запрос";
			// 
			// btn_result_clear
			// 
			this.btn_result_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_result_clear.Location = new System.Drawing.Point(602, 99);
			this.btn_result_clear.Name = "btn_result_clear";
			this.btn_result_clear.Size = new System.Drawing.Size(132, 60);
			this.btn_result_clear.TabIndex = 2;
			this.btn_result_clear.Text = "Очистить результаты поиска";
			this.btn_result_clear.UseVisualStyleBackColor = true;
			this.btn_result_clear.Click += new System.EventHandler(this.btn_result_clear_Click);
			// 
			// btn_query_exec
			// 
			this.btn_query_exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_query_exec.Location = new System.Drawing.Point(602, 48);
			this.btn_query_exec.Name = "btn_query_exec";
			this.btn_query_exec.Size = new System.Drawing.Size(132, 45);
			this.btn_query_exec.TabIndex = 1;
			this.btn_query_exec.Text = "Выполнение запроса";
			this.btn_query_exec.UseVisualStyleBackColor = true;
			this.btn_query_exec.Click += new System.EventHandler(this.btn_query_exec_Click);
			// 
			// tabQuery
			// 
			this.tabQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabQuery.Controls.Add(this.tab_query_1);
			this.tabQuery.Controls.Add(this.tab_query_2);
			this.tabQuery.Controls.Add(this.tab_query_3);
			this.tabQuery.Controls.Add(this.tab_query_4);
			this.tabQuery.Controls.Add(this.tab_query_5);
			this.tabQuery.Controls.Add(this.tab_query_6);
			this.tabQuery.Location = new System.Drawing.Point(7, 23);
			this.tabQuery.Name = "tabQuery";
			this.tabQuery.SelectedIndex = 0;
			this.tabQuery.Size = new System.Drawing.Size(589, 151);
			this.tabQuery.TabIndex = 0;
			this.tabQuery.SelectedIndexChanged += new System.EventHandler(this.tabQueryChanged);
			// 
			// tab_query_1
			// 
			this.tab_query_1.Controls.Add(this.comboBox_Query1);
			this.tab_query_1.Controls.Add(this.label37);
			this.tab_query_1.Controls.Add(this.label36);
			this.tab_query_1.Location = new System.Drawing.Point(4, 25);
			this.tab_query_1.Name = "tab_query_1";
			this.tab_query_1.Padding = new System.Windows.Forms.Padding(3);
			this.tab_query_1.Size = new System.Drawing.Size(581, 122);
			this.tab_query_1.TabIndex = 0;
			this.tab_query_1.Text = "Запрос 1";
			this.tab_query_1.UseVisualStyleBackColor = true;
			// 
			// comboBox_Query1
			// 
			this.comboBox_Query1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Query1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_Query1.FormattingEnabled = true;
			this.comboBox_Query1.Location = new System.Drawing.Point(255, 70);
			this.comboBox_Query1.Name = "comboBox_Query1";
			this.comboBox_Query1.Size = new System.Drawing.Size(220, 24);
			this.comboBox_Query1.TabIndex = 1;
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label37.Location = new System.Drawing.Point(6, 70);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(243, 20);
			this.label37.TabIndex = 0;
			this.label37.Text = "Выберите имя сотрудника :";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label36.Location = new System.Drawing.Point(6, 25);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(490, 20);
			this.label36.TabIndex = 0;
			this.label36.Text = "Просмотр договоров заключенных данным сотрудником";
			// 
			// tab_query_2
			// 
			this.tab_query_2.Controls.Add(this.comboBox_Query2);
			this.tab_query_2.Controls.Add(this.label38);
			this.tab_query_2.Controls.Add(this.label39);
			this.tab_query_2.Location = new System.Drawing.Point(4, 25);
			this.tab_query_2.Name = "tab_query_2";
			this.tab_query_2.Padding = new System.Windows.Forms.Padding(3);
			this.tab_query_2.Size = new System.Drawing.Size(581, 122);
			this.tab_query_2.TabIndex = 1;
			this.tab_query_2.Text = "Запрос 2";
			this.tab_query_2.UseVisualStyleBackColor = true;
			// 
			// comboBox_Query2
			// 
			this.comboBox_Query2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Query2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_Query2.FormattingEnabled = true;
			this.comboBox_Query2.Location = new System.Drawing.Point(355, 69);
			this.comboBox_Query2.Name = "comboBox_Query2";
			this.comboBox_Query2.Size = new System.Drawing.Size(220, 24);
			this.comboBox_Query2.TabIndex = 1;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label38.Location = new System.Drawing.Point(6, 70);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(347, 18);
			this.label38.TabIndex = 2;
			this.label38.Text = "Выберите имя предполагаемого пользователя :";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label39.Location = new System.Drawing.Point(6, 25);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(558, 20);
			this.label39.TabIndex = 3;
			this.label39.Text = "Проверка пользователя на нахождение его в зоне подключения";
			// 
			// tab_query_3
			// 
			this.tab_query_3.Controls.Add(this.comboBox_Query3);
			this.tab_query_3.Controls.Add(this.label40);
			this.tab_query_3.Controls.Add(this.label41);
			this.tab_query_3.Location = new System.Drawing.Point(4, 25);
			this.tab_query_3.Name = "tab_query_3";
			this.tab_query_3.Padding = new System.Windows.Forms.Padding(3);
			this.tab_query_3.Size = new System.Drawing.Size(581, 122);
			this.tab_query_3.TabIndex = 2;
			this.tab_query_3.Text = "Запрос 3";
			this.tab_query_3.UseVisualStyleBackColor = true;
			// 
			// comboBox_Query3
			// 
			this.comboBox_Query3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Query3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_Query3.FormattingEnabled = true;
			this.comboBox_Query3.Location = new System.Drawing.Point(276, 70);
			this.comboBox_Query3.Name = "comboBox_Query3";
			this.comboBox_Query3.Size = new System.Drawing.Size(220, 24);
			this.comboBox_Query3.TabIndex = 1;
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label40.Location = new System.Drawing.Point(6, 70);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(264, 20);
			this.label40.TabIndex = 2;
			this.label40.Text = "Выберите имя пользователя :";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label41.Location = new System.Drawing.Point(6, 25);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(467, 20);
			this.label41.TabIndex = 3;
			this.label41.Text = "Вывод списка всех денежных операций пользователя";
			// 
			// tab_query_4
			// 
			this.tab_query_4.Controls.Add(this.comboBox_Query4);
			this.tab_query_4.Controls.Add(this.label42);
			this.tab_query_4.Controls.Add(this.label43);
			this.tab_query_4.Location = new System.Drawing.Point(4, 25);
			this.tab_query_4.Name = "tab_query_4";
			this.tab_query_4.Padding = new System.Windows.Forms.Padding(3);
			this.tab_query_4.Size = new System.Drawing.Size(581, 122);
			this.tab_query_4.TabIndex = 3;
			this.tab_query_4.Text = "Запрос 4";
			this.tab_query_4.UseVisualStyleBackColor = true;
			// 
			// comboBox_Query4
			// 
			this.comboBox_Query4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Query4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_Query4.FormattingEnabled = true;
			this.comboBox_Query4.Location = new System.Drawing.Point(251, 70);
			this.comboBox_Query4.Name = "comboBox_Query4";
			this.comboBox_Query4.Size = new System.Drawing.Size(220, 24);
			this.comboBox_Query4.TabIndex = 1;
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
			this.label42.Location = new System.Drawing.Point(6, 70);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(239, 20);
			this.label42.TabIndex = 2;
			this.label42.Text = "Выберите имя пользователя :";
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
			this.label43.Location = new System.Drawing.Point(6, 25);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(542, 20);
			this.label43.TabIndex = 3;
			this.label43.Text = "Вывод списка денежных операций пользователя за последний месяц";
			// 
			// tab_query_5
			// 
			this.tab_query_5.Controls.Add(this.label44);
			this.tab_query_5.Controls.Add(this.label45);
			this.tab_query_5.Location = new System.Drawing.Point(4, 25);
			this.tab_query_5.Name = "tab_query_5";
			this.tab_query_5.Padding = new System.Windows.Forms.Padding(3);
			this.tab_query_5.Size = new System.Drawing.Size(581, 122);
			this.tab_query_5.TabIndex = 4;
			this.tab_query_5.Text = "Запрос 5";
			this.tab_query_5.UseVisualStyleBackColor = true;
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label44.Location = new System.Drawing.Point(6, 70);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(502, 20);
			this.label44.TabIndex = 1;
			this.label44.Text = "(В данном случае параметром выбирается текущая дата)";
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
			this.label45.Location = new System.Drawing.Point(6, 25);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(487, 20);
			this.label45.TabIndex = 2;
			this.label45.Text = "Вывод списка тарифов с не истекшим сроком действия";
			// 
			// tab_query_6
			// 
			this.tab_query_6.Controls.Add(this.comboBox_Query6);
			this.tab_query_6.Controls.Add(this.label46);
			this.tab_query_6.Controls.Add(this.label47);
			this.tab_query_6.Location = new System.Drawing.Point(4, 25);
			this.tab_query_6.Name = "tab_query_6";
			this.tab_query_6.Padding = new System.Windows.Forms.Padding(3);
			this.tab_query_6.Size = new System.Drawing.Size(581, 122);
			this.tab_query_6.TabIndex = 5;
			this.tab_query_6.Text = "Запрос 6";
			this.tab_query_6.UseVisualStyleBackColor = true;
			// 
			// comboBox_Query6
			// 
			this.comboBox_Query6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Query6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_Query6.FormattingEnabled = true;
			this.comboBox_Query6.Location = new System.Drawing.Point(290, 70);
			this.comboBox_Query6.Name = "comboBox_Query6";
			this.comboBox_Query6.Size = new System.Drawing.Size(220, 24);
			this.comboBox_Query6.TabIndex = 1;
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label46.Location = new System.Drawing.Point(6, 70);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(278, 18);
			this.label46.TabIndex = 2;
			this.label46.Text = "Выберите название тарифного плана :";
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label47.Location = new System.Drawing.Point(6, 25);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(529, 18);
			this.label47.TabIndex = 3;
			this.label47.Text = "Вывод списка пользователей подключенных к данному тарифному плану";
			// 
			// tabMain
			// 
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tab_sql_query);
			this.tabMain.Controls.Add(this.tab_edit);
			this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabMain.Location = new System.Drawing.Point(12, 12);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(760, 538);
			this.tabMain.TabIndex = 0;
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMainChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.tabMain);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "База данных интернет провайдера";
			this.tab_edit.ResumeLayout(false);
			this.tabTables.ResumeLayout(false);
			this.t_agreements.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_apartments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agreements_list)).EndInit();
			this.t_users.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.users_list)).EndInit();
			this.t_transactions.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transaction_amount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transactions_list)).EndInit();
			this.t_co_workers.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.co_worker_salary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.co_workers_list)).EndInit();
			this.t_rates.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rate_cost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rates_list)).EndInit();
			this.t_coverage_areas.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_house)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coverage_areas_list)).EndInit();
			this.tab_sql_query.ResumeLayout(false);
			this.tab_sql_query.PerformLayout();
			this.groupBox.ResumeLayout(false);
			this.tabQuery.ResumeLayout(false);
			this.tab_query_1.ResumeLayout(false);
			this.tab_query_1.PerformLayout();
			this.tab_query_2.ResumeLayout(false);
			this.tab_query_2.PerformLayout();
			this.tab_query_3.ResumeLayout(false);
			this.tab_query_3.PerformLayout();
			this.tab_query_4.ResumeLayout(false);
			this.tab_query_4.PerformLayout();
			this.tab_query_5.ResumeLayout(false);
			this.tab_query_5.PerformLayout();
			this.tab_query_6.ResumeLayout(false);
			this.tab_query_6.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tab_edit;
		private System.Windows.Forms.TabPage tab_sql_query;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.Button btn_query_exec;
		private System.Windows.Forms.TabControl tabQuery;
		private System.Windows.Forms.TabPage tab_query_1;
		private System.Windows.Forms.TabPage tab_query_2;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tab_query_3;
		private System.Windows.Forms.TabPage tab_query_4;
		private System.Windows.Forms.TabPage tab_query_5;
		private System.Windows.Forms.TabPage tab_query_6;
		private System.Windows.Forms.Button btn_result_clear;
		private System.Windows.Forms.TabControl tabTables;
		private System.Windows.Forms.TabPage t_agreements;
		private System.Windows.Forms.TabPage t_users;
		private System.Windows.Forms.ComboBox comboBox_Query1;
		private System.Windows.Forms.TabPage t_transactions;
		private System.Windows.Forms.TabPage t_co_workers;
		private System.Windows.Forms.TabPage t_rates;
		private System.Windows.Forms.TabPage t_coverage_areas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView agreements_list;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView users_list;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView transactions_list;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView co_workers_list;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGridView rates_list;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.DataGridView coverage_areas_list;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
		private System.Windows.Forms.Button btn_agreement_del;
		private System.Windows.Forms.Button btn_agreement_add;
		private System.Windows.Forms.Button btn_agreement_change;
		private System.Windows.Forms.ComboBox id_rate;
		private System.Windows.Forms.ComboBox id_co_worker;
		private System.Windows.Forms.DateTimePicker date_connection;
		private System.Windows.Forms.NumericUpDown num_apartments;
		private System.Windows.Forms.ComboBox id_coverage_area;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.NumericUpDown balance;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.ComboBox id_user;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox user_contact_phone_num;
		private System.Windows.Forms.TextBox user_address;
		private System.Windows.Forms.TextBox user_passport_data;
		private System.Windows.Forms.TextBox user_patronymic;
		private System.Windows.Forms.TextBox user_name;
		private System.Windows.Forms.TextBox user_surname;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_user_del;
		private System.Windows.Forms.Button btn_user_add;
		private System.Windows.Forms.Button иет_user_change;
		private System.Windows.Forms.Button btn_transaction_del;
		private System.Windows.Forms.Button btn_transaction_add;
		private System.Windows.Forms.Button btn_transaction_change;
		private System.Windows.Forms.Button btn_co_worker_del;
		private System.Windows.Forms.Button btn_co_worker_add;
		private System.Windows.Forms.Button btn_co_worker_change;
		private System.Windows.Forms.Button btn_rate_del;
		private System.Windows.Forms.Button btn_rate_add;
		private System.Windows.Forms.Button btn_rate_change;
		private System.Windows.Forms.Button btn_coverage_area_del;
		private System.Windows.Forms.Button btn_coverage_area_add;
		private System.Windows.Forms.Button btn_coverage_area_change;
		private System.Windows.Forms.DateTimePicker transaction_date;
		private System.Windows.Forms.NumericUpDown transaction_amount;
		private System.Windows.Forms.TextBox operation_type;
		private System.Windows.Forms.ComboBox id_agreement;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox co_worker_address;
		private System.Windows.Forms.TextBox co_worker_passport_data;
		private System.Windows.Forms.TextBox co_worker_patronymic;
		private System.Windows.Forms.TextBox co_worker_name;
		private System.Windows.Forms.TextBox co_worker_surname;
		private System.Windows.Forms.TextBox co_worker_post;
		private System.Windows.Forms.TextBox co_worker_contact_phone_num;
		private System.Windows.Forms.NumericUpDown co_worker_salary;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.DateTimePicker rate_validity;
		private System.Windows.Forms.NumericUpDown rate_cost;
		private System.Windows.Forms.TextBox rate_notes;
		private System.Windows.Forms.TextBox rate_description;
		private System.Windows.Forms.TextBox rate_name;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.NumericUpDown num_house;
		private System.Windows.Forms.TextBox street;
		private System.Windows.Forms.TextBox district;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.ComboBox comboBox_Query2;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.ComboBox comboBox_Query3;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.ComboBox comboBox_Query4;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.ComboBox comboBox_Query6;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.TextBox ResultsList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;

	}
}

