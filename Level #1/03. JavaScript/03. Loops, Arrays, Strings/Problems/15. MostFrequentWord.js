function mostFrequentWord(str) {
    var text = str.toLowerCase();
    var wordsCount = {};
    var words = text.split(/[.,\/ -]/);
    words = words.filter(function (n) { return n });
    var max = 0;
    for (var i in words) {
        var word = words[i];

        if (wordsCount[word] === undefined) {
            wordsCount[word] = {word: word, times: 1};
        }
        else {
            wordsCount[word].times++;
        }

        if (wordsCount[word].times > max) {
            max = wordsCount[word].times;
        }
    }

    var result = [];


    for (var i in wordsCount) {
        
        if (wordsCount[i].times === max) {
            result.push(wordsCount[i]);
        }
    }

    result.sort(function (a, b) { return a.word.localeCompare(b.word) });

    for (var i in result) {
        console.log(result[i].word + " -> " + result[i].times + " times");
    }
    console.log();
}

console.log(mostFrequentWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'));