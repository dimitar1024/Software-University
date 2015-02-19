function calcCylinderVol(number) {
	var kw = number;
	var hp = kw * 1.34102;
	hp = hp.toFixed(2);
	return hp;
}
console.log(calcCylinderVol(75));
console.log(calcCylinderVol(150));
console.log(calcCylinderVol(1000));