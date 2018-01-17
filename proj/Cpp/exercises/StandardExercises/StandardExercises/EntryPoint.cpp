#include <iostream>
//#include "zadanie1.h"
//#include "zadanie2.h"
//#include "zadanie3.h"
//#include "zadanie4.h"
//#include "zadanie5.h"


using namespace std;

void main(void) {

	//int x;
	//cout << "START" << endl;
	//cin >> x;

	cout << "Podaj nr zadania: ";
	int numerZadania = 5;
	cout << endl << "Wybrano zadanie: " + numerZadania << endl;

	switch (numerZadania) {
	case 1: {
		cout << "TEST: " + numerZadania;

		//zadanie1();
		break;
	}
	//case 2: {
	//	zadanie2();
	//	break;
	//}
	//case 3: {
	//	zadanie3();
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