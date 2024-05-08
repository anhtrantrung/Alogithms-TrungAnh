using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai24Queu<T>
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
        /// Retrieves and removes the element at the front of the queue.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
        public T Get()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T firstElement = elements[0];
            elements.RemoveAt(0);
            return firstElement;
        }

        /// <summary>
        /// Retrieves the element at the front of the queue without removing it.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return elements[0];
        }

        /// <summary>
        /// Returns the number of elements in the queue.
        /// </summary>
        /// <returns>The number of elements in the queue.</returns>
        public int Count()
        {
            return elements.Count;
        }
    }
}
