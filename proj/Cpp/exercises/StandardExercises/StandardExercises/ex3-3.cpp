#include <iostream>
#include <string>
#include "ex3-3.h"

using namespace std;


void ex3_3() {
	cout << "START zadanie3-3" << endl;


	cout << endl << "KONIEC" << endl;
}

Mysz::Mysz(string i, int e) {
	imie = i;
	energia = e;
}

Mysz::Mysz(Mysz& k) {
	cout << endl << "Konstruktor kopiuj¹cy." << endl;
}

Mysz::~Mysz() {
	cout << endl << "DESTRUKTOR" << endl;
}
