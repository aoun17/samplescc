namespace KTMSInterfaceCoils
{
    partial class FrmDriver
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
            this.tbDriverName = new System.Windows.Forms.TextBox();
            this.lbDriveName = new System.Windows.Forms.Label();
            this.srhDrive = new System.Windows.Forms.Button();
            this.driveList = new System.Windows.Forms.DataGridView();
            this.dsJob = new KTMSInterfaceCoils.dsJob();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARRIERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARRIERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.driveList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDriverName
            // 
            this.tbDriverName.Location = new System.Drawing.Point(104, 12);
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Size = new System.Drawing.Size(208, 20);
            this.tbDriverName.TabIndex = 0;
            // 
            // lbDriveName
            // 
            this.lbDriveName.AutoSize = true;
            this.lbDriveName.Location = new System.Drawing.Point(11, 15);
            this.lbDriveName.Name = "lbDriveName";
            this.lbDriveName.Size = new System.Drawing.Size(87, 13);
            this.lbDriveName.TabIndex = 1;
            this.lbDriveName.Text = "ชื่อพนักงานขับรถ";
            // 
            // srhDrive
            // 
            this.srhDrive.Location = new System.Drawing.Point(334, 12);
            this.srhDrive.Name = "srhDrive";
            this.srhDrive.Size = new System.Drawing.Size(75, 23);
            this.srhDrive.TabIndex = 2;
            this.srhDrive.Text = "Search";
            this.srhDrive.UseVisualStyleBackColor = true;
            this.srhDrive.Click += new System.EventHandler(this.srhDrive_Click);
            // 
            // driveList
            // 
            this.driveList.AutoGenerateColumns = false;
            this.driveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTAFFCODEDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.cARRIERDataGridViewTextBoxColumn,
            this.cARRIERNAMEDataGridViewTextBoxColumn});
            this.driveList.DataSource = this.driverBindingSource;
            this.driveList.Location = new System.Drawing.Point(14, 50);
            this.driveList.Name = "driveList";
            this.driveList.Size = new System.Drawing.Size(670, 150);
            this.driveList.TabIndex = 3;
            this.driveList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.driveList_CellMouseDoubleClick);
            // 
            // dsJob
            // 
            this.dsJob.DataSetName = "dsJob";
            this.dsJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.dsJob;
            // 
            // sTAFFCODEDataGridViewTextBoxColumn
            // 
            this.sTAFFCODEDataGridViewTextBoxColumn.DataPropertyName = "STAFF_CODE";
            this.sTAFFCODEDataGridViewTextBoxColumn.HeaderText = "STAFF_CODE";
            this.sTAFFCODEDataGridViewTextBoxColumn.Name = "sTAFFCODEDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // cARRIERDataGridViewTextBoxColumn
            // 
            this.cARRIERDataGridViewTextBoxColumn.DataPropertyName = "CARRIER";
            this.cARRIERDataGridViewTextBoxColumn.HeaderText = "CARRIER";
            this.cARRIERDataGridViewTextBoxColumn.Name = "cARRIERDataGridViewTextBoxColumn";
            // 
            // cARRIERNAMEDataGridViewTextBoxColumn
            // 
            this.cARRIERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CARRIER_NAME";
            this.cARRIERNAMEDataGridViewTextBoxColumn.HeaderText = "CARRIER_NAME";
            this.cARRIERNAMEDataGridViewTextBoxColumn.Name = "cARRIERNAMEDataGridViewTextBoxColumn";
            // 
            // FrmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 343);
            this.Controls.Add(this.driveList);
            this.Controls.Add(this.srhDrive);
            this.Controls.Add(this.lbDriveName);
            this.Controls.Add(this.tbDriverName);
            this.Name = "FrmDriver";
            this.Text = "FrmDriver";
            ((System.ComponentModel.ISupportInitialize)(this.driveList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDriverName;
        private System.Windows.Forms.Label lbDriveName;
        private System.Windows.Forms.Button srhDrive;
        private System.Windows.Forms.DataGridView driveList;
        private dsJob dsJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARRIERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARRIERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource driverBindingSource;
    }
}