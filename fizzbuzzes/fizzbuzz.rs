fn main() {
  let n = 100;

  for i in 1..(n + 1) {
    let mut o = "".to_string();
    if i % 3 == 0 { o += "fizz"; } 
    if i % 5 == 0 { o += "buzz"; }
    if o == "" { o = i.to_string(); }
    println!("{}", o);
  }
}