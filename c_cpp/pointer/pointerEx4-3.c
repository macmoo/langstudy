#include <stdio.h>

int str_chnum(const char* s, int c)
{
    unsigned int count = 0;
    while (*s)
        if (*s++ == c)
            count++;
    return count;
}
int main(void)
{   
    char str[] = "abcaade";
    char c = 'a';
    printf("���ڿ� %s���� ����%c�� %d�� ���ԵǾ��ִ�.\n", str, c, str_chnum(str, c));
    return 0;
}

// ���ڿ� abcaade���� ����a�� 3�� ���ԵǾ��ִ�.