using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class MainClass
    {
        static void Main(string[] args)
        {
        }
    }
        public class Tree<TItem> where TItem : IComparable<TItem>
        {
            public TItem NodeData { get; set; }
            public Tree<TItem> LeftTree { get; set; }
            public Tree<TItem> RightTree { get; set; }

            public Tree(TItem nodeValue)
            {
                this.NodeData = nodeValue;
                this.LeftTree = null;
                this.RightTree = null;
            }

            public void Insert(TItem newItem)
            {
                TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    LeftTree.Insert(newItem);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    RightTree.Insert(newItem);
                }
            }
            }

            public void WalkThroughTree()
            {
                if (this.LeftTree != null)
                {
                    this.LeftTree.WalkThroughTree();
                }

                Console.WriteLine(this.NodeData.ToString());

                if (this.RightTree != null)
                {
                    this.RightTree.WalkThroughTree();
                }

                

            }
        }


    }




