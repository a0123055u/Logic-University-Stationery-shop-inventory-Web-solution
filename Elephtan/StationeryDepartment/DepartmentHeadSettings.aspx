<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DepartmentHeadSettings.aspx.cs" Inherits="Elephtan.StationeryDepartment.DepartmentHeadSettings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Settings</h1>
    <div>
        <h3>Current Delegation: </h3>
        <asp:GridView ID="CurrentDelegationTable" CssClass="table table-responsive table-hover" BorderColor="Transparent" runat="server" AutoGenerateColumns="false" OnRowCommand="cancelDelegation_Click">
            <Columns>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name" />
                <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
                <asp:BoundField DataField="EndDate" HeaderText="End Date" />
                <asp:ButtonField CommandName="detail" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Cancel" HeaderText="Cancel" />
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color: Transparent; border-collapse: collapse;">
                    <tr>
                        <th scope="col">Staff Name</th>
                        <th scope="col">Start Date</th>
                        <th scope="col">End Date</th>
                        <th scope="col">Cancel</th>
                    </tr>
                    <tr>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                    </tr>
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
    <div>
        <h3>Current Department Representitve</h3>
        <asp:GridView ID="CurrentRepresentitveTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name" />
                <asp:BoundField DataField="CollectionPoint" HeaderText="Collection Point" />
                <%--<asp:ButtonField CommandName="detail" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail" />--%>
            </Columns>
            <EmptyDataTemplate>
                <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color: Transparent; border-collapse: collapse;">
                    <tr>
                        <th scope="col">Staff Name</th>
                        <th scope="col">Collection Point</th>
                    </tr>
                    <tr>
                        <td>N/A</td>
                        <td>N/A</td>
                    </tr>
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
    <hr />
    <div>
        <h3>Staff List</h3>
        <asp:GridView ID="StaffListTable" BorderColor="Transparent" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" OnRowCommand="StaffListTable_RowCommand">
            <Columns>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name" />
                <asp:BoundField DataField="EmailAddress" HeaderText="Email Address" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                <asp:ButtonField CommandName="Assign" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Assign" HeaderText="Assign" />
            </Columns>
            <EmptyDataTemplate>
                N/A
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
