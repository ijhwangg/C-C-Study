using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace ConsoleTest
{
    // BrainCSharp이라는 nmaespace 생성
    // 다른 파일에서 Hello 클래스를 사용하려면 BrainCSharp namespace를 앞에 붙여줘야 사용가능.
    // BreainCSharp::Hello (....)

    namespace Study
    {
        public class Invitation
        {
            private DateTime when;
        }

        public class Ticket
        {
            private double fee;

            public double getFee()
            {
                return fee;
            }
        }

        public class Bag
        {
            private double amount;
            private Invitation invitation;
            private Ticket ticket;
        }
    }
}
