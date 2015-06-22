using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelManagementAPP.BLL;
using HotelManagementAPP.Model;

namespace HotelManagementAPP.UI
{
   
    public partial class RoomInfoUI : System.Web.UI.Page
    {
        RoomInfoManager aRoomInfoManager = new RoomInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                selectCategoryDropDownList.DataSource = aRoomInfoManager.GetAllCategory;
                selectCategoryDropDownList.DataTextField = "room_no";
                selectCategoryDropDownList.DataBind();

                
            }
            int id = Convert.ToInt32(selectCategoryDropDownList.SelectedValue);
            roomLabel.Text = RoomInfoManager.GetRoomInfoByID(id).ToString();

        }
        

        protected void saveButton_Click(object sender, EventArgs e)
        {
            RoomInformation aRoomInformation=new RoomInformation();
            aRoomInformation.RoomNo = roomNoTextBox.Text;
            aRoomInformation.SelectCatagory = selectCategoryDropDownList.Text;
            aRoomInformation.Description = descriptionTextBox.Text;
            
            
            
        }
    }
}