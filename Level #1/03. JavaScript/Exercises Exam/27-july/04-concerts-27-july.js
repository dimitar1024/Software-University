function solve(arr) {
    var info = {};
    for (var i in arr) {
        var data = arr[i].split('|');
        var band = data[0].trim();
        var town = data[1].trim();
        var date = data[2].trim();
        var stadium = data[3].trim();

        if (!info[town]) {
            info[town] = {};
        }

        if (!info[town][stadium]) {
            info[town][stadium] = [];
        }

        if (info[town][stadium].indexOf(band) == -1) {
            info[town][stadium].push(band);
        }


    }

    

    info = sort(info);
    for (var town in info) {
        info[town] = sort(info[town]);

        for (var stadium in sort[town]) {
            info[town][stadium].sort();
        }
    }
    
    console.log(JSON.stringify(info));

    function sort(obj) {
        var keyInObj = Object.keys(obj).sort();
        var sorted = {};

        for (var i = 0; i < keyInObj.length; i++) {
            var key = keyInObj[i];
            sorted[key] = obj[key];
        }

        return sorted;
    }
}

solve([
"ZZ Top | London | 2-Aug-2014 | Wembley Stadium",
"Iron Maiden | London | 28-Jul-2014 | Wembley Stadium",
"Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium",
"Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium",
"Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium",
"Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium",
"Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium",
"Helloween | London | 28-Jul-2014 | Wembley Stadium",
"Twisted Sister | London | 30-Sep-2014 | Wembley Stadium",
"Metallica | London | 03-Oct-2014 | Olympic Stadium",
"Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium",
"Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium"]);