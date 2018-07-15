using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WindowsFormsApplication4
{



    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public Form2()
        {
           
            InitializeComponent();
            main.Show();            
            sitecontrolpanel.Hide();
            welcomepanel.Show();
            tableLayoutPanel1.Hide();
            loginpanel.Hide();
            //procontpanel.Hide();
            

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            pnlSettings_MouseMove(sender,e);
        }


        void pnlSettings_MouseMove(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            // procontpanel.Hide();
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Hide();
            panel6.Hide();
            try {
                string Query = "select * from site_controle;";
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void untxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            untxt.Text = "";
            pwdtxt.Text = "";
            welcomepanel.Hide();
            loginpanel.Show();
            //procontpanel.Hide();
        }

        private void salshscrn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            if ((untxt.Text.Length == 0))
            {
                MessageBox.Show("Pls Fill Username field", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pwdtxt.Text.Length == 0)
                {
                    MessageBox.Show("Pls Fill password field ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    SqlConnection sqlcnObj = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wishwa\Documents\logindb.mdf;Integrated Security=True;Connect Timeout=30");
                    string query = "SELECT COUNT(*)  FROM login where username ='" + untxt.Text.Trim() + "'and pwd ='" + pwdtxt.Text.Trim() + "'";
                    string query1 = "SELECT * FROM login where username ='" + untxt.Text.Trim() + "'";
                    SqlDataAdapter sdaObj = new SqlDataAdapter(query, sqlcnObj);
                    DataTable dtObj = new DataTable();
                    sdaObj.Fill(dtObj);

                    if (dtObj.Rows[0][0].ToString() == "1")
                    {
                        //procontpanel.Hide();
                        sitecontrolpanel.Hide();
                        bunifuFlatButton9.Hide();
                        welcomepanel.Show();
                        loginpanel.Hide();
                       
                        tableLayoutPanel1.Show();
                        
                        logedname.Text ="User : "+untxt.Text.ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invaild user name and password ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectNamebtn_Click(object sender, EventArgs e)
        {
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Show();
            panel6.Hide();
            try
            {
                string Query1 = "select * from project_controls;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid2.DataSource = dTable;

                mycon1.Close();


            } catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            



        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Show();
           
            panel6.Show();
            panel7.Hide();
        }

        private void Empbtn_Click(object sender, EventArgs e)
        {
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Show();

            panel6.Show();
            panel7.Show();
            panel8.Hide();
        }

        private void Eadvbtn_Click(object sender, EventArgs e)
        {
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Show();

            panel6.Show();
            panel7.Show();
            panel8.Show();
            panel9.Show();
            panel10.Hide();
            


            string Query1 = "select * from ean;";
            string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection mycon1 = new SqlConnection(@MyConnection21);
            SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
            SqlDataReader dr1;
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = sqcmnd1;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            bunifuCustomDataGrid6.DataSource = dTable;

        }

        private void datasbtn_Click(object sender, EventArgs e)
        {
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Show();

            panel6.Show();
            panel7.Show();
            panel8.Show();
            panel9.Hide();
            panel10.Hide();


            string Query1 = "select * from aet;";
            string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection mycon1 = new SqlConnection(@MyConnection21);
            SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
            SqlDataReader dr1;
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = sqcmnd1;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            bunifuCustomDataGrid4.DataSource = dTable;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            sitecontrolpanel.Hide();
          //  procontpanel.Hide();
            welcomepanel.Show();
            logedname.Text = "";
            tableLayoutPanel1.Hide();
            this.WindowState = FormWindowState.Normal;
            bunifuFlatButton9.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "update site_controle set project_number='" + this.pronumsitcontxt.Text.Trim() + "',project_name='" + this.projectnamesitcontxt.Text.Trim() + "',site_code='" + this.sitecodetxt.Text.Trim() + "',site_name='" + this.sitenametxt.Text.Trim() + "' where project_number='" + this.pronumsitcontxt.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                string Query1 = "select * from site_controle;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid1.DataSource = dTable;

                mycon1.Close();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newRecSitCbnt_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "insert into site_controle(project_number,project_name,site_code,site_name) values('" + this.pronumsitcontxt.Text.Trim() + "','" + this.projectnamesitcontxt.Text.Trim() + "','" + this.sitecodetxt.Text.Trim() + "','" + this.sitenametxt.Text.Trim() +"');";

                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                mycon.Open();
                dr = sqcmnd.ExecuteReader();
                MessageBox.Show("Data is  updated");
                while (dr.Read()) {

                }
                string Query1 = "select * from site_controle;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid1.DataSource = dTable;

                mycon1.Close();
                mycon.Close();
                sitecontroltxtclear();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);

                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM site_controle  WHERE project_number='" + this.pronumsitcontxt.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("number", number.Text);
                MyConn2.Open();
                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist > 0)
                {
                    string Query = "delete from site_controle where project_number='" + this.pronumsitcontxt.Text.Trim() + "';";
               
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    string Query1 = "select * from site_controle;";
                    string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                    SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                    SqlDataReader dr1;
                    SqlDataAdapter MyAdapter = new SqlDataAdapter();
                    MyAdapter.SelectCommand = sqcmnd1;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    bunifuCustomDataGrid1.DataSource = dTable;
                    MyConn2.Close();
                    sitecontroltxtclear();
                }
                else
                {
                    MessageBox.Show("Item is't found in db");
                }

                           
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sitecontroltxtclear()
        {
            pronumsitcontxt.Text = "";
            projectnamesitcontxt.Text = "";
   
            sitecodetxt.Text = "";
            sitenametxt.Text = "";
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void pcnewbtn_Click(object sender, EventArgs e)
        {
           DateTime  dtp = pcdpickertxt.Value.Date;



            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "insert into project_controls(number,project_code,project_date,project_name,cust) values('" + this.number.Text.Trim() + "','" + this.pcprocodetxt.Text.Trim() + "','" + this.pcdpickertxt.Text+ "','" + this.pcpnametxt.Text.Trim() + "','" + this.pccustxt.Text.Trim() +"');";

                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                mycon.Open();
                dr = sqcmnd.ExecuteReader();
                MessageBox.Show("Data is  updated");
                while (dr.Read())
                {

                }
                string Query1 = "select * from project_controls;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid1.DataSource = dTable;

                mycon.Close();
                sitecontroltxtclear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void pcdelbtn_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";

                string Query = "delete from project_controls where number='" + this.number.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(@MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);

                MyConn2.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM project_controls  WHERE number='" + this.number.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("number", number.Text);
                
                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist>0)
                {
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    string Query1 = "select * from project_controls;";
                    string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                    SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                    SqlDataReader dr1;
                    
                    SqlDataAdapter MyAdapter = new SqlDataAdapter();
                    MyAdapter.SelectCommand = sqcmnd1;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    bunifuCustomDataGrid2.DataSource = dTable;

                    mycon1.Close();


                    MyConn2.Close();
                    sitecontroltxtclear();



                }
                else
                {
                    MessageBox.Show("Item not found in database Pls recheack ");

                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pcupbtn_Click(object sender, EventArgs e)
        {
            try
            {




                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "update project_controls set number='" + this.number.Text.Trim() + "',project_code='" + this.pcprocodetxt.Text.Trim() + "',project_date='" + this.pcdpickertxt.Text.Trim() + "',project_name='" + this.pcpnametxt.Text.Trim()  +"',cust='" + this.pccustxt.Text.Trim() + "' where number='" + this.number.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                string Query1 = "select * from project_controls;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid2.DataSource = dTable;

                
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void cussearchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string quary = "SELECT * FROM customer_control  WHERE number='" + this.searchtxt.Text.Trim() + "';";
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);



                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM customer_control  WHERE number='" + this.searchtxt.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("number", number.Text);
                MyConn2.Open();
                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist > 0)
                {
                    MyConn2.Open();
                    SqlCommand MyCommand2 = new SqlCommand(quary, MyConn2);
                    
                    
                    SqlDataAdapter MyAdapter = new SqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    bunifuCustomDataGrid3.DataSource = dTable;
                    MyConn2.Close();
                }
                else{

                    MessageBox.Show("Item not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            searchtxt.Text = "";
        }

        private void cusnewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "insert into customer_control(number,customer_name,address,tel,mobil,fax,email) values('" + this.cusnumtxt.Text.Trim() + "','" + this.cusnmtxt.Text.Trim() + "','" + this.cusaddtxt.Text + "','" + this.telnumtxt.Text.Trim() + "','" + this.mobitxt.Text.Trim() + "','"  + this.cusfaxtxt.Text + "','" +this.cusemtxt.Text.Trim() + "');";

                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                mycon.Open();
                dr = sqcmnd.ExecuteReader();
                MessageBox.Show("Data is  updated");
               
                while (dr.Read())
                {

                }
                mycon.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cusaddtxt.Text = "";
            cusemtxt.Text = "";
            cusfaxtxt.Text = "";
            cusnmtxt.Text = "";
            telnumtxt.Text = "";
            mobitxt.Text = "";
            cusnumtxt.Text = "";

        }

        private void newempbtn_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked = malebtn.Checked;
            if (isChecked)
                value = malebtn.Text;
            else
                value = femalebtn.Text;


            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "insert into employ_control(emp_numbe,initial,emp_name,sex,D_C_B,date_of_join,nic,div_licen,designation,bankacc,bankname,branch,telphone,mobilnumber,email,active) values('" + this.enumbtxt.Text.Trim() + "','" + this.intitxt.Text.Trim() + "','" + this.emptxt.Text.Trim() + "','" + value + "','" + this.dcbtxt.Text.Trim() + "','" + this.bunifuDatepicker1.Text.Trim() +  "','" + this.nictxt.Text.Trim() + "','" + this.dlntxt.Text.Trim() + "','" + this.destxt.Text.Trim() + "','" + this.bantxt.Text.Trim() +"','" + this.bnntxt.Text.Trim() + "','" + this.btxt.Text.Trim() + "','" + this.teltxt.Text + "','" + this.mbtxt.Text.Trim() + "','" + this.emtxt.Text.Trim() + "','" + this.actitxt.Text + "');";

                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                mycon.Open();
                dr = sqcmnd.ExecuteReader();
                MessageBox.Show("Data is  updated");
                while (dr.Read())
                {

                }
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aeaddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "insert into aet(aeempn,aeempc,aeempnm,aest,aeet,dates) values('" + this.aeentxt.Text.Trim() + "','" + this.emptxt.Text.Trim() + this.aeectxt.Text.Trim() + "','" + this.aeentxt.Text.Trim() + "','" + this.aesttxt.Text.Trim() + "','" + this.ettxt.Text.Trim() + "','" + this.dtp.Value.ToString("yyyy-MM-dd") +"');";

                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                mycon.Open();
                dr = sqcmnd.ExecuteReader();
                MessageBox.Show("Data is  updated");
                while (dr.Read())
                {

                }
                mycon.Close();

                string Query1 = "select * from aet;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid4.DataSource = dTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aeclrbtn_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";

                string Query = "delete from aet where aeempn='" + this.aeentxt.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(@MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);

                MyConn2.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM aet  WHERE aeempn='" + this.aeentxt.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("aeempn", aeentxt.Text);

                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist > 0)
                {
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    string Query1 = "select * from aet;";
                    string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                    SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                    SqlDataReader dr1;
                    SqlDataAdapter MyAdapter = new SqlDataAdapter();
                    MyAdapter.SelectCommand = sqcmnd1;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    bunifuCustomDataGrid4.DataSource = dTable;


                    MyConn2.Close();
                    sitecontroltxtclear();



                }
                else
                {
                    MessageBox.Show("Item not found in database Pls recheack ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            try
            {




                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "update aet set aeempn='" + this.aeentxt.Text.Trim() + "',aeempc='" + this.aeectxt.Text.Trim() + "',aeempnm='" + this.aeenmtxt.Text.Trim() + "',aest='" + this.aesttxt.Text.Trim() + "',aeet='" + this.ettxt.Text.Trim() + "',dates='" + this.dtp.Value.ToString("yyyy-MM-dd") + "' where aeempn ='" + this.aeentxt.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                string Query1 = "select * from aet;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid4.DataSource = dTable;


                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void empaddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "insert into ean(empeapnum,empeapdt,empen,empenm,empan) values('" + this.empapnumtxt.Text.Trim() + "','" + this.empapdttxt.Text.Trim() + this.aeectxt.Text.Trim() + "','" + this.empeapentxt.Text.Trim() + "','" + this.empentxt.Text.Trim() + "','"+ this.empantxt.Text+ "');";

                SqlConnection mycon = new SqlConnection(@MyConnection2);
                SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                SqlDataReader dr;
                mycon.Open();
                dr = sqcmnd.ExecuteReader();
                MessageBox.Show("Data is  updated");
                while (dr.Read())
                {

                }
                mycon.Close();

                string Query1 = "select * from ean;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid6.DataSource = dTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empdebtn_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";

                string Query = "delete from ean where empeapnum='" + this.empapnumtxt.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(@MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);

                MyConn2.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM aet  WHERE empeapnum='" + this.empapnumtxt.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("empeapnum", aeentxt.Text);

                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist > 0)
                {
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    string Query1 = "select * from ean;";
                    string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                    SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                    SqlDataReader dr1;
                    SqlDataAdapter MyAdapter = new SqlDataAdapter();
                    MyAdapter.SelectCommand = sqcmnd1;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    bunifuCustomDataGrid6.DataSource = dTable;


                    MyConn2.Close();
                    sitecontroltxtclear();



                }
                else
                {
                    MessageBox.Show("Item not found in database Pls recheack ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void empupbtn_Click(object sender, EventArgs e)
        {
            try
            {




                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "update ean set empeapnum='" + this.empapnumtxt.Text.Trim() + "',aeempc='" + this.empapdttxt.Text.Trim() + "',aeempnm='" + this.empeapentxt.Text.Trim() + "',aest='" + this.empentxt.Text.Trim() + "',aeet='" + this.empantxt.Text.Trim() + "' where empeapnum ='" + this.empapnumtxt.Text.Trim() + "';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                string Query1 = "select * from ean;";
                string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection mycon1 = new SqlConnection(@MyConnection21);
                SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
                SqlDataReader dr1;
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqcmnd1;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bunifuCustomDataGrid6.DataSource = dTable;


                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            main.Show();
            welcomepanel.Show();
            sitecontrolpanel.Show();
            panel5.Show();

            panel6.Show();
            panel7.Show();
            panel8.Show();
            panel9.Show();
            panel10.Show();
        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void gtbtn_Click(object sender, EventArgs e)
        {
           float val1 =  float.Parse(textBox43.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float val2 = float.Parse(textBox44.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
           float val3  = float.Parse(textBox45.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float val4 = float.Parse(textBox46.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float tot = val1 + val2 + val3 + val4;
            textBox48.Text = tot.ToString();
            
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void getdidbtn_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(textBox49.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float val2 = float.Parse(textBox50.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float val3 = float.Parse(textBox51.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float tot = val1 + val2 + val3;
            textBox52.Text = tot.ToString();
        }

        private void gttotbtn_Click(object sender, EventArgs e)
        {

            String sq1 = "SELECT Comulative_balance FROM ds WHERE Emp_Number = '" + textBox42.Text.ToString()+ "';";

            float val1 = float.Parse(textBox48.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);

            float val2 = float.Parse(textBox52.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            float tot = val1 - val2;
            textBox53.Text = tot.ToString();
            try {
                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection MyConn2 = new SqlConnection(@MyConnection2);
                

                MyConn2.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM ds  WHERE Emp_Number='" + this.textBox42.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("Emp_Number", textBox42.Text);

                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist > 0)
                {
                    
                    SqlCommand MyCommand2 = new SqlCommand(sq1, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                        float val5 =float.Parse(MyReader2["Comulative_balance"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        float val6 = float.Parse(textBox53.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
                        cumbtn.Text = (val5 + val6).ToString();


                    }



                }
                else
                {
                    cumbtn.Text =this.textBox53.Text;

                }


            }
            catch (Exception ex) {

            }



        }

        private void dsaddbtn_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection MyConn2 = new SqlConnection(@MyConnection2);
                MyConn2.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM ds  WHERE Emp_Number='" + this.textBox42.Text.Trim() + "';", MyConn2);
                check_User_Name.Parameters.AddWithValue("Emp_Number", textBox42.Text);

                int UserExist = (int)check_User_Name.ExecuteScalar();
                MyConn2.Close();
                if (UserExist > 0)
                {
                    string Query = "update ds set Emp_Number='" +
                         this.textBox42.Text.Trim() +
                        "',Emp_Name='" + this.dsentxt.Text.Trim() +
                        "',Food='" + float.Parse(textBox43.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                        "',Wages='" + float.Parse(textBox44.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                        "',Target='" + float.Parse(textBox45.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                        "',Total='" + float.Parse(textBox48.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                        "',Advance_Pay='" + float.Parse(textBox50.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                        "',Day_balnce='" + float.Parse(textBox53.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                         "',Comulative_balance='" + float.Parse(cumbtn.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                        "' where Emp_Number ='" + this.aeentxt.Text.Trim() + "';";
                    
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }
                
                    MyConn2.Close();


                }
                else
                {

                    string Query = "insert into ds(Emp_Number,Emp_Name,Food,Wages,Target,Total,Advance_Pay,Day_balnce,Comulative_balance) values('" +
                    this.textBox42.Text.Trim() +
                    "','" + this.dsentxt.Text.Trim() +                  
                    "','" + float.Parse(textBox43.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "','" + float.Parse(textBox44.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "','" + float.Parse(textBox45.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "','" + float.Parse(textBox48.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "','" + float.Parse(textBox50.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "','" + float.Parse(textBox53.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "','" + float.Parse(cumbtn.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) +
                    "');";

                    SqlConnection mycon = new SqlConnection(@MyConnection2);
                    SqlCommand sqcmnd = new SqlCommand(Query, mycon);
                    SqlDataReader dr;
                    mycon.Open();
                    dr = sqcmnd.ExecuteReader();
                    MessageBox.Show("Data is  updated");
                    while (dr.Read())
                    {

                    }
                    mycon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBox42.Text = "";
            dsentxt.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";

            textBox46.Text = "";
            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            cumbtn.Text = "";


        }

        private void dssebtn_Click(object sender, EventArgs e)
        {
            string Query1 = "select * from ds;";
            string MyConnection21 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wishwa\\Documents\\mainfuntionsdb.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection mycon1 = new SqlConnection(@MyConnection21);
            SqlCommand sqcmnd1 = new SqlCommand(Query1, mycon1);
            SqlDataReader dr1;
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = sqcmnd1;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            bunifuCustomDataGrid5.DataSource = dTable;
        }
    }

}
