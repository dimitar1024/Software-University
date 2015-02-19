function bitChecker(number) {
    var check = number >> 3;
    var bit = check & 1;
    var ask = true;
    if (bit == 1) {
        ask = true;
    }
    else {
        ask = false;
    }
    return ask;
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));