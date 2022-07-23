age = int(input())
need_sum = float(input())
toy_price = int(input())
sum = 0
reciver_money = 0
for i in range(1,age+1):
    if i % 2 == 0:
        reciver_money += 10
        sum = sum + (reciver_money - 1)

    else:
        sum = sum + toy_price
if need_sum > sum:
    print(f'No! {need_sum - sum:.2f}')
else:
    print(f'Yes! {sum - need_sum:.2f}')