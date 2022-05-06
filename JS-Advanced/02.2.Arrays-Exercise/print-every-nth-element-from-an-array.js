function solve(arr, count) {

    let result = [];

    for(let i = 0; i < arr.length; i+=count){
        
        result.push(arr[i]);
    }
    return result;
}

let resultArray = solve(['5', '20', '31', '4', '20'], 2);
console.log(resultArray);
