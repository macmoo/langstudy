#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>

int int_bits(void)
{
    int count = 0;
    unsigned x = ~0U;
    while (x) {
        if (x & 1U) count++;
        x >>= 1;
    }
    return count;
}
int main(void)
{
    printf("int���� ��ȿ��Ʈ�� %d��Ʈ�̴�.\n", int_bits());
    return 0;
}
