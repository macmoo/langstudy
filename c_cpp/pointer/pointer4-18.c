#include <stdio.h>
char* str_copy(char* d, const char* s)
{
    char* p = d;
    while (*d++ = *s++);
    return (p);
}
int main(void)
{
    char tmp[100];
    char st1[100], st2[100], st3[100];

    printf("���ڿ��� �Է��Ͻÿ�:");
    scanf("%s", tmp);

    // st1�� ������ ���ڿ��� st2���� ������
    str_copy(st1, str_copy(st2, tmp));

    printf("���ڿ� st1�� \"%s\"�̴�.\n", st1);
    printf("���ڿ� st2�� \"%s\"�̴�.\n", st2);
    printf("���ڿ� st3�� \"%s\"�̴�.\n", str_copy(st3, tmp));

    return 0;
}
// ���ڿ��� �Է��Ͻÿ� : aaaaa
// ���ڿ� st1�� "aaaaa"�̴�.
// ���ڿ� st2�� "aaaaa"�̴�.
// ���ڿ� st3�� "aaaaa"�̴�.