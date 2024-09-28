# -------------------------------------------------
dic = {}
print(dic)
print("------------------------------------------")
dic["name"] = "new name"
dic["head"] = "new head"
dic["body"] = "new body"
print(dic)
print("------------------------------------------")
# print key
key = input("> 키 입력:")
if key in dic:
    print(dic[key])
else:
    print("존재하지 않는 키")
    value = dic.get(key)
    print(value)
    if value == None:
        print("NONE이다")
print("------------------------------------------")
# ------------------------------------------
# {}
# ------------------------------------------
# {'name': 'new name', 'head': 'new head', 'body': 'new body'}
# ------------------------------------------
# > 키 입력:kk
# 존재하지 않는 키
# None
# NONE이다
# ------------------------------------------