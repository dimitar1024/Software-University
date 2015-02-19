function solve(arr) {
    for (var i = 0; i < arr.length; i++) {
        var data = arr[i].replace(/[+ ]+/g, ' ');
        var data2 = data.replace(/%20/g, " ");
        var input = data2.replace(/ {2,}/g, ' ');

        var regex = /(.[^&?+]*=.[^&?+]*)/g;
        var match;
        var results = {};
        while (match = regex.exec(input)) {

            var hrefValue = match[1];
            var pair = hrefValue.replace(/[&\?]+/, '');
            var words = pair.split('=');
            var key = words[0].trim();
            var value = words[1].trim();
            if (!results[key]) {
                results[key] = [];
            }
            results[key].push(value);

        }

        
        var res = objToString(results);
        console.log(res);


        function objToString (obj) {
            var str = '';
            for (var p in obj) {

                if (obj.hasOwnProperty(p)) {

                    str += p + '=[';
                    if(obj[p]){
                        
                        for (var i = 0; i < obj[p].length; i++) {
                            if (i==0) {
                                str += obj[p][i];
                            }
                            else {
                                str += ", " + obj[p][i];
                            }
                            
                        }
                        
                    }

                    str += ']';

                }

            }
            return str;
        }
    }
}

solve([
'foo=%20foo&value=+val&foo+=5+%20+203',
'foo=poo%20&value=valley&dog=wow+',
'url=https://softuni.bg/trainings/coursesinstances/details/1070',
'https://softuni.bg/trainings?trainer=nakov&course=oop&course=php'
]);