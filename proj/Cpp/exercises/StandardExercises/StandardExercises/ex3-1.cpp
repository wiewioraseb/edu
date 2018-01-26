#include <iostream>
#include <string>
#include "ex3-1.h"

using namespace std;


void ex3_1() {
	cout << "START zadanie3-1" << endl;

	Pies *burek = new Pies();
	burek->Spaceruj(45);
	Pies szczurek("Szczurek", 37);
	szczurek.Spaceruj(22);

	cout << endl << "KONIEC" << endl;
}

Pies::Pies(string i, int e) {
	imie = i;
	energia = e;
}
Pies::~Pies() {
	cout << endl << "DESTRUKTOR";
}

void Pies::Spaceruj(int czas) {
	cout << endl << "Pies " << imie 
		<< " spaceruje przez " << czas << " minut." 
		<< " Ma " << energia << " energii."
		<< endl;
}