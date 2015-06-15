<%@ Page Title="" Language="C#" MasterPageFile="~/SharedPages/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DepartmentHeadOverview.aspx.cs" Inherits="Elephtan.StationeryDepartment.DepartmentHeadOverview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Overview</h1>
        <%--<h3>Department Top Consumed Stationaries in Past</h3>
        <div class="row"><!--Chart Row-->
            <div class="col-sm-4">
                <canvas id="chart01" width="150" height="150"></canvas>
            </div>
            <div class="col-sm-4">
                <canvas id="chart02" width="150" height="150"></canvas>
            </div>
            <div class="col-sm-4">
                <canvas id="chart03" width="150" height="150"></canvas>
            </div>
        </div>--%>
        <hr />
        <div class="row"><!--Current Request Row-->
            <h3>Past Approved Requests</h3>
            <asp:GridView ID="pastApprovedTable" BorderColor="Transparent" 
                runat="server" CssClass="table table-responsive table-hover" 
                DataKeyNames="RequestId"
                AutoGenerateColumns="false" OnRowCommand="pastApprovedTable_RowCommand">
                <Columns>
                    <asp:BoundField DataField="RequestId" HeaderText="Requisition Id" Visible="false" ></asp:BoundField>
                    <asp:BoundField DataField="RequestDate" HeaderText="Request Date" />
                    <asp:BoundField DataField="RequestDescription" HeaderText="Description" />
                    <asp:ButtonField CommandName="detail" ControlStyle-CssClass="btn btn-info btn-xs" ButtonType="Button" Text="Detail" HeaderText="Detail"/>
                </Columns>
                <EmptyDataTemplate>
                    <table class="table table-responsive table-hover" cellspacing="0" rules="all" border="1" style="border-color:Transparent;border-collapse:collapse;">
                    <tr>
                        <th scope="col">Request Date</th>
                        <th scope="col">Description</th>
                        <th scope="col">Detail</th>
                    </tr>
                    <tr>
                        <td>N/A</td>
                        <td>N/A</td>
                        <td>N/A</td>
                    </tr>
                </table>
                </EmptyDataTemplate>
            </asp:GridView>
        </div>

        <script>

            var data = [
                {
                    value: 300,
                    color: "#F7464A",
                    highlight: "#FF5A5E",
                    label: "Red"
                },
                {
                    value: 50,
                    color: "#46BFBD",
                    highlight: "#5AD3D1",
                    label: "Green"
                },
                {
                    value: 100,
                    color: "#FDB45C",
                    highlight: "#FFC870",
                    label: "Yellow"
                }
            ];

            var options = {
                legendTemplate: "TestLegendTemplate"
            };

            var ctx1 = $('#chart01').get(0).getContext('2d');
            var myPieChart = new Chart(ctx1).Pie(data);

            var ctx2 = $('#chart02').get(0).getContext('2d');
            var myPieChart = new Chart(ctx2).Pie(data);

            var ctx3 = $('#chart03').get(0).getContext('2d');
            var myPieChart = new Chart(ctx3).Pie(data);
        </script>

</asp:Content>
