#include <stdio.h>

int main(void)
{
    printf("���ڿ� \"ABCD\"    = %p\n", "ABCD"); // ���ڿ��� �ּ�
    printf("���ڿ� \"ABCD\"    = %s\n", "ABCD"); // ���ڿ� ���
    
    printf("���ڿ� \"AB\\0CD\"  = %p\n", "AB\0CD");
    printf("���ڿ� \"AB\\0CD\"  = %s\n", "AB\0CD");
    printf("sizeof(\"AB\\0CD\") = %u\n", (unsigned)sizeof("AB\0CD"));
    return 0;
}

// ���ڿ� "ABCD"    = 00D67B30
// ���ڿ� "ABCD"    = ABCD
// ���ڿ� "AB\0CD"  = 00D67B58
// ���ڿ� "AB\0CD"  = AB
// sizeof("AB\0CD") = 6