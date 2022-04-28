function solve() {

    let resultObj = {};
    let resultTypes = {};

    let data = arguments;

    for (const element of data) {

        let type = typeof (element);

        console.log(`${type}: ${element}`);

        if (type) {
            resultObj[type] = element;

            if (typeof resultTypes[type] === 'undefined') {
                resultTypes[type] = 0;
            }
            resultTypes[type]++; 
        }
    }

    Object.entries(resultTypes).sort((a, b) => b[1] - a[1]).forEach(([key, value]) => {
        console.log(`${key} = ${value}`);
    });
}


solve('cat', 42, function () { console.log('Hello world!'); });
solve({ name: 'bob' }, 3.333, 9.999);