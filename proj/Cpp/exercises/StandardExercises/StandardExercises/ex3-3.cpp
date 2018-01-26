#include <iostream>
#include <string>
#include "ex3-3.h"

using namespace std;


void ex3_3() {
	cout << "START zadanie3-3" << endl;

	Gryzon *gryzon = new Gryzon;
	cout << endl << "Typ: " << gryzon->getTyp() << endl;
	gryzon->sound();
	Gryzon *szczur = new Szczur;
	cout << endl << "Typ: " << szczur->getTyp() << endl;
	szczur->sound();
	Gryzon *mysz = new Mysz;
	cout << endl << "Typ: " << mysz->getTyp() << endl;
	mysz->sound();

	cout << endl << "KONIEC" << endl;
}
