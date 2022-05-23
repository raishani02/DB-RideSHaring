
function calcf1() {
    var medium1 = document.getElementById('Starting_Location').value; //dropdown list
    var medium2 = document.getElementById('Ending_Location').value; //dropdown list  
    var medium3 = document.getElementById('Number_of_Passengers').value; //dropdown list  
    var temp = 123;
    document.getElementById('TextBox4').value = temp;
    temp /= parseInt(medium3);
    document.getElementById('TextBox1').value = temp;

}
// Reset all the values of web page
function setval() {
    //   var did = new Date();
    //did.getFullYear();
    document.getElementById('Starting_Location').value = "Select";
    document.getElementById('Ending_Location').value = "Select";
    document.getElementById('Number_of_Passengers').value = "1";
    document.getElementById('TextBox1').value = "";
    document.getElementById('TextBox2').value = "";
    document.getElementById('TextBox4').value = "";
}