namespace KTMSInterfaceCoils
{
    partial class frmTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTicket = new System.Windows.Forms.TextBox();
            this.ticketList = new System.Windows.Forms.DataGridView();
            this.tICKETNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRUCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fROMADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nETWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROSSWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJob = new KTMSInterfaceCoils.dsJob();
            this.lbTranDate = new System.Windows.Forms.Label();
            this.tbTranDate = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.lbExist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TICKET NO";
            // 
            // tbTicket
            // 
            this.tbTicket.Location = new System.Drawing.Point(82, 6);
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.ReadOnly = true;
            this.tbTicket.Size = new System.Drawing.Size(100, 20);
            this.tbTicket.TabIndex = 1;
            // 
            // ticketList
            // 
            this.ticketList.AutoGenerateColumns = false;
            this.ticketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tICKETNODataGridViewTextBoxColumn,
            this.tRUCKDataGridViewTextBoxColumn,
            this.fROMADDRESSDataGridViewTextBoxColumn,
            this.tOADDRESSDataGridViewTextBoxColumn,
            this.rEFDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.sECTIONDataGridViewTextBoxColumn,
            this.nETWEIGHTDataGridViewTextBoxColumn,
            this.gROSSWEIGHTDataGridViewTextBoxColumn,
            this.tRANDATEDataGridViewTextBoxColumn});
            this.ticketList.DataSource = this.ticketBindingSource;
            this.ticketList.Location = new System.Drawing.Point(15, 32);
            this.ticketList.Name = "ticketList";
            this.ticketList.Size = new System.Drawing.Size(791, 217);
            this.ticketList.TabIndex = 2;
            // 
            // tICKETNODataGridViewTextBoxColumn
            // 
            this.tICKETNODataGridViewTextBoxColumn.DataPropertyName = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.HeaderText = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.Name = "tICKETNODataGridViewTextBoxColumn";
            // 
            // tRUCKDataGridViewTextBoxColumn
            // 
            this.tRUCKDataGridViewTextBoxColumn.DataPropertyName = "TRUCK";
            this.tRUCKDataGridViewTextBoxColumn.HeaderText = "TRUCK";
            this.tRUCKDataGridViewTextBoxColumn.Name = "tRUCKDataGridViewTextBoxColumn";
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
            // rEFDataGridViewTextBoxColumn
            // 
            this.rEFDataGridViewTextBoxColumn.DataPropertyName = "REF";
            this.rEFDataGridViewTextBoxColumn.HeaderText = "REF";
            this.rEFDataGridViewTextBoxColumn.Name = "rEFDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // sECTIONDataGridViewTextBoxColumn
            // 
            this.sECTIONDataGridViewTextBoxColumn.DataPropertyName = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.HeaderText = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.Name = "sECTIONDataGridViewTextBoxColumn";
            // 
            // nETWEIGHTDataGridViewTextBoxColumn
            // 
            this.nETWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "NET_WEIGHT";
            this.nETWEIGHTDataGridViewTextBoxColumn.HeaderText = "NET_WEIGHT";
            this.nETWEIGHTDataGridViewTextBoxColumn.Name = "nETWEIGHTDataGridViewTextBoxColumn";
            // 
            // gROSSWEIGHTDataGridViewTextBoxColumn
            // 
            this.gROSSWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "GROSS_WEIGHT";
            this.gROSSWEIGHTDataGridViewTextBoxColumn.HeaderText = "GROSS_WEIGHT";
            this.gROSSWEIGHTDataGridViewTextBoxColumn.Name = "gROSSWEIGHTDataGridViewTextBoxColumn";
            // 
            // tRANDATEDataGridViewTextBoxColumn
            // 
            this.tRANDATEDataGridViewTextBoxColumn.DataPropertyName = "TRAN_DATE";
            this.tRANDATEDataGridViewTextBoxColumn.HeaderText = "TRAN_DATE";
            this.tRANDATEDataGridViewTextBoxColumn.Name = "tRANDATEDataGridViewTextBoxColumn";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.dsJob;
            // 
            // dsJob
            // 
            this.dsJob.DataSetName = "dsJob";
            this.dsJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbTranDate
            // 
            this.lbTranDate.AutoSize = true;
            this.lbTranDate.Location = new System.Drawing.Point(207, 9);
            this.lbTranDate.Name = "lbTranDate";
            this.lbTranDate.Size = new System.Drawing.Size(50, 13);
            this.lbTranDate.TabIndex = 3;
            this.lbTranDate.Text = "Date Out";
            // 
            // tbTranDate
            // 
            this.tbTranDate.Location = new System.Drawing.Point(273, 6);
            this.tbTranDate.Name = "tbTranDate";
            this.tbTranDate.ReadOnly = true;
            this.tbTranDate.Size = new System.Drawing.Size(132, 20);
            this.tbTranDate.TabIndex = 4;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(368, 261);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 5;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // lbExist
            // 
            this.lbExist.AutoSize = true;
            this.lbExist.Location = new System.Drawing.Point(356, 266);
            this.lbExist.Name = "lbExist";
            this.lbExist.Size = new System.Drawing.Size(98, 13);
            this.lbExist.TabIndex = 6;
            this.lbExist.Text = "มีข้อมูลในระบบแล้ว";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 320);
            this.Controls.Add(this.lbExist);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.tbTranDate);
            this.Controls.Add(this.lbTranDate);
            this.Controls.Add(this.ticketList);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.label1);
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            ((System.ComponentModel.ISupportInitialize)(this.ticketList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicket;
        private System.Windows.Forms.DataGridView ticketList;
        private System.Windows.Forms.Label lbTranDate;
        private dsJob dsJob;
        private System.Windows.Forms.TextBox tbTranDate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fROMDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tICKETNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fROMADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROSSWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label lbExist;
    }
}