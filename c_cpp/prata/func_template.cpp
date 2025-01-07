#include <iostream>

template<class Any>
void Swap(Any& a, Any& b);

int main() 
{
	using namespace std;

	int i = 10;
	int j = 20;

	cout << "변환전 : i, j = " << i << ", " << j << ".\n"; 
	Swap(i, j);
	cout << "변환후 : i, j = " << i << ", " << j << ".\n";

	double x = 24.5;
	double y = 81.7;
	cout << "변환전 : x, y = " << x << ", " << y << ".\n";
	Swap(x, y);
	cout << "변환후 : x, y = " << x << ", " << y << ".\n";
	
	return 0;
}

template<class Any>
void Swap(Any& a, Any& b)
{
	Any temp;
	temp = a;
	a = b;
	b = temp;
}