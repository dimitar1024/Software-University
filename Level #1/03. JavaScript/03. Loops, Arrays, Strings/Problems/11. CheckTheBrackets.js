function checkTheBrackets(arr) {
    var str = arr;
    var first = '';
    var last = '';
    var count = 0;

    for (var i = 0; i < str.length; i++) {
        if (str[i] === '(') {
            count++;
        }

        if (str[i] === ')') {
            count--;
        }

        if (first == '') {
            first = str[i];
        }

        last = str[i];
    }

    if (first == '(' && last == ')' && count == 0) {
        return 'correct';
    }

    return 'incorrect';

}

console.log(checkTheBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));