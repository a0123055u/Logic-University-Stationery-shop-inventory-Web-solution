<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStorePendingVoucher.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStorePendingVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <h3>Pending Voucher</h3>
        <hr />
        <div id="voucherPanel" style="height:600px; width:100%; overflow-y:scroll;border:solid #EDEDED 1px;">
            <asp:GridView ID="vouchersTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="detailBtn_Click">
            <Columns>
                <asp:BoundField DataField="VoucherID" HeaderText="Voucher ID" />
                <asp:BoundField DataField="VoucherDate" HeaderText="Voucher Date" />
                <asp:BoundField DataField="IssueItems" HeaderText="Issue Items" />

                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Voucher ID</th>
                        <th scope="col">Voucher Date</th>
                        <th scope="col">Issue Item</th>
                        <th scope="col">Detail</th>
                    </tr>
                    <tr>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:GridView>       
        <br />   
        </div>
    </div>

</asp:Content>
