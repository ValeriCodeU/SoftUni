function solve(num1, num2) {

    let resultDivisior = 0;
    let counter;

    if(num1 >= num2){
        counter = num1;
    } else{
        counter = num2;
    }

    for (let i = 1; i <= counter; i++) {

        if (num1 % i === 0 && num2 % i === 0) {

            if (i > resultDivisior) {

                resultDivisior = i;
            }
        }
    }

    console.log(resultDivisior);
}

solve(2154, 458);