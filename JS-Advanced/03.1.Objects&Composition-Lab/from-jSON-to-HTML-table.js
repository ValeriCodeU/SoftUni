function solve(input) {

    let students = JSON.parse(input);

    let htmlText = ['<table>'];    

    let objNames = students[0];

    htmlText.push(`${'<tr><th>'}${Object.keys(objNames).join('</th><th>')}${'</th></tr>'}`);

   
    for (const obj of students) {

        htmlText.push(`${'<tr><td>'}${Object.values(obj).join('</td><td>')}${'</td></tr>'}`);
    }


    htmlText.push('</table>');

    console.log(htmlText.join('\r\n'));

}

solve(`[{"Name":"Stamat",
"Score":5.5},
{"Name":"Rumen",
"Score":6}]`);

solve(`[{"Name":"Pesho",
"Score":4,
" Grade":8},
{"Name":"Gosho",
"Score":5,
" Grade":8},
{"Name":"Angel",
"Score":5.50,
" Grade":10}]`);

solve('[{"Name": "Stamat"}]')