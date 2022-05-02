function solve(matrix) {

    let biggestNum;

    for (let row = 0; row < matrix.length; row++) {

        for (let col = 0; col < matrix[row].length; col++) {

            if(row === 0 && col === 0){
                biggestNum = matrix[row][col];
            }

            if (matrix[row][col] > biggestNum) {

                biggestNum = matrix[row][col];
            }
        }
    }

    return biggestNum
}    

let resultValue = solve([[20, 50, 10],
[8, 33, 145]]);

console.log(resultValue);