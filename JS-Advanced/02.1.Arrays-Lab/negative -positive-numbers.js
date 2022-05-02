function solve(array) {

    let result = [];

    for (let index = 0; index < array.length; index++) {

        let currentElement = array[index];

        if (currentElement < 0) {

            result.unshift(currentElement);

        } else {

            result.push(currentElement);
        }
    }

    for (let num of result) {
        console.log(num);
    };
}

solve([7, -2, 8, 9]);
solve([3, -2, 0, -1]);