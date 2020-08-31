using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class BinarySearchTree
    {
        public Node RootNode;

        // 10, 20
        public void Add(Node nodeToAdd)
        {
          
            Node currentNode;

            if (RootNode == null)
            {
                RootNode = nodeToAdd;
                
                //LastNode = RootNode;
            }
            else
            {
                //LastNode.NextNode = nodeToAdd;
                //LastNode = LastNode.NextNode;
                currentNode = nodeToAdd;
                bool found = false;
                while (!found)
                {
                    if (currentNode.Data >= RootNode.Data)
                    {
                        currentNode = RootNode;
                        while (!found)
                        {
                            if (currentNode.RightNode == null)
                            {
                                currentNode.RightNode = nodeToAdd;
                                found = true;
                            }
                            else
                            {
                                currentNode = currentNode.RightNode;
                            }
                        }                     
                    }
                    else if (currentNode.Data < RootNode.Data)
                    {
                        currentNode = RootNode;
                        while (!found)
                        {
                            if (currentNode.LeftNode == null)
                            {
                                currentNode.LeftNode = nodeToAdd;
                                found = true;
                            }
                            else
                            {
                                currentNode = currentNode.LeftNode;
                            }
                        }
                    }
                }
            }
        }
        public void Search(Node nodeToFind)
        {
             
        }
    }
}
