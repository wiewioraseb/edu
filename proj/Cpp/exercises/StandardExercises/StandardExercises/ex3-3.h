#pragma once
#include <string>
void ex3_3();

class Gryzon
{
public:
	Gryzon() {
		imie = "Jakis_gryzon";
		energia = 88;
	}
	Gryzon(std::string i, int e) {
		imie = i;
		energia = e;
	}
	Gryzon(Gryzon& k) {
		cout << "KONSTRUTOR kopiujacy" << endl;
	}
	virtual ~Gryzon() {
		cout << "DESTRUKTOR Gryzon" << endl;
	}
	void sound() {
		cout << "Sound Gryzon" << endl;
	}

private:
	std::string imie;
	int energia;
	std::string typ = "gryzon";

};

class Mysz : public Gryzon
{
public:
	Mysz() {
		imie = "Mickey";
		energia = 88;
	}
	Mysz(std::string i, int e) {
		imie = i;
		energia = e;
	}
	Mysz(Mysz& k) {
		cout << "KONSTRUTOR kopiujacy" << endl;
	}
	~Mysz() {
		cout << "DESTRUKTOR mysz" << endl;
	}
	void sound() {
		cout << "Sound Mysz" << endl;
	}

private:
	std::string imie;
	int energia;
	std::string typ = "mysz";

};


class Szczur : public Gryzon
{
public:
	Szczur() {
		imie = "Szczurek";
		energia = 88;
	}
	Szczur(std::string i, int e) {
		imie = i;
		energia = e;
	}
	Szczur(Szczur& k) {
		cout << "KONSTRUTOR kopiujacy" << endl;
	}
	~Szczur() {
		cout << "DESTRUKTOR Szczur" << endl;
	}
	void sound() {
		cout << "Sound Szczur" << endl;
	}

private:
	std::string imie;
	int energia;
	std::string typ = "szczur";

};
