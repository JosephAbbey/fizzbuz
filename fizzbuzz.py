n = 100

for i in range(1, n + 1):
  o = ""
  if not i % 3:
    o += "fizz"
  if not i % 5:
    o += "buzz"
  if o == "":
    o = i
  print(o)
