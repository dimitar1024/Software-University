function divisionBy3(number) {
    
    var number = number | 0;
    var ask = "";
    if (number % 3 == 0) {
        ask = "the number is divided by 3 without remainder";
    }
    else {
        ask = "the number is  not divided by 3 without remainder";
    }


    return ask;
}
console.log(divisionBy3(12));
console.log(divisionBy3(188));
console.log(divisionBy3(591));