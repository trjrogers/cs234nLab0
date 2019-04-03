using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    public class BoneYard
    {
        private List<Domino> boneYard = new List<Domino>();
        
        public BoneYard(int maxDots)
        {
            for (int i = 0; i <= maxDots; i++)
            {
                for (int j = 0; j <= maxDots; j++)
                {
                    Domino d = new Domino(i, j);
                    boneYard.Add(d);
                }
            }
        }

        // Shuffle boneYard number of times equal to boneYard's count, starting at index one
        // Store current index in temp var, generate random number between 0 and boneYard count
        // Current index equal to random index, overwrite random index value with the store temp value
        public void Shuffle()
        {
            for (int i = 0; i <= boneYard.Count; i++)
            {
                Random random = new Random();
                Domino temp = boneYard[i];

                int r = random.Next(0, boneYard.Count);
                boneYard[r] = boneYard[i];
                boneYard[i] = temp;
            }
        }

        // If count is 0, boneYard is empty
        public bool IsEmpty()
        {
            if (boneYard.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Returns boneYard count
        public int DominosRemaining
        {
            get
            {
                return boneYard.Count;
            }
        }

        // Draw domino from top of pile, add it to player hand, remove from boneYard
       /* public Domino Draw()
        {

        } */

        public Domino this[int index]
        {
            get
            {
                return (Domino)boneYard[index];
            }
        }

       /* public override string ToString()
        {
        } */
    }
}
