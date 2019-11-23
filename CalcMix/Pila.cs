using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMix
{
    class Pila
    {
        private int n; //tamaño máximo del que podemos apilar
        private int tope; //nos va a decir cuantos elementos tenemos apilados
        private object[] pila; //pila, arreglo

        public Pila(int n)
        {
            this.n = n; //cuando construyalmos la pila, le vamos a decir de que tamaño la queremos
            tope = 0;
            pila = new object[n]; //Es object para poder apilar cualquier tipo de cosa números caracteres,etc.

        }
        public virtual bool estaVacia()
        {
            return tope == 0; //devuelve true si el tope es cero, asumisms que no hay nada porque la pila esta vacia
        }

        public virtual bool estaLlena()
        {
            return tope == n;
        }
        public virtual bool apilar(object dato)
        {
            if (estaLlena())
            {
                return false;
            }
            pila[tope] = dato;
            tope++;
            return true;

        }
        public virtual object desapilar()
        {
            if (estaVacia())
            {
                return null;
            }
            tope--;
            return pila[tope];
        }
        public virtual object elementoTope()
        {
            //nos muestra quien esta en el tope, no lo saca.
            return pila[tope - 1]; // se pone tope-1 por que siempre queda una posicion arriba del ultimo elemento


        }
    }
}
