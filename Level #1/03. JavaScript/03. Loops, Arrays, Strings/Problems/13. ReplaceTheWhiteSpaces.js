function replaceTheWhiteSpaces(arr) {
    var text = arr;
    text = text.replace(/(\r\n|\n|\r| )/gm, "");
    console.log(text);

}

console.log(replaceTheWhiteSpaces("But you were living in another world \n tryin' to get your message through"));