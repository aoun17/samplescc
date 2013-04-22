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
    public partial class frmTicket : Form
    {
        private Form1 _parent;
        //public string Ticket { get { return tickets; } set { tickets = value; } }
        //public string Trantype { get { return trantypes; }  set{trantypes = value; } }
        //public string Tranyear { get { return tranyears; }  set{tranyears = value; } }
        String tickets;
        String trantypes;
        String tranyears;
        //String CoilConn = "Data Source=172.25.50.22;Initial Catalog=KERRYCOILDB;Persist Security Info=True;User ID=sa;Password=sql";
        
        //String CoilConn = "Provider=MSDAORA;Data Source=kwmsthkssp.kerrylogistics.com;Persist Security Info=True;Password=v1ew5ssp;User ID=kwmsreadonly";
        String CoilConn = "Provider=MSDAORA;Data Source=KWMSTHKSSP;Persist Security Info=True;Password=v1ew5ssp;User ID=kwmsreadonly";
        String KTMSConn = "Provider=MSDAORA;Data Source=kwms;Persist Security Info=True;Password=ktms123;User ID=ktms";
        public frmTicket()
        {
            InitializeComponent();
        }


        public frmTicket(String ticket, String trantype, String tranYear, Form1 frm1) {
            this.tickets = ticket;
            this.trantypes = trantype;
            this.tranyears = tranYear;
            InitializeComponent();
            //Form1 frm1 = new Form1();
            //btSelect.Visible = false;
            //lbExist.Visible = false;
            _parent = frm1;


            //MessageBox.Show(tickets + " , " + tranyears);
            dsJob.Ticket.Clear();
            tbTicket.Text = tickets;
            String CoilStrComm1;
            try
            {
                OleDbConnection coilConn1 = new OleDbConnection(CoilConn);
                coilConn1.Open();
                lbTranDate.Text = "Date Out";
                /*CoilStrComm1 = "SELECT VCHERIN AS TICKET_NO, ORGTRLC1 AS TRUCK, LOCCODE01 AS FROM_ADDRESS, LOCCODE02 AS TO_ADDRESS, " +
                                   "RELSREF AS REF, RELSREF AS DESCRIPTION, LOCCOL01 SECTION, WGHTNET NET_WEIGHT, WGHTGROS GROSS_WEIGHT, " +
                                   "DATEIN TRAN_DATE " +
                                   "FROM TRNMASTR " +
                                   "WHERE VCHERIN='" + tickets + "' " +
                                   "AND YEAR(DATEIN) = '" + tranyears + "'";*/
                /*CoilStrComm1 = "SELECT kt.truck_id TICKET_NO, substr(kt.truck_no,1,7) TRUCK, ktrd.row_id FROM_ADDRESS, " +
                                "(select user_defined_30 from kwms.rel_batch_detail reld where reld.rel_line_seq = pd.rel_line_seq) TO_ADDRESS, " +
                                "pd.user_defined_18 REF, " +  
                                "(SELECT user_defined_29 FROM kwms.rel_batch_detail relh WHERE relh.rel_line_seq = pd.REL_LINE_SEQ) DESCRIPTION, " +
                                "pd.user_defined_18 SECTION, pd.user_defined_12 NET_WEIGHT,kce.gross_weight GROSS_WEIGHT, TO_CHAR(kt.create_date, 'dd/mm/yyyy') " +
                                "FROM kassist.kssp_truck kt, " +
                                "kassist.kssp_truck_route_header ktrh, " +
                                "kassist.kssp_truck_route_detail ktrd, " +
                                "kwms.picking_detail pd,kassist.kssp_coil_extra kce " +
                                "WHERE to_char(kt.truck_id) = '" + tickets + "' " +
                                "AND kt.truck_id = ktrh.truck_id " +
                                "AND ktrh.route_id = ktrd.route_id " +
                                "AND ktrd.coil_id = TO_NUMBER(pd.USER_DEFINED_01) " +
                                "AND ktrd.coil_id  = kce.coil_id";*/


                CoilStrComm1 = "SELECT kt.truck_id TICKET_NO, SUBSTR(kt.truck_no,1,7) TRUCK, pd.location_id FROM_ADDRESS, " +
                                "(SELECT user_defined_30 FROM kwms.rel_batch_detail reld WHERE reld.rel_line_seq = pd.rel_line_seq) TO_ADDRESS, " +
                                "pd.user_defined_18 REF, " +
                                "(SELECT user_defined_29 FROM kwms.rel_batch_detail relh WHERE relh.rel_line_seq = pd.REL_LINE_SEQ) DESCRIPTION, " +
                                "pd.user_defined_18 SECTION, pd.user_defined_12 NET_WEIGHT,kce.gross_weight GROSS_WEIGHT, TO_CHAR(kt.create_date, 'dd/mm/yyyy') " +
                                "FROM kassist.kssp_truck kt, " +
                                //"kassist.kssp_truck_route_header ktrh, " +
                                "kwms.picking_detail pd,kassist.kssp_coil_extra kce " +
                                "WHERE to_char(kt.truck_id) = '" + tickets + "' " +
                                "AND kt.truck_id = kce.truck_id " +
                                //"AND ktrh.truck_id = kce.truck_id " +
                                "AND kce.coil_id = TO_NUMBER(pd.user_defined_01)";
                //MessageBox.Show(CoilStrComm1);
              


                OleDbCommand coliComm1 = new OleDbCommand(CoilStrComm1, coilConn1);
                OleDbDataAdapter coliAdapt1 = new OleDbDataAdapter(coliComm1);
                coliAdapt1.Fill(dsJob, "Ticket");
                ticketList.DataSource = dsJob.Tables["Ticket"];
                coilConn1.Close();

                /*if (trantypes == "IN")
                {
                    lbTranDate.Text = "Date In";
                    CoilStrComm1 = "SELECT VCHERIN AS TICKET_NO, ORGTRLC1 AS TRUCK, LOCCODE01 AS FROM_ADDRESS, LOCCODE02 AS TO_ADDRESS, " +
                                   "RELSREF AS REF, RELSREF AS DESCRIPTION, LOCCOL01 SECTION, WGHTNET NET_WEIGHT, WGHTGROS GROSS_WEIGHT, " +
                                   "DATEIN TRAN_DATE " +
                                   "FROM TRNMASTR " +
                                   "WHERE VCHERIN='" + tickets + "' " +
                                   "AND YEAR(DATEIN) = '" + tranyears + "'";
                    //MessageBox.Show(CoilStrComm1);
                    SqlCommand coliComm1 = new SqlCommand(CoilStrComm1, coilConn1);
                    SqlDataAdapter coliAdapt1 = new SqlDataAdapter(coliComm1);
                    coliAdapt1.Fill(dsJob, "Ticket");
                    ticketList.DataSource = dsJob.Tables["Ticket"];
                    coilConn1.Close();
                    
                }
                else if (trantypes == "OUT")
                {
                    lbTranDate.Text = "Date Out";
                    CoilStrComm1 = "SELECT VCHEROUT AS TICKET_NO, DESTRLC1 AS TRUCK, LOCCODE01 AS FROM_ADDRESS, LOCCODE02 AS TO_ADDRESS, " +
                                   "RELSREF AS REF, RELSREF AS DESCRIPTION, LOCCOL01 SECTION, WGHTNET NET_WEIGHT, WGHTGROS GROSS_WEIGHT, " +
                                   "DATEOUT TRAN_DATE " +
                                   "FROM TRNMASTR " +
                                   "WHERE VCHEROUT='" + tickets + "' " +
                                   "AND YEAR(DATEOUT) = '" + tranyears + "'";
                    //MessageBox.Show(CoilStrComm1);
                    SqlCommand coliComm1 = new SqlCommand(CoilStrComm1, coilConn1);
                    SqlDataAdapter coliAdapt1 = new SqlDataAdapter(coliComm1);
                    coliAdapt1.Fill(dsJob, "Ticket");
                    ticketList.DataSource = dsJob.Tables["Ticket"];
                    coilConn1.Close(); 
                   
                }*/


                if (dsJob.Tables["Ticket"].Rows.Count > 0)
                {
                    tbTranDate.Text = dsJob.Tables["Ticket"].Rows[0]["TRAN_DATE"].ToString();
                }

                

                String oleSql1 = "SELECT H.MASTER_JOBNO, H.JOBNO, H.JOB_TYPE " +
                                 "FROM JOB_HDR H, JOB_DT D " +
                                 "WHERE H.MASTER_JOBNO = D.MASTER_JOBNO " +
                                 "AND H.JOBNO = D.JOBNO " +
                                 "AND H.HD_LINE_SEQ = D.HD_LINE_SEQ " +
                                 "AND D.BOOK_REF = '" + tickets + "' " +
                                 "AND TO_CHAR(H.JOB_DATE, 'YYYY') = '" + tranyears + "' ";
                OleDbConnection oleConn1 = new OleDbConnection(KTMSConn);
                //MessageBox.Show(oleSql1);
                oleConn1.Open();
                OleDbCommand oleComm1 = new OleDbCommand(oleSql1, oleConn1);
                OleDbDataAdapter oda1 = new OleDbDataAdapter(oleComm1);
                oda1.Fill(dsJob, "BookRef");
                //int cc = dsJob.Tables["BookRef"].Rows.Count;
                //MessageBox.Show(cc.ToString());
                if (dsJob.Tables["BookRef"].Rows.Count > 0)
                {
                    btSelect.Visible = false;
                }
                else
                {
                    lbExist.Visible = false;
                }
                oleConn1.Close();

                //tbTranDate = ticket.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            //_parent.settbTicket(dsJob.Tables["Ticket"].Rows[0]["TICKET_NO"].ToString());
            try
            {
                _parent.Ticket = dsJob.Tables["Ticket"].Rows[0]["TICKET_NO"].ToString();
                _parent.Truck = dsJob.Tables["Ticket"].Rows[0]["TRUCK"].ToString();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
            //MessageBox.Show(dsJob.Tables["Ticket"].Rows[0]["TRUCK"].ToString());
            //this.Close();
        }
            
        
    }
}
