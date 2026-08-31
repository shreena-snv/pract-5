<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Leave.aspx.cs"
    Inherits="pract_5.Leave" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Form</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Leave Management</h2>

        Name :
        <asp:TextBox ID="txtName" runat="server" />
        <br /><br />

        Leave Type :
        <asp:DropDownList ID="ddlLeaveType" runat="server">
            <asp:ListItem Text="--Select--" Value="0" />
            <asp:ListItem>Medical</asp:ListItem>
            <asp:ListItem>Personal</asp:ListItem>
            <asp:ListItem>Emergency</asp:ListItem>
        </asp:DropDownList>

        <br /><br />

        Selected Date :
        <asp:TextBox ID="txtSelectedDate" runat="server" ReadOnly="true" />

        <br /><br />

        Reason :
        <asp:TextBox ID="txtLeaveReason" runat="server"
            TextMode="MultiLine" Rows="3" Columns="25" />

        <br /><br />

        Days :
        <asp:TextBox ID="txtDays" runat="server" />

        <br /><br />

        <asp:Button ID="btnApply" runat="server"
            Text="Apply"
            OnClick="btnApply_Click" />

        <asp:Button ID="btnPrevious" runat="server"
            Text="Back"
            OnClick="btnPrevious_Click" />

        <asp:Button ID="btnLogout" runat="server"
            Text="Logout"
            OnClick="btnLogout_Click" />

        <br /><br />

        <asp:Label ID="lblMessage" runat="server"
            ForeColor="Green" />

    </form>
</body>
</html>