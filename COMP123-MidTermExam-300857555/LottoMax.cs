using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * FileName: lottomax.cs
 *
 * @author Dhruti patel
 * @date June 24, 2016
 *
 * StudentID: 300857555
 *last modified :June 24, 2016
 *
 */
namespace COMP123_MidTermExam_300857555
{/**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        public void GenerateLottoNumbers()
        {
            LottoGame lg = new LottoMax();
            for (int i = 1; i <= 7; i++)
            {
                lg.PickElements();
                lg.ToString();
            }
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
    }
}