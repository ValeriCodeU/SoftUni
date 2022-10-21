function colorize() {

    let tableRows = document.getElementsByTagName('tr');

    let rowElements = Array.from(tableRows);

    for (let i = 0; i < rowElements.length; i++) {

        if(i % 2 != 0)

        rowElements[i].style.backgroundColor = 'teal';
    }

    // rowElements.forEach((x, i) => {
    //     if(i % 2 != 0){
    //         x.style.backgroundColor = 'teal';
    //     }
    // })
}