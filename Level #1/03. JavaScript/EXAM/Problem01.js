function solve(arr) {

    //input
    var dates = [];
    var minDate = new Date();
    minDate.setDate(1);
    minDate.setMonth(0);
    minDate.setYear(1900);;
    var maxDate = new Date();
    maxDate.setDate(1);
    maxDate.setMonth(0);
    maxDate.setYear(2015);


    for (var i in arr) {
        var date = arr[i];
        var dateArr = date.split(/\./);
        var d = new Date();
        d.setDate(dateArr[0]);
        d.setMonth(dateArr[1] - 1);
        d.setYear(dateArr[2]);
        dates.push(d);

        if (i == 0) {
            maxDate = d;
            minDate = d;
        }
    }


    // solve
    var count = 0;


    for (var data in dates) {

        if (dateInRange(dates[data])) {
            if (dates[data] < minDate) {
                minDate = dates[data];
            }
            else if (dates[data] > maxDate) {
                maxDate = dates[data];
            }


        }
        else {
            count++;
            break;
        }

    }

    var middleDate = new Date();
    middleDate.setDate(25);
    middleDate.setMonth(4);
    middleDate.setYear(1973);

    if(count > 0){
        console.log("No result");
        return;
    }
    if (dates.length > 1) {


        if (minDate < middleDate && maxDate > middleDate) {
            if (maxDate > middleDate) {
                console.log("The biggest fan of ewoks was born on " + maxDate.toDateString());
            }
            if (minDate < middleDate) {
                console.log("The biggest hater of ewoks was born on " + minDate.toDateString());
            }
        }

        else if (minDate < middleDate && maxDate < middleDate) {
            if (minDate < middleDate) {
                console.log("The biggest hater of ewoks was born on " + minDate.toDateString());
            }
        }

        else if (minDate > middleDate && maxDate > middleDate) {
            if (maxDate > middleDate) {
                console.log("The biggest fan of ewoks was born on " + maxDate.toDateString());
            }
        }
    }
    else {
        if (dates[0] > middleDate) {
            console.log("The biggest fan of ewoks was born on " + dates[0].toDateString());
        }
        else if (dates[0] > middleDate) {
            console.log("The biggest hater of ewoks was born on " + dates[0].toDateString());
        }
    }




    function dateInRange(data) {
        // format: mm.dd.yyyy;
        var startDate = new Date();
        startDate.setDate(1);
        startDate.setMonth(0);
        startDate.setYear(1900);

        var endDate = new Date();
        endDate.setDate(1);
        endDate.setMonth(0);
        endDate.setYear(2015);

        return data > startDate && data < endDate;
    }
}

solve([
"22.03.1700",
"01.07.2020"
]);