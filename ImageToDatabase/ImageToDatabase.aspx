<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageToDatabase.aspx.cs" Inherits="ImageToDatabase.ImageToDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_file_upload" runat="server" OnClick="btn_file_upload_Click" Text="Button" />
            <br />
            <asp:FileUpload ID="img_file_upload" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btn_display_image" runat="server" Text="Button" OnClick="btn_display_image_Click" />
            <br />
            <asp:Image ID="image" runat="server" />
        </div>
    </form>
</body>
</html>
