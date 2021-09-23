#pragma once

#include <string>

#ifdef DLLTEST_EXPORTS
#define DLLTEST_API __declspec(dllexport)
#else
#define DLLTEST_API __declspec(dllimport)
#endif

extern "C" DLLTEST_API int summ(int, int);

extern "C" DLLTEST_API bool equeals(int, int);

extern "C" DLLTEST_API const char* getString();
extern "C" DLLTEST_API const char* getStringP();

extern "C" DLLTEST_API std::string getStringS();