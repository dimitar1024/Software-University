function extractLinks(input) {
	var data = input.join('\n');
	var regex = /<a\s+([^>]+\s+)?href\s*=\s*('([^']*)'|"([^"]*)|([^\s>]+))[^>]*>/g;
	var match;
	while (match = regex.exec(data)) {
		var value = match[3];
		if (value == undefined) {
			var value = match[4];
		}
		if (value == undefined) {
			var value = match[5];
		}
		console.log(value);
	}
}