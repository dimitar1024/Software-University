function findLargestBySumOfDigits(arr) {
    var numbers = [];

    for (var i = 0; i < arr.length; i++) {
        numbers.push(arr[i].toString().replace('-',''));
    }
    var bigSum = 0;
    var currentSum = 0;
    var index = 0;
    for (var i = 0; i < numbers.length; i++) {
        var num = numbers[i];
        for (var j = 0; j < num.length; j++) {
            var digit = parseInt(num[j]);
            currentSum += digit;
        }

        if (currentSum > bigSum) {
            bigSum = currentSum;
            index = i;
        }
        currentSum = 0;
    }

    console.log(numbers[index]);
}


findLargestBySumOfDigits([33, 44, -99, 0, 20]);