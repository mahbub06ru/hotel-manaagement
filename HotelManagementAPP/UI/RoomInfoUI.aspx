<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomInfoUI.aspx.cs" Inherits="HotelManagementAPP.UI.RoomInfoUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div class="container">
        
        <asp:Label ID="Label4" runat="server" Text="Room Information Details"></asp:Label> 
        <br/>
                
        <asp:Label ID="Label1" runat="server" Text="Room No"></asp:Label>
        <asp:TextBox ID="roomNoTextBox" runat="server"></asp:TextBox>
         <br/>
                
         <asp:Label ID="Label2" runat="server" Text="Select Catagory"></asp:Label>
         <asp:DropDownList ID="selectCategoryDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Page_Load"></asp:DropDownList>
                    
         <br/>
         <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
         <asp:TextBox ID="descriptionTextBox" runat="server"></asp:TextBox>
         <br/>
         <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
         <br/>
            
         <asp:Label ID="roomLabel" runat="server" Text=""></asp:Label>
        
    </div>
    </form>
</body>
</html>
