﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistTest
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node(string value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node head;
        private int count;

        public int Count { get { return count; } }
        public Node Head { get { return head; } }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void AddLast(string value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
                count--;
            }
        }

        public void RemoveLast()
        {
            if (head != null)
            {
                if (head.Next == null)
                {
                    head = null;
                }
                else
                {
                    Node current = head;
                    while (current.Next.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                }
                count--;
            }
        }

        public string GetValue(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }
}

