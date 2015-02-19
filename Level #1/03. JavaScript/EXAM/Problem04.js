function solve(arr) {
    var results ={};
    for (var i = 1; i < arr.length; i++) {
        var person = JSON.parse(arr[i]);
        console.log(person);
        
        if (!results["students"]) {
            results["students"] = {
                id = [];
            firstname = [];

            lastname = [];
            grades = [];
            level = [];
            certificate = [];
            };
        }

        if (person.role == "student") {
            if (!results[student][id]) {
                results[student][id].push(person.id);
                results[student][firstname].push(person.firstname);
                results[student][lastname].push(person.lastname);
                results[student][grades].push(person.grades);
                results[student][level].push(person.level);
                results[student][certificate].push(person.certificate);


            }

            console.log(results[student]);
        }
        if (!result["trainers"]) {
            result["trainers"] = {};
        }

        if (person.role == "trainer") {

        }
    }
}

solve([
'level^courses',
'{"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false}',
'{"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6}',
'{"id":2,"firstname":"Bobi","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false}',
'{"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7}',
'{"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps","Java"],"lecturesPerDay":2}']);


