#include <stdio.h>

void str_copy(char d[], const char s[])
{
    int i = 0;
    while ((d[i] = s[i]) != '\0')
        i++;
}
void str_copy2(char* d, const char* s)
{
    while (*d++ = *s++);
    // while ((*d++ = *s++) != '\0');  // OK
}
int main(void)
{
    char str[100] = "ABC";
    char tmp[100];
    char tmp2[100];

    printf("���ڿ� str�� \"%s\"�Դϴ�.\n", str);
    
    printf("1) ������ ���ڿ��� �Է��Ͻÿ�:");
    scanf("%s", tmp);
    str_copy(str, tmp);
    printf("1) ���ڿ� str�� \"%s\"�Դϴ�.\n", str);

    printf("2) ������ ���ڿ��� �Է��Ͻÿ�:");
    scanf("%s", tmp2);
    str_copy2(str, tmp2);
    printf("2) ���ڿ� str�� \"%s\"�Դϴ�.\n", str);


    return 0;
}
// ���ڿ� str�� "ABC"�Դϴ�.
// 1) ������ ���ڿ��� �Է��Ͻÿ� : qwer
// 1) ���ڿ� str�� "qwer"�Դϴ�.
// 2) ������ ���ڿ��� �Է��Ͻÿ� : 1234
// 2) ���ڿ� str�� "1234"�Դϴ�.