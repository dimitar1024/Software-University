function findNthDigit(arr) {
    var nth = Number(arr[0]);
    var number = arr[1].toString();
    console.log(number);

    var array = [];

    for (var i = 0; i < number.length; i++) {
        if (number[i] == '.') {
            continue;
        }
        array.push(parseInt(number[i]));
    }
    array = array.reverse();
    var exit = array[(nth-1)];
    
    if (exit == undefined) {
        exit = "The number doesn’t have " + nth + " digits";
    }

    console.log(exit);
}

findNthDigit([6, 888.88]);