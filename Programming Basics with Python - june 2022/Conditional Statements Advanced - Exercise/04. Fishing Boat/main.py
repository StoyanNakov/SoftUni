budjet = int(input())
season = input()
people = int(input())
price = 0;
if season == 'Spring':
    if people <= 6:
        price = 2700
    elif 7 <= people <= 11:
        price = 2550
    elif people >= 12:
        price = 2250
if season == 'Summer' or season == 'Autumn':
    if people <= 6:
        price = 3780
    elif 7 <= people <= 11:
        price = 3570
    elif people >= 12:
        price = 3150


if season == 'Winter':
    if people <= 6:
        price = 2340
    elif 7 <= people <= 11:
        price = 2210
    elif people >= 12:
        price = 1950

if people % 2 == 0 and season != 'Autumn':
    price = price - (price * 0.05)

if budjet >= price:
    print(f'Yes! You have {budjet - price:.2f} leva left.')
else:
    print(f'Not enough money! You need {price - budjet:.2f} leva.')