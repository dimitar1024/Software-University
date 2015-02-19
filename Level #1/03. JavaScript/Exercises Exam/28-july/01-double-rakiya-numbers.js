function solve(arr) {
    var start = parseInt(arr[0]);
    var end = parseInt(arr[1]);
    console.log("<ul>");
    for (var i = start; i <= end; i++) {
        if (isDoubleRakiyaNum(i)) {
            console.log("<li>" +
                "<span class='rakiya'>" + i + "</span>" +
                "<a href=\"view.php?id=" + i + "\">View</a>" +
                "</li>")
        } else {
            console.log("<li><span class='num'>" + i + "</span></li>")
        }
    }
    console.log("</ul>");

    function isDoubleRakiyaNum(i) {
        var numStr = '' + i;
        var existingPairs = {};
        for (var j = 1; j < numStr.length; j++) {
            var pair = numStr.substr(j - 1, 2);
            if (existingPairs[pair]) {
                if (j - existingPairs[pair] >= 2) {
                    return true;
                }
            } else {
                existingPairs[pair] = j;
            }
        }
        return false;
    }
}

solve([55555,55560]);