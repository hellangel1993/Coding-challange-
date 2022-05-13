﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class Scaler_Codes
    {
        static void Main(string[] args)
        {
            Scaler_Codes sc = new Scaler_Codes();
            //sc.Minimum_Distance("X......O.....X.....X");
            //sc.Minimum_Distance("o.........................xx.................o...o.o....................................................................................................o.................o.......o................o.o.........o.........................o...........o....................x...................x...............x.....................x.........o..........................................................................o......o...............................x...........................o......................o.......o........................x...........o.....................o....................o.........o...................................................x.....................x.................................................................................................o.o.........................................o........o.......o......................o.....................................................................x...........................................................................x.........................................................x.......o...........................x.............................o..............x......x..........................................................................................................o.................x................................................................................................................x....................o...........................................................o............................x..............................o....oo....................................................x...............x................................................x...x...................o...............................o.......................o................o......................x..........................................o....o............................o..........x...............x...............x...............................o.o........o...o........o............................................................x......................................................x..........................................................................x.....x...........................x.........................x......................x...............................x.............................................x...........x.........x................................x................x............x....x...............................o.....o...............x.................................x...............................o.....o.o..............................................................................................o.....o..............................x....................................................o...............................................................................x............x................................o.....................o........................................o.................................................................o..................o.................oo..................o............o...........................................x..................x.........x.....x.....xx......x......................................................x..........................................................x.....xx.....................o...........................o.............x......x...........x..x..........................................x.........x...........................o.......................................o..............................................................................x..........x......................................x.................x.........................................................x.............................................................................................................................................x....oo..................................................o.......................................................................................................o................................o.o.........x.....x...............o.....o..........o.................................................o.......o.....................................................................................x........x.................................x.............x........x...........x.............x.................x................x.......................................................x..x.........................o............................................................................................................................................................o.......o....................................o......................o...............................................o.......................................................................o.....o.....................................................x.x....x.....................................................................................................................................x................................................o..........................x............................................o.....................................x....................o..............................o......o.o.....o.......x.................x..............................................x.........................................................................................................o.............................................................o................................o....................x................................o...................oo...........................x...................x.........................................o.................................................................x.....................x...................o...................x.......................................o...............o.....................o.....o....................o............o.................................................................................o.....x..................................................................................................................o.......................................................................................o.......................................................x.............................o....o............................................................x.........................................................................................o.........................................x..........................................................................xx................................x...........................o.o.........................o...........................................................xx.................................o................o.........................................................................................................x...........o..................x............................................................o............o..............................................o...................................o..o.......................................................o............................o........o.o.......o....................o........x............................................................................................o..................o...........................x................................................................x..................................................x.............................................................................................o.o.............o...............o.............................................o..o................o....................................................x...................................o................o.................o..........................x.x..x......................................................................................................................o.......................................................................................................................................................................................................x...........................................................xx..........o............o...............................o..........x...................o........................................x................................................................x...................x......................................o................................................................o.........................................x...................x..............................................x.x...x....x................................x.....................................................o.......................................................................x........o................................o..o....................................................................................x.....................................................x.....................o..................o............................................o...............o.........o...............................................o...............................x........................o.......o..............................oo..o........o..oo...........................................................o..........................o................o...............................................x.....x.......................................................x...x..x........................................o.........................x...................x..............................................................o................o.......o.............x................x........................................o.........x......................o...............................................o.......................x..................x.............................x......x.....................o..........x....x..................x...................................................x..................................................o........................................");
            int a = sc.MinimumPick(new List<int> { 74, 9, 51, 51, 75, 0, 35, 89, 96, 77 });
        }

        #region Minimum distance
        public int Minimum_Distance(string A)
        {

            char detected = '0';
            char lookingFor = '0';
            bool checking = false;
            int start = 0, end = 0;
            int res = 100000;
            for (int i = 0; i < A.Length; i++)
            {
                char temp = A[i];
                if (temp == 'x' || temp == 'o')
                {
                    if (checking == false)
                    {
                        if (temp == 'x')
                        {
                            detected = temp;
                            lookingFor = 'o';
                            checking = true;
                        }
                        else
                        {
                            detected = temp;
                            lookingFor = 'x';
                            checking = true;
                        }
                        start = i;
                    }
                    else
                    {
                        if (temp == detected)
                        {
                            start = i;
                        }
                        else
                        {
                            if (temp == lookingFor)
                            {
                                int tempRes = ((start - i) < 0) ? ((start - i) * -1) : (start - i);
                                if (tempRes < res)
                                {
                                    res = tempRes;
                                }
                                start = i;
                                char interTemp = detected;
                                detected = lookingFor;
                                lookingFor = interTemp;
                            }
                        }
                    }
                }
            }

            if (res== 100000)
            {
                return -1;
            }
            return res;
        }
        #endregion

        #region Minimum pick
        public int MinimumPick(List<int> A)
        {
            int even = -100000;
            int ee = 0 % 2;
            int odd = 100000;
            for (int i = 0; i < A.Count; i++)
            {
                int temp = A[i];
                if (temp % 2 == 0 && temp > even)
                {
                    even = temp;
                }
                else if (temp % 2 != 0 && temp < odd)
                {
                    odd = temp;
                }
            }

            return (even - odd);
        }
        #endregion
    }
}