function add(a){

    let result = 0;

    function recursion(num){

        result += num;

        return recursion;
    }
    
    recursion.toString = () => {

        return result;
    }

    return recursion(a);
}
console.log(add(1)(6)(-3).toString());

