function solve(arr) {
    var matrix = [];
    var outmatrix = [];
    for (var word = 0; word < arr.length; word++) {
        matrix[word] = arr[word].toLowerCase().split('');
    }

    for (var word = 0; word < arr.length; word++) {
        outmatrix[word] = arr[word].toLowerCase().split('');
    }

    for (var w = 1; w < matrix.length-1; w++) {
        var maxCol = Math.min(
            matrix[w - 1].length - 2,
            matrix[w].length - 3,
            matrix[w + 1].length - 2);
        for (var l = 0; l <= maxCol; l++) {
            var uplatter = matrix[w][l];
            var leftdownlatter = matrix[w][l + 1];
            var centerdownlatter = matrix[w][l + 2];
            var rightdownleatter = matrix[w - 1][l + 1];
            var downleatter = matrix[w + 1][l + 1];

            if (uplatter == leftdownlatter && leftdownlatter == centerdownlatter && centerdownlatter == rightdownleatter && uplatter == downleatter) {
                outmatrix[w][l] = ' ';
                outmatrix[w][l + 1] = ' ';
                outmatrix[w][l + 2] = ' ';
                outmatrix[w - 1][l + 1] = ' ';
                outmatrix[w + 1][l + 1] = ' ';
            }
        }
    }


    for (var word = 0; word < matrix.length; word++) {
        console.log(outmatrix[word].replace(' ', '').join(''));
    }


}

solve([
"ab**l5",
"bBb*555",
"absh*5",
"ttHHH",
"ttth"
]);