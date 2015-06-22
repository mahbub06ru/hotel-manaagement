<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleRoom.aspx.cs" Inherits="HotelManagementAPP.UI.ScheduleRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="categoryLabel" runat="server" Text="Select Category"></asp:Label>
        <asp:DropDownList ID="SelectCategoryDropDownList" runat="server"></asp:DropDownList>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Select Room"></asp:Label>
        <asp:DropDownList ID="SelecteRoomDropDownList" runat="server"></asp:DropDownList>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Select Date"></asp:Label>
        
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Booked By"></asp:Label>
        <asp:TextBox ID="bookedByTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="saveButton" runat="server" Text="Save" />
    </div>
    </form>
</body>
</html>
