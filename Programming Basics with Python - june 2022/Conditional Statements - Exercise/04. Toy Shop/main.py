budjet = float(input())
a1 = int(input())
a2 = int(input())
a3 = int(input())
a4 = int(input())
a5 = int(input())
sum = (a1 * 2.60) + (a2 * 3) + (a3 * 4.1) + (a4 * 8.2) + (a5 * 2)
count = a1 + a2 + a3 + a4 + a5
if count >= 50:
    sum = sum - (sum * 0.25)
sum = sum - (sum * 0.1)

if sum >= budjet:
    print(f'Yes! {sum - budjet:.2f} lv left.')
else:
    print(f'Not enough money! {budjet - sum:.2f} lv needed.')

