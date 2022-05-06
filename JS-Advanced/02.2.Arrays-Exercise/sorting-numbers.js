function solve(array) {

    let result = [];
    let counter = 0;

    while (array.length > 0) {

        if (counter % 2 === 0) {
            array.sort((x, y) => x - y);
            let smallestNum = array.shift();
            result.push(smallestNum);
        } else {
            array.sort((x, y) => y - x);
            let biggestNum = array.shift();
            result.push(biggestNum);

        }
        counter++;
    }
    return result;
}

console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));
console.log(solve([1, 2, 3])) // test odd array


