
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace HotelReservation_SYS
{
    class Reservations
    {
        private int res_ID;
        private int room_No;
        private string cust_Name;
        private string e_Mail;
        private string date_Arrive;
        private string date_Depart;
        private double total_Cost;
        private string check_In;
        private string check_Out;
        private string res_Status;



        //no arguement constructor
        public Reservations()
        {
            res_ID = 0;
            room_No = 0;
            cust_Name = "";
            e_Mail = "";
            date_Arrive = "";
            date_Depart = "";
            total_Cost = 0.0;
            check_In = "";
            check_Out = "";
            res_Status = "";
        }

        //10 arguement constructor
        public Reservations(int res_ID, int room_No, string cust_Name, string e_Mail, string date_Ariive, string date_Depart, double total_Cost, string check_in, string check_Out, string res_Status)
        {
            this.res_ID = res_ID;
            this.room_No = room_No;
            this.cust_Name = cust_Name;
            this.e_Mail = e_Mail;
            this.date_Arrive = date_Arrive;
            this.date_Depart = date_Depart;
            this.total_Cost = total_Cost;
            this.check_In = check_In;
            this.check_Out = check_Out;
            this.res_Status = res_Status;
        }

        //setters
        public void setRes_ID(int res_ID)
        {
            this.res_ID = res_ID;
        }

        public void setRoom_No(int room_No)
        {
            this.room_No = room_No;
        }

        public void setCust_Name(string cust_Name)
        {
            this.cust_Name = cust_Name;
        }

        public void setE_Mail(string e_Mail)
        {
            this.e_Mail = e_Mail;
        }

        public void setDate_Arrive(string date_Arrive)
        {
            this.date_Arrive = date_Arrive;
        }

        public void setDate_Depart(string date_Depart)
        {
            this.date_Depart = date_Depart;
        }

        public void setTotal_Cost(double total_Cost)
        {
            this.total_Cost = total_Cost;
        }

        public void setCheck_In(string check_In)
        {
            this.check_In = check_In;
        }

        public void setCheck_Out(string check_Out)
        {
            this.check_Out = check_Out;
        }

        public void setRes_Status(string res_Status)
        {
            this.res_Status = res_Status;
        }

        //getters
        public int getRes_ID()
        {
            return res_ID;
        }

        public int getRoom_No(int Room_No)
        {
            return room_No;
        }

        public string getCust_Name()
        {
            return cust_Name;
        }

        public string getE_Mail()
        {
            return e_Mail;
        }

        public string getDate_Arrive()
        {
            return date_Arrive;
        }

        public string getDate_Depart()
        {
            return date_Depart;
        }

        public double getTotal_Cost()
        {
            return total_Cost;
        }

        public string getCheck_In()
        {
            return check_In;
        }

        public string getCheck_Out()
        {
            return check_Out;
        }

        public string getRes_Status()
        {
            return res_Status;
        }


        //method to add a reservation to the db
        public void makeReservation()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            myConn.Open();

            String strSQL = "INSERT INTO Reservations VALUES(" + this.res_ID + "," + this.room_No + ",'" + this.cust_Name + "','" + this.e_Mail + "',DATE '" + this.date_Arrive + "', DATE '" + this.date_Depart + "',"
                + this.total_Cost + ", '" + this.check_In + "','" + this.check_Out + "','" + this.res_Status + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }
        //method to find the next avaailable res id
        public static int nextResId()
        {
            int nextResId;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Res_ID) FROM Reservations";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextResId = 1;
            else
                nextResId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextResId;

        }

        public static DataSet getAvailableRooms(DataSet DS, string Date_Arrive, string Date_Depart, string Room_Type)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            // finds all available rooms that dont have a reservation. that are not closed but available and orders them by their room_No
            String strSQL = "SELECT * FROM Rooms r WHERE r.Room_No NOT IN (SELECT DISTINCT Room_No FROM Reservations rs WHERE(rs.Date_Arrive BETWEEN DATE '" + Date_Arrive +
                            "' AND DATE '" + Date_Depart + "') OR(rs.Date_Depart BETWEEN DATE '" + Date_Arrive + "' AND DATE '" + Date_Depart + "') OR (rs.Date_Arrive < DATE '" + Date_Arrive +
                            "' AND rs.Date_Depart > DATE '" + Date_Depart + "')) AND r.Room_Type = '" + Room_Type + "' AND r.Status = 'A' ORDER BY r.Room_No";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

           OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            myConn.Close();

            return DS;
        }

        //method that allows you to find the rate asociated with a roomNo
        public static double findRate(int Room_No)
        {
            double Rate;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT Rate FROM RoomRate WHERE Room_Type = (Select Room_Type FROM Rooms WHERE Room_No = " + Room_No + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            Rate = Convert.ToDouble(dr.GetValue(0));

            myConn.Close();
            return Rate;

        }

        //method that allows you to find a rate associated with a roomtype
        public static decimal findRateprov(String Type)
        {
            decimal Rate;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT Rate FROM RoomRate WHERE Room_Type ='" + Type + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            Rate = Convert.ToDecimal(dr.GetValue(0));

            myConn.Close();
            return Rate;

        }
        //method allows you delete a reservation from the system
        public void deleteReservation()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "DELETE From Reservations WHERE Res_ID = " + this.res_ID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        //method that allows a guest to checkin i.e it updates the db to 'c' checked in
        public void checkIn()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Reservations SET check_In = 'C' WHERE Res_ID = " + this.res_ID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        // method that allows a user to checkout
        public void checkOut()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Reservations SET check_Out = 'C' ,Res_Status = 'P' WHERE Res_ID = " + this.res_ID; 

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //method that gets monthly Revenue per year
        public static DataSet getMonthlyData(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(Date_Depart,'MM'), SUM(Total_Cost) FROM Reservations WHERE Res_Status = 'P' AND Date_Depart LIKE '%" + Year + "' GROUP BY TO_CHAR(Date_Depart, 'MM') " +
                            "ORDER BY TO_CHAR(Date_Depart, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        //method that allows you to extract sate depart from db
        public static DataSet getYear(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT  To_Char(Date_Depart, 'YYYY') FROM Reservations ORDER BY Date_Depart";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "Year");

            conn.Close();

            return DS;
        }


        public static DataSet getRoomType(DataSet DS, String Year, String Type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(Date_Depart,'MM'), COUNT(Res_Id) FROM Reservations rs JOIN Rooms r ON r.Room_No = rs.Room_No WHERE Res_Status = 'P' AND Date_Depart LIKE '%" + Year + "' AND r.Room_Type" +
                "= '" + Type + "' GROUP BY TO_CHAR(Date_Depart, 'MM') ORDER BY TO_CHAR(Date_Depart, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getRoomType(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT Room_Type FROM RoomRate ORDER BY Room_Type";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "Room_Type");

            conn.Close();

            return DS;
        }

        // method to get available check ins
        public static DataSet getCheckIns(DataSet DS, String Date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //only show checkins that have an active res status that hasnt been already checked in and for todays date
            String strSQL = "SELECT * from Reservations WHERE Res_Status = 'A'AND check_In = 'A' AND Date_Arrive = DATE '" + Date + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //method to get valid checkouts
        public static DataSet getCheckOuts(DataSet DS, String Date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //only show checkOuts that have an active res status that has been already checked in and for The reservations day of depature
            String strSQL = "SELECT * from Reservations WHERE Res_Status = 'A'AND check_In = 'C'  ";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
        //method that will allow me to get all reservations that have been made but havent been checked in or out
        public static DataSet getValidReservationsForDeletion(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //only show reservations that are active. that have not yet been checked in or out of
            String strSQL = "SELECT * from Reservations WHERE Res_Status = 'A' AND check_In = 'A' AND check_Out = 'A'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        //method that allows me extract values for indivdual columns based on the resid
        public void getReservation(int ResID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Reservations WHERE Res_ID = " + ResID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            this.res_ID = dr.GetInt32(0);
            this.room_No = dr.GetInt32(1);
            this.cust_Name = dr.GetString(2);
            
            this.date_Arrive = dr.GetValue(4).ToString();
            this.date_Depart = dr.GetValue(5).ToString();


            conn.Close();

     
        }


    }
}









