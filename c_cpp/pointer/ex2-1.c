#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
int maxOf(const int a[], int n)
{
    int i;
    int max = a[0];
    for (i = 1; i < n; i++)
        if (a[i] > max) max = a[i];
    return max;
}
int minOf(const int a[], int n)
{
    int i;
    int min = a[0];
    for (i = 1; i < n; i++)
        if (a[i] < min) min = a[i];
    return min;
}
int main(void)
{
    int i;
    int* height; // �迭�� ���ο���� ������
    int num;

    printf("��Ҽ� :");
    scanf("%d", &num);

    height = calloc(num, sizeof(int));
    // �ð����� ������ �õ带 �ʱ�ȭ
    srand(time(NULL));
    for (i = 0; i < num; i++)
    {
        // 100 ~ 189�� ���� ����
        height[i] = 100 + rand() % 90;
        printf("height[%d]:%d\n", i, height[i]);
    }
    printf("-- ��� --\n");
    printf("�ִ밪�� :%d\n", maxOf(height, num));
    printf("�ּҰ��� :%d\n", minOf(height, num));
    free(height);
    return 0;
}