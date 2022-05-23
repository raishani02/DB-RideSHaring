<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RideSharing.Login" %>

<!DOCTYPE html>
<script src="Functions.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <style>
body {
    font-family: sans-serif;
}

:before {
    background: url(img/hg.jpeg) no-repeat center center/cover;
    content: '';
    position: absolute;
    top: 0%;
    left: 0%;
    height: 100%;
    width: 100%;
    z-index: -1;
    opacity: 0.5;
    
}

.box {
    margin-top:-70px;
    border: 3px solid rgb(46, 204, 113);
    box-shadow: 9px 9px 8px rgb(211, 49, 49);
    background-color: #191919;
    text-align: center;
    transform: translate(-50, -50);
    width: 300px;
    padding: 103px;
    position: absolute;
    top: 20%;
    left: 38%;
}

.heading {
    font-size: 35px;
    text-align: center;
    color: white;
    font-weight: 500;
}

.box input[type='text'],
.box input[type='tel'],
.box input[type='password'] {
    border: 0px;
    text-align: center;
    display: block;
    width: 210px;
    margin: 15px auto;
    padding: 14px 10px;
    font-size: 16px;
    color: white;
    border: 2px solid#3498db;
    background: none;
    outline: none;
    border-radius: 24px;

}

.box input[type='text']:focus,
.box input[type='tel']:focus,
.box input[type='password']:focus {
    width: 280px;
    border-color: #2ecc71;
    transition: 0.25s;
}

.box input[type='submit'] {
    
    margin-top:60px;
    margin-left:20px;
    background: none;
    border: 2px solid #2ecc71;
    border-radius: 24px;
    font-size: 15px;
    color: grey;
    width: 130px;
    padding: 12px 14px;
    transition: 0.25s;
    cursor: pointer;
    outline: none;
    
}

.box button[id='submit']:hover {
    background-color: #2ecc71;
    color: black;
    width: 200px;
}

.menu-bar ul li a{

    display: block;
    padding: 102px;
    padding-left: 93px;
    margin: 18px;
    font-size: 23px;
    text-decoration: none;
}

a:link {
  color: white;
}

/* visited link */
a:visited {
    color: white;
}

/* mouse over link */
a:hover {
  color: blue;
}
b{
    color:white;
    margin: 15px auto;
    padding: 14px 10px;
}

.box [id=DropDownList1] {
    margin-top:200px;
    background: none;
    box-shadow:none;
    border: 2px solid #2ecc71;
    border-radius: 24px;
    font-size: 15px;
    color: grey;
    width: 130px;
    padding: 12px 14px;
    transition: 0.25s;
    text-align:center;
}
</style>
    <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 

</head>
<body>
    <form action="" method="POST" class="box" id="form1" runat="server" >
       <h1 class="heading">Login</h1>
       
            <asp:TextBox type="tel" placeholder="Contact No." runat="server" id="Cont" required maxlength="12"></asp:TextBox>
            <asp:TextBox type="password" placeholder="Password" runat="server" id="Pass" required minlength="8"></asp:TextBox>

             <asp:DropDownList CssClass="box" ID="DropDownList1" runat="server" >
            <asp:ListItem Text="User Type" Value="0"></asp:ListItem>
            <asp:ListItem Text="Driver" Value="Driver"></asp:ListItem>
            <asp:ListItem Text="Passenger" Value="Passenger"></asp:ListItem>
          </asp:DropDownList>
    
        <asp:Button id="submit" runat="server"  value="Login" OnClick="SubmitForm" text="submit"  />
        <b><br/><br/>Create new Account ?<br/><br/><b>
        <a href="SignUp.aspx" target="_blank">Sign Up</a>
        </form>
    </body>
</html>

