function doubleRakiyaNumbers(arr) {
    var start = Number(arr[0]);
    var end = Number(arr[1]);
    var isRakia = false;
    var result = "<ul>" + "\n";
    for (var i = start; i <= end; i++) {

        var number = i;

        function isTwice(number) {
            var output = [];

            while (number) {
                output.push(number % 100);
                number = Math.floor(number / 10);
            }
            output = output.reverse();

            for (var i = 0; i < output.length - 1; i++) {
                var left = output[i];
                for (var j = i+2; j < output.length; j++) {
                    var right = output[j];

                    if (left === right) {
                        return true;
                    }
                }
            }

            return false;
        }
        isRakia = isTwice(number);


        if (isRakia) {
            result += "<li><span class='rakiya'>" + i + '</span><a href="view.php?id='+ i +">View</a></li>"+"\n";
        }
        else {
            result += "<li><span class='num'>" + i + "</span></li>" + "\n";
        }
    }

    result += "</ul>";
    console.log(result) ;
}
doubleRakiyaNumbers([5, 8]);
doubleRakiyaNumbers([11210, 11215]);
doubleRakiyaNumbers([55555, 55560]);
