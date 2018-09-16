using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HotelReservation_SYS
{
    class RoomRate
    {

        //instance variables
        private string room_Type;
        private string description;
        private decimal rate;




        //no arguement constructor
        public RoomRate()
        {
            room_Type = "";
            description = "";
            rate = 0;
        }

        //3 arguement constructor
        public RoomRate(string room_Type, string description, decimal rate)
        {
            this.room_Type = room_Type;
            this.description = description;
            this.rate = rate;
        }

        //setters
        public void setRoom_Type(string Room_Type)
        {
            this.room_Type = Room_Type;
        }

        public void setDescription(string Description)
        {
            this.description = Description;
        }

        public void setRate(decimal Rate)
        {
            this.rate = Rate;
        }

        //getters
        public string getRoom_Type()
        {
            return room_Type;
        }

        public string getDescription()
        {
            return description;
        }

        public decimal getRate()
        {
            return rate;
        }

        public void addRoomRate()
        {
            //establish Connection to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //SQL Query
            String strSQL = "INSERT INTO RoomRate VALUES('" + this.room_Type.ToUpper() + "','" + this.description.ToUpper() + "'," + this.rate + ")";

            //Execute oracle
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close Connection
            myConn.Close();
        }

        public void updateRoomRate(string room_Type)
        {
         
                //connect to database
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);
                myConn.Open();

                //Define SQL query to INSERT stock record
                String strSQL = "UPDATE RoomRate SET Description = '" + this.description.ToUpper() + "', rate = " +
                    this.rate + " WHERE room_Type = '" + room_Type + "'";

                //Execute the command
                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

                //close DB connection
                myConn.Close();
            
        }



        //define a static method to get data
        public static DataSet getRoomRate(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT Room_Type, Description,Rate FROM Roomrate ORDER BY Room_Type";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void getRoomRate(string room_type)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX Room_Type used
            String strSQL = "SELECT * FROM RoomRate WHERE Room_Type = '" + room_type + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

           
            if (dr.Read())
            {

                setRoom_Type(dr.GetString(0));
                setDescription(dr.GetString(1));
                setRate(dr.GetDecimal(2));

            }
            //close DB connection
            myConn.Close();
        }



        // this class validates that a rate does not already exist
        // wont allow u create multiple of the same rate
        public static Boolean rateExists(String room_type)
        {
            Boolean ans = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            String strSQL = "SELECT * FROM RoomRate WHERE Room_Type = '" + room_type.ToUpper() + "'";

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




    }
}