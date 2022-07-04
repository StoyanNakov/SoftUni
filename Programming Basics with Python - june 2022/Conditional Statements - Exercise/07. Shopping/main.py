budjet = float(input())
vga = int(input())
cpu = int(input())
ram = int(input())
sum_vga = vga * 250
sum_cpu = (sum_vga * 0.35) * cpu
sum_ram = (sum_vga * 0.1) * ram
sum_total = sum_vga + sum_ram + sum_cpu
if vga > cpu:
    sum_total = sum_total - (sum_total * 0.15)

if budjet >= sum_total:
    print(f'You have {budjet - sum_total:.2f} leva left!')
else:
    print(f'Not enough money! You need {sum_total - budjet:.2f} leva more!')