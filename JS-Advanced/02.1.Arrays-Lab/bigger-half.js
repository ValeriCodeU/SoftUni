function solve(array){

    array.sort(function (x, y){
        return x - y;
    });


    let index = array.length / 2;
    let result = array.slice(index);

    return result;
}

console.log(solve([4, 7, 2, 5]));
console.log(solve([3, 19, 14, 7, 2, 19, 6]));