function compareChars(arr1,arr2) {
    
    var equal = 'Equal';

    if (arr1.length == arr2.length) {
        for (var i = 0; i < arr1; i++) {
            
            if (arr1[i] !== arr2[i]) {
                equal = 'Not Equal';
            }
        }
    }
    else {
        equal = 'Not Equal';
    }

    console.log(equal);
}

console.log(compareChars(['1','f','1','s','g','j','f','u','s','q'],
    ['1','f','1','s','g','j','f','u','s','q']));