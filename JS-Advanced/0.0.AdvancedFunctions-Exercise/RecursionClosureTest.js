function sum(num){
    return num > 0 ? num + sum(num - 1) : 0;
}
console.log(sum(5));