
function getOrder() {
 head1="";
 head2="";
 var subTotal = 0;
 var sizeTotal = 0;
 var sizeArray = document.getElementsByClassName("size");
		for (var i=0; i<sizeArray.length;i++) 
		 {
			if (sizeArray[i].checked) {
				var selectedSize = sizeArray[i].value;
				head1=head1+selectedSize+"<br />";
			}
		}
		if (selectedSize === "personal") {
			sizeTotal = 6;
			head2=head2+sizeTotal+"<br />";
		} else if (selectedSize === "medium") {
				sizeTotal = 10;
				head2=head2+sizeTotal+"<br />";
		} else if (selectedSize === "large") {
				sizeTotal = 14;
				head2=head2+sizeTotal+"<br />";
		} else if (selectedSize === "extra_large") {
				sizeTotal = 16;
				head2=head2+sizeTotal+"<br />";
		}
		subTotal = sizeTotal;
		getMeat(subTotal,head1,head2);
};

function getMeat(subTotal,head1,head2) {
	var subTotal = subTotal;
	var meatTotal = 0;
	var selectedMeat = [];
	var meatArray = document.getElementsByClassName("meats");
		for (var j=0; j<meatArray.length; 
		j++) {
			if (meatArray[j].checked) {
					selectedMeat.push(meatArray[j].value);
			}
			
		}
		var countMeat = selectedMeat.length;
		if (countMeat > 1) {
			meatTotal = (countMeat - 1);
		} else {
			meatTotal = 0;
		}
		subTotal = (subTotal + meatTotal);
		for (var j = 0; j<selectedMeat.length; j++) {
					head1 = head1+selectedMeat[j]+"<br />";
					if (countMeat <= 1) {
						head2 = head2+0+"<br />";
						countMeat = (countMeat - 1);
					} else if (countMeat == 2) {
							head2 = head2+1+"<br />";
							countMeat = (countMeat - 1);
					} else {
							head2 = head2+1+"<br />";
							countMeat = (countMeat - 1);
					}
					}
				getVeg(subTotal,head1,head2);
					
					
};


function getVeg(subTotal,head1,head2) {
	var vegTotal = 0;
	var selectedVeg = [];
	var vegArray = document.getElementsByClassName("veg");
		for (var k = 0; k<vegArray.length; k++) {
				if (vegArray[k].checked){
						selectedVeg.push(vegArray[k].value);
				}
		}
		var countVeg = selectedVeg.length;
		if (countVeg >1) {
				vegTotal = (countVeg -1);
		} else {
			vegTotal= 0;
		}
		subTotal = (subTotal + vegTotal);
		for (var k = 0; k<selectedVeg.length; k++){
			head1 = head1+selectedVeg[k]+"<br />";
			if (countVeg <=1) {
				head2 = head2+0+"<br />";
				countVeg = (countVeg - 1);
			} else if (countVeg == 2) {
				head2 = head2+1+"<br />";
				countVeg = (countVeg - 1);
			} else {
				head2 = head2+1+"<br />";
				countVeg = (countVeg - 1);
			}
		}
		getCheese(subTotal,head1,head2);
};
function getCheese(subTotal,head1,head2) {
	var totalCheese = 0;
	var selectedCheese = [];
	var cheeseArray = document.getElementsByClassName("cheese");
		for (var l = 0; l<cheeseArray.length; l++) {
			if (cheeseArray[l].checked) {
			selectedCheese = cheeseArray[l].value;
			} 
			if (selectedCheese === "extra") {
				totalCheese = 3;
			}
		} 
		head1 = head1+selectedCheese+"<br />";
		head2 = head2+totalCheese+"<br />";
		subTotal = (subTotal + totalCheese);
		getSauce(subTotal,head1,head2);
};
function getSauce(subTotal,head1,head2) {
	var sauceArray = document.getElementsByClassName("sauce");
		for (var m = 0; m<sauceArray.length; m++) {
			if (sauceArray[m].checked) {
					selectedSauce = sauceArray[m].value;
					head1 = head1+selectedSauce+"<br />";
			}
		}
		head2 = head2+0+"<br />";
		getCrust(subTotal,head1,head2);
};
function getCrust(subTotal,head1,head2) {
	var totalCrust = 0;
	var selectedCrust = [];
	var crustArray = document.getElementsByClassName("crust");
		for(var n = 0; n <crustArray.length; n++) {
			if (crustArray[n].checked) {
				selectedCrust = crustArray[n].value;
				head1 = head1+selectedCrust+"<br />";
			}
			 if (selectedCrust === "cheese_stuffed") {
				totalCrust = 3;
			}
		}
		subTotal = (subTotal + totalCrust);
		head2 = head2+ totalCrust+"<br />";
		
		document.getElementById("order").style.opacity =1;
		document.getElementById("showhead1").innerHTML = head1;
		document.getElementById("showhead2").innerHTML = head2;
		document.getElementById("total2").innerHTML = "</h3>$"+subTotal+".00"+"</h3>";
};
//code to reset form
function clearForm() {
	document.getElementById("menu_form").reset();
	document.getElementById("order").style.opacity=0;
};
