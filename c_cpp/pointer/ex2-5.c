#ifdef _MSC_VER
    #define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>
#include <stdlib.h>
// "do{ } while();" �� ��Ʈ
// (ȣ����� swap�� �ǵڿ� ;�� ������ �ߺ��� �׷��� define���� ����)
#define swap(type, x, y) do { type t = x; x = y; y = t; } while(0)
// �迭 ���
void printArr(int a[], int n)
{
    for (int i = 0; i < n; i++)
    {
        printf("%d", a[i]);
        if (i != n - 1)
            printf(" ");
    }
    printf("\n");
}
// n���� �迭a�� ��Ҹ� ����
void arr_reverse(int a[], int n)
{
    int i;
    for (i = 0; i < n / 2; i++) 
    {
        printArr(a, n);
        printf("a[%d]�� a[%d]�� ��ȯ�մϴ�.\n", i, n - i - 1);
        swap(int, a[i], a[n - i - 1]);
    }
}
int main(void)
{
    int i;
    int* arr;
    int num;

    printf("��Ҽ� :");
    scanf("%d", &num);

    arr = calloc(num, sizeof(int));
    for (i = 0; i < num; i++)
    {
        printf("arr[%d]:", i);
        scanf("%d", &arr[i]);
    }

    arr_reverse(arr, num); // ����

    printf("-- ��� --\n");
    for (i = 0; i < num; i++)
        printf("arr[%d]:%d\n", i, arr[i]);

    free(arr);
    return 0;
}