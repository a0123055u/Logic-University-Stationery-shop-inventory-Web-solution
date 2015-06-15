<%@ Page Title="Pending Voucher Detail" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="StationaryStorePendingVoucherDetail.aspx.cs" Inherits="Elephtan.StationeryStore.StationaryStorePendingVoucherDetail" %>

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
            <h3>Pending Voucher Details</h3>
            <div class="co-sm-6" style="margin-top:20px;" id="DetailPanel">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label">Voucher Issue Date: </asp:Label>
                    <asp:TextBox runat="server" ID="voucherDetailDate" Enabled="false" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Voucher ID: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="voucherId" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Issue Item: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="issueItem" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Issue Amount: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="issueAmount" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                   
                </div>
                <hr />
                <br />
                <div class="row">
                    <asp:TextBox runat="server" CssClass="form-control" Rows="3" ID="feedbackTextBox" placeholder="Feedback"></asp:TextBox>
                </div>
                <br />
                <div class="row">
                    <asp:LinkButton ID="backButton" runat="server" CssClass="btn btn-default" Text="Back" OnClick="backBtn_Click"></asp:LinkButton>
                    <asp:LinkButton ID="rejectButton" runat="server" CssClass="btn btn-danger" Text="Reject" OnClick="rejectBtn_Click"></asp:LinkButton>
                    <asp:LinkButton ID="approveButton" runat="server" CssClass="btn btn-success" Text="Approve" OnClick="approveBtn_Click"></asp:LinkButton>
                </div>
            </div>
        </div>

</asp:Content>
