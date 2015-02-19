function reverseWordsInString(str) {
    var words = str.split(' ');
    var reverseWords = [];
    for (var w = 0; w < words.length; w++) {
        var word = words[w];

        reverseWords[w] = word.split("").reverse().join("");
    }

    console.log(reverseWords.join(' '));
}

reverseWordsInString('Hello, how are you.');