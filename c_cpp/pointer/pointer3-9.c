#include <stdio.h>

// �迭�� ���� &�� �����ϸ� 
// �迭�� ���ο�ҿ� ���� �����Ͱ� �ƴ϶�
// �迭��ü�� ���� �����Ͱ� �ȴ�.
int main(void)
{
    int x[5] = { 1,2,3,4,5 };

    //  x�� x[0]���� ������
    // &x�� �迭��ü���� ������
    printf("sizeof(*&x)     = %u\n", (unsigned)sizeof(*&x));
    printf("sizeof(*&x[0])  = %u\n", (unsigned)sizeof(*&x[0]));
    
    printf("*&x     = %d\n", *&x);
    printf("*&x[0]  = %d\n", *&x[0]);
    return 0;
}