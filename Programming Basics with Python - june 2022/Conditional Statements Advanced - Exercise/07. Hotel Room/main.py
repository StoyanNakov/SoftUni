month = input()
night = int(input())
studio = 0
apartment = 0
sum_studio = 0
sum_apartment = 0
if month == 'May' or month == 'October':
    studio = 50
    apartment = 65
    sum_studio = night * studio
    sum_apartment = night * apartment
    if night > 7 and night <=14:
        sum_studio = sum_studio - (sum_studio * 0.05)
    elif night > 14:
        sum_studio = sum_studio - (sum_studio * 0.3)
        sum_apartment = sum_apartment - (sum_apartment * 0.1)

if month == 'June' or month == 'September':
    studio = 75.20
    apartment = 68.70
    sum_studio = night * studio
    sum_apartment = night * apartment
    if night > 14:
        sum_studio = sum_studio - (sum_studio * 0.2)
        sum_apartment = sum_apartment - (sum_apartment * 0.1)




if month == 'July' or month == 'August':
    studio = 76
    apartment = 77
    sum_studio = night * studio
    sum_apartment = night * apartment
    if night > 14:
        sum_apartment = sum_apartment - (sum_apartment * 0.1)




print(f'Apartment: {sum_apartment:.2f} lv.')
print(f'Studio: {sum_studio:.2f} lv.')