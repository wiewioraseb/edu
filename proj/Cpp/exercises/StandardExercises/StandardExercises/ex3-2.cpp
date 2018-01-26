#include <iostream>
#include <string>
#include "ex3-2.h"

using namespace std;


void ex3_2() {
	cout << "START zadanie3-2" << endl;

	Kot *burek = new Kot();
	burek->Spaceruj(45);
	Kot szczurek("Mruczek", 37);
	szczurek.Spaceruj(22);

	cout << endl << "KONIEC" << endl;
}

Kot::Kot(string i, int e) {
	imie = i;
	energia = e;
}
Kot::~Kot() {
	cout << endl << "DESTRUKTOR" << endl;
}

void Kot::Spaceruj(int czas) {
	cout << endl << "Kot " << imie
		<< " spaceruje przez " << czas << " minut."
		<< " Ma " << energia << " energii."
		<< endl;
}