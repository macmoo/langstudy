#include <stdio.h>

// ���ڿ����� ���� �˻�
char* str_chr(const char* s, int c)
{
    c = (char)c;
    while (*s != c) {
        if (*s == '\0')
            return NULL;
        s++;
    }
    return ((char*)s);
}

int main(void)
{
    char* ptr;
    char  ch[2];
    char  letter[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    printf("���빮�ڸ� �Է��Ͻÿ�:");
    scanf("%s", ch);

    if ((ptr = str_chr(letter, ch[0])) == NULL)
        printf("%c�� ���빮�ڰ� �ƴմϴ�.\n", ch[0]);
    else
        printf("%c���� ���� ���ĺ��� %s�̴�.\n", ch[0], ptr);

    return 0;
}
// ���빮�ڸ� �Է��Ͻÿ� : T
// T���� ���� ���ĺ��� TUVWXYZ�̴�.
