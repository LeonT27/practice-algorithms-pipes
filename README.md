# Algorithms: Pipes

Tom has **_N_** pipes of heights **_h1, h2, ..., hN._** Let's define an operation on these pipes.

In one operation, Tom picks up the two **different**  pipes with the **smallest**  heights **_x_**  and **_y_** and join them **permanently**  to obtain a pipe of height **(x + y).**

The cost of this operation is max(x,y). Add the obtained pipe height to the array. Tom performs operations on the given pipes until the heights of all the pipes are **strictly greater** than **_H._**

You are given the number of pipes **_N_**, the heights of the pipes **_h1, h2, ..., hN_**, and an integer **_H._**

**You need to print the total cost of all the operations performed on the pipes.**

## Input Format

The first line contains two space-separated integers **_N_** and **_H._**

The second line contains **_N_** space-separated integers **_h1, h2, ..., hN._**

## Sample Input

```
5 10 -- denotes N & H

7 7 8 9 9 -- denotes N elements
```

## Constraints

1 <= **_N_** <= 10

1 <= **_hi_** <= 100

1 <= **_H_** < h1 + h2 + ... + hN

## Output Format

The output contains a single integer representing the **total cost** of all the
operations performed.

## Sample Output

```
30
```

## Explanation

Initially, the pipes are **_{7,7,8,9,9}_**

1) Sal picks the two smallest pipes with heights **_7_** and **_7_** and joins them to get a pipe
of height **_14_**. The cost of this operation **= max(7,7) = 7.**

The pipes now are **_{8,9,9,14}_**

2) Sal picks the two smallest pipes with heights **_8_** and **_9_** and joins them to get a
pipe of height **_17_**. The cost of this operation **= max(8,9) = 9.**

The pipes now are **_{9,14,17}_**

3) Sal picks the two smallest pipes with heights **_9_** and **_14_** and joins them to get a
pipe of height **_23_**. The cost of this operation **= max(9,14) = 14.**

The pipes now are **_{17,23}_**

Now the heights of all the pipes are greater than **_H = 10._** The total cost of the
operations performed = **7 + 9 + 14 = 30.**
