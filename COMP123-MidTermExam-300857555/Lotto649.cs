using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * FileName: lotto649.cs
 *
 * @author Dhruti patel
 * @date June 24, 2016
 *
 * StudentID: 300857555
 *last modified :June 24, 2016
 *
 */


namespace COMP123_MidTermExam_300857555
{ /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lotto649
     */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        public void GenerateLottoNumbers()
        {
            LottoGame lg = new Lotto649();
            for (int i = 1; i <= 6; i++)
            {
                lg.PickElements();
                lg.ToString();
            }

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
    }
}
