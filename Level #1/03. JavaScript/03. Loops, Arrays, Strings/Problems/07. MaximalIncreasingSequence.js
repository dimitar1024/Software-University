function maximalSequence(arr) {
    var numbers = arr;


    var counter = 0;
    var maxSequence = 0;
    var index = 0;

    for (var i = 0; i < numbers.length - 1; i++) {
        counter = 0;
        var j = i + 1;
        var k = i;

        while (numbers[k] < numbers[j]) {
            counter++;
            j++;
            k++;
            if (j >= numbers.length) {
                break;
            }
        }
        if (counter > maxSequence) {
            maxSequence = counter;
            index = i;
        }

    }

    var result = "";
    for (var i = index; i <= index + maxSequence ; i++) {
        result += numbers[i] + " ";

    }
    console.log(result);
}

console.log(maximalSequence([3, 2, 3, 4, 2, 2, 4]));