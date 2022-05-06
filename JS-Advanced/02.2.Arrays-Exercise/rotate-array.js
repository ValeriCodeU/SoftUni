function solve(array, numRotation) {


    for (let i = 0; i < numRotation; i++) {

        let lastElement = array.pop();
        array.unshift(lastElement);
    }

    console.log(array.join(' '));
}
solve(['1',
    '2',
    '3',
    '4'],
    2);

solve(['Banana',
    'Orange',
    'Coconut',
    'Apple'],
    15);