

public class Problem2
{
    static void Main(string[] args)
    {
        ListNode l1, l2;

        //test case: 7634+24=7658
        l1 = new ListNode(4, new ListNode(3, new ListNode(6, new ListNode(7))));
        l2 = new ListNode(4, new ListNode(2));

        Solution2 sol = new Solution2();

        ListNode ans = sol.AddTwoNumbers(l1, l2);


        while(ans != null)
        {
            Console.Write(string.Concat(ans.val, " -> "));
            ans = ans.next;
        }
        Console.Write("\n");

    }
}



//definition for singly - linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}



public class Solution2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode ans = null;
        ListNode ansHead = ans;
        ListNode p, q;

        p = l1;
        q = l2;

        int v1, v2, carry = 0, v;

        while((p != null) || (q != null))
        {
            v1 = (p != null) ? p.val : 0;
            v2 = (q != null) ? q.val : 0;

            v = (v1 + v2 + carry) % 10;
            carry = (int)((v1 + v2 + carry) / 10);

            ListNode lN = new ListNode(v);

            if(ans == null)
            {
                ans = lN;
                ansHead = ans;
            } else
            {
                ans.next = lN;
                ans = ans.next;
            }
            
            if (p != null) p = p.next;
            if (q != null) q = q.next;
        }

        //append carry
        if ((p == null) && (q == null))
        {
            if(carry > 0)
            {
                ListNode lN = new ListNode(carry);

                if (ans == null)
                {
                    ans = lN;
                    ansHead = ans;
                }
                else
                {
                    ans.next = lN;
                    ans = ans.next;
                }
            }
        }


        return ansHead;
    }
}
