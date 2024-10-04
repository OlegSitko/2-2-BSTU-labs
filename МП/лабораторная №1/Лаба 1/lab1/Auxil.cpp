#include "Auxil.h"
#include <ctime>
namespace auxil
{
    void start()
    {
        srand((unsigned)time(NULL));
    };
    double  dget(
        double rmin,   // [in] ����������� ��������   
        double rmax    // [in] ������������ ��������
    )
    {
        return ((double)rand() / (double)RAND_MAX) * (rmax - rmin) + rmin;
    }
    int  iget(
        int rmin,       // [in] ����������� ��������   
        int rmax        // [in] ������������ ��������
    )
    {
        return(int)dget((double)rmin, (double)rmax);
    }
}
