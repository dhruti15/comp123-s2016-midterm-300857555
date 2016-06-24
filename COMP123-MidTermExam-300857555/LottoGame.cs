using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * FileName: lottogame.cs
 *
 * @author Dhruti patel
 * @date June 24, 2016
 *
 * StudentID: 300857555
 *last modified :June 24, 2016
 *
 */
namespace COMP123_MidTermExam_300857555
{

    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     *
     * @class LottoGame
     * @property
    {int}
    ElementNum;
     * @property
    {int}
    SetSize;
     */
    public abstract class LottoGame
    {
        private List<int> _elementList;
        private List<int> _numberList;
        private int _elementNumber;
        private int _setSize;

        Random _random;

        public List<int> ElementList
        {
            get
            {
                return _elementList;
            }
        }

        public List<int> NumberList
        {
            get
            {
                return _numberList;
            }
        }

        public Random random
        {
            get
            {
                return _random;
            }
        }

        public int SetSize
        {
            get
            {
                return _setSize;
            }
            set
            {
                _setSize = value;
            }
        }

        public int ElementNumber
        {
            get
            {
                return _elementNumber;
            }
            set
            {
                _elementNumber = value;
            }
        }
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE private fields here --------------------------------------------

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        private void _initialize()
        {

            ElementList = new List<int>() { };
            NumberList = new List<int>() { };
            _random = new Random();
        }

        private void _build()
        {
            for (int i = 1; i <= ElementNumber;)
            {
                int rand = _random.Next(48) + 1;
                if (!NumberList.Contains(rand))
                {
                    i++;
                    NumberList.Add(rand);
                }
            }
        }
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------

        // CREATE the private _build method here -----------------------------------

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

        public void PickElements()
        {
            if (ElementList.Count > 0)
            {
                ElementList.Clear();
                NumberList.Clear();
                _build();
            }
            foreach (int x in NumberList)
            {
                ElementList.Add(x);
                NumberList.Remove(x);
            }
            ElementList.Sort();
        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
    }
}

