function solve(arr) {
    var rows = [];
    for (var i = 2; i < arr.length -1; i++) {
        var data = arr[i];
        var regex = /<td>.*?<\/td><td>(.*?)<\/td>/g;
        var match = regex.exec(data);
        var price = Number(match[1]);
        var row = { price: price, rowData: data };
        rows.push(row);
    }

    rows.sort(function (a, b) {

        if (a.price != b.price) {
            return a.price - b.price;
        }
        else {
            return a.rowData == b.rowData ? 0 : a.rowData < b.rowData ? -1 : 1;
        }
    });

    console.log(arr[0]);
    console.log(arr[1]);
    for (var i = 0; i < rows.length; i++) {
        console.log(rows[i].rowData);
    }
    console.log(arr[arr.length - 1]);
}

solve([
"<table>",
"<tr><th>Product</th><th>Price</th><th>Votes</th></tr>",
"<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>",
"<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>",
"<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>",
"<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>",
"<tr><td>Ariana Grapefruit 1.5 l</td><td>1.85</td><td>+7</td></tr>",
"<tr><td>Coffee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>",
"</table>"
]);