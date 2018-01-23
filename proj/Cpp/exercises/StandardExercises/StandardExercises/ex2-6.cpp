#include <iostream>
#include <string>

using namespace std;


struct Wiz_tab {
public:
	char imie[10];
};

const int TABLE_SIZE = 3;

void ex2_6() {
	cout << "START zadanie2-6" << endl;

	struct Wiz_tab **wiz = new struct Wiz_tab *[3];

	cout << "Wczytuje imie:" << endl;
	for (int i = 0; i < 3; i++) {
		cout << endl;
		
		//wiz[i] = new struct Wiz_tab;
		*(wiz+i) = new struct Wiz_tab;

		//cin >> (*wiz[i]).imie;
		//cin >> wiz[i]->imie;
		cin >> (*(*(wiz + i))).imie;
	}

	for (int i = 0; i < 3; i++) {
		//cout << "wiz[" << i << "]->imie= " << wiz[i]->imie <<endl;
		//cout << "wiz[" << i << "]->imie= " << (*(*(wiz + i))).imie << endl;
		cout << "wartosc x= " << (*(*(wiz + i))).imie << endl;
	}

	delete[] wiz;
	wiz = NULL;

	cout << endl << "KONIEC" << endl;
}