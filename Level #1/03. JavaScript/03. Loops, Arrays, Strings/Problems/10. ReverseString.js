function moreEqualElementsInArray(arr) {
    var str = arr;

    str = str.split("").reverse().join("");

    return str;

}

console.log(moreEqualElementsInArray(['java script']));