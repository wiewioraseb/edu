#include <iostream>
#include <string>

using namespace std;


struct Wiz {
public:
	string pierwszasStringProperty;
	int drugaIntProperty;
	char trzebaIntTabProperty[10];
};

void ex2_6() {
	cout << "START zadanie2-6" << endl;

	struct Wiz * wiz = new struct Wiz;



	cout << endl << "KONIEC" << endl;

}