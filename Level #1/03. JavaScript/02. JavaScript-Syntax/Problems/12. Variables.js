function variablesTypes(obj) {

    var person = {
        name: obj[0],
        age: obj[1],
        isMale: obj[2],
        foods: obj[3]

    };

    return "\"My name: " + person.name + " //type is " + typeof (person.name) +
            "\nMy age: " + person.age + " //type is " + typeof (person.age) +
            "\nI am male: " + person.isMale + " //type is " + typeof (person.isMale) +
            "\nMy favorite foods are: " + person.foods + " //type is " + typeof (person.foods);





}
console.log(variablesTypes(['Pesho(Piandeto)', 22, true, ['shkembe', 'bob', 'ciganska banica']]));
console.log(variablesTypes(['Bai Ivan(Chechmata)', 72, true, ['musaka', 'bahur', 'sudjuk']]));
console.log(variablesTypes(['Kolyo(Tuhlata)', 22, true, ['bob s zele', 'kebapcheta', 'kyufteta']]));