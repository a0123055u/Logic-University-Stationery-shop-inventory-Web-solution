<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DepartmentRepresetitveSettings.aspx.cs" Inherits="Elephtan.StationeryDepartment.DepartmentRepresetitveSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #DetailPanel {
            background-color: #F7F7F7;
            padding: 15px 35px 15px 35px;
            box-shadow: 1px 2px 4px 0px rgba(0, 0, 0, 0.30);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Collection Point</h1>
    <div id="DetailPanel">
        <h3>Current Collection Point</h3>
        <asp:Label ID="currentCollectionPoint" runat="server" Text="Collection Point Address Placeholder"></asp:Label>
        <br />
        <hr />
        <h4>Collection Point List:</h4>
        <asp:RadioButtonList ID="radioButtonList" runat="server" OnSelectedIndexChanged="radioButtonList_Changed" AutoPostBack="true">
        </asp:RadioButtonList>

        <br />
        <div>
            <asp:LinkButton runat="server" CssClass="btn btn-primary" Text="Update Collection Point" OnClick="UpdateCollectionBtn_Click" ></asp:LinkButton>
        </div>
    </div>
</asp:Content>
