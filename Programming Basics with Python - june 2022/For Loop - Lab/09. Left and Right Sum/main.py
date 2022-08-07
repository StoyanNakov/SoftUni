number = int(input())
left_sum = 0
right_sum = 0
for i in range(0, number * 2):
    current_num = int(input())
    if i < number:
        left_sum += current_num
    elif i >= number:
        right_sum += current_num

if left_sum == right_sum:
    print('Yes, sum = ' + str(right_sum))
else:
    diff = abs(left_sum - right_sum)
    print('No, diff = ' + str(diff))