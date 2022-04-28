function getFibonator() {

    let lastNum = 0;
    let fibNum = 1;
    let sum = 0;
    let counter = 0;

    return function fib() {

        sum = fibNum + lastNum;

        if (counter != 0) {

            lastNum = fibNum;
        }
        counter++;

        fibNum = sum;
        return fibNum;
    }
}

let fib = getFibonator();
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());     
