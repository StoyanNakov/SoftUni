from math import floor

pageCurrentInBook = int(input())
page = int(input())
days = int(input())
total = (pageCurrentInBook / page) / days
print(floor(total))

