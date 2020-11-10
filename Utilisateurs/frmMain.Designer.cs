namespace Utilisateurs
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvUtilDept = new System.Windows.Forms.DataGridView();
			this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtNaissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.v_utildeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dl09_2DataSet = new Utilisateurs.dl09_2DataSet();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.lblIdDept = new System.Windows.Forms.Label();
			this.lblPrenom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDtNaiss = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.dtpDtNaiss = new System.Windows.Forms.DateTimePicker();
			this.cbxIdDept = new System.Windows.Forms.ComboBox();
			this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ckbxNull = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btActualiser = new System.Windows.Forms.Button();
			this.btSupprimer = new System.Windows.Forms.Button();
			this.btAjouter = new System.Windows.Forms.Button();
			this.v_utildeptTableAdapter = new Utilisateurs.dl09_2DataSetTableAdapters.v_utildeptTableAdapter();
			this.utilisateursTableAdapter = new Utilisateurs.dl09_2DataSetTableAdapters.utilisateursTableAdapter();
			this.departementsTableAdapter = new Utilisateurs.dl09_2DataSetTableAdapters.departementsTableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUtilDept)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v_utildeptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dl09_2DataSet)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dgvUtilDept, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 391);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// dgvUtilDept
			// 
			this.dgvUtilDept.AllowUserToAddRows = false;
			this.dgvUtilDept.AllowUserToDeleteRows = false;
			this.dgvUtilDept.AutoGenerateColumns = false;
			this.dgvUtilDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUtilDept.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvUtilDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUtilDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dtNaissDataGridViewTextBoxColumn,
            this.idDeptDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.idUtilDataGridViewTextBoxColumn});
			this.dgvUtilDept.DataSource = this.v_utildeptBindingSource;
			this.dgvUtilDept.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUtilDept.Location = new System.Drawing.Point(3, 3);
			this.dgvUtilDept.MultiSelect = false;
			this.dgvUtilDept.Name = "dgvUtilDept";
			this.dgvUtilDept.ReadOnly = true;
			this.dgvUtilDept.RowHeadersVisible = false;
			this.dgvUtilDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUtilDept.Size = new System.Drawing.Size(710, 222);
			this.dgvUtilDept.StandardTab = true;
			this.dgvUtilDept.TabIndex = 2;
			// 
			// nomDataGridViewTextBoxColumn
			// 
			this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
			this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
			this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
			this.nomDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// prenomDataGridViewTextBoxColumn
			// 
			this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
			this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
			this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
			this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dtNaissDataGridViewTextBoxColumn
			// 
			this.dtNaissDataGridViewTextBoxColumn.DataPropertyName = "DtNaiss";
			this.dtNaissDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
			this.dtNaissDataGridViewTextBoxColumn.Name = "dtNaissDataGridViewTextBoxColumn";
			this.dtNaissDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idDeptDataGridViewTextBoxColumn
			// 
			this.idDeptDataGridViewTextBoxColumn.DataPropertyName = "IdDept";
			this.idDeptDataGridViewTextBoxColumn.HeaderText = "IdDept";
			this.idDeptDataGridViewTextBoxColumn.Name = "idDeptDataGridViewTextBoxColumn";
			this.idDeptDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDeptDataGridViewTextBoxColumn.Visible = false;
			// 
			// libelleDataGridViewTextBoxColumn
			// 
			this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
			this.libelleDataGridViewTextBoxColumn.HeaderText = "Département";
			this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
			this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idUtilDataGridViewTextBoxColumn
			// 
			this.idUtilDataGridViewTextBoxColumn.DataPropertyName = "IdUtil";
			this.idUtilDataGridViewTextBoxColumn.HeaderText = "IdUtil";
			this.idUtilDataGridViewTextBoxColumn.Name = "idUtilDataGridViewTextBoxColumn";
			this.idUtilDataGridViewTextBoxColumn.ReadOnly = true;
			this.idUtilDataGridViewTextBoxColumn.Visible = false;
			// 
			// v_utildeptBindingSource
			// 
			this.v_utildeptBindingSource.DataMember = "v_utildept";
			this.v_utildeptBindingSource.DataSource = this.dl09_2DataSet;
			this.v_utildeptBindingSource.CurrentChanged += new System.EventHandler(this.v_utildeptBindingSource_CurrentChanged);
			// 
			// dl09_2DataSet
			// 
			this.dl09_2DataSet.DataSetName = "dl09_2DataSet";
			this.dl09_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.txtPrenom, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.lblIdDept, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.lblPrenom, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblDtNaiss, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.txtNom, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.dtpDtNaiss, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.cbxIdDept, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.ckbxNull, 2, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 231);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 105);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// txtPrenom
			// 
			this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_utildeptBindingSource, "Prenom", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPrenom.Location = new System.Drawing.Point(105, 29);
			this.txtPrenom.MaxLength = 100;
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(557, 20);
			this.txtPrenom.TabIndex = 6;
			// 
			// lblIdDept
			// 
			this.lblIdDept.AutoSize = true;
			this.lblIdDept.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblIdDept.Location = new System.Drawing.Point(3, 78);
			this.lblIdDept.Name = "lblIdDept";
			this.lblIdDept.Size = new System.Drawing.Size(96, 27);
			this.lblIdDept.TabIndex = 3;
			this.lblIdDept.Text = "Département";
			this.lblIdDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPrenom
			// 
			this.lblPrenom.AutoSize = true;
			this.lblPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPrenom.Location = new System.Drawing.Point(3, 26);
			this.lblPrenom.Name = "lblPrenom";
			this.lblPrenom.Size = new System.Drawing.Size(96, 26);
			this.lblPrenom.TabIndex = 2;
			this.lblPrenom.Text = "Prénom";
			this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nom";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDtNaiss
			// 
			this.lblDtNaiss.AutoSize = true;
			this.lblDtNaiss.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDtNaiss.Location = new System.Drawing.Point(3, 52);
			this.lblDtNaiss.Name = "lblDtNaiss";
			this.lblDtNaiss.Size = new System.Drawing.Size(96, 26);
			this.lblDtNaiss.TabIndex = 0;
			this.lblDtNaiss.Text = "Date de naissance";
			this.lblDtNaiss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNom
			// 
			this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_utildeptBindingSource, "Nom", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtNom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNom.Location = new System.Drawing.Point(105, 3);
			this.txtNom.MaxLength = 100;
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(557, 20);
			this.txtNom.TabIndex = 5;
			// 
			// dtpDtNaiss
			// 
			this.dtpDtNaiss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_utildeptBindingSource, "DtNaiss", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.dtpDtNaiss.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtpDtNaiss.Location = new System.Drawing.Point(105, 55);
			this.dtpDtNaiss.Name = "dtpDtNaiss";
			this.dtpDtNaiss.Size = new System.Drawing.Size(557, 20);
			this.dtpDtNaiss.TabIndex = 7;
			// 
			// cbxIdDept
			// 
			this.cbxIdDept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.v_utildeptBindingSource, "IdDept", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.cbxIdDept.DataSource = this.departementsBindingSource;
			this.cbxIdDept.DisplayMember = "Libelle";
			this.cbxIdDept.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbxIdDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxIdDept.FormattingEnabled = true;
			this.cbxIdDept.Location = new System.Drawing.Point(105, 81);
			this.cbxIdDept.MaxLength = 3;
			this.cbxIdDept.Name = "cbxIdDept";
			this.cbxIdDept.Size = new System.Drawing.Size(557, 21);
			this.cbxIdDept.TabIndex = 10;
			this.cbxIdDept.ValueMember = "IdDept";
			// 
			// departementsBindingSource
			// 
			this.departementsBindingSource.DataMember = "departements";
			this.departementsBindingSource.DataSource = this.dl09_2DataSet;
			// 
			// ckbxNull
			// 
			this.ckbxNull.AutoSize = true;
			this.ckbxNull.Location = new System.Drawing.Point(668, 83);
			this.ckbxNull.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.ckbxNull.Name = "ckbxNull";
			this.ckbxNull.Size = new System.Drawing.Size(42, 17);
			this.ckbxNull.TabIndex = 11;
			this.ckbxNull.Text = "null";
			this.ckbxNull.UseVisualStyleBackColor = true;
			this.ckbxNull.CheckedChanged += new System.EventHandler(this.ckbxNull_CheckedChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.btActualiser);
			this.flowLayoutPanel1.Controls.Add(this.btSupprimer);
			this.flowLayoutPanel1.Controls.Add(this.btAjouter);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 342);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 46);
			this.flowLayoutPanel1.TabIndex = 1;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// btActualiser
			// 
			this.btActualiser.Image = global::Utilisateurs.Properties.Resources.Actualiser;
			this.btActualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btActualiser.Location = new System.Drawing.Point(3, 3);
			this.btActualiser.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.btActualiser.Name = "btActualiser";
			this.btActualiser.Size = new System.Drawing.Size(98, 40);
			this.btActualiser.TabIndex = 0;
			this.btActualiser.Text = "&Actualiser";
			this.btActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btActualiser.UseVisualStyleBackColor = true;
			this.btActualiser.Click += new System.EventHandler(this.btActualiser_Click);
			// 
			// btSupprimer
			// 
			this.btSupprimer.Image = global::Utilisateurs.Properties.Resources.Supprimer;
			this.btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btSupprimer.Location = new System.Drawing.Point(134, 3);
			this.btSupprimer.Name = "btSupprimer";
			this.btSupprimer.Size = new System.Drawing.Size(98, 40);
			this.btSupprimer.TabIndex = 1;
			this.btSupprimer.Text = "&Supprimer";
			this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btSupprimer.UseVisualStyleBackColor = true;
			this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
			// 
			// btAjouter
			// 
			this.btAjouter.Image = global::Utilisateurs.Properties.Resources.Ajouter;
			this.btAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btAjouter.Location = new System.Drawing.Point(238, 3);
			this.btAjouter.Name = "btAjouter";
			this.btAjouter.Size = new System.Drawing.Size(98, 40);
			this.btAjouter.TabIndex = 2;
			this.btAjouter.Text = "A&jouter";
			this.btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btAjouter.UseVisualStyleBackColor = true;
			this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
			// 
			// v_utildeptTableAdapter
			// 
			this.v_utildeptTableAdapter.ClearBeforeFill = true;
			// 
			// utilisateursTableAdapter
			// 
			this.utilisateursTableAdapter.ClearBeforeFill = true;
			// 
			// departementsTableAdapter
			// 
			this.departementsTableAdapter.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(342, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "Modifier";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 391);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "frmMain";
			this.Text = "Utilisateurs";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUtilDept)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v_utildeptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dl09_2DataSet)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.DataGridView dgvUtilDept;
        private dl09_2DataSet dl09_2DataSet;
        private System.Windows.Forms.BindingSource v_utildeptBindingSource;
        private dl09_2DataSetTableAdapters.v_utildeptTableAdapter v_utildeptTableAdapter;
        private System.Windows.Forms.Button btSupprimer;
        private dl09_2DataSetTableAdapters.utilisateursTableAdapter utilisateursTableAdapter;
        private System.Windows.Forms.Button btAjouter;
        private dl09_2DataSetTableAdapters.departementsTableAdapter departementsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblIdDept;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDtNaiss;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpDtNaiss;
        private System.Windows.Forms.ComboBox cbxIdDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNaissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private System.Windows.Forms.CheckBox ckbxNull;
		private System.Windows.Forms.Button button1;
	}
}

