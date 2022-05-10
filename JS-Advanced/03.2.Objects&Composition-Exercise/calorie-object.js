function solve(array) {

    let arr = array;
    let result = {};

    while (arr.length > 0) {

        let productName = array[0];
        let calories = Number(array[1]);

        result[productName] = calories;
        arr.shift();
        arr.shift();        
    }

    return result;
}


let print = solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);

console.log(print);