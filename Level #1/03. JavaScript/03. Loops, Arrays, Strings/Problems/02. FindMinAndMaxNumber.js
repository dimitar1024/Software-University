function FindMinAndMaxNumber(input) {

    var inp = input.replace(" ", "");
    var data = inp.split(",");
    var min = Number.MAX_VALUE;
    var max = Number.MIN_VALUE;

    for (var i = 0; i < data.length; i++) {
        item = parseInt(data[i]);
        if (item > max) {
            max = item;
        }

        if (item < min) {
            min = item;
        }
    }
    

    console.log("Min -> " + min);
    console.log("Max -> " + max);
}

console.log(FindMinAndMaxNumber("1, 2, 1, 15, 20, 5, 7, 31"));