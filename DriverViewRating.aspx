<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverViewRating.aspx.cs" Inherits="RideSharing.DriverViewRating" %>


<!DOCTYPE html>
<link rel="stylesheet" href="DriverRatings.css"/>
<link rel="stylesheet" href="PassengerHome.css"/>
<link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />

<head runat="server">
        <title>DriverViewRating</title>
    <style>
section .Boxn{
            font-size:25px;
            text-decoration-color:white;
            color:white;
            margin-top: 50px;
            overflow: hidden;
        }   
</style>
  
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
                    <a href="DriverHome.aspx">
                        <i class="fas fa-home"></i><span> Home</span> 
                    </a>
                </li>
                

                <li>
                    <a href="DriverEditProfile.aspx">
                        <i class="fas fa-edit"></i> Edit Profile 
                    </a>
                </li>
                <li>
                    <a href="#">
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
                <div class="text" >Ride <span>Sharing</span>| <span>Ratings</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>

           
              <center>
                    <h1 class="Boxn">Ratings</h1>
                <div class="Boxn">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </div>
                  </center>

            </section>
    </form>
</body>
</html>


