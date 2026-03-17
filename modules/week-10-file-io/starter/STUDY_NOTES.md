# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Ethan

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer:I looped through each element and used it to create a habit object.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer:it would produce an array with no elements

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer:Writes all the strings in an array to a file with the given path

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer:Select transforms each Habit into a CSV string, and To Array converts the resulting sequence into a string array that can be passed to File.WriteAllLines

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer:this happens when the program tries to find a file in the wrong location or if the file doesnt even exist

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer:We catch FileNotFoundException specifically to handle missing files only, while allowing other types of errors be found

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1.reading and writing CVS files
2.I got some practice with using objects
3.practice with LINQ

**What was the trickiest part of this assignment and how did you work through it?**

Answer:understanding reading and writing CVS files. Taking things one step at a time and making sure i understood each step

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1/2 hours
- Implementing LoadHabits: 1/2 hours
- Implementing PrintHabits / PrintSummary: 1/2 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1/2 hours
- Testing and debugging: 1/2 hours
- Writing study notes: 1/2 hours

**Most time-consuming part:**

Answer:Learning the new concept of reading and writeing CVS files
