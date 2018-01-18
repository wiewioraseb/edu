#include <iostream>
#include "ex1-1.h"
#include "ex2-9.h"


using namespace std;

// https://github.com/hexen2k/cppio

void main(void) {

	//int x;
	//cout << "START" << endl;
	//cin >> x;

	cout << "Podaj nr zadania: ";
	int numerZadania = 2;
	cout << endl << "Wybrano zadanie: " << numerZadania << endl;

	switch (numerZadania) {
	case 1: {
		cout << "TEST: " << numerZadania;

		ex1_1();
		break;
	}
	case 2: {
		ex2_9();
		break;
	}
	//case 3: {
	//	ex2_4();
	//	break;
	//}
	//case 4: {
	//	zadanie4();
	//	break;
	//}
	//case 5: {
	//	zadanie5();
	//	break;
	//}
	}


	//cout << "wskaznikZadania1:" << wskaznikZadania1  << endl;
	//cout << "*wskaznikZadania1:" << *wskaznikZadania1  << endl;


	system("pause");
}