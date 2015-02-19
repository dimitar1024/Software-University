var persons = [
  { firstname: 'George', lastname: 'Kolev', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Baba', lastname: 'Ginka', age: 40 }];

function findYoungestPerson(persons)
{
	persons.sort(function (a, b) {
		return a.age - b.age;
	});
}
findYoungestPerson(persons);

    console.log("The youngest person is " +persons[0].firstname +" " + persons[0].lastname);

	

