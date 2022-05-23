<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostRide.aspx.cs" Inherits="RideSharing.PostRide" %>

<!DOCTYPE html>

<link rel="stylesheet" href="PostRideStyle.css"/>  <!-- add CSS file in HTML -->
<script src="PostRideScript.js"></script>            <!-- add JAVAscript file in HTML --> 
<link rel="stylesheet" href="PassengerHome.css"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>| PostRide</title>
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
                    <a href="DriverHome.aspx">
                        <i class="fas fa-home"></i><span>Home</span> 
                    </a>
                </li>
                

                <li>
                    <a href="DriverEditProfile.aspx">
                        <i class="fas fa-edit"></i> Edit Profile 
                    </a>
                </li>
                <li>
                    <a href="PostRide.aspx">
                        <i class="fas fa-person-booth"></i> Post Ride
                    </a>
                </li>
                 <li>
                        <a href="DriverViewRating.aspx">
                            <i class="fas fa-star"></i> View Ratings
                        </a>
                  </li>
                
                <li>
                    <a href="DriverHistory.aspx">
                        <i class="fas fa-history"></i> History 
                    </a>
                </li>
               <li>
                    <a href="DriverChangeVehicle.aspx">
                        <i class="fas fa-adjust"></i> Update Vehicle 
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
                <div class="text" >Ride <span>Sharing </span>|<span> Post Ride</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
        <center>
        <!-- Current Location Menu -->
       <div class="Box1"> Starting Location:   
        <asp:DropDownList ID="Starting_Location" runat="server">
        <asp:ListItem Text="Lahore"></asp:ListItem>
        <asp:ListItem Text="karachi"></asp:ListItem>
        <asp:ListItem Text="Sialkot"></asp:ListItem>
        </asp:DropDownList>
        <br /> <br />
        
        <!-- Ending Location Menu -->
        Select Ending Location:         
        <asp:DropDownList ID="Ending_Location" runat="server">
        <asp:ListItem Text="Islamabad"></asp:ListItem>
        <asp:ListItem Text="Abbotobad"></asp:ListItem>
        <asp:ListItem Text="Naran"></asp:ListItem>
        </asp:DropDownList>
        <br /> <br />

       <!-- Number of Passengers Menu -->
        Select Total Passengers:         
        <asp:DropDownList ID="Number_of_Passengers" runat="server">
            <asp:ListItem Text="0"></asp:ListItem>
            <asp:ListItem Text="1"></asp:ListItem>
            <asp:ListItem Text="2"></asp:ListItem>
            <asp:ListItem Text="3"></asp:ListItem>
            <asp:ListItem Text="4"></asp:ListItem>
        </asp:DropDownList>
        <br /> <br />

        <!--Calculate fare for each passenger -->
        
       <asp:Button ID="Button3" OnClick="car_detail" runat="server"  Text="Car Detail" />
       <br /><br />
           <div class="Box2">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
               </div>
       <br />
           <!--Post a Ride -->
        <asp:Button ID="Button2" OnClick="post" runat="server" Text="Post" />
        <!--Go to Home Page of driver -->
           <br/><br/>
           <asp:Button ID="Button4" OnClick="Start_ride" runat="server" Text="Start Ride" />
            <br/><br/>
        <asp:Button ID="Button1" OnClick="Complete_ride" runat="server" Text="Complete Ride" />
           </div>
        </center>
            </section>
    </form>
</body>
</html>
