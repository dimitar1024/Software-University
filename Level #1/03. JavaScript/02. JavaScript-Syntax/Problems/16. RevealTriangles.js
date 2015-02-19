function solve(input) {
	var outPut = [];

	for (var i = 0; i < input.Length; i++) {
		outPut[i] = input[i].split('');

	}

	for (var j = 1; j < input.length; j++) {
		var max = Math.min(
				input[j - 1].length - 2,
				input[j].length - 3);
		for (var c = 0; c <= max; c++) {
			var first = input[j][c];
			var second = input[j][c + 1];
			var third = input[j][c + 2];
			var fourth = input[j - 1][c + 1];

			if (first == second && second == third & third == fourth) {

				outPut[j][c] = '*';
				outPut[j][c + 1] = '*';
				outPut[j][c + 2] = '*';
				outPut[j - 1][c + 1] = '*';
			}
		}

	}

	for (var i = 0; i < input.length; i++) {
		console.log(outPut[i].join(''));
	}

	// m ne6to mi dava gre6ka v Sistemata 
}
