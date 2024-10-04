#include "Auxil.h"
#include <ctime>
namespace auxil
{
    void start()
    {
        srand((unsigned)time(NULL));
    };
    double  dget(
        double rmin,   // [in] минимальное значение   
        double rmax    // [in] максимальное значение
    )
    {
        return ((double)rand() / (double)RAND_MAX) * (rmax - rmin) + rmin;
    }
    int  iget(
        int rmin,       // [in] минимальное значение   
        int rmax        // [in] максимальное значение
    )
    {
        return(int)dget((double)rmin, (double)rmax);
    }
}
