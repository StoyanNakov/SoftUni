import math

serial_name = input()
serial_time = int(input())
input_rest_time = int(input())
lunch_time = input_rest_time / 8
rest_time = input_rest_time / 4
sum = input_rest_time - (lunch_time + rest_time)

if serial_time <= sum:
    print(f'You have enough time to watch {serial_name} and left with {math.ceil(abs(serial_time - sum))} minutes free time.')
else:
    print(f"You don't have enough time to watch {serial_name}, you need {math.ceil(abs(sum - serial_time))} more minutes.")

