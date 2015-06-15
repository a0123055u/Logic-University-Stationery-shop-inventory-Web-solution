<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreDisbursement.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreDisbursement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>Disbursment</h3>
        <hr />
        <div id="disbursementPanel" style="height:600px; width:100%; overflow-y:scroll;border:solid #EDEDED 1px;">
            <asp:GridView ID="disbursementTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="detailBtn_Click">
            <Columns>
                <asp:BoundField DataField="DisbursementId" HeaderText="Request ID" />
                <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
                <asp:BoundField DataField="Department" HeaderText="Department" />
                <asp:BoundField DataField="RequestItems" HeaderText="Request Items" />
                <asp:BoundField DataField="State" HeaderText="Status" />
                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Request ID</th>
                        <th scope="col">Request Date</th>
                        <th scope="col">Department</th>
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
        <%--<div class="row">
            <asp:LinkButton runat="server" ID="generateDisbursementList" Text="Generate Disbursement List" CssClass="btn btn-primary btn-sm pull-right"></asp:LinkButton>
        </div>--%>
    </div>

</asp:Content>
