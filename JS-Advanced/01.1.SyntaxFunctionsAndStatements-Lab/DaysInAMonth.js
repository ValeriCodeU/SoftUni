function solve(month, year) {
 
  let date = new Date(year, month, 0).getDate();
  
  console.log(date);
};

solve(1, 2012);

