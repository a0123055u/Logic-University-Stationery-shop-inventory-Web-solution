<%@ Page Title="Order Stationary" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="RequestStationary.aspx.cs" Inherits="Elephtan.SharedPages.RequestStationary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>Order Stationary</h3>
        <div class="input-group">
            <asp:TextBox ID="itemSearchBox" CssClass="form-control" placeholder="Search using Code OR Item Name OR Category" runat="server"></asp:TextBox>
            <span class="input-group-btn">
                <asp:LinkButton runat="server" CssClass="btn btn-info" OnClick="searchButton_Click">Search</asp:LinkButton>
            </span>
        </div>
    </div>
    <div class="row">
        <div style="border:solid #EDEDED 1px; height:300px; width:100%; overflow-y:scroll">
            <div id="searchResultPanel">
                <asp:GridView ID="searchResultTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="searchResultTable_RowCommand">
            <Columns>
                <asp:BoundField DataField="ItemNumber" HeaderText="Item Number" />
                <asp:BoundField DataField="Catagory" HeaderText="Catagory" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="UnitOfMeasure" HeaderText="Unit Of Measure" />
                
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox runat="server" type="number" ID="quantityTextBox" placeholder="Quantity" AutoPostBack="false"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="quantityTextBox" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Add" HeaderText="Action" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Item Number</th>
                        <th scope="col">Category</th>
                        <th scope="col">Description</th>
                        <th scope="col">Unit of Measure</th>
                        <th scope="col">Quantity</th>
                        <th scope="col">Action</th>
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
        </div>
        <br />
        <asp:LinkButton runat="server" ID="showEntireCatalogBtn" CssClass="btn btn-default pull-right" Text="View Entire Catalog" OnClick="showEntireCatalogBtn_Click"></asp:LinkButton>
    </div>
    <hr />
    <div class="row">
        <h3>Stationaries Added</h3>
        <div style="border:solid #EDEDED 1px; overflow-y:scroll; height:200px; width:100%;">
            <div id="stationariesAdded">
                <asp:GridView ID="stationariesAddedTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="stationariesAddedTable_RowCommand">
            <Columns>
                <asp:BoundField DataField="ItemNumber" HeaderText="Item Number" />
                <asp:BoundField DataField="Catagory" HeaderText="Gatagory" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="UnitOfMeasure" HeaderText="UnitOfMeasure" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />

                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-danger btn-xs" ButtonType="Button" Text="Remove" HeaderText="Action" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Item Number</th>
                        <th scope="col">Category</th>
                        <th scope="col">Description</th>
                        <th scope="col">Unit of Measure</th>
                        <th scope="col">Quantity</th>
                        <th scope="col">Action</th>
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
        </div>
        <br />
        <asp:LinkButton runat="server" ID="doneButton" CssClass="btn btn-primary pull-right btn-lg" Text="Done" OnClick="doneButton_Click"></asp:LinkButton>
    </div>
</asp:Content>
