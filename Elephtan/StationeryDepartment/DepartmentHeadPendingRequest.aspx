<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DepartmentHeadPendingRequest.aspx.cs" Inherits="Elephtan.StationeryDepartment.DepartmentHeadPendingRequest" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h1>Pending Requests</h1>
        <asp:GridView ID="pendingRequestTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="pendingRequestDetail_Click">
            <Columns>
                <asp:BoundField DataField="RequestDate" HeaderText="Request Date" />
                <asp:BoundField DataField="Applicant" HeaderText="Applicant" />
                <asp:BoundField DataField="RequestDescription" HeaderText="Request Description" />
                <asp:ButtonField CommandName="action" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Action" HeaderText="Action" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Request Date</th>
                        <th scope="col">Applicant</th>
                        <th scope="col">Request Description</th>
                        <th scope="col">Action</th>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:GridView>

    </asp:Content>