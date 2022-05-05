# BoxCorp Box Choosing Algoritm
## Our Objective
We here at BoxCorp are very concerned with boxes. People often send us a file full of boxes, and we are responsible for chosing the best boxes from the file. In order to get only the finest boxes we:
1. look for overlapping boxes and choose the best one based on a formula;
2. remove any poor quality boxes based on a formula.

## How do we choose the best boxes? 
Boxes come in CSV files. There may be an arbitrarily large number of boxes in the file. A file has 5 columns and a single-row header record. The columns are:
* two integer coordinates (`x` and `y`), representing the lower x and y bounds of the box;
* two integer dimensions (`width` and `height`), representing the size of the box; and
* one decimal value (`quality`), between 0 and 1 inclusive.

Quality is a representation of how important the box is to us. A larger quality value will mean the box is more important (e.g., a box with quality = 0.8 is more important than a box with quality = 0.4). When forced to choose, we want to retain higher quality boxes.

An example of a box file would look like this:
| x | y | width | height | quality |
|----|----|----|----|----|
| 2 | 2 | 4 | 3 | 0.6 |

This would give a box that looks like this:

<img src="./Images/BoxExample.png" width="600px"/>

The problem exists that some boxes in the file may overlap one another. When two boxes significantly overlap each other, we want to retain the higher-quality box. Two boxes are determined to significantly overlap if their intersection over union (IoU) is `≥ 0.4`. The formula for calculating IoU is: `IoU = <intersecting area of the boxes> / <union area of the boxes>`

<img src="./Images/IoU.png" width="600px" />

We also want to discard low quality boxes. Boxes with a quality less than `0.5` should be discarded.

## What outcome do we want?
We want a CSV file containing the list of all boxes neither suppressed nor discarded. We would also like a print out of the number of boxes retained, suppressed, and discarded.

## What do we want you to do?

### Task 1:
A solution exists in [the src directory](./src). This solution contains a sample [box file](./src/BoxCorp/BoxCorp.App/boxes.csv). Write a program to satisfy the requirements above. You will be judged based on:
1. Accuracy of the algorithm
2. Code hygiene
3. Performance (speed) of the code

### Task 2:
We have written an acceptance criteria with inputs and outputs. You are to write a unit test to validate the results of your code

![](./Images/acceptance.png)
