function countDivs(html) {
    var html = html;
    var regex = /<div\s*.*?>/g;
    var match;
    var count = 0;
    while (match = regex.exec(html)) {
        if (match[0]) {
            count++;
        }
    }

    console.log(count);
}

countDivs('<!DOCTYPE html><html><head lang="en"><meta charset="UTF-8"><title>index</title><script src="/yourScript.js" defer></script></head><body><div id="outerDiv"><divclass="first"><div><div>hello</div></div></div><div>hi<div></div></div><div>I am a div</div></div></body></html>');