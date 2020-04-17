using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Editor
{
    public class CharacterDecorationInfo
    {
        public CharacterDecorationType DecorationType
        {
            get;
            set;
        }
        public Position Position
        {
            get;
            set;
        }
        public string UnicodeString
        {
            get;    //Only if DecorationType == CharacterDecorationType.Unicode
            set;
        }
        public int Index
        {
            get;    //Should be -1 when not appplicable or invalid
            set;
        }

        //public CharacterDecorationInfo(CharacterDecorationType decorationType, Position position)
        //{
        //    DecorationType = decorationType;
        //    Position = position;
        //    //Index = -1;
        //}

        //public CharacterDecorationInfo Clone()
        //{
        //    CharacterDecorationInfo cdi = new CharacterDecorationInfo(this.DecorationType, this.Position);
        //    //cdi.Index = this.Index;
        //    cdi.UnicodeString = this.UnicodeString;
        //    return cdi;
        //}
    }
}
