#include <stdio.h>

// 3차배열 출력
int main(void)
{
    int b[3][2][4] = {
        {{1,2,3,4},{5,6,7,8}},
        {{9,10,11,12},{13,14,15,16}},
        {{17,18,19,20},{21,22,23,24}}
    };


    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 4; k++)
                printf("b[%d][%d][%d] = %2d, addr = %p\n", i, j, k, b[i][j][k], &b[i][j][k]);
   return 0;
}

// b[0][0][0] =  1, addr = 0095F7D8
// b[0][0][1] =  2, addr = 0095F7DC
// b[0][0][2] =  3, addr = 0095F7E0
// b[0][0][3] =  4, addr = 0095F7E4
// b[0][1][0] =  5, addr = 0095F7E8
// b[0][1][1] =  6, addr = 0095F7EC
// b[0][1][2] =  7, addr = 0095F7F0
// b[0][1][3] =  8, addr = 0095F7F4
// b[1][0][0] =  9, addr = 0095F7F8
// b[1][0][1] = 10, addr = 0095F7FC
// b[1][0][2] = 11, addr = 0095F800
// b[1][0][3] = 12, addr = 0095F804
// b[1][1][0] = 13, addr = 0095F808
// b[1][1][1] = 14, addr = 0095F80C
// b[1][1][2] = 15, addr = 0095F810
// b[1][1][3] = 16, addr = 0095F814
// b[2][0][0] = 17, addr = 0095F818
// b[2][0][1] = 18, addr = 0095F81C
// b[2][0][2] = 19, addr = 0095F820
// b[2][0][3] = 20, addr = 0095F824
// b[2][1][0] = 21, addr = 0095F828
// b[2][1][1] = 22, addr = 0095F82C
// b[2][1][2] = 23, addr = 0095F830
// b[2][1][3] = 24, addr = 0095F834