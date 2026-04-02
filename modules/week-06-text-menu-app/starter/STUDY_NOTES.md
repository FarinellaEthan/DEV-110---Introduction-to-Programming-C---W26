# Week 6: Text Menu App - Study Notes

**Name:**Ethan

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer:while loop is best used if there isnt some code you want to run before the loop, but do while is used if there is something you want to run before the loop

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer:i used a helper method with a do while to check if the input was valid

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: the menu loop was used to allow the user to choose multiple options while running the program

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: a for loop wasnt needed because there was no needed limit to the amount of times the user can choose an option

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer:the helper method is used to validate user input for each loop in the menu

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: it checked if it was an integer, then if it was in range of 1-6

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: int.TryParse converts an input into an integer, and double.TryParse converts an input into a number with two possible decimal places

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer:trim removes empty spaces, toUpper converts every character to uppercase,ToLower converts everything to lowercase, replace replaces specified characters with other characters, split splits a string into multiple parts, join combines multiple strings into one, contains checks if a string contains a certain character, padleft aligns a string to the left of a line and pad right does that for the right side, formatting techniques are ways to display text.


**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer:StringComparison checks if two strings are equal, Substring extracts part of a string, EndsWith tests if a string ends with a specific character or text, IndexOf finds the position of a character or substring within a string.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer:string concatenation joins strings together using the + operator, while string interpolation inserts variables directly into a string

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.I learned how to convert strings to upper or lower case
2.I learned how to replace specific characters
3.I learned how the difference between concatentation and interpolation
4.I learned how to pad left, center and pad right string
5.I was able to use a switch statement and learn a better understanding of how they work

**Which loop felt most natural to use and why?**

Answer: while loop because its condition is very simple

## Time Spent

**Total time:** [5 hours]

**Breakdown:**

- Planning the loops: [1/2 hours]
- Input validation: [1 hours]
- String formatting: [2 hours]
- Testing and debugging: [1/2 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: string formatting took the longest because I had never used most of what was needed to be done before

## Reflection

**What would you do differently next time?**

Answer: understand all the string operations better

**How did using three different loop types improve your understanding of repetition?**

Answer:they helped me design logic to avoid repetition
