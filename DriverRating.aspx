<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverRating.aspx.cs" Inherits="RideSharing.DriverRating" %>

<!DOCTYPE html>
<link rel="stylesheet" href="DriverRatigstyle.css"/>
<link rel="stylesheet" href="customersupportstyle.css"/>  <!-- add CSS file in HTML -->
<link rel="stylesheet" href="PassengerHome.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
 
<head runat="server">
        <title>| RateYourRide</title>
   <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 

</head>
<body>
    <form id="form2" runat="server">
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
                <div class="text" >Ride <span>Sharing</span>| <span>Ratings</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>




        <center>
            <div class="Box1">

	       
		        <h1>Rate your last trip </h1>
	
            <br/><br/>
            Give Ratings from 1-5
                <br/><br/>
               <asp:DropDownList ID="list1" runat="server">
            
                    <asp:ListItem Text="1"></asp:ListItem>
                    <asp:ListItem Text="2"></asp:ListItem>
                    <asp:ListItem Text="3"></asp:ListItem>
                    <asp:ListItem Text="4"></asp:ListItem>
                   <asp:ListItem Text="5"></asp:ListItem>
               </asp:DropDownList>
	
            <br/><br/>
              Enter Driver Contact Number:
             <br/> <br/>
             <asp:TextBox ID="TextBox1" runat="server" pattern="[0-9]{4}-[0-9]{7}" requiredmaxlength="12"></asp:TextBox>   <br/><br/><br/>              
             
                <asp:TextBox ID="TextBox2" style="height:60px;" runat="server"></asp:TextBox>
                 
            <br/> <br/>
             Are there any comments or suggestions you'd like to share with us?
             <br/><br/>
       
   
            
             <asp:Button ID="submit" runat="server" OnClick="submitformRating" Text="Submit"></asp:Button>
            
                </div>
            </center>
            </section>
    </form>
</body>
</html>

