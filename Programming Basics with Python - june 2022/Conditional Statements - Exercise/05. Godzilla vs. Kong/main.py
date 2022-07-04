
budjet = float(input())
people = int(input())
dress_price = float(input())

decore = budjet * 0.1
sum_dress = (people * dress_price)
if people > 150:
    sum_dress = sum_dress - (sum_dress * 0.1)
sum = sum_dress + decore
if budjet >= sum:
    print('Action!')
    print(f'Wingard starts filming with {budjet - sum:.2f} leva left.')
else:
    print('Not enough money!')
    print(f'Wingard needs {sum - budjet:.2f} leva more.')
