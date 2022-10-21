function sumTable() {

    let rows = document.querySelectorAll('tr td:nth-of-type(2)');

    let rowsArray = Array.from(rows);

    let sum = 0;

    for (const iterator of rowsArray) {

        sum += Number(iterator.textContent);        
    }

    let sumCol = document.getElementById('sum');

    sumCol.textContent = sum;    

    console.log(rowsArray);
}