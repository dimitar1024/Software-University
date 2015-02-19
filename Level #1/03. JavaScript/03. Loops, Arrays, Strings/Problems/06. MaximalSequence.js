function maximalSequence(arr) {
    var numbers = arr;

    var index =0;
    var maxSequence=0;
    var counter = 0;

    for (var i = 0; i < numbers.length; i++) {
        counter = 0;
        var j = i;

        while (numbers[i] == numbers[j]) {
            counter++;
            j++;
            if (j >=numbers.length) {
                break;
            }
        }

        if (counter > maxSequence) {
            maxSequence = counter;
            index = i;
        }
    }
    //print on Console
    var result = "";
    for (var j = index; j < index + maxSequence; j++) {
        result += numbers[index] + " ";

    }

    console.log(result);

}

console.log(maximalSequence([2,1,1,2,3,3,2,2,2,1]));