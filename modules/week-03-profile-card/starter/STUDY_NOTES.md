# Week 3: Personal Profile Card - Study Notes

**Name:**Ethan
Ethan
## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer:
A string stores a set of characters. One example of a string used in the profile card was the major.
An int stores a whole number. An example for when this was used is the age.
A double stores a number with decimal places. This was used for the gpa.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: Because the GPA used decimals.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I checked if it was "yes", if so then it was set to true.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: The information was grouped together in catagories to make things more organized and easy to read at the end.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer:The information that I calculated rather than asked for was Birth year, years to graduation, height in feet, honor status, and age in months.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer:asking for both can be repetitive

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer:I didn't run into to many challenges this week, but I'd say calculations were the hardest part

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: To get the calculations working correctly I had to stop and think through how each calculation should be formated.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer:modulus for hight was probably the hardest to understand

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: int.Parse() is used to convert a string to an int, and double.Parse() was used to convert a string to a double.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: I did two seperate calculations and added thier answers to one output. the first calculation was height in inches
divided by 12, the second was getting the remainder of height in inches divided by 12.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: gpa >= checks if the gpa is greater than or equal to 3.5

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: F2 makes the output only show two decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: if the use was full time the program outputted "full time student", if they were part time it outputted
"part time student".

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used spacing and section headers to make things more organized.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: height/weight, age when graduate.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: Choosing the right data type is important because if we didn't the program wouldn't be able to store/manage the correct information.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: It can provide basic information about a person

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1.I gained a better understanding of if/then statments
2.I learned about switch statments
3.I learned about goto
4.I learned when to use if statments over switch statments.
5.I learned the difference between program flow and program logic

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: bool because it can be hard converting a string to a boolean

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types helps you write better programs by preventing errors, and allowing data to be represented and used in the most efficient way.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer:I tested typical values, decimals, and negative numbers.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: One issue I ran into but fixed, was the user being able to enter a gpa above 4.0, to fix this I used a loop to ensure they entered the right information

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer:I used loops and if statments to validate data types.

## Time Spent

**Total time:** [3 hours]

**Breakdown:**

-   Understanding data types and planning variables: [1/2 hours]
-   Collecting user input with correct types: [1 hours]
-   Implementing calculations: [1/2 hours]
-   Formatting output: [1/3 hours]
-   Testing and debugging: [1/3 hours]
-   Writing documentation: [1/3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:collecting user input with correct types was the hardest part because there was a lot of information that was needed to be collected

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer:I would find more efficient ways to avoid incorrect user input

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer:Proper data modeling makes programs easier to update and fix bugs.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: financial calculator
