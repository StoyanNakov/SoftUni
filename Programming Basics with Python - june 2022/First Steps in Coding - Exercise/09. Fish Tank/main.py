w = int(input())
l = int(input())
h = int(input())
percent = int(input())
sum = ((w * l * h) / 1000)
sum  = sum -  (sum * percent) / 100
print(sum)
