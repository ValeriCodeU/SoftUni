function solve(array) {

    let initialValue = 1;
    let result = [];

    for (let i = 0; i < array.length; i++) {

        if (array[i] === 'add') {

            result.push(initialValue);

        } else if (array[i] === 'remove') {

            result.pop();
        }

        initialValue++;
    }

    let printResult = result.length > 0 ? result.join('\r\n') : 'Empty';
    
    console.log(printResult);
}


solve(['add', 'add', 'add', 'add']);

solve(['add', 'add', 'remove', 'add', 'add']);

solve(['remove', 'remove', 'remove']);
