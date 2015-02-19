function solve(arr) {
	var rotate = arr[0].replace(/[^0-9]/g,'') % 360;

	var words = [];
	var len = 0;
	var maxLen = 0;
	for (var i = 1; i < arr.length; i++) {
		words[i - 1] = arr[i].split('');
		len = arr[i].length;
		if (len > maxLen) {
			maxLen = len;
		}
	}

	for (var i = 0; i < words.length; i++) {
		
		while (words[i].length < maxLen) {
			words[i].push(' ');
		}
	}

	function rotate90(words) {
		var maxRow = words.length-1;
		var maxCol = words[0].length-1;

		var result = new Array(maxCol);
		for (var c = 0; c <= maxCol; c++) {
			result[c] = new Array(maxRow);
			for (var r = 0; r <= maxRow; r++) {
				result[c][maxRow - r] = words[r][c];
			}
		}
		return result;
	}

	while (rotate > 0) {
		words = rotate90(words);
		rotate -= 90;
	}

	for (var w in words) {
		console.log(words[w].join(''));
	}

}

solve(["Rotate(270)", "hello", "softuni", "exam"]);