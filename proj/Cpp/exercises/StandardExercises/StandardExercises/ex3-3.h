#pragma once
#include <string>
void ex3_3();

class Mysz
{
public:
	Mysz() {
		imie = "Mickey";
		energia = 88;
	}
	Mysz(std::string i, int e);
	Mysz(Mysz& k);
	~Mysz();
private:
	std::string imie;
	int energia;
};