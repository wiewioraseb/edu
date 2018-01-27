#pragma warning(suppress : 4996)
#include <iostream>


using namespace std;

class DString;



class DString {
public:
	char* sp;
	DString() {
		sp = new char;
		*sp = 'h';
	}
	DString(const DString & dstring) {
		sp = new char;
		*sp = *dstring.sp;
	}
	~DString() {
		delete[] sp;
		*sp = 0;
		cout << "destruktor" << endl;
	}
	DString& operator=(const DString& dstring) {
		if (this == &dstring)
			return *this;
		return *this;
	}
	
	DString& operator+=(const DString& dstring)
	{
		int i = 0;

		i += strlen(sp);
		i += strlen(dstring.sp);
		char * p_str = new char[i + 1];
		strcpy(p_str, sp);
		strcat(p_str, dstring.sp);

		int j = 0;
		char * p_tmp = dstring.sp;
		while (*p_tmp++)
		{
			j++;
		}

		delete[] sp;
		sp = new char[j + 1];

		for (; j >= 0; j--)
		{
			sp[j] = dstring.sp[j];
		}


		delete[] p_str;
		return *this;
	}
	
	friend ostream& operator<<(ostream& output, DString& dstring)
	{
		output << dstring.sp;
		return output;
	}
};

int main(void) {
	cout << "START" << endl;

	DString s1;
	cout << "obiekt s1:"<< s1.sp << endl;

	DString *s2 = new DString();
	cout << "obiekt s2:" << (*s2).sp << endl;

	DString *s3 = new DString(s1);
	cout << "obiekt s3:" << s3->sp << endl;

	DString s4;
	s4 = s1;
	cout << "obiekt s4:" << s4.sp << endl;

	DString s5;
	s5 += s1;
	cout << "obiekt s5:" << s4.sp << endl;

	cout << "Funkcja zaprzyjazniona: " << s2 << endl;


	delete s2;
	delete s3;


	cout << "KONIEC" << endl;

	system("pause");

	return 0;
}