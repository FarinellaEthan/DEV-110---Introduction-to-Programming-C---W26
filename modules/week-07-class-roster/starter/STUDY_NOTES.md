# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:**
Ethan
## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer:parallel arrays are two seperate arrays that use the same index to store data. Both rosterNames and rosterCredits used the same index for each student

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer:The count variable was an integer that counted how many students were in the roster.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer:I looped using count instead of the full array length because the full array might not have information stored

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer:for each line it printed a string of both the student name and their credits.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer:I used Array.Sort to organize the elements of the array in the right order then I printed each line out

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.what a parallel array is
2.How to sort arrays
3.I gained a better understanding of arrays and how to define them
4.I learned how to loop through an array
5.

**Which loop felt most natural to use and why?**

Answer: foreach loop was the most natural for me to use because it would simply loop through each element in the array

## Time Spent

**Total time:** [3 hours]

**Breakdown:**

- Planning the arrays/menu: [1/3 hours]
- Input validation: [1/2 hours]
- Add + print roster features: [1/2 hours]
- Sorting feature: [1 hours]
- Testing and debugging: [1/3 hours]
- Writing documentation: [1/3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:the storting feature took the longest because of the helper method I had to implement

## Reflection

**What would you do differently next time?**

Answer: I would plan out how to do each function beforehand

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer:using these loops helped me understand how to access the elements in the array
