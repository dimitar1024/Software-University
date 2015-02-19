function solve(arr) {
    var matrix = [];
    var outmatrix = [];
    for (var word = 0; word < arr.length; word++) {
        matrix[word] = arr[word].split('');
    }
    
    for (var word = 0; word < arr.length; word++) {
        outmatrix[word] = arr[word].split('');
    }

    for (var w = 1; w < matrix.length; w++) {
        var maxCol = Math.min(
            matrix[w - 1].length - 2,
            matrix[w].length - 3);
        for (var l = 0; l <= maxCol; l++) {
            var uplatter = matrix[w][l];
            var leftdownlatter = matrix[w][l + 1];
            var centerdownlatter = matrix[w][l+2];
            var rightdownleatter = matrix[w - 1][l+1];

            if (uplatter == leftdownlatter && leftdownlatter == centerdownlatter && centerdownlatter == rightdownleatter) {
                outmatrix[w][l] = '*';
                outmatrix[w][l + 1] = '*';
                outmatrix[w][l+2] = '*';
                outmatrix[w - 1][l + 1] = '*';
            }
        }
    }


    for (var word = 0; word < matrix.length; word++) {
        console.log(outmatrix[word].join(''));
    }
    
    
}

solve(["abcdexgh","bbbdxxxh","abcxxxxx"]);