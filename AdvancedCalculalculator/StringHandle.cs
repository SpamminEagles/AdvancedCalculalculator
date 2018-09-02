using System;
using System.Collections.Generic;

namespace AdvancedCalculator
{

    public partial class StringHandle
    {
        public StringHandle()
        {
        }

        public static int QuickLaunch(string input)
        {
            StringHandle sh = new StringHandle();
            input = sh.Correct(input);
            sh.Validate(input);

            string[] A = sh.ReduceExpressions(sh.Partition(input));
            
            return 0;   //To be removed
        }

        public string[] ReduceExpressions(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 2)
                {
                    input[i] = "e" + QuickLaunch(input[i].Substring(1));
                }
            }

            return input;
        }

        //Correcting all it can / should
        public string Correct(string par)
        {
            List<char> ret = new List<char>();
            par = Normalize(par);

            for (int i = 0; i < par.Length; i++)
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
                if (i < par.Length - 1 && par[i + 1] == '(' && GetElementType(par[i]) == ElementType.Number)
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

        //Partition up!

        public string[] Partition(string param)
        {
            List<string> ret = new List<string>();

            string current = "";
            ElementType CurrentElementsType = ElementType.None;
            ElementType LastElementsType = ElementType.None;
            int parantheses = 0;

            //First element handled separately
            LastElementsType = ElementType.None;

            for (int i = 0; i < param.Length; i++)
            {
                //Set the type of this element - economic
                CurrentElementsType = parantheses == 0 ? GetElementType(param[i]) : ElementType.Parantheses;

                //If it is an operator we can just add it
                if (CurrentElementsType == ElementType.Operator)
                {
                    if (LastElementsType != ElementType.None)
                    {
                        ret.Add(current);
                    }
                    current = "o" + param[i];

                    LastElementsType = ElementType.Operator;
                
                }else if(CurrentElementsType == ElementType.Number)
                {

                    //If this is the beginning of a new part, we should prepare the space for it
                    if (LastElementsType != ElementType.Number)
                    {
                        if (LastElementsType != ElementType.None)
                        {
                            ret.Add(current);
                        }
                        
                        current = "e";
                    }

                    current += param[i];

                    LastElementsType = ElementType.Number;

                }else if (CurrentElementsType == ElementType.Parantheses)
                {
                    if (LastElementsType != ElementType.Parantheses)
                    {
                        ret.Add(current);
                        current = "";
                    }

                    parantheses = param[i] == '(' ? parantheses + 1 : (param[i] == ')' ? parantheses - 1 : parantheses);

                    if (parantheses == 0)
                    {
                        Print("Done");
                        current = "e" + current.Substring(1);
                    }
                    else
                    {
                        current += param[i];
                    }

                    LastElementsType = ElementType.Parantheses;
                }           
            }

            ret.Add(current);

            return ret.ToArray();
        }

        public ElementType GetElementType(char element)
        {
            if (ArrayLib.Contains(OPERATORS, element))
            {
                return ElementType.Operator;
            }else if (ArrayLib.Contains(NUMBERS, element))
            {
                return ElementType.Number;
            }else if(ArrayLib.Contains(PARANTHESES, element))
            {
                return ElementType.Parantheses;
            }
            else
            {
                return ElementType.None;
            }
        }

        char GetPrefix(ElementType param)
        {
            if (param == ElementType.Operator)
            {
                return 'o';
            }
            else
            {
                return 'e';
            }
        }

        //Checking for errors

        public bool Validate(string param)
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


        //For my debugging convinience
        void Print<T>(T o)
        {
            Console.WriteLine(o.ToString());
        }

        void Print<T>(params T[] o)
        {
            string output = "";
            foreach (object i in o)
            {
                output += o.ToString() + " ";
            }
            Console.WriteLine(output.Substring(0, output.Length - 2));
        }
    }
}
