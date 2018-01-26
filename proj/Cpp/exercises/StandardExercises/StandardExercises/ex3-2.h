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
private:
	std::string imie;
	int energia;
};