n = 100
for i in (1..n).to_a do
  o = ""
  if i % 3 == 0
    o += "fizz"
  end
  if i % 5 == 0
    o += "buzz"
  end
  if o == ""
    o = i
  end
  print(o, "\n")
end