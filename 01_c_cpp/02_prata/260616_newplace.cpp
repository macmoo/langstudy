// 위치 지정 연산자 new
//
// new와 위치지정new의 첫번째호출 :
// 버퍼주소:
// 000002905A9D6E90 : 힙;    00007FF735A5F490 : 정적
// 버퍼내용 :
// 000002905A9D6E90에 1000; 00007FF735A5F490에 1000
// 000002905A9D6E98에 1020; 00007FF735A5F498에 1020
// 000002905A9D6EA0에 1040; 00007FF735A5F4A0에 1040
// 000002905A9D6EA8에 1060; 00007FF735A5F4A8에 1060
// 000002905A9D6EB0에 1080; 00007FF735A5F4B0에 1080
// new와 위치지정new의 두번째호출 :
// 버퍼내용:
// 000002905A9D6F70에 1000; 00007FF735A5F490에 1000
// 000002905A9D6F78에 1020; 00007FF735A5F498에 1020
// 000002905A9D6F80에 1040; 00007FF735A5F4A0에 1040
// 000002905A9D6F88에 1060; 00007FF735A5F4A8에 1060
// 000002905A9D6F90에 1080; 00007FF735A5F4B0에 1080
// new와 위치지정new의 세번째호출 :
// 버퍼내용:
// 000002905A9D7440에 1000; 00007FF735A5F4B8에 1000
// 000002905A9D7448에 1020; 00007FF735A5F4C0에 1020
// 000002905A9D7450에 1040; 00007FF735A5F4C8에 1040
// 000002905A9D7458에 1060; 00007FF735A5F4D0에 1060
// 000002905A9D7460에 1080; 00007FF735A5F4D8에 1080

#include <iostream>
#include <new>

const int BUF = 512;
const int N = 5;
char buffer[BUF]; // 정적 메모리

int main()
{
	using namespace std;

	double* pd1, * pd2;
	int i;

	// ---------------------------------------------
	cout << "new와 위치지정new의 첫번째호출 :\n";
	pd1 = new double[N];
	pd2 = new (buffer) double[N];

	for (i = 0; i < N; i++)
		pd2[i] = pd1[i] = 1000 + 20.0 * i;
	cout << "버퍼주소:\n" << pd1 << " : 힙;    "
		<< (void*)buffer << " : 정적" << endl;

	cout << "버퍼내용:\n";
	for (i = 0; i < N; i++)
	{
		cout << &pd1[i] << "에 " << pd1[i] << "; ";
		cout << &pd2[i] << "에 " << pd2[i] << endl;
	}
	// ---------------------------------------------
	cout << "new와 위치지정new의 두번째호출 :\n";
	double *pd3, *pd4;
	pd3 = new double[N];
	pd4 = new (buffer) double[N];
	for (i = 0; i < N; i++)
		pd3[i] = pd4[i] = 1000 + 20.0 * i;
	cout << "버퍼내용:\n";
	for (i = 0; i < N; i++)
	{
		cout << &pd3[i] << "에 " << pd3[i] << "; ";
		cout << &pd4[i] << "에 " << pd4[i] << endl;
	}
	// ---------------------------------------------
	cout << "new와 위치지정new의 세번째호출 :\n";
	delete[] pd1;
	pd1 = new double[N];
	pd2 = new (buffer + N * sizeof(double)) double[N];
	for (i = 0; i < N; i++)
		pd2[i] = pd1[i] = 1000 + 20.0 * i;
	cout << "버퍼내용:\n";
	for (i = 0; i < N; i++)
	{
		cout << &pd1[i] << "에 " << pd1[i] << "; ";
		cout << &pd2[i] << "에 " << pd2[i] << endl;
	}
	// ---------------------------------------------
	delete[] pd1;
	delete[] pd3;
}

