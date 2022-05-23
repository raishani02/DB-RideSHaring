<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PassengerHistory.aspx.cs" Inherits="RideSharing.PassengerHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en" dir="ltr">
<head runat="server">
    <meta charset="utf-8" />
    <title>| PassengerHitory</title>
    <link rel="stylesheet" href="PassengerHome.css" />
	<link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
	<style>
	body{
		font-family: 'Times New Roman', sans-serif;
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

.table-box{
	margin: 50px auto;
}
.table-row{
	display: table;
	width: 80%;
	margin:10px;
	font-family: sans-serif;
	background: transparent;
	padding: 12px 0;
	color: black;
	font-size: 20px;
	box-shadow: 0 1px 4px 0 rgba(0,0,50,0.3);
	background-color:white;
}
.table-cell{
	display: table-cell;
	width: 30%;
	text-align: center;
	padding: 4px 0;
	border-right: 1px solid #d6d4d4;
	vertical-align: middle;
}
.table-head{
	background: #8665f7;
	box-shadow: none;
	color: #fff;
	font-weight: 600;
}
.first-cell{
	text-align: left;
	padding-left: 10px;
}
table-data{
	border: 1px solid #000;
	border-collapse: collapse;
}
table-data: nth-child(even){
	background-color: #fff;
}
table-data: nth-child(odd){
	background-color: #ddd;
}
 section .BOX{
            font-size:25px;
           
            color:white;
            margin-top: 50px;
            
        }

</style>
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
                <div class="text" >Ride <span>Sharing| Passenger History</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
            <!-- END: left side menu of logout -->
			
			<center>
            <div class= "BOX">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
				</center>
			</section>
        <!-- END: BackGround Image-->

    </form>
</body>
</html>
