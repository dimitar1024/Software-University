function solve(arr) {
    var results = {};

    for (var i in arr) {
        var data = arr[i].split(/[\/:\- ]+/);
        var teamInHome = data[0].trim();
        var teamOutHome = data[1].trim();
        var goalInHome = Number(data[2].trim());
        var goalOutHome = Number(data[3].trim());
        addresults(results, teamInHome, teamOutHome, goalInHome, goalOutHome);
        addresults(results, teamOutHome, teamInHome, goalOutHome, goalInHome);
    }

    // object
    function addresults(results, teamInHome, teamOutHome, goalInHome, goalOutHome) {
        
        if (!results[teamInHome]) {
            results[teamInHome] = { goalsScored : 0, goalsConceded : 0, matchesPlayedWith : []};
        }
        results[teamInHome].goalsScored += goalInHome;
        results[teamInHome].goalsConceded += goalOutHome;

        if (results[teamInHome].matchesPlayedWith.indexOf(teamOutHome) == -1) {
            results[teamInHome].matchesPlayedWith.push(teamOutHome);
        }
    }
    // sort function
    function sort(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }

    // sorting
    results = sort(results);
    for (var team in results) {
        results[team].matchesPlayedWith.sort();
    }

    //print
    console.log(JSON.stringify(results));
}

solve([
"Germany / Argentina: 1-0",
"Brazil / Netherlands: 0-3",
"Netherlands / Argentina: 0-0",
"Brazil / Germany: 1-7",
"Argentina / Belgium: 1-0",
"Netherlands / Costa Rica: 0-0",
"France / Germany: 0-1",
"Brazil / Colombia: 2-1"
]);