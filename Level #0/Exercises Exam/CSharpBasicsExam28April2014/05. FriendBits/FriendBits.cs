using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FriendBits
{
    class FriendBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint friend = 0;
            uint alone = 0;
            for (int i = 31; i >=0; i--)
            {
                uint bitNow = (number >> i) & 1;

                bool isALeft = (i < 31);
                uint left = (number >>(i+1))&1;
                bool leftCheck = isALeft && (left == bitNow);

                bool isRight = i > 0;
                uint right = (number >>(i-1))&1;
                bool rightCheck = isRight && (right == bitNow);

                bool isFriend = leftCheck || rightCheck;
                if (isFriend)
                {
                    friend = (friend << 1) | bitNow;
                }
                else
                {
                    alone = (alone << 1) | bitNow;
                }
            }
            Console.WriteLine(friend);
            Console.WriteLine(alone);
        }
    }
}
