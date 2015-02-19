function numberChecker(num) {
	
	var output = '';
	for (var i = 1; i <=num; i++) {
		
		if (i % 4 == 0) {
			continue;
		}
		if (i % 5 == 0) {
			continue;
		}
		
		output = output +" "+i+ ",";
	}

	console.log(output);
}


console.log(numberChecker(20));