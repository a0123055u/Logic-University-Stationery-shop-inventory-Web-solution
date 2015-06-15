<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreDepartmentWaiting.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreDepartmentWaiting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Outstanding Items</h3>
        <hr />
        <div id="requestPanel" style="height:600px; width:100%; overflow-y:scroll;border:solid #EDEDED 1px;">
            <asp:GridView ID="requestsTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="requestDetailBtn_Click">
            <Columns>
                <asp:BoundField DataField="Department" HeaderText="Department" />
                <asp:BoundField DataField="RequestDescription" HeaderText="Outstanding Item" />
                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Department</th>
                        <th scope="col">Outstanding Item</th>
                        <th scope="col">Detail</th>
                    </tr>
                    <tr>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:GridView>

</asp:Content>
