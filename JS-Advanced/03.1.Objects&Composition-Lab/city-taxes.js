function cityTaxes(cityName, population, treasury) {
    let city = {
        name: cityName,
        population,
        treasury,
        taxRate: 10,
        collectTaxes() {
            this.treasury += this.taxRate * this.population;
        },

        applyGrowth(percentage) {

            percentage /= 100;
            this.population += this.population * percentage;
        },

        applyRecession(percentage) {

            percentage /= 100;
            this.treasury -= this.treasury * percentage;
        }
    };

    return city;
}

const city =
    cityTaxes('Tortuga',
        7000,
        15000);
city.collectTaxes();
console.log(city.treasury);
city.applyGrowth(5);
console.log(city.population);

