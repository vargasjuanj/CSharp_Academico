using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para realizar la evaluación de funciones o expresiones (no es una calculadora, porque tal es binaria) se utilizó el algoritmo polaco inverso (Expresión infija a postfija)
namespace CalcMix
{
    class Evaluador
    {



        public static double evaluar(string infi)
        {

            //if (infi[0] != '(' && infi[infi.Length - 1] != ')')
            //{
                infi = "(" + infi + ")";
            //}
            string aux = infi.Replace("(", "");
            IList<string> infija = aceptarDecimales(infi);
            IList<string> postfija = convertir(infija, aux);
            mostrarLista(postfija);
            return evaluarPostfija(postfija);
        }

        private static IList<string> convertir(IList<string> infija, string aux)
        {
            bool neg = false, key = true, valor = false;
            IList<string> postfija = new List<string>();
            Pila pila = new Pila(100);
            int cont = -1;
            foreach (string letra in infija)
            {
                cont++;

                if (aux[0] == '-' && key)
                {
                    neg = true;
                    key = false;

                }
                if (cont == 1 && letra.Equals("-"))
                {
                    neg = true;
                    continue;

                }
                if (!pila.estaVacia() && (pila.elementoTope().Equals("/") || pila.elementoTope().Equals("*")) && letra.Equals("-") && valor == false)
                {
                    neg = true;

                }
                else if (esOperador(letra))
                {
                    if (letra.Equals("*") || letra.Equals("/"))
                    {
                        valor = false;
                    }
                    if (pila.estaVacia())
                    {
                        pila.apilar(letra);
                    }
                    else if (letra.Equals("("))
                    {
                        pila.apilar(letra);
                    }
                    else if (pila.elementoTope().Equals("(") && !letra.Equals(")"))
                    {
                        pila.apilar(letra);
                    }
                    else if (letra.Equals(")"))
                    {
                        while (!pila.elementoTope().Equals("("))
                        {
                            postfija.Add((string)pila.desapilar());
                        }
                        pila.desapilar(); //termina desapilando el "(";, según el algoritmo
                    }
                    else
                    {
                        int pe = prioridadEnExpresion(letra); //prioridad en la expresion
                        int pp = prioridadEnPila((string)pila.elementoTope()); //prioridad en la pila
                        if (pe > pp)
                        {
                            pila.apilar(letra);
                        }
                        else
                        {

                            while (true)
                            {
                                postfija.Add((string)pila.desapilar());
                                if (pila.estaVacia())
                                {
                                    pila.apilar(letra);
                                    break;
                                }
                                if (pila.elementoTope().Equals("("))
                                {
                                    pila.apilar(letra);
                                    break;
                                }
                                if (pe > pp)
                                {
                                    pila.apilar(letra);
                                    break;
                                }
                                pp = prioridadEnPila((string)pila.elementoTope());
                            }
                        }
                    }
                }
                else
                {
                    if (neg)
                    {
                        string temp = "-" + letra;
                        //letra = "-" + letra;
                        postfija.Add(temp);

                    }
                    else
                    {
                        postfija.Add(letra);
                    }
                    neg = false;
                    valor = true;
                }
            }
            while (!pila.estaVacia() && !pila.elementoTope().Equals("("))
            {
                postfija.Add((string)pila.desapilar());
            }
            return postfija;
        }


        public static double evaluarPostfija(IList<string> postfija)
        { //en principio se hace sin parentesis, despues de probarlo se meten las condiciones d elos parentesis
            Pila pila = new Pila(5);
            string aux = "";
            foreach (string letra in postfija)
            {

                if (!esOperador(letra))
                {

                    if (!letra.Contains("-"))
                    {
                        double num = double.Parse(letra);
                        pila.apilar(num);

                    }
                    else
                    { //en el caso de que haya un / o * seguido de un -

                        aux = letra.Substring(1, letra.Length - 1);
                        double num = -double.Parse(aux);
                        pila.apilar(num);

                    }
                }
                else
                {
                    double num2 = (double)pila.desapilar(); // //primero se desapila el numero 2
                    double num1 = 0f;
                    //el siguiente try-catch resuelve un gran problema como las siguientes expresiones  //(-7)   -(-7) (-(-(-(-7-2))))
                    try
                    {
                        num1 = (double)pila.desapilar();
                    }
                    catch (Exception)
                    {
                        num1 = 0;
                    }
                    double num3 = operacion(letra, num1, num2);
                    pila.apilar(num3);
                }
            }
            return (double)pila.elementoTope();
        }
        public static IList<string> aceptarDecimales(string infija)
        {
            bool key = false;
            IList<string> inf = new List<String>();
            IList<string> res = new List<String>();
            string temp = "";
            char token = ' ';
            for (int i = 0; i < infija.Length; i++)
            {

                token = infija[i];

                if (token == '+' || token == '-' || token == '/' || token == '*' || token == '^' || token == '(' || token == ')')
                {
                    if (key)
                    {
                        res.Add(temp);
                        temp = "";
                        key = false;
                    }
                    res.Add(token.ToString());
                }
                else
                {
                    key = true;
                    temp += token;
                }
                /*
                if (i == infija.length() - 1 && !temp.equals("")) {
                    res.add(temp); //mete el último elemento si llegase a ser un operando, pero si al string lo completo siempre con los dos parentesis, esta expresión no haria falta, porque no queda un operando suelto
                }
                 */
            }
            return res;
        }
        public static void mostrarLista(IList<string> lista)
        {
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public static bool esOperador(string letra)
        {
            if (letra.Equals("+") || letra.Equals("-") || letra.Equals("/") || letra.Equals("*") || letra.Equals("(") || letra.Equals(")") || letra.Equals("^"))
            {
                return true;
            }
            return false;
        }
        public static int prioridadEnExpresion(string operador)
        {
            if (operador.Equals("^"))
            {
                return 4;
            }
            if (operador.Equals("*") || operador.Equals("/"))
            {
                return 2;
            }
            if (operador.Equals("+") || operador.Equals("-"))
            {
                return 1;
            }
            if (operador.Equals("("))
            {
                return 5;
            }
            return 0; //si no era ninguna devuelvo cero cero

        }
        public static int prioridadEnPila(string operador)
        {
            if (operador.Equals("^"))
            {
                return 3;
            }
            if (operador.Equals("*") || operador.Equals("/"))
            {
                return 2;
            }
            if (operador.Equals("+") || operador.Equals("-"))
            {
                return 1;
            }
            if (operador.Equals("("))
            {
                return 0;
            }
            return 0; //si no era ninguna devuelvo cero cero

        }
        public static double operacion(string letra, double num1, double num2)
        {
            if (letra.Equals("*"))
            {
                return num1 * num2;
            }
            if (letra.Equals("/"))
            {
                return num1 / num2;
            }
            if (letra.Equals("+"))
            {
                return num1 + num2;
            }
            if (letra.Equals("-"))
            {
                return num1 - num2;
            }
            if (letra.Equals("^"))
            {
                return Math.Pow(num1, num2);
            }
            return 0;
        }
       
    }
       
}
