function solve (cityName, population, treasury){
   let city = {
    name: cityName,
    population,
    treasury
   };

   return city;
}

console.log(solve('Tortuga',
7000,
15000));