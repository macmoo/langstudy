#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>

void swap(int* x, int* y)
{
    int temp = *x;
    *x = *y;
    *y = temp;
}
void sort2(int* na, int* nb)
{
    if (*na > *nb)
        swap(na, nb);
}

int main(void)
{
    int a, b;
    puts("���� �ΰ��� �Է��Ͻÿ�.");
    printf("����A : ");
    scanf("%d", &a);
    printf("����B : ");
    scanf("%d", &b);

    sort2(&a, &b);
    puts("���� �ΰ��� �����Ѵ�.");
    printf("A�� ���� : %d\n", a);
    printf("B�� ���� : %d\n", b);
    return 0;
}