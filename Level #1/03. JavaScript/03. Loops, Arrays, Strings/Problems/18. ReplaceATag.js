function extractElementContent(str) {
    var text = str;
    var path =/<a/;

    while (text.search(path)!=-1) {
        text = text.replace(path,'[URL');
    }

    path =/<\/a>/;

    while (text.search(path)!=-1) {
        text = text.replace(path,'[/URL]');
    }

    return text;

}

console.log(extractElementContent('<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>'));