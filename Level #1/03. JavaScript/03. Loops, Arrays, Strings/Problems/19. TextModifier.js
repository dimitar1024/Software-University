function fixCasing(str) {
    
    function changeText(match) {
        var patt = /<(\w+)>([\W\w]+)<\/\w+>/g; 
        var content = patt.exec(match);
        
        switch (content[1]) {
            case 'lowcase':
                content[2] = content[2].toLowerCase();
                break;
            case 'upcase':
                content[2] = content[2].toUpperCase();
                break;
            case 'mixcase':
                content[2] = randomCase(content[2]);
                break;
        }
        return content[2];
    }
    function randomCase(word) {
        var result = "";
        for (var i = 0; i < word.length; i++) {
            var randol = Math.random();
            if (randol <= 0.5) {
                result += word.charAt(i).toUpperCase();
            }
            else {
                result += word.charAt(i).toLowerCase();
            }
        }
        return result;
    }
    str = str.replace(/<\w+>([^<>]+)<\/\w+>/g, changeText);
    return str;
}




console.log(fixCasing("We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else."));
