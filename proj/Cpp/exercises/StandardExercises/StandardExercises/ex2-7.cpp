#include <iostream>
#include <string>
#include "ex2-7.h"

using namespace std;


void ex2_7() {
	cout << "START zadanie2-7" << endl;
	int *x;
	x =	UstalLiczbeCalkowita();
	
	cout << endl << "Liczba ca³kowita: " << *x << endl;

	cout << endl << "KONIEC" << endl;
}


int * UstalLiczbeCalkowita() {
	int *a = new int;
	cout << endl << "Podaj liczbê: " << endl;
	cin >> *a;
	return a;
}