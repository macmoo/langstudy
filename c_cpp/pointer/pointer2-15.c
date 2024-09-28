#include <stdio.h>

// �迭x�� ���� n���� ��ҿ� 0�� ����
// ������ a�� ����Ű�� �ִ°� �迭�� �ƴ϶� ����̹Ƿ�.
// �Լ����� �迭�� �ѱ涧�� �迭�� ������ ���� �Ѱܾ���
void fill_zero(int x[], int n)
{
    for (int i = 0; i < n; i++)
        x[i] = 1;
}

void fill_zero2(int x[], int n)
{
    for (int i = 0; i < n; i++)
        *(x + i) = 2;
}

void fill_zero3(int x[], int n)
{
    while (n-- > 0) {
        *x = 3;
        x++;
    }
}
void fill_zero4(int x[], int n)
{
    while (n-- > 0) 
        *x++ = 4;
}
int main(void)
{
    int a[5] = { 10,20,30,40,50 };
    int a_size = sizeof(a) / sizeof(a[0]); // ��Ҽ�

    fill_zero(a, a_size);
    for (int i = 0; i < a_size; i++)
        printf("a[%d] = %d\n", i, a[i]);

    printf("---------\n");
    fill_zero2(a, a_size);
    for (int i = 0; i < a_size; i++)
        printf("a[%d] = %d\n", i, a[i]);
    printf("---------\n");
    fill_zero3(a, a_size);
    for (int i = 0; i < a_size; i++)
        printf("a[%d] = %d\n", i, a[i]);
    printf("---------\n");
    fill_zero4(a, a_size);
    for (int i = 0; i < a_size; i++)
        printf("a[%d] = %d\n", i, a[i]);

    return 0;
}