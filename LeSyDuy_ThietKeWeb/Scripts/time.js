// JavaScript Document
function display_date(){
	var date = new Date();
	var current_day = date.getDay();
	var day_name;
	switch (current_day) {
		case 0:
   			day_name = "Chủ Nhật";
   			break;
		case 1:
   			day_name = "Thứ Hai";
   			break;
		case 2:
   			day_name = "Thứ Ba";
   			break;
		case 3:
   			day_name = "Thứ Tư";
   			break;
		case 4:
   			day_name = "Thứ Năm";
   			break;
		case 5:
   			day_name = "Thứ Sáu";
			break;
		case 6:
   			day_name = "Thứ Bảy";
			break;
	}
	var month = date.getMonth()+1;
	document.getElementById("date").innerHTML = "<font size = 6>" + day_name + ", " + date.getDate() + "/" + month + "/" + date.getFullYear() +"<br/>" + (date.getHours() < 10 ? "0" : "")+ date.getHours() + (date.getMinutes()<10 ? " : 0" : " : ")+ date.getMinutes()  + "</font>";
	window.setInterval(display_date, 60000);
}
