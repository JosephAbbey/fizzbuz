n = 100

for i in (1..n).to_a do
  if i % 3 == 0
    if i % 5 == 0
      print("fizzbuz\n")
    else
      print("fizz\n")
    end
  else if i % 5 == 0
    print("buzz\n")
  else
    print(i, "\n")
  end
end
end