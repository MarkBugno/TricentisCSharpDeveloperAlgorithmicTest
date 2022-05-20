# BoxCorp Box Choosing Algorithm
## Our Objective
We here at BoxCorp are very concerned with boxes. People often send us a file full of boxes, and we are responsible for chosing the best boxes from the file. In order to get only the finest boxes we:
1. look for overlapping boxes and choose the best one based on a formula;
2. remove any poor quality boxes based on a formula.

## How do we choose the best boxes? 
Boxes come in CSV files. [Here's](./src/BoxChooser/boxes.csv) the one you'll be working with. There may be an arbitrarily large number of boxes in the file. A file has 5 columns and a single-row header record. Each subsequent row is a box. The columns are:
* two positive integer coordinates (`x` and `y`), representing the lower x and y bounds of the box;
* two positive integer dimensions (`width` and `height`), representing the size of the box; and,
* one decimal value (`quality`), between 0 and 1 inclusive.

Quality is a representation of how important the box is to us. A larger quality value will mean the box is more important (e.g., a box with quality = 0.8 is more important than a box with quality = 0.4). When forced to choose, we want to retain higher quality boxes.

An example of a box file with a single box would look like this:
| x | y | width | height | quality |
|----|----|----|----|----|
| 2 | 2 | 4 | 3 | 0.6 |

This would give a box that looks like this:

<img src="./Images/BoxExample.png" width="600px"/>

The problem exists that some boxes in the file may overlap one another. When two boxes significantly overlap each other, we want to retain the higher-quality box. The eliminated box is said to be *suppressed*. Two boxes are determined to significantly overlap if their intersection over union (IoU) is `≥ 0.4`. The formula for calculating IoU is: `IoU = <intersecting area of the boxes> / <union area of the boxes>`

<img src="./Images/IoU.png" width="600px" />

We also want to discard low quality boxes. Boxes with `quality < 0.5` should be discarded.

## What outcome do we want?
We want a CSV file containing the list of all retained boxes (all boxes neither suppressed nor discarded). We also want a print out of the number of boxes retained, suppressed, and discarded.

## What do we want you to do?

### Task 1:
A solution exists in [the src directory](./src). This solution contains a sample [box file](./src/BoxChooser/boxes.csv). Write a program to satisfy the requirements above. Feel free to replace any/all existing code, but use the box file provided. You will be judged based on:
1. accuracy of the algorithm;
2. code hygiene; and,
3. performance (speed) of the code.

There are `10,000` boxes in the file. Approximately `2510` will be retained, `2464` suppressed, and `5026` discarded. Your numbers might be out by 10 or so. The solution should take less than `1 second` to run (my solution runs in 28 milliseconds on the potato Tricentis gave me).
