#ifdef _MSC_VER
    #define _CRT_SECURE_NO_WARNINGS
#endif
#include <stdio.h>
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
        while (x) {
            d[digits++] = dchar[x % n];
            x /= n;
        }
    return digits;
}
// ������
int card_conv_right(unsigned x, int n, char d2[])
{
    char    dchar[] = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int     digits = 0; // ��ȯ���� ���ڼ�

    if (x == 0)
        d2[digits++] = dchar[0];
    else
    {
        int tmpX = x;
        do {
            digits++;
            tmpX /= n;
        } while (tmpX);
        
        for(int i = digits -1 ; i >= 0 ; i--)
        {
            d2[i] = dchar[x % n];
            x /= n;
        }
    }
    return digits;
}
int main(void)
{
    int         i;
    unsigned    no;         // ��ȯ�� ����
    int         cd;         // ���
    int         dno;        // ��ȯ���� ���ڼ�
    int         dno2;       // ��ȯ���� ���ڼ�
    char        cno[512];   // ��ȭ���� ���ڸ� ������ ����
    char        cno2[512] = { 0 };  // ��ȭ���� ���ڸ� ������ ����

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
    
    dno2 = card_conv_right(no, cd, cno2);
    printf("%d�����δ� ������:[", cd);
    for (i = dno2 - 1; i >= 0; i--)
        printf("%c", cno2[i]);
    printf("]�̴�.\n\n");

    return 0;
}