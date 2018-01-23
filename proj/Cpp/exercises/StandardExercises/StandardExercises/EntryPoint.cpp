#include <iostream>
#include "ex1-1.h"
#include "ex2-4.h"
#include "ex2-6.h"
#include "ex2-9.h"


using namespace std;

// https://github.com/hexen2k/cppio

void main(void) {

	//int x;
	//cout << "START" << endl;
	//cin >> x;

	cout << "Podaj nr zadania: ";
	int numerZadania = 4;
	cout << endl << "Wybrano zadanie: " << numerZadania << endl;

	switch (numerZadania) {
	case 1: {
		ex1_1();
		break;
	}
	case 2: {
		ex2_9();
		break;
	}
	case 3: {
		ex2_4();
		break;
	}
	case 4: {
		ex2_6();
		break;
	}
	//case 5: {
	//	zadanie5();
	//	break;
	//}
	}


	//cout << "wskaznikZadania1:" << wskaznikZadania1  << endl;
	//cout << "*wskaznikZadania1:" << *wskaznikZadania1  << endl;


	system("pause");
}