# 401-data-structures-and-algorithms

# Reverse an Array
<!-- Short summary or background information -->
Use a ArrayReverse() to reverse an array

## Challenge
<!-- Description of the challenge -->
Take an array of ints and reverse it

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

## Solution
<!-- Embedded whiteboard image -->
![array reverse](assets/array-reverse.PNG)


# Unit Tests & Documentation
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

## Challenge
Insert a number in the center of an array of numbers

## Approach & Efficiency


## Solution
![array reverse](assets/unit-tests.PNG)


# Binary search
<!-- Short summary or background information -->
Taking an array and splitting it into 2 sections over and over.

## Challenge
<!-- Description of the challenge -->
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Binary Code Search Pseudo Code 
INPUT = Single Sorted Array and a Key
OUTPUT=  If found = 2/ else = -1
Start in Center of Array , 
if int = Key, Output =2
If int i < Key then Key.Length/2
if > 2 then Key.leng
2then end of array , search center

## Solution
<!-- Embedded whiteboard image -->
![Binary Search](assets/binarySearch.jpeg)


# Class 05: Linked List Implementation

# Linked List Implementation
<!-- Short summary or background information -->
Create a loop for a node and be able to go to the next node.

## Challenge
<!-- Description of the challenge -->
Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->


# Class 06: Linked list insertions

# Linked List Implementation
<!-- Short summary or background information -->


## Challenge
<!-- Description of the challenge -->


Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

You have access to the Node class and all the properties on the Linked List class.

Write tests to prove the following functionality:

Can successfully add a node to the end of the linked list
Can successfully add multiple nodes to the end of a linked list
Can successfully insert a node before a node located i the middle of a linked list
Can successfully insert a node before the first node of a linked list
Can successfully insert after a node in the middle of the linked list
Can successfully insert a node after the last node of the linked list
Unit tests must be passing before you submit your final solution code.



## Approach & Efficiency



# Class 07: Linked List Implementation

## Challenge
<!-- Description of the challenge -->
Write a method for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
![Kth value from end of list](assets/Kth-value-from-end-of-list.jpeg)



# Class 08: Zip two linked lists

## Challenge
Write a function called zipLists which takes two linked lists as arguments. Zip the two lists together into one so the nodes alternate between the two lists return a reference to the head of the zipped list. 

## Approach & Efficiency
![ZipTwoLinkedLists](assets/zipLists.jpeg)


# Class 11: PseudoQueue

## Challenge
Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:<br>

- enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.<br>
- dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.<br>
The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor

## Approach and Efficiency
![PseudoQueue](assets/PseudoQueue.PNG)
With each number in the queue we push it and pop it into the next stack repeatedly.


# Class 12 : First-in, First out Animal Shelter.

## Challenge 
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

## Approach and Efficiency
![AnimalShelter](assets/Lab12ShelterWhiteboard.jpeg)


# Class 13: multi-bracket-validation

## Challenge
Create a function that should take a string as it's only argument, and should return a boolean representing whether or not the brackeets in the string are balanced or have it's matching bracket. 

## Approach and Efficiency
[MultiBracketValidation](assets/challenge13.PNG)


# Trees
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
[Tree](assets/treeWhiteboard.png)


## API
<!-- Description of each method publicly available in each of your trees -->


# Binary tree
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->
Create a method called find-maximum-value which will return the maximum value in the tree. Assuming the values are numeric. And don't use any built in methods.
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
[BinaryTree](assets/findMaxValueofBinaryTree.jpeg)


## API
<!-- Description of each method publicly available in each of your trees -->


## Challenge Breadth-First
<!-- Description of the challenge -->
Be able to write a breadth first traversal methods which takes a Binary Tree as its unique input. And output the values in order.
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
[BreadthFirst](assets/breadthtree.jpeg)


## Challenge FizzBuzzTree
Write a function called FizzBuzzTree which takes a k-ary tree as an argument. Determine whether or not the value of each node is divisible 3, 5 or both. 
- If the value is divisible by 3, replace the value with “Fizz”
- If the value is divisible by 5, replace the value with “Buzz”
- If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
- If the value is not divisible by 3 or 5, simply turn the number into a String.

## Approach and Efficiency
[FizzBuzzTree](assets/KAryTree.jpeg)


## Challenge - Insertion Sort
Review the pseudocode below, then trace the algorithm by stepping through the process with the provided sample array. Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.
- Provide a visual step through for each of the sample arrays based on the provided pseudo code
- Convert the pseudo-code into working code in your language
- Present a complete set of working tests

## Approach and Efficiency
[InsertionSort](assets/InsertionSort.jpeg)

## Challenge - Merge Sort

Sample Arrays
In your blog article, visually show the output of processing this input array:

[8,4,23,42,16,15]

#### For your own understanding, consider also stepping through these inputs:

- Reverse-sorted: [20,18,12,8,5,-2]
- Few uniques: [5,12,7,5,5,7]
- Nearly-sorted: [2,3,5,7,13,11]
####Implementation
- Provide a visual step through for each of the sample arrays based on the provided pseudo code
- Convert the pseudo-code into working code in your language
- Present a complete set of working tests

[MergeSort](assets/MergeSort.jpeg)



## Challenge - Quick Sort
Set a pivot point, go through the array swapping values so that if they are less they are pivoted to the left and the greater are pivoted to the right. Call the sort for the left side of the array and then the right side.Keep sorting through it using smaller and smaller portions until the partition size is 1.

### Approach and Efficiency
[QuickSort](assets/QuickSort.jpeg)

## Challenge HashTables
Implement a Hashtable with the following methods:

add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
get: takes in the key and returns the value from the table.
contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
hash: takes in an arbitrary key and returns an index in the collection.

### Approach and Efficiency
[Hashtable](assets/Hashtables.jpg)


## Challenge - Hash Set
Write a function that accepts a lengthy string parameter and return the first repeated word in the string.

## Approach and Efficiency
[HashSet](assets/HashSet.jpg)


## Challenge - tree-intersection
Find common values in 2 binary trees. Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write at least three test assertions for each method that you define.
Ensure your tests are passing before you submit your solution.

## Approach and Efficiency
[TreeIntersection](assets/TreeIntsersection.jpeg)


## Challenge Left Join for 2 Hashmaps
Implement a simplified LEFT JOIN for 2 Hashmaps.
- Write a function that LEFT JOINs two hashmaps into a single data structure.
- The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
- The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
- Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
- LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.
- The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic.
- Avoid utilizing any of the library methods available to your language.

## Approach and Efficiency 
[LeftJoinHashTable](assets/LeftJoinHashTable.jpeg)


# Challenge - Graph Implementation
Implement your own Graph. The graph should be represented as an adjacency list,

## Approach and Efficiency
[GraphImplementation](assets/GraphImplementation.jpeg)


# Challenge - breadth-first-graph
Implement a breadth-first traversal on a graph.
Extend your graph object with a breadth-first traversal method that accepts a starting node. 
Without utilizing any of the built-in methods available to your language, return a collection of nodes in the order they were visited. 
Display the collection.

## Approach and Efficiency
[BreadthFirstGraph](assets/BreadthFirstGraph.jpeg)
