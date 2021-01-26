var n = 100;

for (var i of Array(n).keys()) {
  i++
  console.log(i % 3 ? i % 5 ? i : "buzz" : i % 5 ? "fizz" : "fizzbuz");
}
