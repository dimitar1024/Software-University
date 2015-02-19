function isPrime(number) {
    var n = number | 0;
    
    for (var i = 2; i < n; i++) {
        if (n % i == 0)
            return false;
    }
    return true;
}
console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));