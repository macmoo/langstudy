#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>

int main(void)
{
    int nx = 100;
    int* pt = &nx;

    
    printf("int  ���� %u����Ʈ�̴�.\n", (unsigned)sizeof(int));
    printf("int* ���� %u����Ʈ�̴�.\n", (unsigned)sizeof(int*));

    printf(" nx �� %u����Ʈ�̴�.\n", (unsigned)sizeof(nx));
    printf("*pt �� %u����Ʈ�̴�.\n", (unsigned)sizeof(*pt));
    printf(" pt �� %u����Ʈ�̴�.\n", (unsigned)sizeof(pt));
    printf("&nx �� %u����Ʈ�̴�.\n", (unsigned)sizeof(&nx));

    printf("------------------------\n");

    printf("&nx �� %d �̴�.\n", &nx);
    printf("*pt �� %d �̴�.\n", *pt);

    printf("*&nx �� %d �̴�.\n", *&nx);
    printf("&*pt �� %d �̴�.\n", &*pt);

    return 0;
} 