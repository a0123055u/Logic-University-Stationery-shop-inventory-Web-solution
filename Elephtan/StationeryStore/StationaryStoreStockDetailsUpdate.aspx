<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStoreStockDetailsUpdate.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStoreStockDetailsUpdate" %>
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
            <h3>Stock Item Detail</h3>
            <div class="co-sm-6" style="margin-top:20px;" id="DetailPanel">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label">Item Number: </asp:Label>
                    <asp:TextBox runat="server" ID="itemNumber" Enabled="false" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Category: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="category" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Description: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="description" CssClass="form-control input-sm"></asp:TextBox>
                    <hr />
                    <asp:Label runat="server" CssClass="control-label">Reorder Leve: </asp:Label>
                    <asp:TextBox runat="server" Enabled="true" ID="reorderLevel" type="number" CssClass="form-control input-sm"></asp:TextBox>
                    <asp:Label runat="server" CssClass="control-label">Reorder Quantity: </asp:Label>
                    <asp:TextBox runat="server" Enabled="true" ID="reorderQuantity" type="number" CssClass="form-control input-sm"></asp:TextBox>
                    <asp:Label runat="server" CssClass="control-label">Current Stock Level: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="currentStockLevel" CssClass="form-control input-sm"></asp:TextBox>
                    <asp:TextBox runat="server" Enabled="true" ID="actualStockLevel" type="number" CssClass="form-control input-sm" OnTextChanged="actualStockLevel_Changed" AutoPostBack="true"></asp:TextBox>
   
                    <asp:TextBox runat="server" Enabled="false" ID="difference" CssClass="form-control input-sm"></asp:TextBox>
  
                    <asp:TextBox runat="server" Enabled="false" ID="value" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:TextBox runat="server" CssClass="form-control" Rows="3" ID="feedbackTextBox" placeholder="Feedback"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:LinkButton ID="backButton" runat="server" CssClass="btn btn-default" Text="Back" OnClick="backBtn_Click"></asp:LinkButton>

                    <asp:LinkButton ID="updateButton" runat="server" CssClass="btn btn-success" Text="Update" OnClick="updateBtn_Click"></asp:LinkButton>
                </div>
                </div>
        </div>

</asp:Content>
