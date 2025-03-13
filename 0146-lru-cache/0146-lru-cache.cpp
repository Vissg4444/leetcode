class Node {
public:
    int key;
    int val;
    Node* prev;
    Node* next;

    Node(int k, int v) : key(k), val(v), prev(nullptr), next(nullptr) {}
};

class LRUCache {
public:
    int cap;
    unordered_map<int, Node*> hash;
    Node* left; // Least Recently Used (LRU)
    Node* right; // most recent

    LRUCache(int capacity) {
        cap = capacity;
        hash.clear();
        left = new Node(0,0);
        right = new Node(0,0);
        left->next = right;
        right->prev = left;
    }

    // remove node from list
    void remove(Node* node)
    {
        Node* prv = node->prev;
        Node* nxt = node->next;
        prv->next = nxt;
        nxt->prev = prv;
    }

    // insert node at right pos
    void insert(Node* node)
    {
        Node* prv = right->prev;
        prv->next = node;
        node->prev = prv;
        node->next = right;
        right->prev = node;
    }
    
    int get(int key) {
        if (hash.count(key))
        {
            Node* node = hash[key];
            remove(node);
            insert(node);
            return node->val;
        }
        return -1;
    }
    
    void put(int key, int value) {
        if (hash.count(key))
            remove(hash[key]);
        Node* node = new Node(key,value);
        hash[key] = node;
        insert(node);

        if(hash.size() > cap)
        {
            Node* lru = left->next;
            remove(lru);
            hash.erase(lru->key);
            delete lru;
        }
    }
};
