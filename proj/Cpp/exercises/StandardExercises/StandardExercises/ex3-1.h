#pragma once
#include <string>
void ex3_1();

class Pies 
{
public:
	Pies() {
		imie = "Burek";
		energia = 30;
	}
	Pies(std::string imie, int energia);
	Pies(Pies&);
	~Pies();
	void Spaceruj(int);
private:
	std::string imie;
	int energia;
};