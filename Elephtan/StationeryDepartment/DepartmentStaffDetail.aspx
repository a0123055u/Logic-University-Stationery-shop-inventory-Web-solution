<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DepartmentStaffDetail.aspx.cs" Inherits="Elephtan.StationeryDepartment.DepartmentStaffDetail" %>
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
            <h3>Staff Details</h3>
            <div class="co-sm-6" style="margin-top:20px;" id="DetailPanel">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label">Department Name: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="departmentName" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Staff Name: </asp:Label>
                    <asp:TextBox runat="server" Enabled="false" ID="staffName" CssClass="form-control input-sm"></asp:TextBox>
                    <br />
                    <asp:Label runat="server" CssClass="control-label">Email Address: </asp:Label>
                    <asp:HyperLink runat="server" ID="staffEmail">placeholder@mail.com</asp:HyperLink>
                    <br />
                </div>
                <hr />
                <div>
                    <asp:Label runat="server" CssClass="control-label">Assigment Role</asp:Label>
                    <asp:DropDownList runat="server" ID="assignmentDropDownList" CssClass="form-control input-sm" OnSelectedIndexChanged="assignmentDropDownList_Changed" AutoPostBack="true">
                        <asp:ListItem Value="Representitve">Representitve</asp:ListItem>
                        <asp:ListItem Value="Delegation">Delegation</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <br />
                <div>
                    <asp:Label runat="server" CssClass="control-label">Start Date: </asp:Label>
                    <asp:TextBox runat="server" Enabled="true" ID="StartDate" CssClass="form-control input-sm" type="date"></asp:TextBox>
                    <asp:Label runat="server" CssClass="control-label">End Date: </asp:Label>
                    <asp:TextBox runat="server" Enabled="true" ID="EndDate" CssClass="form-control input-sm" type="date"></asp:TextBox>
                </div>
                <br />
                <div class="row">
                    <asp:LinkButton ID="backButton" runat="server" CssClass="btn btn-default" Text="Back" OnClick="backButton_Click"></asp:LinkButton>
                    <asp:LinkButton ID="assignButton" runat="server" CssClass="btn btn-success" Text="Assign" OnClick="assignButton_Click"></asp:LinkButton>
                </div>
            </div>
        </div>
</asp:Content>
