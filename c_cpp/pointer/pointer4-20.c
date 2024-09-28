#include <stdio.h>

unsigned int lengOfString(const char* t)
{
    unsigned int count = 0;
    while (*t++ != '\0')
        count++;
    return count;
}
void put_str(const char* s)
{
    while (*s)
    // or while (*s != '\0')
        putchar(*s++);
    putchar('\n');
}
int main(void)
{
    // �迭�� ���� ���ڿ�
    char str[] = "ABCDEF";   // str�� ����Ҵ� 'A','B','C','\n'
    // �����Ϳ� ���� ���ڿ�
    char* ptr  = "XYZ1234";  // ptr�� ����Ҵ� 'X','Y','Z'

    printf("���ڿ� str�� \"%s\"�̴�.\n", str);
    printf("���ڿ� ptr�� \"%s\"�̴�.\n", ptr);

    printf("���ڿ� str�� ������ \"sizeof(%s)\"�� %u�̴�.\n", str, (unsigned)sizeof(str));
    // ptr�� ������� ������ptr�� ������(4) + ���ͷ�"XYZ1234"�� �Ǿ�� �Ѵ�. ���ϴ� NG.
    printf("���ڿ� ptr�� ������ \"sizeof(%s)\"�� %u�̴�.\n", ptr, (unsigned)sizeof(ptr));
    
    printf("���ڿ� str�� ���� \"length(%s)\"�� %u�̴�.\n", str, lengOfString(str));
    printf("���ڿ� ptr�� ���� \"length(%s)\"�� %u�̴�.\n", ptr, lengOfString(ptr));
   
    // []���ٰ���
    putchar(str[1]);  putchar('\n');
    putchar(ptr[1]);  putchar('\n');

    // ���
    puts("str ���"); put_str(str);
    puts("ptr ���"); put_str(ptr);

    // ������
    // �� ERROR : ����	C2106	'=': ���� �ǿ����ڴ� l - value�̾�� �մϴ�.
    // str = "XXXXXX"; 
    ptr = "XXXXXX"; // OK
    puts("ptr ���"); put_str(ptr);

    return 0;
}

// ���ڿ� str�� "ABCDEF"�̴�.
// ���ڿ� ptr�� "XYZ1234"�̴�.
// ���ڿ� str�� ������ "sizeof(ABCDEF)"�� 7�̴�.
// ���ڿ� ptr�� ������ "sizeof(XYZ1234)"�� 4�̴�.
// ���ڿ� str�� ���� "length(ABCDEF)"�� 6�̴�.
// ���ڿ� ptr�� ���� "length(XYZ1234)"�� 7�̴�.
// B
// Y
// str ���
// ABCDEF
// ptr ���
// XYZ1234
// ptr ���
// XXXXXX