using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {

        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            if (list.Count < 2) return list;

            bool changed = true;
            while (changed) 
            {
                changed = false;
                var node = list.First;
                bool reachedEnd = false;

                while (reachedEnd == false)
                {
                    if (node.Next == null)
                    {
                        reachedEnd = true;
                    }
                    else
                    {
                        if (node.Value < node.Next.Value)
                        {
                            int temp = node.Value;
                            node.Value = node.Next.Value;
                            node.Next.Value = temp;
                            changed = true;
                        }
                        node = node.Next;
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            if (list.Count < 2) return list;

            bool changed = true;
            while (changed)
            {
                changed = false;
                var node = list.First;
                bool reachedEnd = false;

                while (reachedEnd == false)
                {
                    if (node.Next == null)
                    {
                        reachedEnd = true;
                    }
                    else
                    {
                        if (node.Value > node.Next.Value)
                        {
                            int temp = node.Value;
                            node.Value = node.Next.Value;
                            node.Next.Value = temp;
                            changed = true;
                        }
                        node = node.Next;
                    }
                }
            }

            return list;
        }
    }
}
