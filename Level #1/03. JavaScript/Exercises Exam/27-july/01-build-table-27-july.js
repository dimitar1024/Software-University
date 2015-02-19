function solve(arr) {
    var start = parseInt(arr[0]);
    var end = parseInt(arr[1]);
    
    var fibNums = calcFibonacciNums(end);
    function calcFibonacciNums(maxNum) {
        fibNums = { 1: true };
        var f1 = 1;
        var f2 = 1;
        while (true) {
            var f3 = f1 + f2;
            if (f3 > maxNum) {
                return fibNums;
            }
            fibNums[f3] = true;
            f1 = f2;
            f2 = f3;
        }
    }
    var result = "<table>\n";
    result += "<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n";

    for (var i = start; i <= end; i++) {
        var isFibonacci = fibNums[i] ? "yes" : "no";
        result += "<tr><td>" + i + "</td><td>" + (i * i) + "</td><td>" + isFibonacci +
        "</td></tr>\n"
    }

    result += "</table>";
    console.log(result);
}

solve([2, 6]);