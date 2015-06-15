<%@ Page Title="Retriving List" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreRetrival.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreRetrival" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="row">
            <h3>Retriver History</h3>
        <div class="row" style="height:800px; overflow-y:scroll;"><!--Current Request Row-->
            <asp:GridView ID="retriverTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="retriverTable_RowCommand">
                <Columns>
                    
                    <asp:BoundField DataField="RetriverNum" HeaderText="Retriver ID" />
                    <asp:BoundField DataField="RetriverDate" HeaderText="Request Date" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:ButtonField CommandName="detail" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail"/>
                </Columns>
                <EmptyDataTemplate>
                    <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Request ID</th>
                        <th scope="col">Request Date</th>
                        <th scope="col">Status</th>
                        <th scope="col">Description</th>
                        <th scope="col">Detail</th>
                    </tr>
                    <tr>
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

        </div>

    </div>

</asp:Content>
