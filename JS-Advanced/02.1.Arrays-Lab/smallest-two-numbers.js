function solve(arr){

    arr.sort((x, y) => x - y);

    let result = arr.splice(0, 2);

    console.log(result.join(' '));    
}

solve([30, 15, 50, 5]);