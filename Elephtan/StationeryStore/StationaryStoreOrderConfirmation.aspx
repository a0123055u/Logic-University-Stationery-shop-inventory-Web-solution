﻿<%@ Page Title="Order Confirmation Detail" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreOrderConfirmation.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreOrderConfirmation" %>
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
            <h3>Order Confirmation Details</h3>
            <div class="co-sm-6" style="margin-top:20px;" id="DetailPanel">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label">Request Date: </asp:Label>
                    <asp:TextBox runat="server" ID="requestDetailDate" Enabled="false" CssClass="form-control input-sm"></asp:TextBox>

                    <br />
                    <asp:Label runat="server" CssClass="control-label">Staff Name: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="staffName" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                </div>
                <hr />
                <h4>Item List</h4>

                <asp:GridView ID="requestDetailTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowDataBound="requestDetail_OnRowDataBound">
                    <Columns>
                        <asp:BoundField DataField="Catagory" HeaderText="Category" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                        <asp:BoundField DataField="UnitOfMeasure" HeaderText="Unit Of Measure" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />

                        <asp:TemplateField HeaderText="Supplier">
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="supplierList" CssClass="form-control input-sm">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>

                    </Columns>
                    <EmptyDataTemplate>
                        <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" id="ContentPlaceHolder1_requestDetailTable" style="border-color:Transparent;border-collapse:collapse;">
                            <tr>
                                <th scope="col">Category</th>
                                <th scope="col">Description</th>
                                <th scope="col">Unit Of Measure</th>
                                <th scope="col">Quantity</th>
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
                <div class="row">
                    <asp:LinkButton ID="backButton" runat="server" CssClass="btn btn-default" Text="Back" OnClick="backButton_Click"></asp:LinkButton>
                    <asp:LinkButton ID="deleteButton" runat="server" CssClass="btn btn-danger" Text="Confirm" OnClick="confirmButton_Click"></asp:LinkButton>
                </div>
            </div>
        </div>


</asp:Content>
