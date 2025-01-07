#include <iostream>

int main()
{
	using namespace std;

	int rats = 101;
	int & rodents = rats;

	cout << "rats = " << rats;
	cout << ", rodents = " << rodents << endl;

	rodents++;
	
	cout << "rats = " << rats;
	cout << ", rodents = " << rodents << endl;

	cout << "rats주소 = " << &rats;
	cout << ", rodents주소 = " << &rodents << endl;

}