function solve(array, flavor1, flavor2) {

    let result = [];

    let startIndex = array.indexOf(flavor1);
    let endIndex = array.indexOf(flavor2);

    return result = array.slice(startIndex, endIndex + 1);
}

let result = solve(['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie'
);

console.log(result);

