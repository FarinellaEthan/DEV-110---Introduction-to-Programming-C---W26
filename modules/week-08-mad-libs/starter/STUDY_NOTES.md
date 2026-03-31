# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** replace-with-your-name

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer:generate story checks if the user added enough words for each promp then calls another method to assemble the story
FormatStory forms the words into the story.
collectwords gathers the input for each prompt.
ReadYesNo asks the user if they want to play again.
ReadIntInRange checks if an input is within a designated range
ReadNotEmptyString makes sure the user doesnt input nothing

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer:it keeps thing super organized and helps me identify bugs quicker

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer:it stores string inputs and forms them into the final story

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer:it went through the same process of gathering input and formatting the story with different inputs

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer:when i first used StoryTemplate

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer:it helped me understand exactly what happens and when

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer:i ran into an issue of the program not formatting correctly, i used breakpoints to find where the input/varibles werent being managed correctly

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1.I learned how to use breakpoints
2.I learned the definition of classes, objects, and methods, and how they are different from each other
3.I learned how to return a variable from methods

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer:breaking the code into multiple methods helped me the most

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

- Planning structure (methods/classes): [1 hours]
- Input validation: [1 hours]
- Story templates + formatting: [1 hours]
- Testing and debugging: [1/2 hours]
- Writing documentation: [1/2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:the input validation took the longest cause there was a lot to validate

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer:use breakpoints more often, they are much more usefull than i thought

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer:it helped me know when and where a bug occured
