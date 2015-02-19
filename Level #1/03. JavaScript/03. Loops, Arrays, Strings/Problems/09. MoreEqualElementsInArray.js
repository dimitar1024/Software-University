function moreEqualElementsInArray(arr) {
    var numbers = arr;

    numbers = numbers.sort(function (a, b) { return a - b });

    var index = 0;
    var maxSequence = 0;
    var counter = 0;

    for (var i = 0; i < arr.length; i++) {
        counter = 0;
        var j = i;

        while (arr[i] == arr[j]) {
            counter++;
            j++;
            if (j >= arr.length) {
                break;
            }
        }

        if (counter > maxSequence) {
            maxSequence = counter;
            index = i;
        }
    }
    
    var exit = ("" + arr[index] + " (" + maxSequence + " times) ");

    console.log(exit);

}

console.log(moreEqualElementsInArray([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));