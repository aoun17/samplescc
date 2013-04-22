using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KTMSInterfaceCoils
{
    
    public partial class FrmDriver : Form
    {
        private Form1 _parent;
        public string Carrier { get { return carrier; } set { carrier = value; } }
        String carrier;
        String KTMSConn = "Provider=MSDAORA;Data Source=kwms;Persist Security Info=True;Password=ktms123;User ID=ktms";
        public FrmDriver()
        {
            InitializeComponent();
        }

        public FrmDriver(Form1 frm1) {
            InitializeComponent();
            _parent = frm1;

        }

        private void srhDrive_Click(object sender, EventArgs e)
        {
            dsJob.Driver.Clear();
            String drvStrComm1;
            try
            {
                OleDbConnection drvConn1 = new OleDbConnection(KTMSConn);
                drvConn1.Open();
                drvStrComm1 = "SELECT S.STAFF_CODE, S.FIRST_NAME, S.SURNAME LAST_NAME, S.CARRIER,STD.SHORT_NAME CARRIER_NAME " +
                              "FROM  STAFF_MST S, STORER ST, STORER_DISPLAY STD " +
                              "WHERE S.STATUS = 'ACTIVE' " +
                              "AND S.CARRIER = ST.STORER_ID " +
                              "AND ST.STORER_TYPE = 'CARRIER' " +
                              "AND ST.STORER_ID = STD.STORER_ID " +
                              "AND STD.DEFAULT_YN = 'Y' " +
                              "AND (S.FIRST_NAME LIKE'%" + tbDriverName.Text + "%' OR S.FIRST_NAME LIKE'" + tbDriverName.Text + "%')";
                //MessageBox.Show(drvStrComm1);

                OleDbCommand drvComm1 = new OleDbCommand(drvStrComm1, drvConn1);
                OleDbDataAdapter drvAdapt1 = new OleDbDataAdapter(drvComm1);
                drvAdapt1.Fill(dsJob, "Driver");
                driveList.DataSource = dsJob.Tables["Driver"];
                drvConn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void driveList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _parent.Carrier = driveList.CurrentRow.Cells[3].Value.ToString();
            _parent.Driver = driveList.CurrentRow.Cells[0].Value.ToString();
            _parent.DriverName = driveList.CurrentRow.Cells[1].Value.ToString() + " " + driveList.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }
    }
}
