budjet = float(input())
season = input()
destination = ''
spent = 0
rest = ''

if budjet <= 100:
    destination = 'Bulgaria'

    if season == 'summer':
        spent = (budjet * 0.3)
        rest = 'Camp'
    else:
        rest = 'Hotel'
        spent = (budjet * 0.7)

if 101 <= budjet <= 1000:
    destination = 'Balkans'


    if season == 'summer':
        rest = 'Camp'
        spent = (budjet * 0.4)
    else:
        rest = 'Hotel'
        spent = (budjet * 0.8)

if budjet > 1000:
    destination = 'Europe'
    spent = (budjet * 0.9)
    rest = 'Hotel'

print(f'Somewhere in {destination}')
print(f'{rest} - {spent:.2f}')