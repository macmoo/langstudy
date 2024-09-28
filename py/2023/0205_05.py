import datetime
print("------------------------------------------");
# 현재 시간
now = datetime.datetime.now()
print(now)
print(now.year)
print(now.month)
print(now.day)
print(now.hour)
print(now.minute)
print(now.second)
print("------------------------------------------");
v1 = "{}년 {}월 {}일".format(now.year, now.month, now.day)
print(v1)
print("------------------------------------------");
# ------------------------------------------
# 2023-02-06 00:39:33.887923
# 2023
# 2
# 6
# 0
# 39
# 33
# ------------------------------------------
# 2023년 2월 6일
# ------------------------------------------
