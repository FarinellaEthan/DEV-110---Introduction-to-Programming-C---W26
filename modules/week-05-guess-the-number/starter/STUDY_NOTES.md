# Week 5: Guess the Number - Study Notes

**Name:**
Ethan
## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer:Use a while loop when the code should run only if the condition is already true, and use a do-while loop when the code must run at least once before the condition is checked.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer:do-while was used in the ReadIntInRange method to input the amount of rounds and the max number.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer:I used a while loop to handle the guesses, because the condition was true before any code was run

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a for loop for handling each round, because I wanted to run specific code for each round.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: It can be called with some inputs to set both the max value and rounds variables, instead of writing two different methods for each variable

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: i used an if statment to check if the max value was in range

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: I used the same if statment of the max value check, but with different inputs

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer:If the input wasnt valid it wrote out an error message and restarted the while loop

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: To check for the correct number I used if statements that checked whether the guess was less than, greater than, or equal to the secret number.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: each time the while loop ran code it added one to the counter until the round was over

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: Random gets a random int, and the min and max variables were used by the helper method to determin the round amount and max value.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: the plus one is needed to allow the max value to be able to be picked as the secret number.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I tested letters, whole numbers, and negative numbers.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer:I didn't encounter many errors other than some syntax errors.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.I learned how to properly use While loop
2.I learned how to use for loop
3.I learned the difference between do-while and while loop
4.I learned a little bit about helper metods
5.I learned how to get a random variable

**Which loop felt most natural to use and why?**

Answer: While loop because it't condition was very simple.

## Time Spent

**Total time:** [2 hours]

**Breakdown:**

- Planning the loops: [1/3 hours]
- Input validation: [1/3 hours]
- Guessing logic: [1/2 hours]
- Testing and debugging: [1/3 hours]
- Writing documentation: [1/2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:Guessing logic took the longest amount of time because I had little experience with using loops before this assignment.

## Reflection

**What would you do differently next time?**

Answer: Make sure I completely understand all loop types before starting

**How did using three different loop types improve your understanding of repetition?**

Answer:It showed me how to use loops to efficently manage input and logic, and to avoid repetition
