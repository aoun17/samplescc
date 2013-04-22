using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace KTMSInterfaceCoils
{
    public partial class Form1 : Form
    {
        public string Ticket { get { return tbTicket.Text; } set { tbTicket.Text = value; } }
        public string Truck { get { return tbTruck.Text; } set { tbTruck.Text = value; } }
        public string DriverName { get { return lbDriver.Text; } set { lbDriver.Text = value; } }
        public string Carrier { get { return tbCarrier.Text; } set { tbCarrier.Text = value; } }
        public string Driver { get { return tbDriver.Text; } set { tbDriver.Text = value; } }
        public string maxDO { get { return maxdo; } set { maxdo = value; } }

        String maxdo;
        String strConn;
        String strSteelCoilStorer = "SELECT DISTINCT jm.storer_id, (SELECT short_name FROM STORER_DISPLAY sd WHERE storer_id = jm.STORER_ID) storer_name " +
                                    "FROM JOB_MST jm, JOB_SKU js " +
                                    "WHERE jm.master_jobno = js.master_jobno " +
                                    "AND UPPER(js.sku_desc) IN('STEEL COIL', 'STEEL COILS') ";
        //String CoilConn = "Data Source=172.25.50.22;Initial Catalog=KERRYCOILDB;Persist Security Info=True;User ID=sa;Password=sql";
        String CoilConn = "Provider=MSDAORA;Data Source=kwmsthkssp.kerrylogistics.com;Persist Security Info=True;Password=v1ew5ssp;User ID=kwmsreadonly";
        public Form1()
        {
            InitializeComponent();
            rbKDT.Checked = true;
            strConn = "Provider=MSDAORA;Data Source=kwms;Persist Security Info=True;Password=ktms123;User ID=ktms";

            //-------- Initail storer ------------
            OleDbConnection oleConnStorer = new OleDbConnection(strConn);
            oleConnStorer.Open();
            OleDbCommand oleCommStorer = new OleDbCommand(strSteelCoilStorer, oleConnStorer);
            OleDbDataAdapter oleAdaptStorer = new OleDbDataAdapter(oleCommStorer);

            oleAdaptStorer.Fill(dsJob, "Storer");
            cbStorer.DataSource = dsJob.Tables["Storer"];
            oleConnStorer.Close();
            //------------------------------------
        }


        private void tbSearch_Click(object sender, EventArgs e)
        {
            dsJob.JobOpen.Clear();
            try
            {
                OleDbConnection oleConn1 = new OleDbConnection(strConn);
                oleConn1.Open();
                String StrComm1 = "SELECT M.MASTER_JOBNO, H.JOBNO, M.JOB_DATE, H.JOB_TYPE, " +
                                  "(SELECT STD.SHORT_NAME FROM STORER_DISPLAY STD WHERE STD.STORER_ID = M.STORER_ID AND STD.DEFAULT_YN='Y') STORER_NAME, " +
                                  "H.FR_ADDRESS_NAME FROM_ADDRESS, " +
                                  "H.TO_ADDRESS_NAME TO_ADDRESS, " +
                                  "(CASE WHEN M.STORER_ID ='T0000072' THEN 'OUT' ELSE 'IN' END) TRAN_TYPE, " +
                                  "TO_CHAR(H.JOB_DATE, 'YYYY') JOB_YEAR " +
                                  "FROM JOB_MST M, JOB_HDR H " +
                                  "WHERE M.MASTER_JOBNO  = H.MASTER_JOBNO " +
                                  "AND H.JOBNO = '1' " +
                                  "AND H.STATUS = 'OPEN' " +
                                  "AND H.JOB_TYPE='LTL' " +
                                  //"AND M.STORER_ID IN('T0000072', 'K0000024', 'K00000057') " +
                                  "AND M.JOB_DATE BETWEEN TO_DATE('" + frDate.Value.ToShortDateString() + "', 'DD/MM/YYYY') AND TO_DATE('" + toDate.Value.ToShortDateString() + "','DD/MM/YYYY') " +
                                  "AND M.STORER_ID ='" + cbStorer.SelectedValue.ToString() + "' " +
                                  "ORDER BY M.JOB_DATE";

                //MessageBox.Show(StrComm1.ToString());
                OleDbCommand oleComm1 = new OleDbCommand(StrComm1, oleConn1);
                OleDbDataAdapter oleAdapt1 = new OleDbDataAdapter(oleComm1);

                oleAdapt1.Fill(dsJob, "JobOpen");
                jobList.DataSource = dsJob.Tables["JobOpen"];
                oleConn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void jobList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //tbMasterJob.Text = jobList.CurrentRow.Cells[0].Value.ToString();
            //tbTrantype.Text = jobList.CurrentRow.Cells[7].Value.ToString();
        }

        private void btSchTicket_Click(object sender, EventArgs e)
        {
            if (tbTicket.Text != "" && tbMasterJob.Text != "")
            {
                frmTicket frm_ticket = new frmTicket(tbTicket.Text, jobList.CurrentRow.Cells[7].Value.ToString(), jobList.CurrentRow.Cells[8].Value.ToString(), this);
                frm_ticket.Show();
            }
            else
            {
                MessageBox.Show("Please tpye ticket no");
            }
        }

        public void settbTicket(String ticket)
        {
            tbTicket.Text = ticket;

        }

        public void settbTruck(String truck)
        {
            tbTruck.Text = truck;

        }

        public void showMsg(String ticket, String truck)
        {
            MessageBox.Show("Call form form2 : Ticket = " + ticket + ", Truck = " + truck);


        }

        private void btSrhDriver_Click(object sender, EventArgs e)
        {
            FrmDriver frm_driver = new FrmDriver(this);
            frm_driver.Carrier = tbCarrier.Text;
            frm_driver.Show();
        }

        private void btImport_Click(object sender, EventArgs e)
        {

            MaxDO(tbMasterJob.Text);
            MessageBox.Show(maxdo.ToString());
            int maxJob = int.Parse(maxdo);
            //MessageBox.Show(maxJob.ToString());
            try
            {
                OleDbConnection ktmsConn = new OleDbConnection(strConn);
                ktmsConn.Open();

                if (maxJob > 1) {
                     //maxJob += 1;
                    // Assign SQL Statement for insert job_hdr, job_dt, job_hdr_ref

                    String strInsertHead = "INSERT INTO JOB_HDR(MASTER_JOBNO, JOBNO, HD_LINE_SEQ, JOB_DATE, JOB_TYPE, TRIP_TYPE, CARGO_TYPE, TARIFF_ID, " +
                                           "FR_ADDRESS_ID, FR_ADDRESS_NAME, FR_LOC_ID, FR_ZONE_ID, TO_ADDRESS_ID,  TO_ADDRESS_NAME, TO_LOC_ID, TO_ZONE_ID, CARRIER, " +
                                           "TRUCK_REG,TRAILER, NO_OF_DRIVER, DELIVERY_TIME_OPT, DELIVERY_TIME, DELIVERY_TIME_TO, STATUS,SPECIAL_INSTRUCTION, REMARK, CREATE_BY, CREATE_DATE) " +
                                           "SELECT MASTER_JOBNO, '" + maxJob.ToString() + "' JOBNO, '" + maxJob.ToString() + "' HD_LINE_SEQ, JOB_DATE, JOB_TYPE, TRIP_TYPE, CARGO_TYPE, " +
                                           "TARIFF_ID, FR_ADDRESS_ID, FR_ADDRESS_NAME, FR_LOC_ID, FR_ZONE_ID, TO_ADDRESS_ID, TO_ADDRESS_NAME, TO_LOC_ID, TO_ZONE_ID, '" + tbCarrier.Text + "' CARRIER, '" + tbTruck.Text + "' TRUCK_REG, " +
                                           "TRAILER, NO_OF_DRIVER, DELIVERY_TIME_OPT, DELIVERY_TIME, DELIVERY_TIME_TO, 'OPEN' STATUS,SPECIAL_INSTRUCTION, REMARK, 'optweb' CREATE_BY, SYSDATE CREATE_DATE " +
                                           "FROM JOB_HDR  WHERE MASTER_JOBNO='" + tbMasterJob.Text + "' AND JOBNO='1'";


                    String strInsertDT  = "INSERT INTO JOB_DT(MASTER_JOBNO, JOBNO, HD_LINE_SEQ, DT_LINE_SEQ, PICKUP_DELIVERY, STATUS, BOOK_REF, CREATE_BY, CREATE_DATE) " +
                                          "SELECT MASTER_JOBNO, '" + maxJob.ToString() + "' JOBNO, '" + maxJob.ToString() + "' HD_LINE_SEQ, '1' DT_LINE_SEQ, PICKUP_DELIVERY, 'OPEN', '" + tbTicket.Text + "' BOOK_REF, 'optweb' CREATE_BY, SYSDATE CREATE_DATE " +
                                          "FROM JOB_DT WHERE MASTER_JOBNO='" + tbMasterJob.Text + "' AND JOBNO='1' AND HD_LINE_SEQ='1' AND DT_LINE_SEQ='1'";
                                         
    		        
                    String strInsertRef = "INSERT INTO JOB_HDR_REF(MASTER_JOBNO, JOBNO, HD_LINE_SEQ, LINE_SEQ, STORER_ID, REF_NO, REF_TYPE, REF_DESC, CREATE_BY, CREATE_DATE) " +
                                          " SELECT MASTER_JOBNO, '" + maxJob.ToString() + "' JOBNO, '" + maxJob.ToString() + "' AS HD_LINE_SEQ, LINE_SEQ, STORER_ID, REF_NO, REF_TYPE, REF_DESC, 'optweb' CREATE_BY, SYSDATE CREATE_DATE " +
		                                  "FROM JOB_HDR_REF WHERE MASTER_JOBNO='" + tbMasterJob.Text + "' AND JOBNO='1' AND HD_LINE_SEQ='1'";


                    String strInsertDriver = "INSERT INTO JOB_DRIVER(MASTER_JOBNO, JOBNO, HD_SEQ_LINE, CARRIER, DRIVER, CREATE_BY, CREATE_DATE) " +
		                                    "SELECT MASTER_JOBNO, '" + maxJob.ToString() + "' AS JOBNO, '" + maxJob.ToString() + "' AS HD_SEQ_LINE, '" + tbCarrier.Text + "' AS CARRIER, '" + tbDriver.Text + "' AS DRIVER, 'optweb' AS CREATE_BY, SYSDATE AS CREATE_DATE " +
		                                    "FROM JOB_DRIVER WHERE MASTER_JOBNO='" + tbMasterJob.Text + "' AND JOBNO='1' AND HD_SEQ_LINE='1'";

                    //----------------------------------------------------------------


                        // insert data to job_hdr, job_dt, job_hdr_ref
                        OleDbCommand insertHdrComm = new OleDbCommand(strInsertHead, ktmsConn);
                        OleDbCommand insertDTComm = new OleDbCommand(strInsertDT, ktmsConn);
                        OleDbCommand insertRefComm = new OleDbCommand(strInsertRef, ktmsConn);
                        OleDbCommand insertDriverComm = new OleDbCommand(strInsertDriver, ktmsConn);

                        /*MessageBox.Show(strInsertHead);
                        MessageBox.Show(strInsertDT);
                        MessageBox.Show(strInsertRef);
                        MessageBox.Show(strInsertDriver);*/

                        insertHdrComm.ExecuteNonQuery();
                        insertDTComm.ExecuteNonQuery();
                        insertRefComm.ExecuteNonQuery();
                        insertDriverComm.ExecuteNonQuery();

                        

                        //---------------------------------------------------

                        insertSKU(tbMasterJob.Text, tbTrantype.Text, tbTicket.Text, jobList.CurrentRow.Cells[8].Value.ToString(), maxJob);
                    //MessageBox.Show("New Job : " + maxJob.ToString());
                }
                else { 

                    String strUpdHeader = "UPDATE JOB_HDR SET CARRIER='" + tbCarrier.Text + "', TRUCK_REG='" + tbTruck.Text + "', NO_OF_DRIVER = 1, MODIFY_BY= 'optweb' , MODIFY_DATE = SYSDATE " +
                                          "WHERE MASTER_JOBNO='" + tbMasterJob.Text + "' AND JOBNO='1'";

                    /*$sqlJob = "UPDATE KTMS_JOB_HDR SET CARRIER='$carrier', TRUCK_REG='$truck', NO_OF_DRIVER = 1, MODIFY_BY= 'optweb' , MODIFY_DATE = now()";
		            $sqlJob = $sqlJob." WHERE MASTER_JOBNO='$mst_job' AND JOBNO='1'";*/

                    String strUpdDt = "UPDATE JOB_DT SET BOOK_REF='" + tbTicket.Text + "', MODIFY_BY='optweb', MODIFY_DATE = SYSDATE " +
                                      "WHERE MASTER_JOBNO='"+ tbMasterJob.Text + "' AND JOBNO='1' AND HD_LINE_SEQ='1' AND DT_LINE_SEQ='1'";

                    /*$sqlDetail = "UPDATE KTMS_JOB_DT SET BOOK_REF='$tkNo', MODIFY_BY='optweb', MODIFY_DATE = now()";
		            $sqlDetail = $sqlDetail." WHERE MASTER_JOBNO='$mst_job' AND JOBNO='1' AND HD_LINE_SEQ='1' AND DT_LINE_SEQ='1'";*/

                    String strInsertDriver = "INSERT INTO JOB_DRIVER(MASTER_JOBNO, JOBNO, HD_SEQ_LINE, CARRIER, DRIVER, CREATE_BY, CREATE_DATE) " +
                                             "VALUES('"+ tbMasterJob.Text + "', '" + maxJob.ToString() + "', '" + maxJob.ToString() + "', '" + tbCarrier.Text + "', '" + tbDriver.Text + "', 'optweb', SYSDATE)";


                    /*$sqlDriver = "INSERT INTO KTMS_JOB_DRIVER(MASTER_JOBNO, JOBNO, HD_SEQ_LINE, CARRIER, DRIVER, CREATE_BY, CREATE_DATE)";
			        $sqlDriver = $sqlDriver." VALUES('$mst_job', '$newJob', '$newJob', '$carrier', '$driver', 'optweb', now())";*/

                    String strDeleteSku = "DELETE FROM JOB_SKU WHERE MASTER_JOBNO='" + tbMasterJob.Text + "'";

                    //$sqlDeleteSKU = "DELETE FROM KTMS_JOB_SKU WHERE MASTER_JOBNO='$mst_job'";

                    // Update job_hdr, update job_dt, insert job_driver, delete job_sku

                    OleDbCommand updHdrComm = new OleDbCommand(strUpdHeader, ktmsConn);
                    OleDbCommand updDtComm = new OleDbCommand(strUpdDt, ktmsConn);
                    OleDbCommand insertDriverComm = new OleDbCommand(strInsertDriver, ktmsConn);
                    OleDbCommand deleteSkuComm = new OleDbCommand(strDeleteSku, ktmsConn);

                    updHdrComm.ExecuteNonQuery();
                    updDtComm.ExecuteNonQuery();
                    insertDriverComm.ExecuteNonQuery();
                    deleteSkuComm.ExecuteNonQuery();

                    /*MessageBox.Show(strUpdHeader);
                    MessageBox.Show(strUpdDt);
                    MessageBox.Show(strInsertDriver);
                    MessageBox.Show(strDeleteSku);*/



                    insertSKU(tbMasterJob.Text, tbTrantype.Text, tbTicket.Text, jobList.CurrentRow.Cells[8].Value.ToString(), maxJob);

                    //----------------------------------------------------------------


                    //MessageBox.Show("New Job : " + maxJob.ToString());

                }

                ktmsConn.Close();

                MessageBox.Show("Import Data Completed");

                //tbMasterJob.Text = null;
                tbCarrier.Text = null;
                tbDriver.Text = null;
                tbTicket.Text = null;
                tbTruck.Text = null;

                tbMasterJob.Text = jobList.CurrentRow.Cells[0].Value.ToString();
                tbTrantype.Text = jobList.CurrentRow.Cells[7].Value.ToString();

            }
            catch(Exception ex){
                    MessageBox.Show(ex.ToString());
            }

        }


        public void MaxDO(string mstJob)
        {
            try
            {
                //dsJob.MaxJob.Clear();

                OleDbConnection connMaxDO = new OleDbConnection(strConn);
                connMaxDO.Open();
                String strMaxDO = "SELECT MAX(TO_NUMBER(JOBNO)) JOBNO  FROM JOB_HDR WHERE MASTER_JOBNO='" + mstJob + "'";
                OleDbCommand commMaxDO = new OleDbCommand(strMaxDO, connMaxDO);
                OleDbDataAdapter maxDOAdapt1 = new OleDbDataAdapter(commMaxDO);
                //maxDOAdapt1.Fill(dsJob, "MaxJob");
                OleDbDataReader odr = commMaxDO.ExecuteReader();
                //String j = "";
                Int32 mm = 0;
                while(odr.Read()){
                    mm = int.Parse(odr.GetValue(0).ToString());
                    if (mm > 1)
                    {
                        mm += 1;                      
                    }
                    else {
                        String strLastUpd = "select modify_by  from job_hdr where master_jobno='" + mstJob + "' and jobno='1'";
                        OleDbCommand commLastUpd = new OleDbCommand(strLastUpd, connMaxDO);
                        //OleDbDataAdapter maxDOAdapt1 = new OleDbDataAdapter(commMaxDO);
                        OleDbDataReader odrLastUpd = commLastUpd.ExecuteReader();
                        while (odrLastUpd.Read()) {
                            String lastUpd = odrLastUpd.GetValue(0).ToString();
                            if (lastUpd == "optweb")
                            {
                                mm += 1;
                            } 
                        }
                    }
                    maxdo = mm.ToString();
                    //MessageBox.Show(mm.ToString());
                }
                connMaxDO.Close();
                //return dsJob.Tables["MaxJob"].Rows[0]["JOBNO"].ToString();   
                //return j;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        


        public void insertSKU(string masterjob, string tranType, string ticket, string tranYear, int mJob) {

            try{ 
                  OleDbConnection ktmsSku = new OleDbConnection(strConn);
                  ktmsSku.Open();

                  String strTicket = "";

                  //MessageBox.Show(ticket);
 
                  /*strTicket =   "SELECT " +
                                "(select (case when relh.storer_id='TOYOTA' then 'TTTC' else 'OTHER' end) from kwms.rel_batch_header relh, kwms.rel_batch_detail reld where relh.release_key = reld.release_key " +
                                "and relh.batch_no = reld.batch_no and reld.rel_line_seq = pd.rel_line_seq) STORERID, " +
                                "kt.truck_id VCHER,  TO_CHAR(kt.create_date, 'dd/mm/yyyy') DATEOUT, " +
                                "(SELECT user_defined_18 FROM kwms.rel_batch_detail relh WHERE relh.rel_line_seq = pd.REL_LINE_SEQ) ORG_SEC, " +
                                "pd.user_defined_18 ORG_REQ, " +
                                "pd.rel_line_seq UNIQUEID, " +
                                "(SELECT user_defined_29 FROM kwms.rel_batch_detail relh WHERE relh.rel_line_seq = pd.REL_LINE_SEQ) RELSREF, " +
                                "pd.picked_qty GOODQTY, " +
                                "to_number(pd.user_defined_12) WGHTNETS,kce.gross_weight WGHTGROSS, 'KG' WGHTUOM, 'COIL' PCKGCODE " +
                                "FROM kassist.kssp_truck kt, " +
                                "kassist.kssp_truck_route_header ktrh, " +
                                "kassist.kssp_truck_route_detail ktrd, " +
                                "kwms.picking_detail pd,kassist.kssp_coil_extra kce " +
                                "WHERE to_char(kt.truck_id) = '" + ticket + "' " +
                                "AND kt.truck_id = ktrh.truck_id " +
                                "AND ktrh.route_id = ktrd.route_id " +
                                "AND ktrd.coil_id = TO_NUMBER(pd.USER_DEFINED_01) " +
                                "AND ktrd.coil_id  = kce.coil_id";*/

                  strTicket = "SELECT " +
                                 "(select (case when relh.storer_id='TOYOTA' then 'TTTC' else 'OTHER' end) from kwms.rel_batch_header relh, kwms.rel_batch_detail reld where relh.release_key = reld.release_key " +
                                 "and relh.batch_no = reld.batch_no and reld.rel_line_seq = pd.rel_line_seq) STORERID, " +
                                 "kt.truck_id VCHER,  TO_CHAR(kt.create_date, 'dd/mm/yyyy') DATEOUT, " +
                                 "(SELECT user_defined_18 FROM kwms.rel_batch_detail relh WHERE relh.rel_line_seq = pd.REL_LINE_SEQ) ORG_SEC, " +
                                 "pd.user_defined_18 ORG_REQ, " +
                                 "pd.rel_line_seq UNIQUEID, " +
                                 "(SELECT user_defined_29 FROM kwms.rel_batch_detail relh WHERE relh.rel_line_seq = pd.REL_LINE_SEQ) RELSREF, " +
                                 "pd.picked_qty GOODQTY, " +
                                 "to_number(pd.user_defined_12) WGHTNETS,kce.gross_weight WGHTGROSS, 'KG' WGHTUOM, 'COIL' PCKGCODE " +
                                 "FROM kassist.kssp_truck kt, " +
                                 //"kassist.kssp_truck_route_header ktrh, " +
                                 "kwms.picking_detail pd,kassist.kssp_coil_extra kce " +
                                 "WHERE to_char(kt.truck_id) = '" + ticket + "' " +
                                 "AND kt.truck_id = kce.truck_id " +
                                 //"AND ktrh.truck_id = kce.truck_id " +
                                 "AND kce.coil_id = TO_NUMBER(pd.USER_DEFINED_01)"; 

                  /*if (tranType == "OUT")
                  {
                      //                      0         1                2        3                   4          5        6                   7                   8                       9         10        11
                      strTicket = "SELECT STORERID, VCHEROUT AS VCHER, DATEOUT, ORG_SEC, ORG_SEC AS ORG_REQ, UNIQUEID, RELSREF, QTYOUT AS GOODQTY, WGHTNET AS WGHTNETS, WGHTGROS AS WGHTGROSS, WGHTUOM,  PCKGCODE FROM TRNMASTR WHERE VCHEROUT='" + ticket + "' and year(dateout) = '" + tranYear + "'";
                                  "SELECT STORERID, VCHEROUT AS VCHER, DATEOUT, ORG_SEC, ORG_SEC AS ORG_REQ, UNIQUEID, RELSREF, QTYOUT AS GOODQTY, WGHTNET AS WGHTNETS, WGHTGROS AS WGHTGROSS, WGHTUOM,  PCKGCODE FROM TRNMASTR WHERE VCHEROUT='" + ticket + "' and year(dateout) = '" + tranYear + "'";

                                
                  }
                  else if (tranType == "IN")
                  {
                      strTicket = "SELECT STORERID, VCHERIN AS VCHER, DATEIN, ' ' AS ORG_SEC, ' ' AS ORG_REQ, '', '' AS RELSREF, SUM(goodqty) AS GOODQTYS, SUM(wghtnet) AS WGHTNETS, SUM(wghtgros) AS WGHTGROSS, WGHTUOM, PCKGCODE FROM TRNMASTR WHERE VCHERIN='" + ticket + "' and year(datein) = '" + tranYear + "' GROUP BY  STORERID, VCHERIN, DATEIN, WGHTUOM, PCKGCODE";
                  }*/

                        //MessageBox.Show(strTicket);
                        OleDbConnection coilConn1 = new OleDbConnection(CoilConn);
                        coilConn1.Open();
                        OleDbCommand coliComm1 = new OleDbCommand(strTicket, coilConn1);
                        OleDbDataAdapter coliAdapt1 = new OleDbDataAdapter(coliComm1);
                        OleDbDataReader sdr = coliComm1.ExecuteReader();
				   



                    // Select Data from Colis Center for insert to table job_sku
       
                        int runNo = 1;
                        while (sdr.Read()) {

                            //MessageBox.Show(sdr.GetValue(6).ToString());

                            Double netWT = Double.Parse(sdr.GetValue(8).ToString())/1000;
                            Double grsWT = Double.Parse(sdr.GetValue(9).ToString())/1000;
                            String wtUom = "MT";
                            String uom = sdr.GetValue(11).ToString();                         
                            int qty = int.Parse(sdr.GetValue(7).ToString());
                            String ref1 = "";
                            String ref2 = "";
                            String ref3 = "";

                            if(tranType == "OUT"){
                                
                                ref1 = sdr.GetValue(3).ToString();
                                ref2 = sdr.GetValue(6).ToString();
                                //ref3 = sdr.GetValue(5).ToString();
                                ref3 = runNo.ToString();
                            }
                            else if(tranType == "IN"){
                                if(sdr.GetValue(0).ToString() == "TTTC" ){
                                    ref1 = "NET";
                                }
                                else{
                                    ref1 = "GROSS";
                                }

                                ref2 = sdr.GetValue(3).ToString();
                            }

                           // Insert to job_sku
                           String  strInsertSKU = "INSERT INTO JOB_SKU(MASTER_JOBNO, JOBNO, HD_LINE_SEQ, DT_LINE_SEQ, LINE_SEQ, SKU, SKU_DESC, NET_WEIGHT, GROSS_WEIGHT, WEIGHT_UOM, QTY, UOM, REF_1, REF_2, REF_3, CREATE_BY, CREATE_DATE) " +
                                                  "VALUES('" + masterjob + "', '" + mJob.ToString() + "', '" + mJob.ToString() + "', '1', " + runNo + ", 'STEEL', 'STEEL COIL', " + netWT + ", " +
                                                  "" + grsWT + ", '" + wtUom + "', " + qty + ", '" + uom + "', '" + ref1 + "', '" + ref2 + "','" + ref3 + "', 'optweb', SYSDATE)";


                           OleDbCommand insertSKUComm = new OleDbCommand(strInsertSKU, ktmsSku);
                            
                            //MessageBox.Show(strInsertSKU);

                            insertSKUComm.ExecuteNonQuery();
                            // ----------------------------------------------

                            runNo++;

                         /*$netWT = odbc_result($seTicket, wghtnets)/1000;
					     $grsWT = odbc_result($seTicket, wghtgross)/1000;
					     //$wtUom = odbc_result($seTicket, wghtuom);
					     $wtUom = 'MT';				
					     $uom = odbc_result($seTicket, pckgcode);
    					 

					    if($tkType=='OUT'){
						     $qty = odbc_result($seTicket, qtyout);
					         $ref1 = odbc_result($seTicket, org_sec);
					         $ref2 = odbc_result($seTicket, relsref);
				        }
				        elseif($tkType=='IN'){
					         $qty = odbc_result($seTicket, goodqtys);
						     if(odbc_result($seTicket, storerid) == 'TTTC'){
							     $ref1 = 'NET';
						     }
						     else{
							     $ref1 = 'GROSS';
						     }
    					     
					         $ref2 = odbc_result($seTicket, org_req);
				        }*/

                            

                        } // end while

                        coilConn1.Close();
                        ktmsSku.Close();
                    //------------------------------------------------
 
        }
        catch(Exception ex){
           MessageBox.Show(ex.ToString());
        }

    }

        private void jobList_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                tbMasterJob.Text = jobList.CurrentRow.Cells[0].Value.ToString();
                tbTrantype.Text = jobList.CurrentRow.Cells[7].Value.ToString();

                tbTruck.Text = null;
                tbTicket.Text = null;
                tbCarrier.Text = null;
                tbDriver.Text = null;
            }
            catch {
                jobList.Rows[0].Selected = true;
            }

        }

        private void rbKDT_Click(object sender, EventArgs e)
        {
            dsJob.JobOpen.Clear();
            dsJob.Storer.Clear();
            rbKLCH.Checked = false;
            rbKDT.Checked = true;
            strConn = "Provider=MSDAORA;Data Source=kwms;Persist Security Info=True;Password=ktms123;User ID=ktms";

            OleDbConnection oleConnStorer2 = new OleDbConnection(strConn);
            oleConnStorer2.Open();
            OleDbCommand oleCommStorer2 = new OleDbCommand(strSteelCoilStorer, oleConnStorer2);
            OleDbDataAdapter oleAdaptStorer2 = new OleDbDataAdapter(oleCommStorer2);

            oleAdaptStorer2.Fill(dsJob, "Storer");
            cbStorer.DataSource = dsJob.Tables["Storer"];
            oleConnStorer2.Close();

        }

        private void rbKLCH_Click(object sender, EventArgs e)
        {
            dsJob.JobOpen.Clear();
            dsJob.Storer.Clear();
            rbKDT.Checked = false;
            rbKLCH.Checked = true;
            strConn = "Provider=MSDAORA;Data Source=kwms;Persist Security Info=True;Password=uat;User ID=klchlive";

            OleDbConnection oleConnStorer3 = new OleDbConnection(strConn);
            oleConnStorer3.Open();
            OleDbCommand oleCommStorer3 = new OleDbCommand(strSteelCoilStorer, oleConnStorer3);
            OleDbDataAdapter oleAdaptStorer3 = new OleDbDataAdapter(oleCommStorer3);

            oleAdaptStorer3.Fill(dsJob, "Storer");
            cbStorer.DataSource = dsJob.Tables["Storer"];
            oleConnStorer3.Close();
        }

   }
}
