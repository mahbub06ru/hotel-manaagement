using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using HotelManagementAPP.DAL;
using HotelManagementAPP.Model;

namespace HotelManagementAPP.BLL
{
    public class RoomInfoManager
    {
        RoomInfoGateway roomInfoGateway=new RoomInfoGateway();
        public string Save(RoomInformation aRoomInformation)
        {
            
            if (aRoomInformation.RoomNo.Length>3)
                {
                    return "Successfully Saved";
                }
                else
                {
                    return "Save Failed";
                }
         }
        //RoomInfoGateway roomInfoGateway = new RoomInfoGateway();
        public List<RoomInformation> GetAllCategory()
        {
            return roomInfoGateway.GetAllCategory();
        }

        public RoomInformation GetRoomInfoByID(int id)
        {
            return roomInfoGateway.GetRoomInfoByID(id);
        }

        internal static object GetInfoByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}