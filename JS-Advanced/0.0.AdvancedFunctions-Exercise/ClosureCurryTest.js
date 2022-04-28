function test(a){

    return function (b){
        return a + b;
    }
}
let result = test(2)(3);

console.log(result);