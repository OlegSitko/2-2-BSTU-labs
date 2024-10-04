#include "Fibonachi.h"
#include <iostream>


unsigned long long fibonachi(int n)
{
	if (n == 0)
		return 0;
	if (n == 1)
		return 1;
	return fibonachi(n - 1) + fibonachi(n - 2);
}
