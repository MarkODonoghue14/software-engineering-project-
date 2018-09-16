using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HotelReservation_SYS
{
    class Rooms
    {
        private int room_No;
        private string room_Type;
        private string status;


        // no arguement constructor for 
        public Rooms()
        {
            room_No = 0;
            room_Type = "";
            status = "";
        }

        //3 arguement Constructor
        public Rooms(int room_No, string room_Type, string status)
        {
            this.room_No = room_No;
            this.room_Type = room_Type;
            this.status = status;
        }

        //setters
        public void setRoom_No(int Room_No)
        {
            this.room_No = Room_No;
        }

        public void setRoom_Type(string Room_Type)
        {
            this.room_Type = Room_Type;
        }

        public void setStatus(string Status)
        {
            this.status = Status;
        }


        //getters


        public int getRoom_No(int Room_No)
        {
            return room_No;
        }
        public string getRoom_Type(string Room_Type)
        {
            return room_Type;
        }

        public string getStatus(string Status)
        {
            return status;
        }

        public void addRoom()
        {
            //establish Connection to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //SQL Query
            String strSQL = "INSERT INTO Rooms VALUES(" + this.room_No + ",'" + this.room_Type.ToUpper() + "','" + this.status.ToUpper() + "')";

            //Execute oracle
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Connection
            myConn.Close();
        }
        // method that checks to see if a room exists
        public static Boolean roomExists(int room_No)
        {
            Boolean ans = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM Rooms WHERE Room_No = " + room_No + "";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ans = true;

                conn.Close();
            }
            else
                ans = false;


            return ans;

        }

        //
        public static DataSet getRooms(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Rooms ORDER BY Room_No";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
    
        // This method allows you to extract the roomtype from the db associated with the roomno

        public static string getRoomRate(int RoomNo)
        {
            string type;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //connection name conn.Open();
            String strSQL = "SELECT Room_Type FROM Rooms WHERE Room_No = " + RoomNo;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

        
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            type = dr.GetString(0);

            conn.Close();

            return type.Trim();
        }
        //method that allows me to extract the status of the room associated with the roomNo
        public static string getStatus(int RoomNo)
        {
            string status;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //connection name conn.Open();
            String strSQL = "SELECT Status FROM Rooms WHERE Room_No = " + RoomNo;
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            status = dr.GetString(0);

            conn.Close();

            return status.Trim();
        }




        //method that allows me update a room
        public void updateRooms(int Room_No)
        {

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT rooms record
            String strSQL = "UPDATE Rooms SET Room_Type = '" + this.room_Type.ToUpper() + 
                "' WHERE Room_No = " + Room_No + "";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }
        //method that allows the user to update a status
        public void updateStatus(string Status)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            //Define SQL query to INSERT rooms record
            String strSQL = "UPDATE Rooms SET Status ='" + this.status.ToUpper() + "'" +
                " WHERE Room_No = " + room_No + "";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        //Method similar to check if rate exists. this will stop a room from being updated or closed if the room already has a booking
        public static Boolean isRoomAvailable(String Room_No)
        {
            Boolean ans = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM Reservations WHERE Room_No = " + Room_No + "AND Date_Depart >= SYSDATE";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
                ans = true;

            conn.Close();

            return ans;

        }

    }
}