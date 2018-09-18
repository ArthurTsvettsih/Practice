## Linked Lists
- Works similarly to Trees using nodes
- Nodes only have 1 child
- Same run time for search as arrays
- We keep a reference only to the head
- Deleting is also O(n)
- When inserting: 
    - If the list doesn't need to be sorted then its O(1) as we can just make it the new head
    - If the list does need to be sorted 
- The main benefit of Linked Lists over Arrays is that they do not need to be resized

## Double Linked Lists
- Linked lists but they maintain a reference to both of their neighbours 

## Skip Lists
- Is a a sorted Linked List
- Nodes have height 
- Nodes point to 2 neighbours, one pointing to the immediate neighbor and another pointing to the neighbor 2 elements ahead
- The head is a dummy object with no data
- Max heigh is log n, where n is the number of elements in the list, e.g. max height of a list of 8 elements is 3
- Instead of calculating the which exactly which elements have their height increased, we pick them at random due to _1/2^i_ distribution, ie 50% of the elements have a height of 1; 25% have height of 2; 12.5% height of 3 etc.
- Searching skip lists:
    1) Start at the highest point of the head
    1) Check if target value is bigger than the value head is pointing at
    1) If it is go to that value and repeat
    1) If it is not go down 1 height and repeat same checks
    1) Keep doing this until you reach the bottom height or find your element
- https://people.ok.ubc.ca/ylucet/DS/SkipList.html