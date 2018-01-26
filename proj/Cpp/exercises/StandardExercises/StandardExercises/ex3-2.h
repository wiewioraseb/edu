#pragma once
#include <string>
void ex3_2();

class Kot
{
public:
	Kot() {
		imie = "Bonifacy";
		energia = 30;
	}
	Kot(std::string imie, int energia);
	Kot(Kot&);
	~Kot();
	void Spaceruj(int);
	void Spaceruj(double);
	/*
	Kot operator+(const Kot& k) {
		Kot kot;
		kot.energia = this->energia + k.energia;

		return kot;
	}
	*/
	friend std::ostream & operator<<(std::ostream & out, Kot & os);
private:
	std::string imie;
	int energia;
};