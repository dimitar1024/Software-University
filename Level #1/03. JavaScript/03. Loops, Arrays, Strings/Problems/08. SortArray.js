function sortArray(arr) {
    var numbers = arr;
    var min;

    for (var i = 0; i < numbers.length; i++) {
        min = i;
        for (var j = i + 1; j < numbers.length; j++) {
            if (numbers[j] < numbers[min]) {
                min = j;
            }
        }
        var temp = numbers[i];
        numbers[i] = numbers[min];
        numbers[min] = temp;
    }

    console.log(numbers.join(" "));
}

console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));