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
![Kth value from end of list](../assets/Kth-value-from-end-of-list.jpeg)



# Class 08: Zip two linked lists

## Challenge
Write a function called zipLists which takes two linked lists as arguments. Zip the two lists together into one so the nodes alternate between the two lists return a reference to the head of the zipped list. 

## Approach & Efficiency
![ZipTwoLinkedLists](../assets/zipLists.jpeg)


# Class 11: PseudoQueue

## Challenge
Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:<br>

- enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.<br>
- dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.<br>
The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor

## Approach and Efficiency
![PseudoQueue](../assets/PseudoQueue.PNG)
With each number in the queue we push it and pop it into the next stack repeatedly.


# Class 12 : First-in, First out Animal Shelter.

## Challenge 
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

## Approach and Efficiency
![AnimalShelter](../assets/Lab12ShelterWhiteboard.jpeg)


# Class 13: multi-bracket-validation

## Challenge
Create a function that should take a string as it's only argument, and should return a boolean representing whether or not the brackeets in the string are balanced or have it's matching bracket. 

## Approach and Efficiency
[MultiBracketValidation](../assets/challenge13.PNG)


# Trees
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
[Tree](../assets/treeWhiteboard.png)


## API
<!-- Description of each method publicly available in each of your trees -->


# Binary tree
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->
Create a method called find-maximum-value which will return the maximum value in the tree. Assuming the values are numeric. And don't use any built in methods.
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
[BinaryTree](../assets/findMaxValueofBinaryTree.jpeg)


## API
<!-- Description of each method publicly available in each of your trees -->


## Challenge Breadth-First
<!-- Description of the challenge -->
Be able to write a breadth first traversal methods which takes a Binary Tree as its unique input. And output the values in order.
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
[BreadthFirst](../assets/breadthtree.jpeg)


## Challenge FizzBuzzTree
Write a function called FizzBuzzTree which takes a k-ary tree as an argument. Determine whether or not the value of each node is divisible 3, 5 or both. 
- If the value is divisible by 3, replace the value with “Fizz”
- If the value is divisible by 5, replace the value with “Buzz”
- If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
- If the value is not divisible by 3 or 5, simply turn the number into a String.

## Approach and Efficiency
[FizzBuzzTree](../assets/KAryTree.jpeg)


## Challenge - Insertion Sort
Review the pseudocode below, then trace the algorithm by stepping through the process with the provided sample array. Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.
- Provide a visual step through for each of the sample arrays based on the provided pseudo code
- Convert the pseudo-code into working code in your language
- Present a complete set of working tests

## Approach and Efficiency
[InsertionSort](../assets/InsertionSort.jpeg)


# Challenge - GetEdges
- Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? If so, how much will the total trip cost be?
- Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.

## Approach and Efficiency
[GetEdges](/assets/GetEdges.jpeg)