#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>

int main(void)
{
    int     i;
    long    k;
    char    s[20];

    printf("������ �Է��ض�.:");
    scanf("%d", &i);

    printf("������ �Է��ض�.:");
    scanf("%ld", &k);

    printf("���ڿ��� �Է��ض�.");
    scanf("%s", s);

    printf("����   i �� �Է°��� : %d�̴�.\n", i);
    printf("����   k �� �Է°��� : %ld�̴�.\n", k);
    printf("���ڿ� s �� �Է°��� : %s�̴�.\n", s);

    return 0;
}
