function solve(elements){
    let firstNum = Number(elements[0]);
    let lastNum = Number(elements[elements.length-1]);
    let result = firstNum + lastNum;

    console.log(result);
}

solve(['20', '30', '40']);
solve(['5', '10']);