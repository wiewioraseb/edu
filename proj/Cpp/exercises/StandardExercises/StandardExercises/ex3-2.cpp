#include <iostream>
#include <string>
#include "ex3-2.h"

using namespace std;


void ex3_2() {
	cout << "START zadanie3-2" << endl;

	Kot *burek = new Kot();
	burek->Spaceruj(45);
	burek->Spaceruj(41.0);

	Kot szczurek("Mruczek", 37);
	szczurek.Spaceruj(22);

	Kot filemon("Filemon", 11);

	cout << endl << "Wypisze fielomna? " << filemon << endl;
	cout << endl << "Wypisze bonifacy? " << *burek<< endl;

	/*
	Kot pankracy("Pankracy", 99);
	pankracy = filemon + szczurek;
	pankracy.Spaceruj(77);
	*/

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

void Kot::Spaceruj(double czas) {
	cout << endl << "Kot " << imie
		<< " spaceruje przez DOUBLE " << czas << " minut."
		<< " Ma " << energia << " energii."
		<< endl;
}

std::ostream & operator<<(std::ostream & out, Kot & os)
{
	out << "Kot: " << os.imie << " energia: " << os.energia;
	return out;
}
