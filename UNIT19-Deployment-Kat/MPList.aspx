<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MPList.aspx.cs" Inherits="UNIT19_Deployment_Kat.MPList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }

        h1 {
            color: #333;
            text-align: center;
        }

        p {
            color: #666;
            text-align: center;
        }

        .search-container {
            text-align: center;
            margin-bottom: 20px;
        }

        #txtSearch {
            padding: 8px;
            width: 250px;
            border: 1px solid #ccc;
            border-radius: 4px;
            margin-right: 10px;
        }

        #btnSearch {
            padding: 8px 20px;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        #btnSearch:hover {
            background-color: #0056b3;
        }

        #gvMPList {
            width: 100%;
            border-collapse: collapse;
        }

        #gvMPList th, #gvMPList td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        #gvMPList th {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>List of MPs</h1>
        <p>This app displays a list of Members of Parliament derived from <a href="https://www.theyworkforyou.com/">www.theyworkforyou.com</a>.</p>
        <p>The app has been developed for the purpose of the assignment for Unit 19, by Katarzyna Kuracinska.</p>
        <div class="search-container">
            <!-- Add a TextBox for search input -->
            <asp:TextBox ID="txtSearch" runat="server" placeholder="Search MP..." />
            <!-- Add a Button for search -->
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
        <!-- GridView to display MPs -->
        <asp:GridView ID="gvMPList" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="PersonID" HeaderText="Person ID" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Party" HeaderText="Party" />
                <asp:BoundField DataField="Constituency" HeaderText="Constituency" />
                <asp:HyperLinkField DataTextField="URI" HeaderText="URI" Text="Link" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
