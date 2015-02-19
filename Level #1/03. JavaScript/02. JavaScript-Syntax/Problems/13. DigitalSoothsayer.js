function soothsayer(object) {
    var PersonalSkills = {
        years: object[0],
        language: object[1],
        country: object[2],
        car: object[3]
    };

    var output = 'You will work ' + PersonalSkills.years[parseInt(Math.random() * PersonalSkills.years.length)] +
                ' years on ' + PersonalSkills.language[parseInt(Math.random() * PersonalSkills.language.length)] +
                '. You will live in ' + PersonalSkills.country[parseInt(Math.random() * PersonalSkills.country.length)] +
                ' and drive ' + PersonalSkills.car[parseInt(Math.random() * PersonalSkills.car.length)] + '.';

    return output;
}
console.log(soothsayer(
    [[3, 5, 2, 7, 9],
['Java', 'Python', 'C#', 'JavaScript', 'Ruby'],
['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'],
['BMW', 'Audi', 'Lada', 'Skoda', 'Opel']]
    ));


console.log(soothsayer(
    [[3, 5, 2, 7, 9],
['ciganish', 'bulgaristan', 'tyrke', 'albanish', 'romanian'],
['Pobit Kamak', 'Orlandovci', 'Stolipinovo', 'Pitovo', 'Banite'],
['Karuca', 'Kalqska', 'Lada', 'Moskvich', 'Opel Kadet 1.3']]
    ));

console.log(soothsayer(
    [[3, 5, 2, 7, 9],
['Germany', 'France', 'English', 'Sarbian', 'Italyan'],
['Stara Zagora', 'Sofia', 'Rome', 'Belgrad', 'Paris'],
['BMW', 'Audi', 'Tesla', 'Mercedes', 'VW']]
    ));
