namespace KTMSInterfaceCoils
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
            this.frDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.jobList = new System.Windows.Forms.DataGridView();
            this.mASTERJOBNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTORERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fROMADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobOpenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJob = new KTMSInterfaceCoils.dsJob();
            this.tbSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMasterJob = new System.Windows.Forms.TextBox();
            this.tbTicket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSchTicket = new System.Windows.Forms.Button();
            this.tbTruck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCarrier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDriver = new System.Windows.Forms.TextBox();
            this.btSrhDriver = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTrantype = new System.Windows.Forms.TextBox();
            this.lbDriver = new System.Windows.Forms.Label();
            this.rbKDT = new System.Windows.Forms.RadioButton();
            this.rbKLCH = new System.Windows.Forms.RadioButton();
            this.cbStorer = new System.Windows.Forms.ComboBox();
            this.storerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStorer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOpenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // frDate
            // 
            this.frDate.Location = new System.Drawing.Point(98, 52);
            this.frDate.Name = "frDate";
            this.frDate.Size = new System.Drawing.Size(200, 20);
            this.frDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FROM DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TO DATE";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(396, 52);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 20);
            this.toDate.TabIndex = 3;
            // 
            // jobList
            // 
            this.jobList.AutoGenerateColumns = false;
            this.jobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASTERJOBNODataGridViewTextBoxColumn,
            this.jOBNODataGridViewTextBoxColumn,
            this.jOBDATEDataGridViewTextBoxColumn,
            this.jOBTYPEDataGridViewTextBoxColumn,
            this.sTORERNAMEDataGridViewTextBoxColumn,
            this.fROMADDRESSDataGridViewTextBoxColumn,
            this.tOADDRESSDataGridViewTextBoxColumn,
            this.tRANTYPEDataGridViewTextBoxColumn,
            this.jOBYEARDataGridViewTextBoxColumn});
            this.jobList.DataSource = this.jobOpenBindingSource;
            this.jobList.Location = new System.Drawing.Point(22, 127);
            this.jobList.Name = "jobList";
            this.jobList.Size = new System.Drawing.Size(798, 153);
            this.jobList.TabIndex = 4;
            this.jobList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.jobList_CellMouseClick);
            this.jobList.CurrentCellChanged += new System.EventHandler(this.jobList_CurrentCellChanged);
            // 
            // mASTERJOBNODataGridViewTextBoxColumn
            // 
            this.mASTERJOBNODataGridViewTextBoxColumn.DataPropertyName = "MASTER_JOBNO";
            this.mASTERJOBNODataGridViewTextBoxColumn.HeaderText = "MASTER_JOBNO";
            this.mASTERJOBNODataGridViewTextBoxColumn.Name = "mASTERJOBNODataGridViewTextBoxColumn";
            // 
            // jOBNODataGridViewTextBoxColumn
            // 
            this.jOBNODataGridViewTextBoxColumn.DataPropertyName = "JOBNO";
            this.jOBNODataGridViewTextBoxColumn.HeaderText = "JOBNO";
            this.jOBNODataGridViewTextBoxColumn.Name = "jOBNODataGridViewTextBoxColumn";
            // 
            // jOBDATEDataGridViewTextBoxColumn
            // 
            this.jOBDATEDataGridViewTextBoxColumn.DataPropertyName = "JOB_DATE";
            this.jOBDATEDataGridViewTextBoxColumn.HeaderText = "JOB_DATE";
            this.jOBDATEDataGridViewTextBoxColumn.Name = "jOBDATEDataGridViewTextBoxColumn";
            // 
            // jOBTYPEDataGridViewTextBoxColumn
            // 
            this.jOBTYPEDataGridViewTextBoxColumn.DataPropertyName = "JOB_TYPE";
            this.jOBTYPEDataGridViewTextBoxColumn.HeaderText = "JOB_TYPE";
            this.jOBTYPEDataGridViewTextBoxColumn.Name = "jOBTYPEDataGridViewTextBoxColumn";
            // 
            // sTORERNAMEDataGridViewTextBoxColumn
            // 
            this.sTORERNAMEDataGridViewTextBoxColumn.DataPropertyName = "STORER_NAME";
            this.sTORERNAMEDataGridViewTextBoxColumn.HeaderText = "STORER_NAME";
            this.sTORERNAMEDataGridViewTextBoxColumn.Name = "sTORERNAMEDataGridViewTextBoxColumn";
            // 
            // fROMADDRESSDataGridViewTextBoxColumn
            // 
            this.fROMADDRESSDataGridViewTextBoxColumn.DataPropertyName = "FROM_ADDRESS";
            this.fROMADDRESSDataGridViewTextBoxColumn.HeaderText = "FROM_ADDRESS";
            this.fROMADDRESSDataGridViewTextBoxColumn.Name = "fROMADDRESSDataGridViewTextBoxColumn";
            // 
            // tOADDRESSDataGridViewTextBoxColumn
            // 
            this.tOADDRESSDataGridViewTextBoxColumn.DataPropertyName = "TO_ADDRESS";
            this.tOADDRESSDataGridViewTextBoxColumn.HeaderText = "TO_ADDRESS";
            this.tOADDRESSDataGridViewTextBoxColumn.Name = "tOADDRESSDataGridViewTextBoxColumn";
            // 
            // tRANTYPEDataGridViewTextBoxColumn
            // 
            this.tRANTYPEDataGridViewTextBoxColumn.DataPropertyName = "TRAN_TYPE";
            this.tRANTYPEDataGridViewTextBoxColumn.HeaderText = "TRAN_TYPE";
            this.tRANTYPEDataGridViewTextBoxColumn.Name = "tRANTYPEDataGridViewTextBoxColumn";
            // 
            // jOBYEARDataGridViewTextBoxColumn
            // 
            this.jOBYEARDataGridViewTextBoxColumn.DataPropertyName = "JOB_YEAR";
            this.jOBYEARDataGridViewTextBoxColumn.HeaderText = "JOB_YEAR";
            this.jOBYEARDataGridViewTextBoxColumn.Name = "jOBYEARDataGridViewTextBoxColumn";
            // 
            // jobOpenBindingSource
            // 
            this.jobOpenBindingSource.DataMember = "JobOpen";
            this.jobOpenBindingSource.DataSource = this.dsJobBindingSource;
            // 
            // dsJobBindingSource
            // 
            this.dsJobBindingSource.DataSource = this.dsJob;
            this.dsJobBindingSource.Position = 0;
            // 
            // dsJob
            // 
            this.dsJob.DataSetName = "dsJob";
            this.dsJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(614, 51);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(75, 23);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.Text = "Search";
            this.tbSearch.UseVisualStyleBackColor = true;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MASTER JOBNO";
            // 
            // tbMasterJob
            // 
            this.tbMasterJob.Location = new System.Drawing.Point(119, 298);
            this.tbMasterJob.Name = "tbMasterJob";
            this.tbMasterJob.ReadOnly = true;
            this.tbMasterJob.Size = new System.Drawing.Size(100, 20);
            this.tbMasterJob.TabIndex = 7;
            // 
            // tbTicket
            // 
            this.tbTicket.Location = new System.Drawing.Point(119, 333);
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.Size = new System.Drawing.Size(100, 20);
            this.tbTicket.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TICKET";
            // 
            // btSchTicket
            // 
            this.btSchTicket.Location = new System.Drawing.Point(235, 331);
            this.btSchTicket.Name = "btSchTicket";
            this.btSchTicket.Size = new System.Drawing.Size(29, 23);
            this.btSchTicket.TabIndex = 10;
            this.btSchTicket.Text = "...";
            this.btSchTicket.UseVisualStyleBackColor = true;
            this.btSchTicket.Click += new System.EventHandler(this.btSchTicket_Click);
            // 
            // tbTruck
            // 
            this.tbTruck.Location = new System.Drawing.Point(119, 370);
            this.tbTruck.Name = "tbTruck";
            this.tbTruck.Size = new System.Drawing.Size(100, 20);
            this.tbTruck.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "TRUCK";
            // 
            // tbCarrier
            // 
            this.tbCarrier.Location = new System.Drawing.Point(302, 370);
            this.tbCarrier.Name = "tbCarrier";
            this.tbCarrier.Size = new System.Drawing.Size(100, 20);
            this.tbCarrier.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CARRIER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DRIVER";
            // 
            // tbDriver
            // 
            this.tbDriver.Location = new System.Drawing.Point(483, 369);
            this.tbDriver.Name = "tbDriver";
            this.tbDriver.Size = new System.Drawing.Size(100, 20);
            this.tbDriver.TabIndex = 16;
            // 
            // btSrhDriver
            // 
            this.btSrhDriver.Location = new System.Drawing.Point(598, 367);
            this.btSrhDriver.Name = "btSrhDriver";
            this.btSrhDriver.Size = new System.Drawing.Size(26, 23);
            this.btSrhDriver.TabIndex = 17;
            this.btSrhDriver.Text = "...";
            this.btSrhDriver.UseVisualStyleBackColor = true;
            this.btSrhDriver.Click += new System.EventHandler(this.btSrhDriver_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(119, 408);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(100, 23);
            this.btImport.TabIndex = 18;
            this.btImport.Text = "IMPORT TICKET";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "TYPE";
            // 
            // tbTrantype
            // 
            this.tbTrantype.Location = new System.Drawing.Point(304, 298);
            this.tbTrantype.Name = "tbTrantype";
            this.tbTrantype.ReadOnly = true;
            this.tbTrantype.Size = new System.Drawing.Size(100, 20);
            this.tbTrantype.TabIndex = 20;
            // 
            // lbDriver
            // 
            this.lbDriver.AutoSize = true;
            this.lbDriver.Location = new System.Drawing.Point(486, 408);
            this.lbDriver.Name = "lbDriver";
            this.lbDriver.Size = new System.Drawing.Size(0, 13);
            this.lbDriver.TabIndex = 21;
            // 
            // rbKDT
            // 
            this.rbKDT.AutoSize = true;
            this.rbKDT.Location = new System.Drawing.Point(22, 23);
            this.rbKDT.Name = "rbKDT";
            this.rbKDT.Size = new System.Drawing.Size(47, 17);
            this.rbKDT.TabIndex = 22;
            this.rbKDT.TabStop = true;
            this.rbKDT.Text = "KDT";
            this.rbKDT.UseVisualStyleBackColor = true;
            this.rbKDT.Click += new System.EventHandler(this.rbKDT_Click);
            // 
            // rbKLCH
            // 
            this.rbKLCH.AutoSize = true;
            this.rbKLCH.Location = new System.Drawing.Point(98, 23);
            this.rbKLCH.Name = "rbKLCH";
            this.rbKLCH.Size = new System.Drawing.Size(53, 17);
            this.rbKLCH.TabIndex = 23;
            this.rbKLCH.TabStop = true;
            this.rbKLCH.Text = "KLCH";
            this.rbKLCH.UseVisualStyleBackColor = true;
            this.rbKLCH.Click += new System.EventHandler(this.rbKLCH_Click);
            // 
            // cbStorer
            // 
            this.cbStorer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.storerBindingSource, "STORER_ID", true));
            this.cbStorer.DataSource = this.storerBindingSource;
            this.cbStorer.DisplayMember = "STORER_NAME";
            this.cbStorer.FormattingEnabled = true;
            this.cbStorer.Location = new System.Drawing.Point(98, 91);
            this.cbStorer.Name = "cbStorer";
            this.cbStorer.Size = new System.Drawing.Size(304, 21);
            this.cbStorer.TabIndex = 24;
            this.cbStorer.ValueMember = "STORER_ID";
            // 
            // storerBindingSource
            // 
            this.storerBindingSource.DataMember = "Storer";
            this.storerBindingSource.DataSource = this.dsJobBindingSource;
            // 
            // txtStorer
            // 
            this.txtStorer.AutoSize = true;
            this.txtStorer.Location = new System.Drawing.Point(22, 94);
            this.txtStorer.Name = "txtStorer";
            this.txtStorer.Size = new System.Drawing.Size(52, 13);
            this.txtStorer.TabIndex = 25;
            this.txtStorer.Text = "STORER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 524);
            this.Controls.Add(this.txtStorer);
            this.Controls.Add(this.cbStorer);
            this.Controls.Add(this.rbKLCH);
            this.Controls.Add(this.rbKDT);
            this.Controls.Add(this.lbDriver);
            this.Controls.Add(this.tbTrantype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btSrhDriver);
            this.Controls.Add(this.tbDriver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCarrier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTruck);
            this.Controls.Add(this.btSchTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.tbMasterJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.jobList);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frDate);
            this.Name = "Form1";
            this.Text = "KTMS Interface Coils -New";
            ((System.ComponentModel.ISupportInitialize)(this.jobList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobOpenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker frDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DataGridView jobList;
        private System.Windows.Forms.BindingSource dsJobBindingSource;
        private dsJob dsJob;
        private System.Windows.Forms.Button tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMasterJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSchTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCarrier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDriver;
        private System.Windows.Forms.Button btSrhDriver;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTrantype;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASTERJOBNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fROMADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jobOpenBindingSource;
        private System.Windows.Forms.TextBox tbTicket;
        private System.Windows.Forms.TextBox tbTruck;
        private System.Windows.Forms.Label lbDriver;
        private System.Windows.Forms.RadioButton rbKDT;
        private System.Windows.Forms.RadioButton rbKLCH;
        private System.Windows.Forms.ComboBox cbStorer;
        private System.Windows.Forms.Label txtStorer;
        private System.Windows.Forms.BindingSource storerBindingSource;
    }
}

