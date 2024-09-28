#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>
void printCardConv(int x, int n, char r)
{
    printf("%4d | %7d --- %c \n", x, n, r);
    printf("     +--------\n");
}
// x : ������
// n : ��ȯ�� ���� 
// d : ��ȯ���
// ������
int card_conv(unsigned x, int n, char d[])
{
    char    dchar[] = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int     digits = 0; // ��ȯ���� ���ڼ�

    if (x == 0)
        d[digits++] = dchar[0];
    else
    {
        int  m = 0;
        char r = 0;
        while (x) {
            r = dchar[x % n];
            printCardConv(x, n, r);
            d[digits++] = r;
            x /= n;
        }
        printf("             0\n");
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

    puts("10������ �����ȯ�Ѵ�.");
    printf("��ȯ�� ���� : ");
    scanf("%d", &no);
    do {
        printf("��ȯ�� ���� ( 2 - 36 ) :");
        scanf("%d", &cd);
    } while (cd < 2 || cd > 36);

    printf("%d�� %d������ ��ȯ \n", no, cd);
    dno = card_conv(no, cd, cno);
    printf("%d�����δ� ������:[", cd);
    for (i = dno - 1; i >= 0; i--)
        printf("%c", cno[i]);
    printf("]�̴�.\n");
    
    return 0;
}