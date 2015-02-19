function calcCylinderVol(radius, height) {
    var areaBasic = radius * radius * Math.PI;
    var volume = areaBasic * height;
    volume = volume.toFixed(3);
    return volume;
}
console.log(calcCylinderVol(2, 4));
console.log(calcCylinderVol(5, 8));
console.log(calcCylinderVol(12, 3));