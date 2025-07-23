/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* next;
    Node* random;
    
    Node(int _val) {
        val = _val;
        next = NULL;
        random = NULL;
    }
};
*/

class Solution {
public:
    Node* copyRandomList(Node* head) {
        
        unordered_map<Node*, Node*> hash;

        Node* cur = head; // copy all nodes
        while (cur)
        {
            Node* copy = new Node(cur->val);
            hash[cur] = copy;
            cur = cur->next;
        }
        cur = head; // set pointers in all nodes
        while (cur)
        {
            Node* copy = hash[cur];
            copy->next = hash[cur->next];
            copy->random = hash[cur->random];
            cur = cur->next;

        }
        
        return hash[head];
    }
};
