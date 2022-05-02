function solve(elements) {

    let result = [];

    for (let index = 0; index < elements.length; index++) {

        let element = elements[index];

        if (index % 2 === 0) {

            result.push(element);
        }
    }

    console.log(result.join(' '));
}

solve(['5', '10']);