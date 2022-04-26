function area() {
    return Math.abs(this.x * this.y);
};

function vol() {
    return Math.abs(this.x * this.y * this.z);
};

function solve(area, vol, input) {

    let arrayOfObjects = [];

    let data = JSON.parse(input);
  

    for (const figure of data) {

        let areaResult = area.call(figure);
        let volumeResult = vol.call(figure);

        let resultObject = {
            area: areaResult,
            volume: volumeResult
        }
        
        arrayOfObjects.push(resultObject);
    }
    
    return arrayOfObjects;
}


solve(area, vol, `[
    {"x":"10","y":"-22","z":"10"},
    {"x":"47","y":"7","z":"-5"},
    {"x":"55","y":"8","z":"0"},
    {"x":"100","y":"100","z":"100"},
    {"x":"55","y":"80","z":"250"}
    ]`
    );