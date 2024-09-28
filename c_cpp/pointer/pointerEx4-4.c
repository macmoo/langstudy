#include <stdio.h>
#include <ctype.h> // isdigit

int str_dignum(const char* s)
{
    int count = 0;
    while (*s)
    {
        if (*s > '0' && *s < '9')
            count++;
        s++;
    }
    return count;
}
int str_dignum2(const char* s)
{
    int count = 0;
    while (*s)
    {
        if (isdigit(*s))
            count++;
        s++;
    }
    return count;
}
int main(void)
{
    char str[] = "a1b2c3a4a5d6e";
    printf("1) ���ڿ� %s���� ���ڰ� %d�� ���ԵǾ��ִ�.\n", str, str_dignum(str));
    printf("2) ���ڿ� %s���� ���ڰ� %d�� ���ԵǾ��ִ�.\n", str, str_dignum2(str));
    return 0;
}

// 1) ���ڿ� a1b2c3a4a5d6e���� ���ڰ� 6�� ���ԵǾ��ִ�.
// 2) ���ڿ� a1b2c3a4a5d6e���� ���ڰ� 6�� ���ԵǾ��ִ�.