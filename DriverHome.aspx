<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverHome.aspx.cs" Inherits="RideSharing.DriverHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <title>DriverHomePage</title>
        <!--  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" /> -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
     <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 

    <!--CSS start for sidebar and layout-->
    <style>
        body{
            font-family: 'Times New Roman', sans-serif;
            background: url(img/hg.jpeg) no-repeat center center/cover;
        }
       
        *{
            margin: 0;
            padding: 0;
            list-style: none;
            text-decoration: none;
        }
        .sidebar{
            position: fixed;
            left: -250px;
            width: 250px;
            height: 100%;
            background: #042331;
            transition: all .5s ease;
        }
        .sidebar header{
            font-size: 12px;
            color: white;
            text-align: center;
            line-height: 70px;
            background: #063146;
            user-select: none;
        }
        .sidebar ul a{
            display: block;
            height: 100%;
            width: 100%;
            line-height: 65px;
            font-size: 20px;
            color: white;
            padding-left: 40px;
            box-sizing:border-box;
            border-top: 1px solid rgba(255,255,255,.1);
            border-bottom: 1px solid black;
            transition: .4s;
        }
        ul li:hover a{
            padding-left: 50px;
        }
        .sidebar ul a i{
            margin-right: 16px;
        }
        #check{
            display: none;
        }
        label #btn, label #cancel{
            position: absolute;
            cursor: pointer;
            background: #808080;
            border-radius: 2px;
        }
        label #btn{
            left: 40px;
            top: 25px;
            font-size: 35px;
            color: white;
            padding: 3px 4px;
            transition: all .5s;
        }
        label #cancel{
            z-index: 1111;
            left: -205px;
            top: 17px;
            font-size: 20px;
            color: #0a5275;
            padding: 1px 1px;
            transition: all .5s ease;
        }
        #check:checked ~ .sidebar{
            left: 0;
        }
        #check:checked ~ label #btn{
            left: 250px;
            opacity: 0;
            pointer-events: none;
        }
        #check:checked ~ label #cancel{
            left: 205px;
        }

        #check:checked ~ section{
            margin-left:250px;
        }
        section
        {
            background-position: center;
            background-size: cover;
            height: 100vh;
            transition: all .5s;
        }
        section header{
            font-size: 22px;
            color: white;
            text-align:start;
            padding-left: 100px;
            line-height: 70px;
            background: #063146;
            user-select: none;
            width: 100%;
            height: 70px;
        }
        section header span{
            color: aqua;
        }
        section ul a{
            display: block;
            height: 100%;
            width: 100%;
        }
        section .right_area{
            padding: 5px;
            background: #19B3D3;
            text-decoration: none;
            float: right;
            margin-top: -30px;
            margin-right: 40px;
            border-radius: 2px;
            font-size: 12px;
            font-weight: 600;
        }
        section .right_area span{
            color: #fff;
        }
        section .Box{
            font-size:25px;
            text-decoration-color:white;
            color:white;
            margin-top: 50px;
            overflow: hidden;
        }
    </style>
    <!--CSS End for sidebar and layout-->

</head>
 
<body>
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
                <div class="text" >Ride <span>Sharing </span> | <span>Driver Home</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
            <!-- END: left side menu of logout -->
            <center>
                <h1 class= "Box">Personal Information</h1>
            <div class= "Box">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
                <br/><br/>
                <h1 class= "Box">Car Detail</h1>
            <div class= "Box">
                <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            </div>
        </center>
            
        </section>
        <!-- END: BackGround Image-->
        
           
    </form>
</body>
</html>