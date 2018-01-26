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
	
	const Kot operator ++(int)
	{
		//Kot temp(*this);
		Kot temp;
		energia = energia + 1;
		return temp;
	}
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