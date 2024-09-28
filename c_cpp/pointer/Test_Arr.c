#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
/* */
/* */
/* */
#include <stdio.h>
// x : ������
// n : ��ȯ�� ���� 
// d : ��ȯ���
int card_conv(unsigned x, int n, char d[])
{
    char    dchar[] = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int     digits = 0; // ��ȯ���� ���ڼ�

    if (x == 0)
        d[digits++] = dchar[0];
    else
        while (x) {
            d[digits++] = dchar[x % n];
            x /= n;
        }
    return digits;
}

int main(void)
{
    int         i;
    unsigned    no;         // ��ȯ�� ����
    int         cd;         // ���
    int         dno;        // ��ȯ���� ���ڼ�
    char        cno[512];   // ��ȭ���� ���ڸ� ������ ����
    int         retry;

    puts("10������ �����ȯ�Ѵ�.");
    printf("��ȯ�� ���� : ");
    scanf("%d", &no);
    do {
        do {
            printf("��ȯ�� ���� ( 2 - 36 ) :");
            scanf("%d", &cd);
        } while (cd < 2 || cd > 36);

        printf("%d�� %d������ ��ȯ \n", no, cd);
        dno = card_conv(no, cd, cno);

        printf("%d�����δ� [", cd);
        for (i = dno - 1; i >= 0; i--)
            printf("%c", cno[i]);
        printf("]�̴�.\n\n");
        printf("�ѹ���? Yes(1)/No(0)");
        scanf("%d", &retry);
    } while (retry == 1);
    return 0;
}
