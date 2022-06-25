packegP = int(input())
packegM = int(input())
cleanerL = int(input())
discount = int(input())

sum = (packegP * 5.80) + (packegM * 7.20) + (cleanerL * 1.20)
sum = sum - ((sum * discount) / 100)
print(sum)