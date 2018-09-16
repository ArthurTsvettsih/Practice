## Queue aka FIFO Data Structure
- FIFO stands for First In First Out
- Allows for a first come first served array
- Works in a First In First Out method. Think of a queue at a coffee shop - the first person to enter the queue will be served first, the second person will be served second etc. 
- It uses Enqueue and Dequeue methods to add an remove elements. There is also a Peek method, which returns head element of the queue without removing it from the queue
- Wraps a circular array - an array that has 16 elements and a start and end variable we use to keep track of it. When we reach element 16 by adding elements to it and add one more element, instead of going to 17 we go back to 0, so our array could have a start of 13 and end of 2 
- The start and end of the circular array are known as the "head" and "tail"
- In order to calculate the tail size we use ```var tail = (currentTail + 1) % theArray.Length;```
- Similarly to list Queue has a growth factor of 2 of it's interal array, however we can change this factor by passing it in the constructor
- Unlike the List the Queue does not allow random access, ie you cannot look at the 3rd element of the queue - only the head. However, it does have a Contains method, which will check if an element is in the Queue

## Stack aka LIFO Data Structure
- LIFO stands for Last In First Out
- Do not confuse with Stack from Stack and Heap memory
- Similarly to Queue it uses an internal ciruclar array
- It uses Push, which adds the passed-in item to the stack, and Pop, which removes and returns the item at the top of the stack
- Similarly to Queue the growth factor can be specified in the constructor
- A use case for Stack Data Structure is the Stack memory example. When calling functions we need to keep track of all the functions and resolve them right to left. For example, when a WrapperFunction() calls a Function(), we need to resolve Function() first, so we add WrapperFunction() to the stack using Push, then we add Function() using Push and then we start Pop -ing them, so that Function() gets Pop -ped first and then WrapperFunction


## HashTable
- Also known as "Associative List"
- Indexes lists by an arbitary object rather than ordinal index
- Hash is a compressed version of it's input, e.g. a 9 digit number can be hashed to a 4 digit number
- Sometimes Collisions can occure where to hashes numbers are the same and in order to deal with them we employ Collision Avoidance and Collision Resolution:
    - Linear Probing - If the location the hash function pointed to was location x, simply check location x + 1 to see if that is available. If it is also taken, check x + 2 etc. until an open spot is found. However, this method makes it hard to search the Hashtable as we would need to know what we are searching for and we would need to keep checking x + [1..] until we found what we are looking for or reached a free spot, at which point we know that what we are looking for is not in our table. This is called Clustering
    - Quadratic Probing - Works and can have the same issues as Linear Probing, except that instead of doing x + [1..] we do x + (1 ^ 2); x - (1 ^ 2); x + (2 ^ 2); x - (2 ^ 2); x + (3 ^ 2); x - (3 ^ 2) etc.
    - Rehashing aka Double Hashing - Works by choosing a hash function from a list of hash functions. These functions only differ in the multiplicative factor: ``` [GetHash(key) + k * (1 + (((GetHash(key) >> 5) + 1) % (hashsize – 1)))] % hashsize ```
    - Chaining - Instead finding the next available slot, each slot is a LinkedList, and every collision is prepended to that list
- Uses the Rehashing Collision Resolution
- Does not preserve the order of items as it is ordered by the open slot based on the key's hash value and Collision Resolution Strategy
- The Hash function must return an ordinal number. In general this is achieved using GetHashCode from System.Object class. Note that this method can be overridden to create a Hash function more suitable for a specific class, e.g. Point class does that by returning XOR of it's x and y member variables
- Hashtables Hash function: ``` [GetHask(key) + 1 + (((GetHash(key) >> 5) + 1) % (hashsize - 1))] % hashsize ```
- We can specify a custom GetHash function
- Hashtable has to have a certain % of the indexes empty, this % is called loadFactor and by default its 0.72 meaning that a Hashtable must have 28% of its indexes free. Loadfactor can be specified in an overloaded Hashtable's constructor. Furthermore, this factor cannot exceed 0.72 - this value was come up with by Microsoft as the optimal loadFactor
- In order for Hashing to work properly the number of elements in the Hashtable must be a prime number
- When a Hashtable exceeds its limit or its loadFactor ratio it expands itself by adding enough free slots to reach the next prime number in length
- The number of probes when a collision ocures is ``` 1 / ( 1 / loadFactor) ``` - by default this means roughly 3.5 probes per collision, if the loadFactor is 0.72
- Because hashing and accessing items by the hashed keys the access time for an element is O(1), which is a lot faster than the O(n) of an Array/Lists
- Expanding the Hashtable is expsenive, therefore if you know the size of the table you should specify the number of elements during initialization
- The Hashtable is loosely-typed

## Dictionary
- Essentially the same as a Hashtable except that 1) Dictionary uses Generics and is therefore strongly-typed. 2) It employs an alternate collision resolution strategy
