using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Tokenizer
    {
        public Tokenizer(string input) {
            mText = input;
            mN= 0;
          }
        readonly string mText;
        int mN;
        public Token GetNext() {
            while(mN < mText.Length) { 
            char ch = mText[mN++];
                if ( ch == ' ' ) continue;
                if ( ch is '+' or '-' or '*' or '/' or '^' or '=') return new TOpBinary(ch);
                if ( ch is >= '0' and <= '9' ) return GetLiteral();
                if ( ch is '(' or ')' ) return new TPunctuation(ch);
                if ( ch is >= 'a' and <= 'z' ) return GetIdentifier();
                return new TError($"Unexpected character {ch}");
        }
            return new TEnd();
        }
        Token GetLiteral()
        {
            int start = mN-1;
            while (mN < mText.Length) {
                char ch = mText[mN++];
                if ( ch is (>= '0' and <= '9') or '.' ) continue;
                mN--; break;
            }
            string number = mText.Substring(start, mN - start  );
            double f = double.Parse (number);
            return new TLiteral (f);
        }
        Token GetIdentifier ()
        {
            int start =mN-1;
            while (mN < mText.Length) {
                char ch = mText[mN++];
                if ( ch is ( >= '0' and <= '9' ) or (>='a' and <='z') ) continue;
                mN--; break;
            }
            string identifier = mText.Substring (start, mN - start);
            if ( mFuncs.Contains(identifier) ) return new TOpFunction(identifier);
            else return new TVariable(identifier);
        }
        readonly string[] mFuncs = {"sin", "cos", "tan", "sqrt", "log", "exp", "asin", "acos", "atan"}
    }
}
