using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Token { }

    class TNumber : Token { }

    class TLiteral : TNumber {
        public TLiteral( double f ) => mValue = f;
        public override string ToString() => $"literal :{Value}";
        public double Value => mValue;
        readonly double mValue;
    }

    class TVariable : TNumber {
        public TVariable( string name ) => mName = name;
        public override string ToString() => $"var :{Name}";
        public string Name => mName;
        readonly string mName;
    }

    class TOperator : Token { }

    class TOpBinary : TOperator {
        public TOpBinary( char op ) => mOp = op;
        public override string ToString () => $"binary : {Op}";
        public char Op => mOp;
        readonly char mOp;
    }

    class TOpFunction : TOperator {
        public TOpFunction (string func) => mFunc = func;
        public override string ToString() => $"func : {Func}";

        public string Func => mFunc;
        readonly string mFunc;

    }

    class TPunctuation : Token { 
    public TPunctuation(char p) => mPunct =p;
        public override string ToString() => $"punctuation : {Punct}";
        public char Punct => mPunct;
        readonly char mPunct;
    }

    class TEnd : Token { }

    class TError : Token {
        public TError (string msg) => mMessage = msg;
        public override string ToString() => $"error : {Message}";
        public string Message => mMessage;
        readonly string mMessage;
    }

    
    }
