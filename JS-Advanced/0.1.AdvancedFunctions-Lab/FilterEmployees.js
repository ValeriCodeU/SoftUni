function solve (data, criteria){

    let arrayCriteria = criteria.split('-');
    let prop = arrayCriteria[0];
    let value = arrayCriteria[1];

    let arrayOfObjects = JSON.parse(data);
   
    let result = arrayOfObjects.filter(x => x[prop] === value);

    Object.keys(result).forEach((x) => {

        console.log(`${x}. ${result[x].first_name} ${result[x].last_name} - ${result[x].email}`);
    })

}


solve(`[{
    "id": "1",
    "first_name": "Kaylee",
    "last_name": "Johnson",
    "email": "k0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Johnson",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  }, {
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }, {
    "id": "4",
    "first_name": "Evanne",
    "last_name": "Johnson",
    "email": "ev2@hostgator.com",
    "gender": "Male"
  }]`,
 'last_name-Johnson');