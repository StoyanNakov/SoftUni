naylon = int(input())
paint = int(input())
r = int(input())
hour = int(input())

sumNaylon  = (naylon + 2) * 1.5
sumPaint = (paint + (paint * 0.1)) * 14.5
sumR = r * 5.00
totalSum = sumNaylon + sumPaint + sumR + 0.4
totalSum = (totalSum + ((totalSum * 0.3)) * hour)

print(totalSum)