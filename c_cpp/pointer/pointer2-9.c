#include <stdio.h>

void func(int a[])
{
    printf("sizeof(a) = %u\n", (unsigned)sizeof(a));
}
int main(void)
{
    printf("-----------------------------\n");
    printf("��[2-09]                      \n");
    printf("-----------------------------\n");
    int x[5];
    printf("sizeof(x) = %u\n", (unsigned)sizeof(x));
    func(x);
    // sizeof(x) = 20
    // sizeof(a) = 4
    printf("-----------------------------\n");
    printf("��[2-10]                      \n");
    printf("-----------------------------\n");
    printf("x�� ��Ҽ��� %d�̴�\n", (unsigned)sizeof(x) / sizeof(x[0]));
    // x�� ��Ҽ��� 5�̴�
    return 0;
}