function solve(product, grams, pricePerKg){

    let kgProduct = grams / 1000;
    let priceProduct = kgProduct * pricePerKg;

    console.log(`I need $${priceProduct.toFixed(2)} to buy ${kgProduct.toFixed(2)} kilograms ${product}.`);
}

solve('orange', 2500, 1.80);