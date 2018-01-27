#pragma warning(suppress : 4996)
#include <iostream>
#include <string>

#include <cstdio>
#include <vector>


using namespace std;

class Ssak;
//class Krowa;
//class Swinia;
//class Owca;



class Ssak {
public:
	int waga;
	int ilePije;
	int ileJe;
	string typ = "ssak";
	Ssak() {
		waga = 0;
		ilePije = 0;
		ileJe = 0;

		cout << "default konstruktor ssak" << endl;
	}
	Ssak(int w): waga(w) {
		cout << "konstruktor: " << typ << "waga: " << waga << endl;
	}
	~Ssak() {
		cout << "destruktor" << endl;
	}
	virtual void SprawdzWage() {
		cout << "Typ: " << typ << " waga: " << waga  << endl;
	}
	virtual void PijWode() {
		cout << "Typ: " << typ << " pije: " << ilePije << endl;
	}
};


class Krowa: public Ssak {
public:
	int waga;
	int ilePije;
	int ileJe;
	string typ = "krowa";
	Krowa(int w): waga(w), ilePije(3), ileJe(80) {
		cout << "konstruktor: " << typ << "waga: " << waga << endl;
	}
	~Krowa() {
		cout << "destruktor" << endl;
	}
	void SprawdzWage() {
		cout << "Typ: " << typ << " waga: " << waga << endl;
	}
	void PijWode() {
		cout << "Typ: " << typ << " pije: " << ilePije << endl;
	}
};

class Swinia : public Ssak {
public:
	int waga;
	int ilePije;
	int ileJe;
	string typ = "swinia";
	Swinia(int w) : waga(w), ilePije(1), ileJe(0) {
		cout << "konstruktor: " << typ << "waga: " << waga << endl;
	}
	~Swinia() {
		cout << "destruktor" << endl;
	}
	void SprawdzWage() {
		cout << "Typ: " << typ << " waga: " << waga << endl;
	}
	void PijWode() {
		cout << "Typ: " << typ << " pije: " << ilePije << endl;
	}
	void JemWszystkoOproczSiana() {
		cout << "Typ: " << typ << " JemWszystkoOproczSiana." << endl;
	}
};

class Owca : public Ssak {
public:
	int waga;
	int ilePije;
	int ileJe;
	string typ = "owca";
	Owca(int w) : waga(w), ilePije(2), ileJe(40) {
		cout << "konstruktor: " << typ << "waga: " << waga << endl;
	}
	~Owca() {
		cout << "destruktor" << endl;
	}
	void SprawdzWage() {
		cout << "Typ: " << typ << " waga: " << waga << endl;
	}
	void PijWode() {
		cout << "Typ: " << typ << " pije: " << ilePije << endl;
	}
};

int main(void) {
	cout << "START" << endl;

	Ssak ssak;
	ssak.SprawdzWage();

	Krowa krowa(124);
	krowa.SprawdzWage();
	

	std::vector < Ssak > farma;
	farma.push_back(krowa);
	farma.push_back(krowa);
	farma.push_back(krowa);
	farma.push_back(krowa);

	for (size_t i = 0; i < farma.size(); i++)
		printf("%d, ", farma[i]);

	

	cout << "KONIEC" << endl;

	system("pause");

	return 0;
}