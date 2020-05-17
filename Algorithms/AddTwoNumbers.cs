using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.*/
    class AddTwoNumber
    {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {

                ListNode current1 = l1; //copia a current1
                ListNode current2 = l2; // copia a current2

                ListNode firstNode = new ListNode(0); // crea otro nodo y lo inicializa en 0
                ListNode tempNode = firstNode; //copia a un nodo temporario.

                bool carry = false; // definicion del flag para saber si la suma es mayor 10.

                while ((current1 != null) && (current2 != null))
                { // correr hasta que los siguientes the ambas listas es nullas.

                    int resultado = tempNode.val + current1.val + current2.val; //sumo, el tempNode, es por si tiene el carry!
                    tempNode.val = resultado % 10; // guardo el resto de la division por 10

                    if (resultado >= 10) // se setea el carry por si la suma es mas grande que 9
                    {
                        carry = true;
                    }
                    else
                    {
                        carry = false;
                    }

                    bool l1next = false; // hago flags para checkiar si el next es NULL
                    bool l2next = false;

                    if (current1.next != null)
                    {
                        l1next = true;
                        current1 = current1.next; // si el que le sigue no es null, entonces 
                                                  // mueve el puntero al siguiente
                    }
                    else
                    {
                        current1 = new ListNode(0);// Si en esta lista ya esta vacia, tengo que crear
                                                   // nodos para sumar aunque sea 0 y no me joda el resto
                                                   // del programa.
                    }
                    //************************************

                    if (current2.next != null)
                    {
                        l2next = true;
                        current2 = current2.next; // si el que le sigue no es null, entonces 
                                                  // mueve el puntero al siguiente
                    }
                    else
                    {
                        current2 = new ListNode(0);// Si en esta lista ya esta vacia, tengo que crear
                                                   // nodos para sumar aunque sea 0 y no me joda el resto
                                                   // del programa.
                    }



                    if ((l1next == false) && (l2next == false))
                    {
                        current1 = null;
                        current2 = null; //si ambos no tienen next los nuevos que creo, los ponen en null
                                         //para poder salir del while.
                    }
                    else
                    {
                        tempNode.next = new ListNode(0);
                    }


                    if (carry)
                    {
                        tempNode.next = new ListNode(0); //si existe el carry, en el nuevo crea un nuevo nodo para sumar el 1!
                        tempNode.next.val++;
                    }
                    if (tempNode.next != null)
                    {
                        tempNode = tempNode.next; // mueve el puntero
                    }
                }
                return firstNode;
            }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }  
}
