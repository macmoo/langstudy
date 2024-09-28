#include <stdio.h>

unsigned str_length(const char s[])
{
    unsigned len = 0;
    while (s[len] != '\0')
        len++;
    return len;
}
unsigned str_length2(const char s[])
{
    unsigned len = 0;
    for( ; *s != '\0' ; s++)
        len++;
    return len;
}
unsigned str_length3(const char s[])
{
    const char* p = s;
    while(*s)
        s++;
    return (s - p);
}
int main(void)
{
    char str[100];
    printf("���ڿ��Է�:");
    scanf("%s", str);

    printf("1) ���ڿ� %s�� ���̴� %u�̴�.\n", str, str_length(str));
    printf("2) ���ڿ� %s�� ���̴� %u�̴�.\n", str, str_length2(str));
    printf("3) ���ڿ� %s�� ���̴� %u�̴�.\n", str, str_length3(str));

    return 0;
}
// ���ڿ��Է�:abcde
// 1) ���ڿ� abcde�� ���̴� 5�̴�.
// 2) ���ڿ� abcde�� ���̴� 5�̴�.
// 3) ���ڿ� abcde�� ���̴� 5�̴�.