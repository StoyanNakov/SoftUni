flowers = input()
quantity = int(input())
budjet = int(input())
price = 0
sum = 0
if flowers == 'Roses':
    if quantity > 80:
        sum = 5 * quantity
        sum = sum - (sum * 0.1)
    else:
        sum = 5 * quantity

elif flowers == 'Dahlias':
    if quantity > 90:
        sum = 3.80 * quantity
        sum = sum - (sum * 0.15)
    else:
        sum = 3.80 * quantity
elif flowers == 'Tulips':
    if quantity > 80:
        sum = 2.80 * quantity
        sum = sum - (sum * 0.15)
    else:
        sum = 2.80 * quantity
elif flowers == 'Narcissus':
    if quantity < 120:
        sum = 3 * quantity
        sum = sum + (sum * 0.15)
    else:
        sum = 3 * quantity
elif flowers == 'Gladiolus':
    if quantity < 80:
        sum = 2.5 * quantity
        sum = sum + (sum * 0.2)
    else:
        sum = 2.5 * quantity

if budjet >= sum:
    print(f'Hey, you have a great garden with {quantity} {flowers} and {budjet - sum:.2f} leva left.')
else:
    print(f'Not enough money, you need {sum - budjet:.2f} leva more.')