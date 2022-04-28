function solution(number){

    return function(addNum){

        let currentNum = number;

        return currentNum += addNum;
    }
}


let add5 = solution(5);

console.log(add5(2));
console.log(add5(3));