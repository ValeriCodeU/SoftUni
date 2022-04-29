function solve(input) {
    let num = input;
    let lastNum = num % 10;
    let sum = 0;
    let isEqual = true;

    while (num > 0) {

        let currentNum = num % 10;
        sum += currentNum;

        if (lastNum !== currentNum) {
            isEqual = false;
        }

        num /= 10;
        let temp = num.toFixed(0);

        num = Number(temp);

        if (currentNum >= 5) {
            num--;
        }
    }

    console.log(isEqual);
    console.log(sum);
}

solve(2222222);