import math

record = float(input())
meters = int(input())
time_in_seconds = float(input())
delay = (math.floor(meters / 15)) * 12.5
sum = (time_in_seconds * meters) + delay

if sum >= record:
    sum -= record
    print(f'No, he failed! He was {sum:.2f} seconds slower.')
elif sum < record:
    print(f'Yes, he succeeded! The new world record is {sum:.2f} seconds.')
