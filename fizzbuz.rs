fn main() {
  let n = 100;

  for i in 1..(n + 1) {
    if i % 3 == 0 {
      if i % 5 == 0 {
        println!("fizzbuz");
      } else {
        println!("fizz");
      }
    } else if i % 5 == 0 {
      println!("buz");
    } else {
      println!("{}", i);
    }
  }
}