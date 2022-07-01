exam_hour = int(input())
exam_min = int(input())
arrive_hour = int(input())
arrive_min = int(input())

exam_in_minute = (exam_hour * 60) + exam_min
arrive_in_minutes = (arrive_hour * 60) + arrive_min
differens = exam_in_minute - arrive_in_minutes
if differens >= 0 and differens <= 30:
    if differens > 0:
        print('On time')
        print(f'{differens} minutes before the start')
    else:
        print('On time')
elif differens > 30:
    if differens > 59:
        print('Early')
        print(f'{int(differens / 60)}:{(differens % 60):02d} hours before the start')
    else:
        print('Early')
        print(f'{differens:02d} minutes before the start')
elif differens < 0:
    differens = differens * -1
    if differens > 59:
        print('Late')
        print(f'{int(differens / 60)}:{differens % 60:02d} hours after the start')
    else:
        print('Late')
        print(f'{differens} minutes after the start')
