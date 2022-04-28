function solve(array, command) {
    let result = [];

    if (command == 'asc') {

        result = array.sort((x, y) => x - y);

    } else if (command == 'desc') {

        result = array.sort((x, y) => y - x);
    }

    return result;
}

solve([14, 7, 17, 6, 8], 'asc');
solve([14, 7, 17, 6, 8], 'desc');