function solve(year, month, day) {

    let dateInput = `${year}-${month}-${day}`;

    let date = new Date(dateInput);

    date.setDate(date.getDate() - 1)

    let dateResult = date.getDate();
    let yearResult = date.getFullYear();
    let monthResult = date.getMonth() + 1;


    console.log(`${yearResult}-${monthResult}-${dateResult}`);
}


solve(2016, 10, 1);