#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif
#include <iostream>

using namespace std;
void swap(int& x, int& y)
{
    int temp = x;
    x = y;
    y = temp;
}
int main(void)
{
    int a, b;
    cout << "�ΰ��� ������ �Է��Ͻÿ�.\n";
    cout << "���� A:";
    cin >> a;
    cout << "���� B:";
    cin >> b;
    swap(a, b);

    cout << "������\n";
    cout << "A : " << a << "�̴�.\n";
    cout << "B : " << b << "�̴�.\n";
}
