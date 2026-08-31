<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="pract_5.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="lblWelcome" runat="server"
            Text="Academic Calendar" Font-Bold="true" />

        <br /><br />

        <asp:Calendar ID="calleave" runat="server"
            OnSelectionChanged="calleave_SelectionChanged" />

        <br />

        <asp:Label ID="lblSelectedDate" runat="server"
            Text="Selected Date:" />

        <br /><br />

        <asp:Button ID="btnLeave" runat="server"
            Text="Apply for Leave"
            OnClick="btnLeave_Click" />

    </form>
</body>
</html>