using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class SLL
    {
        private Node head;

        public SLL()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }

        public void Add(int index, int data)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index must be non-negative.");

            if (index == 0)
            {
                AddFirst(data);
                return;
            }

            Node newNode = new Node(data);
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null)
                    throw new ArgumentOutOfRangeException("Index out of range.");
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
        }

        public void Replace(int index, int data)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index must be non-negative.");

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                    throw new ArgumentOutOfRangeException("Index out of range.");
                current = current.next;
            }
            current.data = data;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        public void RemoveLast()
        {
            if (head == null || head.next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
        }

        public void Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index must be non-negative.");

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null)
                    throw new ArgumentOutOfRangeException("Index out of range.");
                current = current.next;
            }
            if (current.next != null)
            {
                current.next = current.next.next;
            }
        }

        public int GetValue(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index must be non-negative.");

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                    throw new ArgumentOutOfRangeException("Index out of range.");
                current = current.next;
            }
            if (current != null)
            {
                return current.data;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
        }

        public override string ToString()
        {
            string result = "";
            Node current = head;
            while (current != null)
            {
                result += current.data + " ";
                current = current.next;
            }
            return result.Trim();
        }
    }
}
