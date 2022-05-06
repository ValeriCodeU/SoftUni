function solve(array, delimeter){

    let result = array.join(`${delimeter}`);

    console.log(result);    
}

solve(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-');

solve(['How about no?', 
'I',
'will', 
'not', 
'do', 
'it!'], 
'_');