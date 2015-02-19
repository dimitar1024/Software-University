function checkDigit(number) {
	var digit = ((number / 100) % 10) | 0;

	var isThree = true;
	if (digit == 3) {
		return isThree = true;
	}
	else {
		return isThree = false;
	}
}
console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));