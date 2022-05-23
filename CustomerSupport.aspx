<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerSupport.aspx.cs" Inherits="RideSharing.CustomerSupport" %>

<!DOCTYPE html>

<link rel="stylesheet" href="customersupportstyle.css"/>  <!-- add CSS file in HTML -->
<link rel="stylesheet" href="PassengerHome.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
    
<script src="CustomerSupport.js"></script>            <!-- add JAVAscript file in HTML --> 


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>| Customer Support</title>
     <!-- add icon link -->
          <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 
</head>
   
<body1>
    <form id="form1" runat="server">
            <!-- START: create cross(cancel and menu botton on  the sidebar and out of the sidebar-->
        <input type="checkbox" id="check" />
        <label for="check">
            <i class="fas fa-bars" id="btn"></i>
            <i class="fas fa-times" id="cancel"></i>
        </label>
        <!-- END: create cross(cancel and menu botton on  the sidebar and out of the sidebar-->

        <!--sidebar start-->
        <div class="sidebar">
            <header>
                <div class="text" >UserName and PIC</div>
            </header>
            <ul>
                <li>
                    <a href="HomePassenger.aspx">
                        <i class="fas fa-home"></i><span> Home</span> 
                    </a>
                </li>
                <li>
                    <a href="PassengerEditProfile.aspx">
                        <i class="fas fa-edit"></i> Edit Profile 
                    </a>
                </li>
                <li>
                    <a href="#">
                        <i class="fas fa-person-booth"></i> Request Ride
                    </a>
                </li>
                <li>
                    <a href="DriverRating.aspx">
                        <i class="fas fa-star"></i> Give Ratings
                    </a>
                </li>
                <li>
                    <a href="PassengerHistory.aspx">
                        <i class="fas fa-history"></i> History 
                    </a>
                </li>
                <li>
                    <a href="CustomerSupport.aspx">
                        <i class="far fa-question-circle"></i> Custumer Support 
                    </a>
                </li>
                <li>
                    <a href="Login.aspx">
                        <i class="fas fa-power-off"></i> Logout 
                    </a>
                </li>
            </ul>
        </div>
        <!-- sidebar end-->

        <!-- START: BackGround Image -->
        <section>

            <!--image path is given in css part of that class-->
            <header>
                <div class="text" >Ride <span>Sharing</span>|<span> Customer Support</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
            <center>
                <div class="Box1">
                        <!-- Enter guidance -->
                        Enter guidance: 
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br /><br />

                        <!--Send guidance -->
                        Send guidance:
                        <asp:Button ID="Button1" runat="server" OnClientClick="calcf1()" Text="Send" />
                        <br /><br />
                        Enter Driver Contact#:
                        <asp:TextBox ID="TextBox3" runat="server" pattern="[0-9]{4}-[0-9]{7}" required maxlength="12"></asp:TextBox>
                        <!-- Enter complaint -->
                        <br /><br />
                        Enter complaint: 
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br /><br />

                        <!--Send complaint -->
                        Send complaint:
                        <asp:Button ID="Button2" OnClick="complain" runat="server" Text="Send"  />
                        <br /><br />

                         <!--Reset everything -->
                        <asp:Button ID="Button4" runat="server" OnClientClick="setval()"  Text="Reset" />
                         <br /><br />
                    </div>
                </center>
     
    </form>
</body1>
</html>
