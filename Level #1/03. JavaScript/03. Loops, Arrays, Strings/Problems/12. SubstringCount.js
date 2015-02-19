function substringCount(arr) {
    var word = arr[0];
    var text = arr[1];
    var count = 0;

    var index = text.indexOf(word);
    while (index !=-1) {
        count++;
        index = text.indexOf(word, index+1);			
    }
		
    console.log(count);

}

console.log(substringCount(["in", "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."]));