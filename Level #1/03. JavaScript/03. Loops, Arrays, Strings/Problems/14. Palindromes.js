function palindromes(str) {
    var text = str.toLowerCase();

    var word = text.split(/[.,\/ -]/);
    var reverseWord = [];
    word = word.filter(function (n) { return n });

    console.log(word);

    for (var i = 0; i < word.length; i++) {
        var item = word[i];

        item = item.split("").reverse().join("");

        reverseWord[i] = item;
    }
    var result = [];

    for (var i = 0; i < word.length; i++) {
        
        if (word[i] == reverseWord[i]) {
            result.push(word[i]);
        }
    }

    console.log(result.join());
}

console.log(palindromes('There is a man, his name was Bob.'));