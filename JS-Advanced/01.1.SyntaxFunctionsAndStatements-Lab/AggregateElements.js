function solve([...params]){

    let sum = 0;
    let sum2 = 0;
    let concat = '';

    for(let i = 0; i < params.length; i++ ){
        sum+= params[i];
        sum2 += 1 / params[i]
        concat += String(params[i]);
    }
      
    console.log(sum);
    console.log(sum2);    
    console.log(concat);
}

solve([2, 4, 8, 16]);