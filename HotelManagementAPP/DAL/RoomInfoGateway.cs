using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using HotelManagementAPP.Model;
using System.Data.SqlClient;

namespace HotelManagementAPP.DAL
{
    public class RoomInfoGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public void save(RoomInformation aRoomInformation)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_room VALUES('" + aRoomInformation.RoomNo + "','" +
                           aRoomInformation.SelectCatagory + "','" + aRoomInformation.Description + "')";


            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            //return rowAffected;


        }

        public RoomInformation GetRoomInfoByID(int id);
    {
        List<RoomInformation> roomInformationList = new List<RoomInformation>();
        
        string query = "SELECT * FROM tbl_room WHERE id=" + id;
        SqlConnection aConnection = new SqlConnection(connectionString);
        aConnection.Open();
        SqlCommand aCommand = new SqlCommand(query, aConnection);
        SqlDataReader aReader = aCommand.ExecuteReader();
        RoomInformation roomInformation = new RoomInformation();
        while (aReader.Read())
        {
            roomInformation.RoomNo = aReader["room"].ToString();
            roomInformation.SelectCatagory = aReader["category"].ToString();
            roomInformation.Description = aReader["description"].ToString();
            roomInformationList.Add(roomInformation);
        }
        aReader.Close();
        aConnection.Close();
        return roomInformation;



    }

    }

}