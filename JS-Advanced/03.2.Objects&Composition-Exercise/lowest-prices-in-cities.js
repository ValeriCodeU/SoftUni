function solve(arr) {

    let result = []; 


    for (const item of arr) {

        let input = item.split(' | ');

        let [town, product, price] = input;
        price = Number(price);

        if (result.some(x => x.product === product)) {

            let obj = result.find(x => x.product === product)

            if(obj.price > price){

                obj.price = price;
                obj.town = town;
            }

            //continue;

        } else{

            result.push({ product, price, town });
        }     

    }

    for (const item of result) {

        console.log(`${item.product} -> ${item.price} (${item.town})`);
        
    }

}

solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']);

    solve(['Sofia City | Audi | 100000',
        'Sofia City | BMW | 100000',
        'Sofia City | Mitsubishi | 10000',
        'Sofia City | Mercedes | 10000',
        'Sofia City | NoOffenseToCarLovers | 0',
        'Mexico City | Audi | 1000',
        'Mexico City | BMW | 99999',
        'Mexico City | Mitsubishi | 10000',
        'New York City | Mitsubishi | 1000',
        'Washington City | Mercedes | 1000])']);
