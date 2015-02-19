function currentTime() {
    var d = new Date();
    var hours = d.getHours();
    var mins = d.getMinutes();
    var toString = (hours + " : " + mins);

    return toString;
}
console.log(currentTime());