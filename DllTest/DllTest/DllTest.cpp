#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "DllTest.h"

// DLL internal state variables:
static unsigned long long previous_;  // Previous value, if any
static unsigned long long current_;   // Current sequence value
static unsigned index_;               // Current seq. position

int summ(int a, int b) {
	return a + b;
}

bool equeals(int a, int b)
{
	return a == b;
}


const char* getString()
{
	const char* str = "Привет";
	return str;
}

const char* getStringP()
{
	return "Bye bye!";
}

std::string getStringS()
{
	std::string s = "Это строка 2 Nina";
	return s;
}