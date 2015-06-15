<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="Elephtan.SharedPages.signin"  enableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in SSIM</title>

        <!--       Favicon-->
        <link rel="icon" href="../Assets/Logo/favicon.ico">

        <!--        Style Sheet List-->
        <!--        Awesome Font-->
        <link rel="stylesheet" href="../FrontendLib/font-awesome-4.3.0/css/font-awesome.css">
        <!--        Bootstrap Stylesheet-->
        <link rel="stylesheet" href="../FrontendLib/bootstrap-3.3.2-dist/bootstrap-3.3.2-dist/css/bootstrap.min.css">
        <!--        Bootstrap Theme Spacelab-->
        <link rel="stylesheet" href="../FrontendLib/themeSpacelab.min.css">
        <!--        Page Stylesheet-->
        <link rel="stylesheet" href="sigin.css">

        <!--        Script List-->
        <!--    jQuery Script-->
        <script src="../FrontendLib/jquery-2.1.3.min.js"></script>
        <!--        Bootstrap Script-->
        <script src="../FrontendLib/bootstrap-3.3.2-dist/bootstrap-3.3.2-dist/js/bootstrap.min.js"></script>
        <!--        Page Script-->
        <script src="sigin.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="text-center" id="siginInstruction">
                <img src="../Assets/Logo/logo.png" alt="Login Logo" class="img-responsive center-block" id="logoImage">

                <h2>Stationery Store Inventory System</h2>
                <br>
                <h4>
                Sign in with your University Email Account
                </h4>
            </div>
            <div class="container col-sm-offset-4 col-sm-4">
                <div id="loginPanel">
                    <br/>
                    <form class="form-signin" id="form-signin">
                        <!--                <label for="inputEmail">Email Address</label>-->
                        <asp:TextBox ID="inputEmail" CssClass="form-control" placeholder="&nbsp;&#xf0e0; Email" runat="server" autofocus required ClientIDMode="Static" type="email" style="font-family: FontAwesome"></asp:TextBox>
                        <!--                <label for="inputPassword">Password</label>-->
                        <asp:TextBox ID="inputPassword" CssClass="form-control" placeholder="&nbsp;&#xf084; Password" runat="server" required type="password" style="font-family: FontAwesome"></asp:TextBox>

                        <asp:Button ID="buttonLogin" Text="Sign in" CssClass="btn btn-lg btn-primary btn-block" runat="server" OnClick="buttonLogin_Clicked" />
                        <div class="checkbox" id="checkboxSignedIn">
                            <label>
                                <asp:CheckBox ID="checkboxRememberMe" runat="server" ClientIDMode="Static" CssClass="checkbox" />Stay signed in
                            </label>
                        </div>
                    </form>
                </div>
            </div>
            <nav class="navbar navbar-default navbar-fixed-bottom" role="navigation">
                <div class="container text-center">
                    <p class="navbar-text col-md-12 col-sm-12 col-xs-12">
                        &copy;&nbsp;Logic Univeristy. Logic, Infinity Loop 1.
                    </p>
                </div>
            </nav>
    </form>
</body>
</html>
