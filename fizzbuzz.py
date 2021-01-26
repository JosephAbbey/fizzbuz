n = 100

for i in range(1, n + 1):
  if not i % 3:
    if not i % 5:
      print("fizzbuz")
    else:
      print("fizz")
  elif not i % 5:
    print("buz")
  else:
    print(i)
