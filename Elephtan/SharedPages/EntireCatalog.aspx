<%@ Page Title="View Entire Catalog" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="EntireCatalog.aspx.cs" Inherits="Elephtan.SharedPages.EntireCatalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>Stationary Catalog</h3>
        <hr />
        <div id="entireCatalogPanel" style="height:600px; width:100%; overflow-y:scroll;border:solid #EDEDED 1px;">
            <asp:GridView ID="entireCatalogTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="entireCatalogAddBtn_Click">
            <Columns>
                <asp:BoundField DataField="ItemNumber" HeaderText="Item Number" />
                <asp:BoundField DataField="Catagory" HeaderText="Gatagory" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="UnitOfMeasure" HeaderText="UnitOfMeasure" />
                
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox runat="server" type="number" placeholder="Quantity" ID="quantityTextBox" AutoPostBack="false"></asp:TextBox>
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
        <br />
        <asp:LinkButton runat="server" ID="showEntireCatalogBtn" CssClass="btn btn-default pull-right" Text="Back to Request Page" OnClick="backBtn_Click"></asp:LinkButton>
        </div>
</asp:Content>
