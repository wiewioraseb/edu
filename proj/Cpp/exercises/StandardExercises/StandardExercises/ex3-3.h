#pragma once
#include <iostream>
#include <string>
void ex3_3();

class Gryzon
{
public:
	Gryzon() {
		imie = "Jakis_gryzon";
		energia = 88;
		std::cout << "KONSTRUTOR " << imie << std::endl;

	}
	Gryzon(std::string i, int e) {
		imie = i;
		energia = e;
	}
	Gryzon(Gryzon& k) {
		std::cout << "KONSTRUTOR kopiujacy" << std::endl;
	}
	virtual ~Gryzon() {
		std::cout << "DESTRUKTOR Gryzon" << std::endl;
	}
	virtual void sound() {
		std::cout << "Sound Gryzon" << std::endl;
	}
	virtual std::string getTyp() {
		return typ;
	}
private:
	std::string imie;
	int energia;
	std::string typ = "gryzon";

};

class Gryzon;

class Mysz : public Gryzon
{
public:
	Mysz() {
		imie = "Mickey";
		energia = 88;
		std::cout << "KONSTRUTOR " << imie << std::endl;

	}
	Mysz(std::string i, int e) {
		imie = i;
		energia = e;
	}
	Mysz(Mysz& k) {
		std::cout << "KONSTRUTOR kopiujacy" << std::endl;
	}
	~Mysz() {
		std::cout << "DESTRUKTOR mysz" << std::endl;
	}
	void sound() {
		std::cout << "Sound Mysz" << std::endl;
	}
	std::string getTyp() {
		return typ;
	}

private:
	std::string imie;
	int energia;
	std::string typ = "mysz";

};


class Szczur : public Gryzon
{
public:
	Szczur(): Gryzon() {
		imie = "Szczurek";
		energia = 88;
		std::cout << "KONSTRUTOR " << imie << std::endl;

	}
	Szczur(std::string i, int e) {
		imie = i;
		energia = e;
	}
	Szczur(Szczur& k) {
		std::cout << "KONSTRUTOR kopiujacy" << std::endl;
	}
	~Szczur() {
		std::cout << "DESTRUKTOR Szczur" << std::endl;
	}
	void sound() {
		std::cout << "Sound Szczur" << std::endl;
	}
	std::string getTyp() {
		return typ;
	}

private:
	std::string imie;
	int energia;
	std::string typ = "szczur";

};
