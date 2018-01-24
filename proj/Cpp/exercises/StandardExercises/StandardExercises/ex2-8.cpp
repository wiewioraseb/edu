#include <iostream>
#include <string>
#include "ex2-8.h"

using namespace std;


void ex2_8() {
	cout << "START zadanie2-8" << endl;
	int trescDlugosc = 5;
	char **tresc = new char*[trescDlugosc];

	cout << "Podaj tresc:" << endl;
	for (int i = 0; i < trescDlugosc; i++) {
		tresc[i] = new char;
		cin >> tresc[i];
	}
	cout << "Wypisz tresc:" << endl;
	for (int i = 0; i < trescDlugosc; i++) {
		cout << tresc[i];
	}
	cout << endl;

	char *szukanyWskaznik = wskazdnikDoDrugiegoC(*tresc, trescDlugosc);
	cout << endl << "Szukany wsaznik adres:" << szukanyWskaznik << endl;
	cout << endl << "Szukany wsaznik wartosc:" << *szukanyWskaznik << endl;


	cout << endl << "KONIEC" << endl;
}

char * wskazdnikDoDrugiegoC(char lancuch[], int dlugosc) {
	cout << endl << "Wejsc do funkcji." << endl;
	int licznik = 0;
	for (int i = 0; i < dlugosc; i++) {
		cout << endl << "i:" << i  << " value: " << lancuch[i] << endl;
		if ( lancuch[i] == 'c') {
			cout << endl << "Znaleziono!" << endl;
			licznik++;
		}
		if (licznik == 2) {
			cout << endl << "Znaleziono 'c', adres:" << &lancuch[i] << endl;
			cout << endl << "Znaleziono 'c', wartosc:" << lancuch[i] << endl;

			return &lancuch[i];
		}
	}
	return NULL;
}
