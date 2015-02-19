function extractElementContent(str) {
    var text = str;
    var path =/<.*?>/;

    while (text.search(path)!=-1) {
        text = text.replace(path,'');
    }

    return text;

}

console.log(extractElementContent('<p>Hello</p><a href=\'http://w3c.org\'>W3C</a>'));