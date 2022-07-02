hour = int(input())
minute = int(input())
minute = minute + 15

if minute > 59:
    hour = hour + 1
    minute = minute - 60

if hour > 23:
    hour = 0
if minute < 10:
    print(f'{hour}:0{minute}')
else:
    print(f'{hour}:{minute}')

