function solve(array){

    let objectTown = {};    

    for(let i = 0; i < array.length; i++){
        let input = array[i].split(' <-> ');

        let town = input[0];
        let population = Number(input[1]);

        if(typeof objectTown[town] !== 'number'){
            objectTown[town] = 0;
        }        

        objectTown[town] += population;
    }

    Object.keys(objectTown).forEach(x => console.log(`${x} : ${objectTown[x]}`));
}

solve(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']);

solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);