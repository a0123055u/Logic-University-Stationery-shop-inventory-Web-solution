<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreOrderDetail.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreOrderDetail" %>
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
    <div class="row">
            <h3>Order Status Details</h3>
            <div class="co-sm-6" style="margin-top:20px;" id="DetailPanel">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label">Order Date: </asp:Label>
                    <asp:TextBox runat="server" ID="orderDetailDate" Enabled="false" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Order ID: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="orderID" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Supplier Code: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="supplierCode" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Supplier Name: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="supplierName" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Contact Name: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="contactName" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Address: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="phoneNumber" CssClass="form-control input-sm"></asp:TextBox>
                </div>
                <hr />
                <h4>Item List</h4>

                <asp:GridView ID="orderDetailTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Catagory" HeaderText="Category" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                        <asp:BoundField DataField="UnitOfMeasure" HeaderText="Unit Of Measure" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    </Columns>
                    <EmptyDataTemplate>
                        <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" id="ContentPlaceHolder1_requestDetailTable" style="border-color:Transparent;border-collapse:collapse;">
                            <tr>
                                <th scope="col">Category ID</th>
                                <th scope="col">Category</th>
                                <th scope="col">Description</th>
                                <th scope="col">Unit Of Measure</th>
                                <th scope="col">Quantity</th>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                </asp:GridView>
                <br />
                <div class="row">
                    <asp:LinkButton ID="backButton" runat="server" CssClass="btn btn-default" Text="Back" OnClick="backBtn_Click"></asp:LinkButton>
                    <asp:LinkButton ID="approveButton" runat="server" CssClass="btn btn-success" Text="Receive" OnClick="receiveBtn_Click"></asp:LinkButton>
                </div>
            </div>
        </div>
</asp:Content>
