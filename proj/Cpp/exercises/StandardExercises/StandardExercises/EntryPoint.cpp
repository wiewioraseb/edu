#include <iostream>
#include "ex1-1.h"
#include "ex2-4.h"
#include "ex2-6.h"
#include "ex2-7.h"
#include "ex2-8.h"
#include "ex2-9.h"
#include "ex3-1.h"


using namespace std;

// https://github.com/hexen2k/cppio

int main(void) {

	//int x;
	//cout << "START" << endl;
	//cin >> x;

	cout << "Podaj nr zadania: ";
	int numerZadania = 7;
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
	case 5: {
		ex2_7();
		break;
	}
	case 6: {
		ex2_8();
		break;
	}
	case 7: {
		ex3_1();
		break;
	}
}


	system("pause");

	return 0;
}