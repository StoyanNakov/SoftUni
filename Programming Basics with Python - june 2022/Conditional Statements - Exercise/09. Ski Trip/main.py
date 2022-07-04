days = int(input())
room_type = input()
raiting = input()
sum = float(0)
days = days - 1
if room_type == 'apartment':
    sum = days * 25.00
    if days < 10:
        sum = sum - (sum * 0.3)
    elif 10 <= days <= 15:
        sum = sum - (sum * 0.35)
    elif days > 15:
        sum = sum - (sum * 0.5)
elif room_type == 'president apartment':
    sum = days * 35.00
    if days < 10:
        sum = sum - (sum * 0.1)
    elif 10 <= days <= 15:
        sum = sum - (sum * 0.15)
    elif days > 15:
        sum = sum - (sum * 0.2)

elif room_type == 'room for one person':
    sum = days * 18.00

if raiting == 'positive':
    sum = sum + (sum * 0.25)
else:
    sum = sum - (sum * 0.1)
print(f'{sum:.2f}')