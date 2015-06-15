<%@ Page Title="Order Payment Status" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreOrderStatus.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreOrderStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Order Status</h3>
        <hr />
        <div id="orderPanel" style="height:600px; width:100%; overflow-y:scroll;border:solid #EDEDED 1px;">
            <asp:GridView ID="ordersTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="detailBtn_Click">
            <Columns>
                <%--<asp:BoundField DataField="RequestId" HeaderText="Order ID" />--%>
                <asp:BoundField DataField="RequestId" HeaderText="Request ID" />
                <asp:BoundField DataField="RequestDate" HeaderText="Order Date" />
                <asp:BoundField DataField="Supplier" HeaderText="Supplier" />
                <asp:BoundField DataField="Description" HeaderText="Request Items" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Order ID</th>
                        <th scope="col">Order Date</th>
                        <th scope="col">Supplier</th>
                        <th scope="col">Request Items</th>
                        <th scope="col">Status</th>
                        <th scope="col">Detail</th>
                    </tr>
                    <tr>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:GridView>            
        </div>
        <br />
    </div>

</asp:Content>
