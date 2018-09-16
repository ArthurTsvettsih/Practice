## Arrays

- Arrays are stored contiguously in memory, meaning without breaks ie memory address 1 through 100
- Access time is O(1) because we only need to know the start address and the index we are accessing, ie (start at 123) + (index 32) = addresss at 155
- In managed code it the value lookups are slightly more involved as CLR needs to check that the index is not out of bounds and we are not accessing memory we shouldn't be accessing
- Searching for a value in an array is O(n) as we need to lookup every value until we find it. However, if the array is sorted it can be done in O(log n)
- When it comes to multi dimensional arrays ie array[][] the search time becomes O(n^k), where n is the number of elements in each dimension (not the sum) and k is the number of dimensions

## Array Lists

- Array Lists are deprecated as of .NET 2.0
- Array Lists are a wrapper for Arrays that add additional functionality, such as auto resizing the array and searching by properties
- Array Lists are much expensive as all the values are boxed as an object and have to be unboxed into the required type
- Array Lists are more bug prone as the type is object, which everythign inherits from and as a result it is possible to pass an object of the wrong type to the array. This issue won't be highlighted until runtime 

## Lists

- Lists are type safe Array Lists
- Lists contain an internal array
- List's constructor can take an argument to indicate how large the list should be, otherwise it's initiated as 0. Same can be done using the List.Capacity property
- Lists have a number of useful functions, some of them being IndexOf(), BinarySearch(), Find(), FindAll(), Sort(), ConvertAll()
- Even though Lists have more overhead, the cost per operation is the same as with standard arrays