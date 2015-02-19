function cardsFrequencies(str) {
    var text = str.toLowerCase();
    var wordsCount = {};
    text = text.replace(/♣/g, "");
    text = text.replace(/♥/g, "");
    text = text.replace(/♦/g, "");
    text = text.replace(/♠/g, "");
    var words = text.split(/[.,\/ -]/);

    words = words.filter(function (n) { return n });
    for (var i in words) {
        var word = words[i];

        if (wordsCount[word] === undefined) {
            wordsCount[word] = { word: word, times: 1 };
        }
        else {
            wordsCount[word].times++;
        }
    }

    var result = [];
    var sumElements = words.length;

    for (var i in wordsCount) {
        result.push(wordsCount[i]);
    }

    result.sort(function (a, b) { return a.word.localeCompare(b.word) });

    for (var i in result) {
        console.log(result[i].word + " -> " + ((result[i].times/sumElements)*1000)/10 + "%");
    }
    console.log();
}

console.log(cardsFrequencies('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));