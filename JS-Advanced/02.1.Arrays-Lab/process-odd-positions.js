function solve(array) {

    let result = [];
    
    for (let i = 1; i < array.length; i += 2) {

        result.push(array[i]);
    }

    let mapResult = result.map(x => x * 2).reverse();

    console.log(mapResult);
}

solve([10, 15, 20, 25]);
solve([3, 0, 10, 4, 7, 3]);