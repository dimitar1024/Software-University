function concerts(input) {
    var Info = {};
    for (var i in input) {
        var tokens = input[i].split('|');
        var band = tokens[0].trim();
        var town = tokens[1].trim();
        var date = tokens[2].trim();
        var venue = tokens[3].trim();

        if (!Info[town]) {
            Info[town] = {};
        }
        if (!Info[town][venue]) {
            Info[town][venue] = [];
        }
        if (Info[town][venue].indexOf(band) == -1) {
            Info[town][venue].push(band);
        }
    }

    Info = sort(Info);
    for (var town in Info) {
        Info[town] = sort(Info[town]);
        for (var venue in Info[town]) {
            Info[town][venue].sort();
        }
    }

    console.log(JSON.stringify(Info));

    function sort(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
}