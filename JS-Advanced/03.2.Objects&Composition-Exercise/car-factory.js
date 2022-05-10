function solve(object) {

    let car = {};
    let engine = {};
    let carriage = {};
    let wheelsArr = [];


    if (object.power <= 90) {

        engine.power = 90;
        engine.volume = 1800;

    } else if (object.power <= 120) {

        engine.power = 120;
        engine.volume = 2400;

    } else if (object.power <= 200) {

        engine.power = 200;
        engine.volume = 3500;
    }

    carriage.type = object.carriage;
    carriage.color = object.color;

    let singleWheelSize = object.wheelsize;

    if (singleWheelSize % 2 === 0) {
        singleWheelSize -= 1;
    }

    wheelsArr.length = 4;
    wheelsArr.fill(singleWheelSize, 0, 4);

    car.model = object.model;
    car.engine = engine;
    car.carriage = carriage;
    car.wheels = wheelsArr;

    return car;
}

let printResult = solve({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}
);


console.log(printResult);