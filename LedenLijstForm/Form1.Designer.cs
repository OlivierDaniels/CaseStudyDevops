
namespace LedenLijstForm
{
    partial class Form1
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
            System.Windows.Forms.Label voornaamLabel;
            System.Windows.Forms.Label achternaamLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label geslachtLabel;
            System.Windows.Forms.Label takLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet = new LedenLijstForm.ModelDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.achternaamTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.geslachtCheckBox = new System.Windows.Forms.CheckBox();
            this.takTextBox = new System.Windows.Forms.TextBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTableAdapter = new LedenLijstForm.ModelDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new LedenLijstForm.ModelDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZonsondergangResult = new System.Windows.Forms.Label();
            this.ZonsopgangResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WindsnelheidResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LuchtdrukResult = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.DetailsResult = new System.Windows.Forms.Label();
            this.ToestandResult = new System.Windows.Forms.Label();
            voornaamLabel = new System.Windows.Forms.Label();
            achternaamLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            geslachtLabel = new System.Windows.Forms.Label();
            takLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // voornaamLabel
            // 
            voornaamLabel.AutoSize = true;
            voornaamLabel.Location = new System.Drawing.Point(12, 48);
            voornaamLabel.Name = "voornaamLabel";
            voornaamLabel.Size = new System.Drawing.Size(77, 17);
            voornaamLabel.TabIndex = 3;
            voornaamLabel.Text = "Voornaam:";
            // 
            // achternaamLabel
            // 
            achternaamLabel.AutoSize = true;
            achternaamLabel.Location = new System.Drawing.Point(12, 76);
            achternaamLabel.Name = "achternaamLabel";
            achternaamLabel.Size = new System.Drawing.Size(88, 17);
            achternaamLabel.TabIndex = 5;
            achternaamLabel.Text = "Achternaam:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(12, 162);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(49, 17);
            adresLabel.TabIndex = 7;
            adresLabel.Text = "Adres:";
            // 
            // geslachtLabel
            // 
            geslachtLabel.AutoSize = true;
            geslachtLabel.Location = new System.Drawing.Point(12, 106);
            geslachtLabel.Name = "geslachtLabel";
            geslachtLabel.Size = new System.Drawing.Size(68, 17);
            geslachtLabel.TabIndex = 9;
            geslachtLabel.Text = "Geslacht:";
            // 
            // takLabel
            // 
            takLabel.AutoSize = true;
            takLabel.Location = new System.Drawing.Point(12, 134);
            takLabel.Name = "takLabel";
            takLabel.Size = new System.Drawing.Size(36, 17);
            takLabel.TabIndex = 11;
            takLabel.Text = "Tak:";
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(817, 31);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.modelDataSet;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Voornaam", true));
            this.voornaamTextBox.Location = new System.Drawing.Point(106, 45);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(195, 22);
            this.voornaamTextBox.TabIndex = 4;
            // 
            // achternaamTextBox
            // 
            this.achternaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Achternaam", true));
            this.achternaamTextBox.Location = new System.Drawing.Point(106, 73);
            this.achternaamTextBox.Name = "achternaamTextBox";
            this.achternaamTextBox.Size = new System.Drawing.Size(195, 22);
            this.achternaamTextBox.TabIndex = 6;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(106, 159);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(195, 65);
            this.adresTextBox.TabIndex = 8;
            // 
            // geslachtCheckBox
            // 
            this.geslachtCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Geslacht", true));
            this.geslachtCheckBox.Location = new System.Drawing.Point(106, 101);
            this.geslachtCheckBox.Name = "geslachtCheckBox";
            this.geslachtCheckBox.Size = new System.Drawing.Size(137, 24);
            this.geslachtCheckBox.TabIndex = 10;
            this.geslachtCheckBox.Text = "Kies geslacht";
            this.geslachtCheckBox.UseVisualStyleBackColor = true;
            this.geslachtCheckBox.CheckedChanged += new System.EventHandler(this.geslachtCheckBox_CheckedChanged);
            // 
            // takTextBox
            // 
            this.takTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Tak", true));
            this.takTextBox.Location = new System.Drawing.Point(106, 131);
            this.takTextBox.Name = "takTextBox";
            this.takTextBox.Size = new System.Drawing.Size(104, 22);
            this.takTextBox.TabIndex = 12;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(12, 243);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersWidth = 51;
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(788, 220);
            this.tableDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Voornaam";
            this.dataGridViewTextBoxColumn2.HeaderText = "Voornaam";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Achternaam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Achternaam";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Geslacht";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Geslacht";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tak";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tak";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = LedenLijstForm.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(457, 45);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 14;
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(626, 41);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 23);
            this.btnZoeken.TabIndex = 15;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Toestand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Zonsopgang:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Zonsondergang:";
            // 
            // ZonsondergangResult
            // 
            this.ZonsondergangResult.AutoSize = true;
            this.ZonsondergangResult.Location = new System.Drawing.Point(483, 173);
            this.ZonsondergangResult.Name = "ZonsondergangResult";
            this.ZonsondergangResult.Size = new System.Drawing.Size(31, 17);
            this.ZonsondergangResult.TabIndex = 20;
            this.ZonsondergangResult.Text = "N/A";
            // 
            // ZonsopgangResult
            // 
            this.ZonsopgangResult.AutoSize = true;
            this.ZonsopgangResult.Location = new System.Drawing.Point(483, 147);
            this.ZonsopgangResult.Name = "ZonsopgangResult";
            this.ZonsopgangResult.Size = new System.Drawing.Size(31, 17);
            this.ZonsopgangResult.TabIndex = 21;
            this.ZonsopgangResult.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Windsnelheid:";
            // 
            // WindsnelheidResult
            // 
            this.WindsnelheidResult.AutoSize = true;
            this.WindsnelheidResult.Location = new System.Drawing.Point(648, 92);
            this.WindsnelheidResult.Name = "WindsnelheidResult";
            this.WindsnelheidResult.Size = new System.Drawing.Size(31, 17);
            this.WindsnelheidResult.TabIndex = 23;
            this.WindsnelheidResult.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Luchtdruk:";
            // 
            // LuchtdrukResult
            // 
            this.LuchtdrukResult.AutoSize = true;
            this.LuchtdrukResult.Location = new System.Drawing.Point(648, 119);
            this.LuchtdrukResult.Name = "LuchtdrukResult";
            this.LuchtdrukResult.Size = new System.Drawing.Size(31, 17);
            this.LuchtdrukResult.TabIndex = 25;
            this.LuchtdrukResult.Text = "N/A";
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(570, 159);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 50);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 26;
            this.pbIcon.TabStop = false;
            // 
            // DetailsResult
            // 
            this.DetailsResult.AutoSize = true;
            this.DetailsResult.Location = new System.Drawing.Point(483, 119);
            this.DetailsResult.Name = "DetailsResult";
            this.DetailsResult.Size = new System.Drawing.Size(31, 17);
            this.DetailsResult.TabIndex = 27;
            this.DetailsResult.Text = "N/A";
            // 
            // ToestandResult
            // 
            this.ToestandResult.AutoSize = true;
            this.ToestandResult.Location = new System.Drawing.Point(483, 92);
            this.ToestandResult.Name = "ToestandResult";
            this.ToestandResult.Size = new System.Drawing.Size(31, 17);
            this.ToestandResult.TabIndex = 28;
            this.ToestandResult.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 508);
            this.Controls.Add(this.ToestandResult);
            this.Controls.Add(this.DetailsResult);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.LuchtdrukResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.WindsnelheidResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ZonsopgangResult);
            this.Controls.Add(this.ZonsondergangResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(voornaamLabel);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(achternaamLabel);
            this.Controls.Add(this.achternaamTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(geslachtLabel);
            this.Controls.Add(this.geslachtCheckBox);
            this.Controls.Add(takLabel);
            this.Controls.Add(this.takTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledenlijst";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ModelDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.TextBox achternaamTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.CheckBox geslachtCheckBox;
        private System.Windows.Forms.TextBox takTextBox;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ZonsondergangResult;
        private System.Windows.Forms.Label ZonsopgangResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label WindsnelheidResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LuchtdrukResult;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label DetailsResult;
        private System.Windows.Forms.Label ToestandResult;
    }
}

