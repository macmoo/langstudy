#ifdef _MSC_VER
    #define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>
int main(void)
{
    int  nx;
    int* pt;

    nx = 57;
    pt = &nx;

    printf(" nx�� ��:%d\n", nx);
    printf("&nx�� ��:%p\n", &nx);
    printf(" pt�� ��:%p\n", pt);
    printf("*pt�� ��:%d\n", *pt);
}
