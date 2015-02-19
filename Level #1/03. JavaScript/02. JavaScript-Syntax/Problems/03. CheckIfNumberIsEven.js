function evenNumber(number) {
    var number = number | 0;
    var isEven = true;

    if (number % 2 == 0) {
        isEven = true;
    }
    else {
        isEven = false;
    }

    return isEven
}
console.log(evenNumber(3));
console.log(evenNumber(127));
console.log(evenNumber(588));