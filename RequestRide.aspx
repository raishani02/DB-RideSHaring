<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestRide.aspx.cs" Inherits="RideSharing.RequestRide" %>

<!DOCTYPE html>

<link rel="stylesheet" href="RequestRideStyle.css"/>  <!-- add CSS file in HTML -->
<script src="RequestRideScript.js"></script>            <!-- add JAVAscript file in HTML --> 
<link rel="stylesheet" href="PassengerHome.css"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>| RequestRide</title>
     <!-- add icon link -->
          <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 
          <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />

</head>
   
<body>
    <form id="form1" runat="server">
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
                    <a href="RequestRide.aspx">
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
                <div class="text" >Ride <span>Sharing </span>|<span> Request Ride</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
        <center>
        <!-- Current Location Menu -->
       <div class="Box1">  
           <br/><br/>
        Select Starting Location:         
        <asp:DropDownList ID="Starting_Location" runat="server">
        <asp:ListItem Text="Lahore" ></asp:ListItem>
        <asp:ListItem Text="karachi" ></asp:ListItem>
        <asp:ListItem Text="Sialkot" ></asp:ListItem>
        </asp:DropDownList>
        <br /> <br />

        <!-- Ending Location Menu -->
        Select Ending Location:         
        <asp:DropDownList ID="Ending_Location" runat="server">
        
        <asp:ListItem Text="Islamabad" ></asp:ListItem>
        <asp:ListItem Text="Abbotobad" ></asp:ListItem>
        <asp:ListItem Text="Naran" ></asp:ListItem>
        </asp:DropDownList>
        <br /> <br />

        Enter Number of Passenger:         
        <asp:DropDownList ID="Passengers" runat="server">
        
        <asp:ListItem Text="1" ></asp:ListItem>
        <asp:ListItem Text="2" ></asp:ListItem>
        <asp:ListItem Text="3" ></asp:ListItem>
        <asp:ListItem Text="4" ></asp:ListItem>
        </asp:DropDownList>
        <br /> <br />
           
        <!--Enter Details --> 
        <asp:Button ID="Button1" OnClick="get_driver" runat="server" Text="Get Driver" />
        <br /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Button ID="Button2" OnClick="request" runat="server" Text="Request" />
        <br /><br />
          <asp:Button ID="Button3" OnClick="cancel" runat="server" Text="Cancel" />
        <br /><br />

       </div>
        </center>
    </form>
</body>
</html>

