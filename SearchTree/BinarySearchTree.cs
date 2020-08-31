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
        public bool Search(int findValue)
        {
            Node currentNode;
            if(findValue == RootNode.Data)
            {
                return true;
            }
            else if (findValue > RootNode.Data)
            {
                currentNode = RootNode.RightNode;
                do
                {
                    if (findValue == currentNode.Data)
                    {
                        return true;
                    }
                } while (currentNode.RightNode != null);
               
                return false;
            }
            else if(findValue < RootNode.Data)
            {
                currentNode = RootNode.LeftNode;
                do
                {
                    if (findValue == currentNode.Data)
                    {
                        return true;
                    }
                } while (currentNode.LeftNode != null);

                return false;
            }
            return false;
        }
    }
}
