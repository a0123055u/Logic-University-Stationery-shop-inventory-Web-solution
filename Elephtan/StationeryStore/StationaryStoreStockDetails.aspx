<%@ Page Title="Stock Details" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreStockDetails.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreStockDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div>
        <h3>Stock Details</h3>
        <div class="input-group">
            <asp:TextBox ID="itemSearchBox" CssClass="form-control input-group-sm" placeholder="Search using Code OR Item Name OR Category" runat="server"></asp:TextBox>
            <span class="input-group-btn">
                <asp:LinkButton runat="server" CssClass="btn btn-info" OnClick="searchBtn_Click">Search</asp:LinkButton>
            </span>
        </div>
        </div>
        <div style="border:solid #EDEDED 1px; height:600px; width:100%; overflow-y:scroll">
        <asp:GridView ID="stockDetailTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="stockItemDetail_Click">
            <Columns>
                <asp:BoundField DataField="ItemID" HeaderText="Item ID" />
                <asp:BoundField DataField="Catagory" HeaderText="Category" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="UnitOfMeasure" HeaderText="Unit Of Measure" />
                <asp:BoundField DataField="CurrentStock" HeaderText="Current Stock" />
                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Category</th>
                        <th scope="col">Description</th>
                        <th scope="col">Unit Of Measure</th>
                        <th scope="col">Current Stock</th>
                        <th scope="col">Detail</th>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:GridView>
        </div>
    </div>
</asp:Content>
