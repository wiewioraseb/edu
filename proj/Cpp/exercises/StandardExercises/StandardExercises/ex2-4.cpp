#include <iostream>
#include <string>

using namespace std;


struct Wiz {
public:
	string pierwszasStringProperty;
	int drugaIntProperty;
	char trzebaIntTabProperty[10];
};

void ex2_4() {
	cout << "START zadanie2-4" << endl;

	struct Wiz * wiz = new struct Wiz;
	cout << "pierwszasStringProperty" << endl;
	cin >> wiz->pierwszasStringProperty;

	cout << endl << "drugaIntProperty" << endl;
	cin >> wiz->drugaIntProperty;
	
	cout << endl << "trzebaIntTabProperty" << endl;
	cin >> wiz->trzebaIntTabProperty;

	cout << endl << "pierwszasStringProperty:" << wiz->pierwszasStringProperty 
		<< endl << "drugaIntProperty: " << wiz->drugaIntProperty
		<< endl << "trzebaIntTabProperty: " << wiz->trzebaIntTabProperty;

	cout << endl << "PRZED DELETEM" << endl;

	delete wiz;
	wiz = NULL;

	cout << endl << "KONIEC" << endl;
	cin >> wiz->drugaIntProperty;
}