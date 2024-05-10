using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Bai25Stack<T>
    {
        private List<T> elements = new List<T>();

        /// <summary>
        /// Adds an element to the top of the stack.
        /// </summary>
        /// <param name="element"></param>
        public void Push(T element)
        {
            elements.Add(element);
        }

        /// <summary>
        /// Removes and returns the element at the top of the stack.
        /// </summary>
        /// <returns>The element removed from the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
        public T Get()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T lastElement = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return lastElement;
        }

        /// <summary>
        /// Returns the element at the top of the stack without removing it.
        /// </summary>
        /// <returns>The element at the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return elements[elements.Count - 1];
        }

        /// <summary>
        /// Returns the number of elements in the stack.
        /// </summary>
        /// <returns>The number of elements in the stack.</returns>
        public int Count()
        {
            return elements.Count;
        }
    }
}
