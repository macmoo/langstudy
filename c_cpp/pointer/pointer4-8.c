#include <stdio.h>

// �迭�� ���ڿ� ����
int main(void)
{
    char str1[6];
    char str2[6];
    char str3[6];
    char str4[] = "ABCDE";

    str1[0] = 'A';
    str1[1] = 'B';
    str1[2] = 'C';
    str1[5] = '\0';
    printf("�迭str1���� ���ڿ� \"%s\"�� ����Ǿ� �ִ�.\n", str1);

    str2[0] = 'Q';
    str2[1] = 'B';
    str2[2] = 'C';
    str2[3] = '\0';
    str2[4] = 'D';
    str2[5] = 'E';
    printf("�迭str2���� ���ڿ� \"%s\"�� ����Ǿ� �ִ�.\n", str2);

    str3[0] = '\0';
    str3[1] = 'B';
    str3[2] = 'C';
    str3[3] = 'D';
    str3[4] = 'E';
    str3[5] = 'F';
    printf("�迭str3���� ���ڿ� \"%s\"�� ����Ǿ� �ִ�.\n", str3);
    
    printf("�迭str4���� ���ڿ� \"%s\"�� ����Ǿ� �ִ�.\n", str4);
    
    puts("* ������ -------");
    printf("�迭str1�� ������ : %u\n", (unsigned)sizeof(str1));
    printf("�迭str2�� ������ : %u\n", (unsigned)sizeof(str2));
    printf("�迭str3�� ������ : %u\n", (unsigned)sizeof(str3));
    printf("�迭str4�� ������ : %u\n", (unsigned)sizeof(str4));

    puts("* �ּ� ---------");
    printf("�迭str1�� �ּ� : %p\n", str1);
    printf("�迭str2�� �ּ� : %p\n", str2);
    printf("�迭str3�� �ּ� : %p\n", str3);
    printf("�迭str4�� �ּ� : %p\n", str4);

    return 0;
}
// �迭str����  ���ڿ� "ABC��"�� ����Ǿ� �ִ�.
// �迭str2���� ���ڿ� "QBC"�� ����Ǿ� �ִ�.
// �迭str3���� ���ڿ� ""�� ����Ǿ� �ִ�.