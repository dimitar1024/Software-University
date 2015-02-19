function biggerThanNeighbors(inx, arr) {
	var index = parseInt(inx);
	var numbers = [];

	for (var i = 0; i < arr.length; i++) {
		numbers.push(parseInt(arr[i]));
	}
	if (index >= numbers.length) {
		console.log("invalid index");
	}
	else if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1]) {
		console.log("bigger");
	}
	else if (numbers[index - 1] == undefined || numbers[index + 1] == undefined) {
		console.log("only one neighbor");
	}
	else if (numbers[index] <= numbers[index - 1] || numbers[index] <= numbers[index + 1]) {
		console.log("not bigger");

	}
}

biggerThanNeighbors(0, [1, 2, 5, 3, 4]);