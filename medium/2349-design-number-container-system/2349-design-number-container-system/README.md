# Design a Number Container System

## Problem Description

Design a number container system that can perform the following operations:

1. **Insert or Replace** a number at a given index in the system.
2. **Return** the smallest index for a given number in the system.

Implement the `NumberContainers` class:

- `NumberContainers()`: Initializes the number container system.
- `void change(int index, int number)`: Fills the container at the specified index with the given number. If there is already a number at that index, it replaces it.
- `int find(int number)`: Returns the smallest index containing the specified number, or `-1` if no such index exists in the system.

## Example

```python
Input:
["NumberContainers", "find", "change", "change", "change", "change", "find", "change", "find"]
[[], [10], [2, 10], [1, 10], [3, 10], [5, 10], [10], [1, 20], [10]]

Output:
[null, -1, null, null, null, null, 1, null, 2]

NumberContainers nc = new NumberContainers();
nc.find(10); // Returns -1 because no index contains the number 10.
nc.change(2, 10); // Fills index 2 with number 10.
nc.change(1, 10); // Fills index 1 with number 10.
nc.change(3, 10); // Fills index 3 with number 10.
nc.change(5, 10); // Fills index 5 with number 10.
nc.find(10); // Returns 1, the smallest index containing number 10.
nc.change(1, 20); // Replaces the number at index 1 with 20.
nc.find(10); // Returns 2, the next smallest index containing number 10.
```
Constraints

    1 <= index, number <= 10^9
    Up to 10^5 calls will be made in total to change and find.