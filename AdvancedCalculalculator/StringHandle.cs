using System;
using System.Collections.Generic;

namespace AdvancedCalculator
{

    public partial class StringHandle
    {
        public StringHandle()
        {
        }

        //Correcting all it can / should
        public string Correct(string par)
        {
            List<char> ret = new List<char>();
            par = Normalize(par);

            for(int i = 0; i < par.Length; i++)
            {
                if (ArrayLib.Contains(NUMBERS, par[i]))
                {
                    ret.Add(par[i]);
                } else if (ArrayLib.Contains(OPERATORS, par[i]))
                {
                    ret.Add(par[i]);
                } else if (ArrayLib.Contains(PARANTHESES, par[i]))
                {
                    ret.Add(par[i]);
                }
            }

            par = new string(ret.ToArray());
            par = AddParanthesesMultiplicator(par);
            return par;
        }

        string AddParanthesesMultiplicator(string par)
        {
            List<char> ret = new List<char>();

            //Check if the next haracter is a(n) 'c' - and check if we won't exceed the index
            for (int i = 0; i < par.Length; i++)
            {
                ret.Add(par[i]);
                if (i < par.Length - 1 && par[i + 1] == '(')
                {
                    ret.Add('x');
                }
            }

            return new string(ret.ToArray());
        }

        public string Normalize(string param)
        {
            param = param.ToLower();
            param = param.Replace(" ", "");
            return param;
        }

        //Checking for errors

        bool Validate(string param)
        {
            if (!(ArrayLib.Count(param.ToCharArray(), '(') == ArrayLib.Count(param.ToCharArray(), ')')))
            {
                Prog.ThrowError(1);
                return false;
            }
            for (int i = 0; i < param.Length; i++)
            {
                if (ArrayLib.Contains(OPERATORS, param[i]) && ArrayLib.Contains(OPERATORS, param[i + 1]))
                {
                    Prog.ThrowError(0);
                    return false;
                }
            }
            return true;
        }
    }
}
