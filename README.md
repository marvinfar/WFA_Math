CRM Custom Workflow Activities
This repository contains a collection of custom workflow activities designed for CRM systems. These activities perform various mathematical operations and data conversions. Below is a detailed description of each activity, including its inputs, outputs, and functionality.

Activities Overview
1. Sum
Description: Adds two numbers (Num1 and Num2) and returns the sum.

Inputs:

Num1 (double): The first number.

Num2 (double): The second number.

Output:

SumOf (decimal): The result of Num1 + Num2.

2. Subtract (Sub)
Description: Subtracts Num2 from Num1 and returns the result.

Inputs:

Num1 (double): The first number.

Num2 (double): The second number.

Output:

Subtraction (decimal): The result of Num1 - Num2.

3. Multiply (Mult)
Description: Multiplies two numbers (Num1 and Num2) and returns the product.

Inputs:

Num1 (double): The first number.

Num2 (double): The second number.

Output:

Multiply (decimal): The result of Num1 * Num2.

4. Divide (Div)
Description: Divides Num1 by Num2 and returns the result. If Num2 is zero, it returns 0.

Inputs:

Num1 (double): The numerator.

Num2 (double): The denominator.

Output:

Division (decimal): The result of Num1 / Num2.

5. Power (Pow)
Description: Raises Num1 to the power of Num2 and returns the result.

Inputs:

Num1 (double): The base number.

Num2 (double): The exponent.

Output:

Power (decimal): The result of Num1 ^ Num2.

6. Absolute Value (Abs)
Description: Returns the absolute value of Num1.

Inputs:

Num1 (double): The input number.

Output:

Absolute (decimal): The absolute value of Num1.

7. ToInteger
Description: Converts a string to an integer. If the string is not a valid number, it returns 0.

Inputs:

Text (string): The input string.

Output:

Output (int): The integer representation of the string.

8. ToCurrency
Description: Converts a string to a decimal value, removing any currency symbols or commas.

Inputs:

Text (string): The input string.

Output:

Output (decimal): The decimal representation of the string.

9. IsNumber
Description: Checks if a string is a valid number (contains no alphabetic characters).

Inputs:

StringText (string): The input string.

Output:

isNumber (bool): true if the string is a valid number, otherwise false.

10. EvaluateExpression
Description: Evaluates a mathematical expression provided as a string and returns the result.

Inputs:

Text (string): The mathematical expression.

Output:

Output (double): The result of the evaluated expression.

11. Round
Description: Rounds a number to the nearest integer.

Inputs:

Num (double): The input number.

Output:

Rounded (double): The rounded value.

12. Ceil
Description: Rounds a number up to the nearest integer.

Inputs:

Num (double): The input number.

Output:

Ceiled (double): The ceiling value.

13. Truncate
Description: Truncates a number to its integer part.

Inputs:

Num (double): The input number.

Output:

Truncated (double): The truncated value.

14. Floor
Description: Rounds a number down to the nearest integer.

Inputs:

Num (double): The input number.

Output:

Floored (double): The floor value.

Usage
To use these activities in your CRM workflow:

Add the compiled assembly to your CRM solution.

Register the activities in the CRM workflow designer.

Configure the inputs and outputs as required for your workflow.

Error Handling
All activities include error handling. If an error occurs during execution, the output will default to a safe value (e.g., 0 for numeric outputs or false for boolean outputs)
