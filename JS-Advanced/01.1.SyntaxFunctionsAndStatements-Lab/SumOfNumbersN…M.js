function solve(n, m){

    let start = Number(n);
    let end = Number(m);
    let sum = 0;

    for(let i = start; i <= end; i++){
        sum+= i;
    }
    return sum;
}

let result = solve('-8', '20');
console.log(result);