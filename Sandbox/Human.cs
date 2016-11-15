using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Human
    {
        public enum maleOrFemale {male, female };
        public enum eyeColor {brow, blue, green };
        public enum hairColor {black, blond, red, brown };
        public enum heightCategory {Short, Normal, Tall, VeryTall };

        private maleOrFemale _gender;
        private eyeColor _eyeColor;
        private hairColor _hairColor;
        private heightCategory _height;

        public Human(maleOrFemale gender, eyeColor eyecolor, hairColor haircolor, heightCategory heightCategory)
        {
            _gender = gender;
            _eyeColor = eyecolor;
            _hairColor = haircolor;
            _height = heightCategory;
        }

        public String GetDescription()
        {
            String description = "You got a " + _gender;
            description = description + ", with " + _eyeColor + " eyes";
            description = description + ", " + _hairColor + " hair";
            description = description + ", who is " + _height + " height";

            return description;
        }

        //public String GetGenderDescription()
        //{
        //    if (maleOrFemale)
        //    {
        //        return "man";
        //    }
        //    else
        //    {
        //        return "woman";
        //    }
        //}

        //public String GetHeightDescription()
        //{
        //    switch (heightCategory)
        //    {
        //        case 0:
        //            return "Very short";
        //        case 1:
        //            return "Short";
        //        case 2:
        //            return "Medium height";
        //        case 3:
        //            return "Tall";
        //        case 4:
        //            return "Very tall";
        //        default:
        //            return "Unknown height";
        //    }
        
    }
}
